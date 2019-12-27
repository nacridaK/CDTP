union Veri
{
  float flt;
  byte bytes[4];
};
struct Daire
{
  byte No;
  int Role[4];
  int Direnc[4];
  int Gerilim[4];
  int OlcumPin[4];
  Veri Guc[4];
  Veri ToplamGuc;
};
struct Denetleyici
{
  byte DaireNo;
  byte EsyaNo;
  byte Denetleme;
};