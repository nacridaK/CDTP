using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using static ÇDTP.ZedGraph.VeriTuruDonusumleri;

namespace ÇDTP.ZedGraph
{
    public class PointPairListBase : PointPairList
    {
        public double BaslangicZamani { get; } = new XDate(1899, 12, 30, 0, 0, 0, 0).XLDate;
        public event EventHandler VeriTuruDegisti;
        public VeriTuru Tur { get; private set; }
        public int VeriBoyutu => VeriBoyutuDondur(Tur);
        DonusturMethodu Donustur => Methodlar[(int)Tur];
        public double dt { get; private set; }
        public double SonXZaman { get; private set; } = 0;
        public double Harcama { get; private set; } = 0;
        public double SonXVerisi
        {
            get
            {
                if (Count == 0)
                    return BaslangicZamani;
                return this[Count - 1].X;
            }
        }
        public PointPairListBase(VeriTuru tur = VeriTuru.Byte) => Tur = tur;
        public int DonusturVeEkle(double seconds, double x, byte[] deger, int baslangicIndisi)
        {
            dt = seconds - SonXZaman;
            SonXZaman = seconds;
            int veri = DonusturVeEkle(x, deger, baslangicIndisi);
            Harcama += this[Count - 1].Y * dt;
            return veri;
        }
        public int DonusturVeEkle(double x, byte[] deger, int baslangicIndisi)
        {
            double veri = Donustur(deger, baslangicIndisi);
            Add(x, veri);
            return VeriBoyutu;
        }
        public void VeriTuruDegistir(VeriTuru tur)
        {
            Tur = tur;
            VeriTuruDegisti?.Invoke(this, EventArgs.Empty);
        }
    }
}