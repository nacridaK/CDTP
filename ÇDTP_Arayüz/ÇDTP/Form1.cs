using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using ZedGraph;
using ÇDTP.ZedGraph;
using Microsoft.VisualBasic;

namespace ÇDTP
{
    public partial class Form1 : Form
    {
        byte[] Arabellek = new byte[5];
        System.Windows.Forms.Label[] labels;
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan timespan_zaman;
        XDate xdate_zaman;
        ZedGraphKontrol[] zedGraphs;
        CheckBox[,] checkBoxes;
        TextBox[] textBoxes;
        double[] bakiye = { 1000, 1000 };
        double[] harcama = { 0, 0 };
        public Form1()
        {
            InitializeComponent();
            checkBox1_1.Tag = new byte[2] { 1, 1 };
            checkBox1_2.Tag = new byte[2] { 1, 2 };
            checkBox1_3.Tag = new byte[2] { 1, 3 };
            checkBox1_4.Tag = new byte[2] { 1, 4 };
            checkBox2_1.Tag = new byte[2] { 2, 1 };
            checkBox2_2.Tag = new byte[2] { 2, 2 };
            checkBox2_3.Tag = new byte[2] { 2, 3 };
            checkBox2_4.Tag = new byte[2] { 2, 4 };
            checkBoxes = new CheckBox[2, 4] { { checkBox1_1, checkBox1_2, checkBox1_3, checkBox1_4 }, { checkBox2_1, checkBox2_2, checkBox2_3, checkBox2_4 } };
            labels = new System.Windows.Forms.Label[2] { label1_ToplamGuc, label2_ToplamGuc };
            zedGraphs = new ZedGraphKontrol[2] { zedGraphKontrol1, zedGraphKontrol2 };
            textBoxes = new TextBox[2] { textBox1_LimitGuc, textBox2_LimitGuc };
            CheckForIllegalCrossThreadCalls = false;
        }
        void EsyaKontrolu(object sender, EventArgs e)
        {
            CheckBox cbox = (CheckBox)sender;
            byte[] dizi = (byte[])(cbox.Tag);
            byte[] kontrol = new byte[1] { Convert.ToByte(cbox.Checked && cbox.Enabled) };
            Seriport.Write(dizi, 0, 2);
            Seriport.Write(kontrol, 0, 1);
        }
        void SeriportAc(object sender, EventArgs e)
        {
            Seriport.Open();
            stopwatch.Start();
            button_SeriportAc.Enabled = false;
            button_SeriportKapat.Enabled = true;
            checkBox1_1.Enabled = true;
            checkBox1_2.Enabled = true;
            checkBox1_3.Enabled = true;
            checkBox1_4.Enabled = true;
            checkBox2_1.Enabled = true;
            checkBox2_2.Enabled = true;
            checkBox2_3.Enabled = true;
            checkBox2_4.Enabled = true;
        }
        void SeriportKapat(object sender, EventArgs e)
        {
            Seriport.Close();
            stopwatch.Stop();
            button_SeriportAc.Enabled = true;
            button_SeriportKapat.Enabled = false;
            checkBox1_1.Enabled = false;
            checkBox1_2.Enabled = false;
            checkBox1_3.Enabled = false;
            checkBox1_4.Enabled = false;
            checkBox2_1.Enabled = false;
            checkBox2_2.Enabled = false;
            checkBox2_3.Enabled = false;
            checkBox2_4.Enabled = false;
        }
        void VeriGeldi(object sender, SerialDataReceivedEventArgs e)
        {
            timespan_zaman = stopwatch.Elapsed;
            xdate_zaman = new XDate(1899, 12, 30, timespan_zaman.Hours, timespan_zaman.Minutes, timespan_zaman.Seconds, timespan_zaman.Milliseconds);
            for (int i = 0; i < Arabellek.Length; i++)
                Arabellek[i] = (byte)Seriport.ReadByte();
            int no = Arabellek[0] - 1;
            zedGraphs[no].VeriListesi.DonusturVeEkle(timespan_zaman.TotalSeconds, xdate_zaman, Arabellek, 1);
            harcama[no] = zedGraphs[no].VeriListesi.Harcama;
            labels[no].Text = harcama[no].ToString();
            LimitKontrol(no);
            ZedGraphGuncelle(zedGraphs[Arabellek[0] - 1]);
        }
        void LimitKontrol(int daire)
        {
            if (harcama[daire] > bakiye[daire])
                for (int i = 0; i < 4; i++)
                    checkBoxes[daire, i].Enabled = false;
            else if (Seriport.IsOpen)
                for (int i = 0; i < 4; i++)
                    checkBoxes[daire, i].Enabled = true;
        }
        void ZedGraphGuncelle(ZedGraphKontrol zedGraph)
        {
            if (!zedGraph.GecmisiIncele)
            {
                try
                {
                    double sonDeger = zedGraph.VeriListesi.SonXVerisi;
                    zedGraph.X_EkseniniOlceklendir(sonDeger);
                }
                catch
                {
                }
            }
        }
        void LimitUygula(object sender, EventArgs e)
        {
            int numara = Convert.ToInt32(((Button)sender).Tag);
            bakiye[numara] = int.Parse(textBoxes[numara].Text);
            LimitKontrol(numara);
        }
        void EnerjiTalebi(object sender, EventArgs e)
        {
            int alici, verici, miktar;
            if(!int.TryParse(Interaction.InputBox("Enerji talep eden daireyi girin:", "Enerji Transferi"), out alici))
                return;
            if (!int.TryParse(Interaction.InputBox("Enerjinin talep edildiği daireyi girin:", "Enerji Transferi"), out verici))
                return;
            if (!int.TryParse(Interaction.InputBox("Transfer edilecek enerji miktarını girin:", "Enerji Transferi"), out miktar))
                return;
            if (bakiye[verici - 1] - miktar < harcama[verici - 1])
            {
                MessageBox.Show("Enerji transferi gerçekleşmedi, verici bakiyesi yetersiz.", "Enerji Transferi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bakiye[alici-1] += miktar;
            textBoxes[alici - 1].Text = bakiye[alici - 1].ToString();
            bakiye[verici - 1] -= miktar;
            textBoxes[verici - 1].Text = bakiye[verici - 1].ToString();
            MessageBox.Show("Enerji transferi gerçekleşti.", "Enerji Transferi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void EnerjiSatinAlma(object sender, EventArgs e)
        {
            int alici, miktar;
            if (!int.TryParse(Interaction.InputBox("Enerji satın alan daireyi girin:", "Enerji Satın Alma"), out alici))
                return;
            if (!int.TryParse(Interaction.InputBox("Satın alınacak enerji miktarını girin:", "Enerji Satın Alma"), out miktar))
                return;
            bakiye[alici - 1] += miktar;
            textBoxes[alici - 1].Text = bakiye[alici - 1].ToString();
            MessageBox.Show("Enerji satın alımı gerçekleşti.", "Enerji Satın Alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}