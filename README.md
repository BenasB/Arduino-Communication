# Arduino-Communication
A simple program that allows a Windows Forms application to communicate with an arduino

I got my arduino hooked up to a 16x2 LCD (through I2C) and 2 LEDs

You can:
* Send text and display it on the LCD
* Set the value of wanted digital pin

The whole system relies on commands being sent to the arduino from the application (all commands must end with '\n')
* #BEGIN - indicates that the application successfully connected
* #END - indicates that the applciation had disconnected
* #CLEAR - clears the LCD
* #DIG_PINNUMBER_VALUE - writes a value on a digital pin (does digitalWrite). Value must be either 1 or 0.

[![Demonstration](https://img.youtube.com/vi/i9DpcGDTnBk/0.jpg)](https://www.youtube.com/watch?v=i9DpcGDTnBk)
