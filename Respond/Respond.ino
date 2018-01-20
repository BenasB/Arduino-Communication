#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd (0x27, 16, 2);
String message = String("");

void handleMessage(String msg)
{
  if (msg == "#BEGIN")
  {
    lcd.clear();
    lcd.print("Connected");
  }else if (msg == "#END")
  {
    lcd.clear();
    lcd.print("Disconnected");
  }else if (msg == "#CLEAR")
  {
    lcd.clear();
  }else if (msg.startsWith("#DIG"))
  {
    msg.remove(0, 5);

    // Get pin
    int pin = -1;
    for (int i = 0; i < msg.length(); i++)
    {
      if (msg[i] == '_')
      {
        pin = msg.substring(0, i).toInt();
        msg.remove(0,i+1);
        break;
      }
    }
    if (pin == -1)
    {
      lcd.clear();
      lcd.print("No pin found");
      return;
    }

    pinMode(pin, OUTPUT);

    // Get state
    int state = msg.toInt();

    digitalWrite(pin, state);
  }else
  {
    lcd.clear();
    
    if (msg.length() > 16)
    {
      lcd.print(msg.substring(0, 16));
      lcd.setCursor(0,1);
      lcd.print(msg.substring(16, msg.length()));
    }else
      lcd.print(msg);
  }
}

void setup() {
  Serial.begin(9600);

  lcd.begin();
  lcd.backlight();
  lcd.clear();
}

void loop() {
  while(Serial.available() > 0)
  {
    char ch = Serial.read();
    if (ch != '\n')
    {
      message += ch;
    }else
    {
      handleMessage(message);
      message = String("");  
    }
  }
}
