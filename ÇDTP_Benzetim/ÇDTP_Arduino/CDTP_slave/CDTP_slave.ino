#include <Wire.h>
#include "Daire.h"

Daire daire;
const int d_role[] = {2, 3, 4, 5};
const int d_olcumpin[] = {A0, A1, A2, A3};
const int d_direnc[] = {1, 2, 4, 8};
const int d_no = 7;
bool Denetleyici[] = {true, true, true, true};

void setup()
{
  for (int i = 0; i < 4; i++)
  {
    daire.Role[i] = d_role[i];
    daire.Direnc[i] = d_direnc[i];
    daire.OlcumPin[i] = d_olcumpin[i];
    pinMode(daire.Role[i], OUTPUT);
  }
  daire.No = digitalRead(d_no) + 1;
  for (int i = 0; i < 4; i++)
    digitalWrite(daire.Role[i], Denetleyici[i]);
  Wire.begin(daire.No);
  Wire.onRequest(VeriGonder);
  Wire.onReceive(Denetleme);
  Serial.begin(1200);
}
void loop()
{
  for (int i = 0; i < 4; i++)
  {
    daire.Gerilim[i] = 5 * analogRead(daire.OlcumPin[i]) / 1023.0;
    daire.Guc[i].flt = pow(daire.Gerilim[i], 2) / daire.Direnc[i];
  }
  daire.ToplamGuc.flt = 0;
  for (int i = 0; i < 4; i++)
    daire.ToplamGuc.flt += daire.Guc[i].flt;
  Debug();
}
void Debug()
{
  Serial.print(daire.No);
  Serial.print(". Daire ->   ");
  for (int i = 0; i < 4; i++)
  {
    Serial.print(daire.Guc[i].flt);
    Serial.print("   ");
  }
  Serial.println();
}
void VeriGonder()
{
  Wire.write(daire.No);
  Wire.write(daire.ToplamGuc.bytes, 4);
}
void Denetleme(int numBytes)
{
  if (numBytes == 2)
  {
    byte EsyaNo = Wire.read();
    byte sinyal = Wire.read();
    Denetleyici[EsyaNo] = sinyal;
    digitalWrite(daire.Role[EsyaNo - 1], Denetleyici[EsyaNo]);
  }
}
