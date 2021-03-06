# Arduino-Communication
A simple program that allows a Windows Forms application to communicate with an arduino

[Press here](https://www.dropbox.com/s/w82zkf3pgwupl6s/ArduinoCommunication.exe?dl=0) if you want to download the .exe

You can:
* Send text and display it on the LCD
* Set the value of wanted digital pin

The whole system relies on commands being sent to the arduino from the application (all commands must end with '\n')   
I got my arduino hooked up to a 16x2 LCD (through I2C) and 2 LEDs
* #BEGIN - indicates that the application successfully connected
* #END - indicates that the applciation had disconnected
* #CLEAR - clears the LCD
* #DIG_PINNUMBER_VALUE - writes a value on a digital pin (does digitalWrite). Value must be either 1 or 0.
* If the message doesn't start with either one of the strings from this list, it is displayed on the LCD.

Note that I used [this](https://github.com/fdebrabander/Arduino-LiquidCrystal-I2C-library) library to control the LCD  
The icon is from [here](https://www.flaticon.com/free-icon/usb-cable_196514#term=port&page=1&position=40)

#### Click on the image to check out a demo
[![Demonstration](https://img.youtube.com/vi/i9DpcGDTnBk/0.jpg)](https://www.youtube.com/watch?v=i9DpcGDTnBk)
