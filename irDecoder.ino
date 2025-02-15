/*
 * IRremoteESP8266: IRrecvDemo 
 * Copyright 2009 Ken Shirriff, http://arcfn.com
 * 
 *  https://github.com/crankyoldgit/IRremoteESP8266/wiki#ir-receiving
 */

#include <Arduino.h>
#include <IRremoteESP8266.h>
#include <IRrecv.h>
#include <IRutils.h>

// An IR detector/demodulator is connected to GPIO pin 14(D5 on a NodeMCU
// board).
// Note: GPIO 16 won't work on the ESP8266 as it does not have interrupts.
// Note: GPIO 14 won't work on the ESP32-C3 as it causes the board to reboot.
#ifdef ARDUINO_ESP32C3_DEV
const uint16_t kRecvPin = 10;  // 14 on a ESP32-C3 causes a boot loop.
#else  // ARDUINO_ESP32C3_DEV
const uint16_t kRecvPin = 14;
#endif  // ARDUINO_ESP32C3_DEV

IRrecv irrecv(kRecvPin);

decode_results results;

void setup() {
  Serial.begin(115200);
  irrecv.enableIRIn();  // Start the receiver
  while (!Serial)  // Wait for the serial connection to be establised.
    delay(50);
  Serial.println();
  Serial.print("IR-Reader is now running and waiting for IR message on Pin ");
  Serial.println(kRecvPin);
}

void loop() {
  if (irrecv.decode(&results)) {
    // print() & println() can't handle printing long longs. (uint64_t)
    Serial.print("");
    Serial.print("HEX= ");
    serialPrintUint64(results.value, HEX);
    Serial.print(" : ");
    Serial.print("RAW= ");
    serialPrintUint64(results.value, RAW);
    Serial.print(" : ");
    Serial.print("BIN= ");
    serialPrintUint64(results.value, BIN);
    Serial.print(" : ");
    Serial.print("DEC= ");
    serialPrintUint64(results.value, DEC);
    Serial.print(" : ");
    Serial.print("OCT= ");
    serialPrintUint64(results.value, OCT);
    Serial.println();
    Serial.println(" --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ");
    //Serial.println("");
    irrecv.resume();  // Receive the next value
  }
  delay(100);
}
