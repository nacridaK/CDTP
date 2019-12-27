#include <Wire.h>
#include "Daire.h"

Veri d1;
Denetleyici denetleyici;
byte No;
void setup()
{
  Wire.begin();
  Wire.setClock(1);
  Serial.begin(1200);
}
void loop()
{
  if (Serial.available() == 3)
  {
    denetleyici.DaireNo = Serial.read() - 256;
    denetleyici.EsyaNo = Serial.read() - 256;
    denetleyici.Denetleme = Serial.read() - 256;
    Wire.beginTransmission(denetleyici.DaireNo);
    Wire.write(denetleyici.EsyaNo);
    Wire.write(denetleyici.Denetleme);
    Wire.endTransmission(true);
//    Serial.print(denetleyici.DaireNo);
//    Serial.print(". dairedeki ");
//    Serial.print(denetleyici.EsyaNo);
//    Serial.print(". esya ");
//    Serial.print(denetleyici.Denetleme);
//    Serial.println(" konunumda.");
  }
  else
  {
    for (int j = 1; j < 3; j++)
    {
      Wire.requestFrom(j, 5);
      if (Wire.available())
      {
        No = Wire.read();
        Serial.write(No);
        for (int i = 0; i < 4; i++)
        {
         d1.bytes[i] = Wire.read();
         Serial.write(d1.bytes[i]);
        }
//        Serial.print(j);
//        Serial.print("   ");
//        Serial.print(d1.flt);
//        Serial.print("   ");
//        Serial.println();
      }
    }
  }
}
