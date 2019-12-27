namespace ÇDTP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1_1 = new System.Windows.Forms.CheckBox();
            this.checkBox1_2 = new System.Windows.Forms.CheckBox();
            this.checkBox1_3 = new System.Windows.Forms.CheckBox();
            this.checkBox1_4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_Uygula = new System.Windows.Forms.Button();
            this.textBox1_LimitGuc = new System.Windows.Forms.TextBox();
            this.label1_ToplamGuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2_Uygula = new System.Windows.Forms.Button();
            this.textBox2_LimitGuc = new System.Windows.Forms.TextBox();
            this.label2_ToplamGuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2_1 = new System.Windows.Forms.CheckBox();
            this.checkBox2_4 = new System.Windows.Forms.CheckBox();
            this.checkBox2_2 = new System.Windows.Forms.CheckBox();
            this.checkBox2_3 = new System.Windows.Forms.CheckBox();
            this.Seriport = new System.IO.Ports.SerialPort(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button_SeriportAc = new System.Windows.Forms.Button();
            this.groupBox_Seriport = new System.Windows.Forms.GroupBox();
            this.groupBox_Daireler = new System.Windows.Forms.GroupBox();
            this.button_EnerjiSatınAl = new System.Windows.Forms.Button();
            this.button_EnerjiTalebi = new System.Windows.Forms.Button();
            this.button_SeriportKapat = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.zedGraphKontrol1 = new ÇDTP.ZedGraph.ZedGraphKontrol();
            this.zedGraphKontrol2 = new ÇDTP.ZedGraph.ZedGraphKontrol();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Seriport.SuspendLayout();
            this.groupBox_Daireler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1_1
            // 
            this.checkBox1_1.AutoSize = true;
            this.checkBox1_1.Checked = true;
            this.checkBox1_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_1.Enabled = false;
            this.checkBox1_1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1_1.Name = "checkBox1_1";
            this.checkBox1_1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1_1.TabIndex = 0;
            this.checkBox1_1.Text = "Eşya 1";
            this.checkBox1_1.UseVisualStyleBackColor = true;
            this.checkBox1_1.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox1_1.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox1_2
            // 
            this.checkBox1_2.AutoSize = true;
            this.checkBox1_2.Checked = true;
            this.checkBox1_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_2.Enabled = false;
            this.checkBox1_2.Location = new System.Drawing.Point(6, 42);
            this.checkBox1_2.Name = "checkBox1_2";
            this.checkBox1_2.Size = new System.Drawing.Size(58, 17);
            this.checkBox1_2.TabIndex = 0;
            this.checkBox1_2.Text = "Eşya 2";
            this.checkBox1_2.UseVisualStyleBackColor = true;
            this.checkBox1_2.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox1_2.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox1_3
            // 
            this.checkBox1_3.AutoSize = true;
            this.checkBox1_3.Checked = true;
            this.checkBox1_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_3.Enabled = false;
            this.checkBox1_3.Location = new System.Drawing.Point(6, 65);
            this.checkBox1_3.Name = "checkBox1_3";
            this.checkBox1_3.Size = new System.Drawing.Size(58, 17);
            this.checkBox1_3.TabIndex = 0;
            this.checkBox1_3.Text = "Eşya 3";
            this.checkBox1_3.UseVisualStyleBackColor = true;
            this.checkBox1_3.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox1_3.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox1_4
            // 
            this.checkBox1_4.AutoSize = true;
            this.checkBox1_4.Checked = true;
            this.checkBox1_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_4.Enabled = false;
            this.checkBox1_4.Location = new System.Drawing.Point(6, 88);
            this.checkBox1_4.Name = "checkBox1_4";
            this.checkBox1_4.Size = new System.Drawing.Size(58, 17);
            this.checkBox1_4.TabIndex = 0;
            this.checkBox1_4.Text = "Eşya 4";
            this.checkBox1_4.UseVisualStyleBackColor = true;
            this.checkBox1_4.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox1_4.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_Uygula);
            this.groupBox1.Controls.Add(this.textBox1_LimitGuc);
            this.groupBox1.Controls.Add(this.label1_ToplamGuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1_1);
            this.groupBox1.Controls.Add(this.checkBox1_4);
            this.groupBox1.Controls.Add(this.checkBox1_2);
            this.groupBox1.Controls.Add(this.checkBox1_3);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daire 1";
            // 
            // button1_Uygula
            // 
            this.button1_Uygula.Location = new System.Drawing.Point(85, 76);
            this.button1_Uygula.Name = "button1_Uygula";
            this.button1_Uygula.Size = new System.Drawing.Size(87, 23);
            this.button1_Uygula.TabIndex = 7;
            this.button1_Uygula.Tag = "0";
            this.button1_Uygula.Text = "Uygula";
            this.button1_Uygula.UseVisualStyleBackColor = true;
            this.button1_Uygula.Click += new System.EventHandler(this.LimitUygula);
            // 
            // textBox1_LimitGuc
            // 
            this.textBox1_LimitGuc.Location = new System.Drawing.Point(85, 105);
            this.textBox1_LimitGuc.Name = "textBox1_LimitGuc";
            this.textBox1_LimitGuc.Size = new System.Drawing.Size(87, 20);
            this.textBox1_LimitGuc.TabIndex = 7;
            this.textBox1_LimitGuc.Text = "1000";
            // 
            // label1_ToplamGuc
            // 
            this.label1_ToplamGuc.AutoSize = true;
            this.label1_ToplamGuc.Location = new System.Drawing.Point(93, 128);
            this.label1_ToplamGuc.Name = "label1_ToplamGuc";
            this.label1_ToplamGuc.Size = new System.Drawing.Size(13, 13);
            this.label1_ToplamGuc.TabIndex = 4;
            this.label1_ToplamGuc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enerji Bakiye :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harcanan Enerji :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2_Uygula);
            this.groupBox2.Controls.Add(this.textBox2_LimitGuc);
            this.groupBox2.Controls.Add(this.label2_ToplamGuc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox2_1);
            this.groupBox2.Controls.Add(this.checkBox2_4);
            this.groupBox2.Controls.Add(this.checkBox2_2);
            this.groupBox2.Controls.Add(this.checkBox2_3);
            this.groupBox2.Location = new System.Drawing.Point(197, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daire 2";
            // 
            // button2_Uygula
            // 
            this.button2_Uygula.Location = new System.Drawing.Point(83, 76);
            this.button2_Uygula.Name = "button2_Uygula";
            this.button2_Uygula.Size = new System.Drawing.Size(89, 23);
            this.button2_Uygula.TabIndex = 7;
            this.button2_Uygula.Tag = "1";
            this.button2_Uygula.Text = "Uygula";
            this.button2_Uygula.UseVisualStyleBackColor = true;
            this.button2_Uygula.Click += new System.EventHandler(this.LimitUygula);
            // 
            // textBox2_LimitGuc
            // 
            this.textBox2_LimitGuc.Location = new System.Drawing.Point(83, 105);
            this.textBox2_LimitGuc.Name = "textBox2_LimitGuc";
            this.textBox2_LimitGuc.Size = new System.Drawing.Size(89, 20);
            this.textBox2_LimitGuc.TabIndex = 7;
            this.textBox2_LimitGuc.Text = "1000";
            // 
            // label2_ToplamGuc
            // 
            this.label2_ToplamGuc.AutoSize = true;
            this.label2_ToplamGuc.Location = new System.Drawing.Point(92, 128);
            this.label2_ToplamGuc.Name = "label2_ToplamGuc";
            this.label2_ToplamGuc.Size = new System.Drawing.Size(13, 13);
            this.label2_ToplamGuc.TabIndex = 4;
            this.label2_ToplamGuc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enerji Bakiye :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harcanan Enerji :";
            // 
            // checkBox2_1
            // 
            this.checkBox2_1.AutoSize = true;
            this.checkBox2_1.Checked = true;
            this.checkBox2_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2_1.Enabled = false;
            this.checkBox2_1.Location = new System.Drawing.Point(6, 19);
            this.checkBox2_1.Name = "checkBox2_1";
            this.checkBox2_1.Size = new System.Drawing.Size(58, 17);
            this.checkBox2_1.TabIndex = 0;
            this.checkBox2_1.Text = "Eşya 1";
            this.checkBox2_1.UseVisualStyleBackColor = true;
            this.checkBox2_1.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox2_1.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox2_4
            // 
            this.checkBox2_4.AutoSize = true;
            this.checkBox2_4.Checked = true;
            this.checkBox2_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2_4.Enabled = false;
            this.checkBox2_4.Location = new System.Drawing.Point(6, 88);
            this.checkBox2_4.Name = "checkBox2_4";
            this.checkBox2_4.Size = new System.Drawing.Size(58, 17);
            this.checkBox2_4.TabIndex = 0;
            this.checkBox2_4.Text = "Eşya 4";
            this.checkBox2_4.UseVisualStyleBackColor = true;
            this.checkBox2_4.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox2_4.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox2_2
            // 
            this.checkBox2_2.AutoSize = true;
            this.checkBox2_2.Checked = true;
            this.checkBox2_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2_2.Enabled = false;
            this.checkBox2_2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2_2.Name = "checkBox2_2";
            this.checkBox2_2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2_2.TabIndex = 0;
            this.checkBox2_2.Text = "Eşya 2";
            this.checkBox2_2.UseVisualStyleBackColor = true;
            this.checkBox2_2.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox2_2.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // checkBox2_3
            // 
            this.checkBox2_3.AutoSize = true;
            this.checkBox2_3.Checked = true;
            this.checkBox2_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2_3.Enabled = false;
            this.checkBox2_3.Location = new System.Drawing.Point(6, 65);
            this.checkBox2_3.Name = "checkBox2_3";
            this.checkBox2_3.Size = new System.Drawing.Size(58, 17);
            this.checkBox2_3.TabIndex = 0;
            this.checkBox2_3.Text = "Eşya 3";
            this.checkBox2_3.UseVisualStyleBackColor = true;
            this.checkBox2_3.CheckedChanged += new System.EventHandler(this.EsyaKontrolu);
            this.checkBox2_3.EnabledChanged += new System.EventHandler(this.EsyaKontrolu);
            // 
            // Seriport
            // 
            this.Seriport.BaudRate = 1200;
            this.Seriport.PortName = "COM4";
            this.Seriport.ReceivedBytesThreshold = 5;
            this.Seriport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.VeriGeldi);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.SelectedObject = this.Seriport;
            this.propertyGrid1.Size = new System.Drawing.Size(379, 496);
            this.propertyGrid1.TabIndex = 2;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // button_SeriportAc
            // 
            this.button_SeriportAc.Location = new System.Drawing.Point(6, 177);
            this.button_SeriportAc.Name = "button_SeriportAc";
            this.button_SeriportAc.Size = new System.Drawing.Size(89, 23);
            this.button_SeriportAc.TabIndex = 3;
            this.button_SeriportAc.Text = "Seriport Aç";
            this.button_SeriportAc.UseVisualStyleBackColor = true;
            this.button_SeriportAc.Click += new System.EventHandler(this.SeriportAc);
            // 
            // groupBox_Seriport
            // 
            this.groupBox_Seriport.Controls.Add(this.propertyGrid1);
            this.groupBox_Seriport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Seriport.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Seriport.Name = "groupBox_Seriport";
            this.groupBox_Seriport.Size = new System.Drawing.Size(385, 515);
            this.groupBox_Seriport.TabIndex = 4;
            this.groupBox_Seriport.TabStop = false;
            this.groupBox_Seriport.Text = "Seriport Özellikleri";
            // 
            // groupBox_Daireler
            // 
            this.groupBox_Daireler.Controls.Add(this.button_EnerjiSatınAl);
            this.groupBox_Daireler.Controls.Add(this.button_EnerjiTalebi);
            this.groupBox_Daireler.Controls.Add(this.groupBox1);
            this.groupBox_Daireler.Controls.Add(this.groupBox2);
            this.groupBox_Daireler.Controls.Add(this.button_SeriportAc);
            this.groupBox_Daireler.Controls.Add(this.button_SeriportKapat);
            this.groupBox_Daireler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Daireler.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Daireler.Name = "groupBox_Daireler";
            this.groupBox_Daireler.Size = new System.Drawing.Size(385, 204);
            this.groupBox_Daireler.TabIndex = 5;
            this.groupBox_Daireler.TabStop = false;
            this.groupBox_Daireler.Text = "Daireler";
            // 
            // button_EnerjiSatınAl
            // 
            this.button_EnerjiSatınAl.Location = new System.Drawing.Point(292, 177);
            this.button_EnerjiSatınAl.Name = "button_EnerjiSatınAl";
            this.button_EnerjiSatınAl.Size = new System.Drawing.Size(89, 23);
            this.button_EnerjiSatınAl.TabIndex = 7;
            this.button_EnerjiSatınAl.Text = "Enerji Satın Al";
            this.button_EnerjiSatınAl.UseVisualStyleBackColor = true;
            this.button_EnerjiSatınAl.Click += new System.EventHandler(this.EnerjiSatinAlma);
            // 
            // button_EnerjiTalebi
            // 
            this.button_EnerjiTalebi.Location = new System.Drawing.Point(197, 177);
            this.button_EnerjiTalebi.Name = "button_EnerjiTalebi";
            this.button_EnerjiTalebi.Size = new System.Drawing.Size(89, 23);
            this.button_EnerjiTalebi.TabIndex = 7;
            this.button_EnerjiTalebi.Text = "Enerji Talebi";
            this.button_EnerjiTalebi.UseVisualStyleBackColor = true;
            this.button_EnerjiTalebi.Click += new System.EventHandler(this.EnerjiTalebi);
            // 
            // button_SeriportKapat
            // 
            this.button_SeriportKapat.Enabled = false;
            this.button_SeriportKapat.Location = new System.Drawing.Point(102, 177);
            this.button_SeriportKapat.Name = "button_SeriportKapat";
            this.button_SeriportKapat.Size = new System.Drawing.Size(89, 23);
            this.button_SeriportKapat.TabIndex = 3;
            this.button_SeriportKapat.Text = "Seriport Kapat";
            this.button_SeriportKapat.UseVisualStyleBackColor = true;
            this.button_SeriportKapat.Click += new System.EventHandler(this.SeriportKapat);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 723);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Daireler);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox_Seriport);
            this.splitContainer3.Size = new System.Drawing.Size(385, 723);
            this.splitContainer3.SplitterDistance = 204;
            this.splitContainer3.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.zedGraphKontrol1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGraphKontrol2);
            this.splitContainer2.Size = new System.Drawing.Size(625, 723);
            this.splitContainer2.SplitterDistance = 360;
            this.splitContainer2.TabIndex = 7;
            // 
            // zedGraphKontrol1
            // 
            this.zedGraphKontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol1.GecmisiIncele = false;
            this.zedGraphKontrol1.IsEnableHPan = false;
            this.zedGraphKontrol1.IsEnableHZoom = false;
            this.zedGraphKontrol1.IsEnableVZoom = false;
            this.zedGraphKontrol1.IsShowContextMenu = false;
            this.zedGraphKontrol1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol1.Name = "zedGraphKontrol1";
            this.zedGraphKontrol1.ScrollGrace = 0D;
            this.zedGraphKontrol1.ScrollMaxX = 0D;
            this.zedGraphKontrol1.ScrollMaxY = 0D;
            this.zedGraphKontrol1.ScrollMaxY2 = 0D;
            this.zedGraphKontrol1.ScrollMinX = 0D;
            this.zedGraphKontrol1.ScrollMinY = 0D;
            this.zedGraphKontrol1.ScrollMinY2 = 0D;
            this.zedGraphKontrol1.Size = new System.Drawing.Size(625, 360);
            this.zedGraphKontrol1.TabIndex = 8;
            this.zedGraphKontrol1.Tur = ÇDTP.ZedGraph.VeriTuru.Single;
            this.zedGraphKontrol1.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol2
            // 
            this.zedGraphKontrol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol2.GecmisiIncele = false;
            this.zedGraphKontrol2.IsEnableHPan = false;
            this.zedGraphKontrol2.IsEnableHZoom = false;
            this.zedGraphKontrol2.IsEnableVZoom = false;
            this.zedGraphKontrol2.IsShowContextMenu = false;
            this.zedGraphKontrol2.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol2.Name = "zedGraphKontrol2";
            this.zedGraphKontrol2.ScrollGrace = 0D;
            this.zedGraphKontrol2.ScrollMaxX = 0D;
            this.zedGraphKontrol2.ScrollMaxY = 0D;
            this.zedGraphKontrol2.ScrollMaxY2 = 0D;
            this.zedGraphKontrol2.ScrollMinX = 0D;
            this.zedGraphKontrol2.ScrollMinY = 0D;
            this.zedGraphKontrol2.ScrollMinY2 = 0D;
            this.zedGraphKontrol2.Size = new System.Drawing.Size(625, 359);
            this.zedGraphKontrol2.TabIndex = 8;
            this.zedGraphKontrol2.Tur = ÇDTP.ZedGraph.VeriTuru.Single;
            this.zedGraphKontrol2.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 723);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çok Disiplinli Tasarım Projesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Seriport.ResumeLayout(false);
            this.groupBox_Daireler.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1_1;
        private System.Windows.Forms.CheckBox checkBox1_2;
        private System.Windows.Forms.CheckBox checkBox1_3;
        private System.Windows.Forms.CheckBox checkBox1_4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2_1;
        private System.Windows.Forms.CheckBox checkBox2_4;
        private System.Windows.Forms.CheckBox checkBox2_2;
        private System.Windows.Forms.CheckBox checkBox2_3;
        private System.IO.Ports.SerialPort Seriport;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button_SeriportAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1_ToplamGuc;
        private System.Windows.Forms.Label label2_ToplamGuc;
        private System.Windows.Forms.GroupBox groupBox_Seriport;
        private System.Windows.Forms.GroupBox groupBox_Daireler;
        private System.Windows.Forms.Button button_SeriportKapat;
        private System.Windows.Forms.TextBox textBox1_LimitGuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_LimitGuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1_Uygula;
        private System.Windows.Forms.Button button2_Uygula;
        private System.Windows.Forms.Button button_EnerjiTalebi;
        private System.Windows.Forms.Button button_EnerjiSatınAl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private ZedGraph.ZedGraphKontrol zedGraphKontrol1;
        private ZedGraph.ZedGraphKontrol zedGraphKontrol2;
    }
}

