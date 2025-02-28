namespace irDecoder
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            cbPort = new ComboBox();
            btConnect = new Button();
            tbHex = new TextBox();
            tbRaw = new TextBox();
            tbBin = new TextBox();
            tbDec = new TextBox();
            tbOct = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbOct = new ListBox();
            lbDec = new ListBox();
            lbBin = new ListBox();
            lbRaw = new ListBox();
            lbHex = new ListBox();
            btRefresh = new Button();
            btnExport = new Button();
            cbBaud = new ComboBox();
            toolTip1 = new ToolTip(components);
            btnDelete = new Button();
            linkGitHub = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbPort
            // 
            cbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPort.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPort.FormattingEnabled = true;
            cbPort.Location = new Point(204, 22);
            cbPort.Margin = new Padding(3, 2, 3, 2);
            cbPort.Name = "cbPort";
            cbPort.Size = new Size(117, 28);
            cbPort.TabIndex = 1;
            // 
            // btConnect
            // 
            btConnect.BackgroundImage = Properties.Resources.disonnect;
            btConnect.BackgroundImageLayout = ImageLayout.Zoom;
            btConnect.Location = new Point(409, 21);
            btConnect.Margin = new Padding(3, 2, 3, 2);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(30, 30);
            btConnect.TabIndex = 3;
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // tbHex
            // 
            tbHex.Location = new Point(3, 17);
            tbHex.Margin = new Padding(3, 2, 3, 2);
            tbHex.Name = "tbHex";
            tbHex.ReadOnly = true;
            tbHex.Size = new Size(90, 23);
            tbHex.TabIndex = 2;
            tbHex.TabStop = false;
            tbHex.TextAlign = HorizontalAlignment.Center;
            // 
            // tbRaw
            // 
            tbRaw.Location = new Point(99, 17);
            tbRaw.Margin = new Padding(3, 2, 3, 2);
            tbRaw.Name = "tbRaw";
            tbRaw.ReadOnly = true;
            tbRaw.Size = new Size(90, 23);
            tbRaw.TabIndex = 3;
            tbRaw.TabStop = false;
            tbRaw.TextAlign = HorizontalAlignment.Center;
            // 
            // tbBin
            // 
            tbBin.Location = new Point(195, 17);
            tbBin.Margin = new Padding(3, 2, 3, 2);
            tbBin.Name = "tbBin";
            tbBin.ReadOnly = true;
            tbBin.Size = new Size(200, 23);
            tbBin.TabIndex = 4;
            tbBin.TabStop = false;
            tbBin.TextAlign = HorizontalAlignment.Center;
            // 
            // tbDec
            // 
            tbDec.Location = new Point(401, 17);
            tbDec.Margin = new Padding(3, 2, 3, 2);
            tbDec.Name = "tbDec";
            tbDec.ReadOnly = true;
            tbDec.Size = new Size(90, 23);
            tbDec.TabIndex = 5;
            tbDec.TabStop = false;
            tbDec.TextAlign = HorizontalAlignment.Center;
            // 
            // tbOct
            // 
            tbOct.Location = new Point(497, 17);
            tbOct.Margin = new Padding(3, 2, 3, 2);
            tbOct.Name = "tbOct";
            tbOct.ReadOnly = true;
            tbOct.Size = new Size(92, 23);
            tbOct.TabIndex = 6;
            tbOct.TabStop = false;
            tbOct.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Hexadecimal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(99, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Raw data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(195, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Binary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(401, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Decimal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(497, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "Octal:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2999172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2999172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.80033F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2999172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2999172F));
            tableLayoutPanel1.Controls.Add(lbOct, 4, 2);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(tbHex, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(lbDec, 3, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(tbRaw, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(lbBin, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbBin, 2, 1);
            tableLayoutPanel1.Controls.Add(lbRaw, 1, 2);
            tableLayoutPanel1.Controls.Add(tbDec, 3, 1);
            tableLayoutPanel1.Controls.Add(lbHex, 0, 2);
            tableLayoutPanel1.Controls.Add(tbOct, 4, 1);
            tableLayoutPanel1.Location = new Point(10, 68);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(592, 217);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // lbOct
            // 
            lbOct.FormattingEnabled = true;
            lbOct.ItemHeight = 15;
            lbOct.Location = new Point(497, 43);
            lbOct.Margin = new Padding(3, 2, 3, 2);
            lbOct.Name = "lbOct";
            lbOct.Size = new Size(92, 169);
            lbOct.TabIndex = 19;
            lbOct.TabStop = false;
            // 
            // lbDec
            // 
            lbDec.FormattingEnabled = true;
            lbDec.ItemHeight = 15;
            lbDec.Location = new Point(401, 43);
            lbDec.Margin = new Padding(3, 2, 3, 2);
            lbDec.Name = "lbDec";
            lbDec.Size = new Size(90, 169);
            lbDec.TabIndex = 18;
            lbDec.TabStop = false;
            // 
            // lbBin
            // 
            lbBin.FormattingEnabled = true;
            lbBin.ItemHeight = 15;
            lbBin.Location = new Point(195, 43);
            lbBin.Margin = new Padding(3, 2, 3, 2);
            lbBin.Name = "lbBin";
            lbBin.Size = new Size(200, 169);
            lbBin.TabIndex = 17;
            lbBin.TabStop = false;
            // 
            // lbRaw
            // 
            lbRaw.FormattingEnabled = true;
            lbRaw.ItemHeight = 15;
            lbRaw.Location = new Point(99, 43);
            lbRaw.Margin = new Padding(3, 2, 3, 2);
            lbRaw.Name = "lbRaw";
            lbRaw.Size = new Size(90, 169);
            lbRaw.TabIndex = 16;
            lbRaw.TabStop = false;
            // 
            // lbHex
            // 
            lbHex.FormattingEnabled = true;
            lbHex.ItemHeight = 15;
            lbHex.Location = new Point(3, 43);
            lbHex.Margin = new Padding(3, 2, 3, 2);
            lbHex.Name = "lbHex";
            lbHex.Size = new Size(90, 169);
            lbHex.TabIndex = 15;
            lbHex.TabStop = false;
            // 
            // btRefresh
            // 
            btRefresh.BackgroundImage = Properties.Resources.reload;
            btRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btRefresh.Location = new Point(173, 21);
            btRefresh.Margin = new Padding(3, 2, 3, 2);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(30, 30);
            btRefresh.TabIndex = 0;
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.BackgroundImage = Properties.Resources.export;
            btnExport.BackgroundImageLayout = ImageLayout.Stretch;
            btnExport.Enabled = false;
            btnExport.Location = new Point(554, 22);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(30, 30);
            btnExport.TabIndex = 5;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cbBaud
            // 
            cbBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaud.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbBaud.FormattingEnabled = true;
            cbBaud.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "230400", "250000", "500000", "1000000" });
            cbBaud.Location = new Point(323, 22);
            cbBaud.Name = "cbBaud";
            cbBaud.RightToLeft = RightToLeft.No;
            cbBaud.Size = new Size(85, 28);
            cbBaud.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.delete;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(524, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(30, 30);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // linkGitHub
            // 
            linkGitHub.AutoSize = true;
            linkGitHub.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkGitHub.Location = new Point(292, 282);
            linkGitHub.Name = "linkGitHub";
            linkGitHub.Size = new Size(29, 9);
            linkGitHub.TabIndex = 15;
            linkGitHub.TabStop = true;
            linkGitHub.Text = "GitHub";
            linkGitHub.LinkClicked += linkGitHub_LinkClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 295);
            Controls.Add(linkGitHub);
            Controls.Add(btnDelete);
            Controls.Add(cbBaud);
            Controls.Add(btnExport);
            Controls.Add(btRefresh);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btConnect);
            Controls.Add(cbPort);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "irDecoder";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPort;
        private Button btConnect;
        private TextBox tbHex;
        private TextBox tbRaw;
        private TextBox tbBin;
        private TextBox tbDec;
        private TextBox tbOct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lbHex;
        private ListBox lbRaw;
        private ListBox lbBin;
        private ListBox lbDec;
        private ListBox lbOct;
        private Button btRefresh;
        private Button btnExport;
        private ComboBox cbBaud;
        private ToolTip toolTip1;
        private Button btnDelete;
        private LinkLabel linkGitHub;
    }
}
