# IR Decoder
a small and simple tool to decode and readout IR signals.

Since I have to read out IR remote controls from time to time, I have created a simple project.

It holds a Wemos D1 mini (or clone) and an IR receiver (type doesn't matter, but pay attention to the pinout).

----
### Code
The code, it is a slightly modified version of the IRrecvDemo from the [IRremoteESP8266](https://github.com/crankyoldgit/IRremoteESP8266 "IRremoteESP8266") library (this must be included and could be downloaded [here](https://github.com/crankyoldgit/IRremoteESP8266/blob/master/src/IRremoteESP8266.h "here")).

The current code reads HEX as well as all other values.
These values are output in any serial monitor with BAUD 115200.

-----
### 3D Printing
The two files with the name lid are covers, which have to be glued in.

-----
### Assembly
When assembling, make sure that the cables are first plugged through from the side facing away from the ESP. Attention: solder as flat as possible.
Then, ideally, the cables should be routed through the housing.
The Wemos is then also fed into the housing.
Finally, the IR receiver is soldered on, insulated and pressed into its seat.
