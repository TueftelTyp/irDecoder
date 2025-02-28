# IR Decoder
a small and simple tool to decode and readout IR signals.

Since I have to read out IR remote controls from time to time, I have created a simple project.\
It holds a Wemos D1 mini (or clone) and an IR receiver (type doesn't matter, but pay attention to the pinout).

---
## Update 28.02.2025:
There is now an Windows application that makes reading out even more convenient. \
It is portable executable and requires only few resources, written in C# and available for [download in the releases](https://github.com/TueftelTyp/irDecoder/releases "download in the releases").\
The source code can also be found [here](https://github.com/TueftelTyp/irDecoder/tree/main/irDecoder%20App "here").

----
### c+ Code:
The code, it is a slightly modified version of the IRrecvDemo from the [IRremoteESP8266](https://github.com/crankyoldgit/IRremoteESP8266 "IRremoteESP8266") library \
(this must be included and could be downloaded [here](https://github.com/crankyoldgit/IRremoteESP8266/blob/master/src/IRremoteESP8266.h "here")).

The current code reads HEX as well as all other values, like this:\
*HEX= 167EACDF : RAW= FFRNS3 : BIN= 101011 : DEC= 377400 : OCT= 2652633*

These values are output in any serial monitor with **BAUD 115200**.

You may need the CH340 driver to be able to communicate with the Wemos. You can get it [here](https://www.wemos.cc/en/latest/ch340_driver.html "here").

-----
### 3D Printing:
The two files with the name lid are covers, which have to be glued in.

-----
### Assembly:
When assembling, make sure that the cables are first plugged through from the side facing away from the ESP.\
**Attention:** solder as flat as possible.
Then, ideally, the cables should be routed through the housing.\
The Wemos is then also fed into the housing.
Finally, the IR receiver is soldered on, insulated and pressed into its seat.

---

This project can also be found on [Thingiverse](https://www.thingiverse.com/thing:6633395 "Thingiverse").

---
---
#### Images
<img src="https://github.com/TueftelTyp/irDecoder/blob/main/images/wiring.jpg" width="500"> \
<img src="https://github.com/TueftelTyp/irDecoder/blob/main/images/irDecoderExe.png" width="500"> \
<img src="https://github.com/TueftelTyp/irDecoder/blob/main/images/back.jpg" width="250"> <img src="https://github.com/TueftelTyp/irDecoder/blob/main/images/front.jpg" width="250"> 
