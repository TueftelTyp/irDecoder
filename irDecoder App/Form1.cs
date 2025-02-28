using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Security.Policy;
using System.Diagnostics;

namespace irDecoder
{
    public partial class Main : Form
    {
        private SerialPort serialPort;

        public Main()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);
            cbBaud.SelectedIndex = 11;
            tbHex.Click += TextBox_Click;
            tbRaw.Click += TextBox_Click;
            tbBin.Click += TextBox_Click;
            tbDec.Click += TextBox_Click;
            tbOct.Click += TextBox_Click;
            lbHex.Click += ListBox_Click;
            lbRaw.Click += ListBox_Click;
            lbBin.Click += ListBox_Click;
            lbDec.Click += ListBox_Click;
            lbOct.Click += ListBox_Click;
        }

        public void LoadPorts(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            if (ports.Length > 0)
            {
                cbPort.Items.AddRange(ports);
                cbPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No available ports found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btConnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                cbPort.Enabled = true;
                cbBaud.Enabled = true;
                btConnect.BackgroundImage = Properties.Resources.disonnect;
            }
            else if (cbPort.SelectedItem != null)
            {
                try
                {
                    serialPort = new SerialPort(cbPort.SelectedItem.ToString(), Convert.ToInt32(cbBaud.SelectedItem)); //konvertiert den ausgewählten Wert aus der cbBaud ComboBox in einen Integer, der als Baudrate verwendet wird
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();
                    cbPort.Enabled = false;
                    cbBaud.Enabled = false;
                    btConnect.BackgroundImage = Properties.Resources.connect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadPorts(sender, e);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    string data = serialPort.ReadLine();
                    this.Invoke(new Action(() => ProcessData(data)));
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Console.WriteLine("Error reading the data: " + ex.Message);
                });
            }
        }

        private void ProcessData(string data)
        {
            if (string.IsNullOrEmpty(data) || data.Contains("---")) return;

            Console.WriteLine("Data received: " + data);
            // aktuelle Werte ListBoxen hinzufügen, bevor überschreiben
            if (!string.IsNullOrEmpty(tbHex.Text)) lbHex.Items.Add(tbHex.Text);
            if (!string.IsNullOrEmpty(tbRaw.Text)) lbRaw.Items.Add(tbRaw.Text);
            if (!string.IsNullOrEmpty(tbBin.Text)) lbBin.Items.Add(tbBin.Text);
            if (!string.IsNullOrEmpty(tbDec.Text)) lbDec.Items.Add(tbDec.Text);
            if (!string.IsNullOrEmpty(tbOct.Text)) lbOct.Items.Add(tbOct.Text);

            string[] values = data.Split(':');
            foreach (string value in values)
            {
                string[] parts = value.Trim().Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string val = parts[1].Trim();

                    switch (key)
                    {
                        case "HEX":
                            tbHex.Text = val;
                            break;
                        case "RAW":
                            tbRaw.Text = val;
                            break;
                        case "BIN":
                            tbBin.Text = val;
                            break;
                        case "DEC":
                            tbDec.Text = val;
                            break;
                        case "OCT":
                            tbOct.Text = val;
                            break;
                    }
                }
            }
            // Scrollen Sie zu den neuesten Einträgen
            ScrollToBottom(lbHex);
            ScrollToBottom(lbRaw);
            ScrollToBottom(lbBin);
            ScrollToBottom(lbDec);
            ScrollToBottom(lbOct);

            btnExport.Enabled = true;
            btnDelete.Enabled = true;
        }

        // Scrollen zum letzten Eintrag
        private void ScrollToBottom(ListBox listBox)
        {
            listBox.SelectedIndex = listBox.Items.Count - 1;
            listBox.SelectedIndex = -1; // Entfernt die Auswahl wieder
        }


        private void Main_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV-File (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV-File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("HEX,RAW,BIN,DEC,OCT");

                        int maxCount = Math.Max(lbHex.Items.Count,
                            Math.Max(lbRaw.Items.Count,
                            Math.Max(lbBin.Items.Count,
                            Math.Max(lbDec.Items.Count, lbOct.Items.Count))));

                        for (int i = 0; i < maxCount; i++)
                        {
                            string hex = i < lbHex.Items.Count ? $"{lbHex.Items[i]?.ToString() ?? ""}" : "";
                            string raw = i < lbRaw.Items.Count ? $"{lbRaw.Items[i]?.ToString() ?? ""}" : "";
                            string bin = i < lbBin.Items.Count ? $"'{lbBin.Items[i]?.ToString() ?? ""}" : "";
                            string dec = i < lbDec.Items.Count ? $"{lbDec.Items[i]?.ToString() ?? ""}" : "";
                            string oct = i < lbOct.Items.Count ? $"{lbOct.Items[i]?.ToString() ?? ""}" : "";

                            sw.WriteLine($"{hex},{raw},{bin},{dec},{oct}");
                        }
                    }

                    MessageBox.Show("Data exported successfully.", "Export completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CopyToClipboard(string? text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                Clipboard.SetText(text);
                toolTip1.Show("Copied!", this, this.PointToClient(Cursor.Position), 1000);
            }
        }

        private void TextBox_Click(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                CopyToClipboard(textBox.Text);
            }
        }

        private void ListBox_Click(object? sender, EventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem != null)
            {
                CopyToClipboard(listBox.SelectedItem.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbHex.Text = string.Empty;
            tbRaw.Text = string.Empty;
            tbBin.Text = string.Empty;
            tbDec.Text = string.Empty;
            tbOct.Text = string.Empty;
            lbHex.Items.Clear();
            lbRaw.Items.Clear();
            lbBin.Items.Clear();
            lbDec.Items.Clear();
            lbOct.Items.Clear();
            btnDelete.Enabled = false;
            btnExport.Enabled = false;
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/TueftelTyp/irDecoder";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
