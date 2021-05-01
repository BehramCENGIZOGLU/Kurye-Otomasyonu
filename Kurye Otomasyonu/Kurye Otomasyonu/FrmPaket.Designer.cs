namespace Kurye_Otomasyonu
{
    partial class FrmPaket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaketTeslimatyeri = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtPaketAğırlığı = new System.Windows.Forms.TextBox();
            this.txtPaketBoyutu = new System.Windows.Forms.TextBox();
            this.txtPaketTürü = new System.Windows.Forms.TextBox();
            this.txtPaketİd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paketİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketBoyutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketTeslimatyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketAğırlığıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketKırılabilirDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblPaketBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet5 = new Kurye_Otomasyonu.KuryeDataSet5();
            this.tblPaketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet3 = new Kurye_Otomasyonu.KuryeDataSet3();
            this.tblPaketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paketDataSet = new Kurye_Otomasyonu.PaketDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PaketTableAdapter = new Kurye_Otomasyonu.PaketDataSetTableAdapters.Tbl_PaketTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kuryeDataSet2 = new Kurye_Otomasyonu.KuryeDataSet2();
            this.tblPaketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PaketTableAdapter1 = new Kurye_Otomasyonu.KuryeDataSet2TableAdapters.Tbl_PaketTableAdapter();
            this.tbl_PaketTableAdapter2 = new Kurye_Otomasyonu.KuryeDataSet3TableAdapters.Tbl_PaketTableAdapter();
            this.tbl_PaketTableAdapter3 = new Kurye_Otomasyonu.KuryeDataSet5TableAdapters.Tbl_PaketTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaketTeslimatyeri);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtPaketAğırlığı);
            this.groupBox1.Controls.Add(this.txtPaketBoyutu);
            this.groupBox1.Controls.Add(this.txtPaketTürü);
            this.groupBox1.Controls.Add(this.txtPaketİd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PaketKayıt";
            // 
            // txtPaketTeslimatyeri
            // 
            this.txtPaketTeslimatyeri.Location = new System.Drawing.Point(187, 168);
            this.txtPaketTeslimatyeri.Name = "txtPaketTeslimatyeri";
            this.txtPaketTeslimatyeri.Size = new System.Drawing.Size(100, 26);
            this.txtPaketTeslimatyeri.TabIndex = 8;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(236, 270);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hayır";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PaketTeslimatyeri :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(167, 270);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evet";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPaketAğırlığı
            // 
            this.txtPaketAğırlığı.Location = new System.Drawing.Point(187, 215);
            this.txtPaketAğırlığı.Name = "txtPaketAğırlığı";
            this.txtPaketAğırlığı.Size = new System.Drawing.Size(100, 26);
            this.txtPaketAğırlığı.TabIndex = 4;
            // 
            // txtPaketBoyutu
            // 
            this.txtPaketBoyutu.Location = new System.Drawing.Point(187, 121);
            this.txtPaketBoyutu.Name = "txtPaketBoyutu";
            this.txtPaketBoyutu.Size = new System.Drawing.Size(100, 26);
            this.txtPaketBoyutu.TabIndex = 3;
            // 
            // txtPaketTürü
            // 
            this.txtPaketTürü.Location = new System.Drawing.Point(187, 74);
            this.txtPaketTürü.Name = "txtPaketTürü";
            this.txtPaketTürü.Size = new System.Drawing.Size(100, 26);
            this.txtPaketTürü.TabIndex = 2;
            // 
            // txtPaketİd
            // 
            this.txtPaketİd.Location = new System.Drawing.Point(187, 27);
            this.txtPaketİd.Name = "txtPaketİd";
            this.txtPaketİd.Size = new System.Drawing.Size(100, 26);
            this.txtPaketİd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "PaketKırılabilir :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "PaketAğırlığı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PaketBoyutu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PaketTürü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paketİd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(408, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İslemler";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(46, 208);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 32);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(46, 154);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(91, 32);
            this.BtnGüncelle.TabIndex = 10;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(46, 100);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 32);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(46, 54);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(91, 32);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(2, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(930, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayitlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paketİdDataGridViewTextBoxColumn,
            this.paketTürüDataGridViewTextBoxColumn,
            this.paketBoyutuDataGridViewTextBoxColumn,
            this.paketTeslimatyeriDataGridViewTextBoxColumn,
            this.paketAğırlığıDataGridViewTextBoxColumn,
            this.paketKırılabilirDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblPaketBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // paketİdDataGridViewTextBoxColumn
            // 
            this.paketİdDataGridViewTextBoxColumn.DataPropertyName = "Paketİd";
            this.paketİdDataGridViewTextBoxColumn.HeaderText = "Paketİd";
            this.paketİdDataGridViewTextBoxColumn.Name = "paketİdDataGridViewTextBoxColumn";
            this.paketİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paketTürüDataGridViewTextBoxColumn
            // 
            this.paketTürüDataGridViewTextBoxColumn.DataPropertyName = "PaketTürü";
            this.paketTürüDataGridViewTextBoxColumn.HeaderText = "PaketTürü";
            this.paketTürüDataGridViewTextBoxColumn.Name = "paketTürüDataGridViewTextBoxColumn";
            // 
            // paketBoyutuDataGridViewTextBoxColumn
            // 
            this.paketBoyutuDataGridViewTextBoxColumn.DataPropertyName = "PaketBoyutu";
            this.paketBoyutuDataGridViewTextBoxColumn.HeaderText = "PaketBoyutu";
            this.paketBoyutuDataGridViewTextBoxColumn.Name = "paketBoyutuDataGridViewTextBoxColumn";
            // 
            // paketTeslimatyeriDataGridViewTextBoxColumn
            // 
            this.paketTeslimatyeriDataGridViewTextBoxColumn.DataPropertyName = "PaketTeslimatyeri";
            this.paketTeslimatyeriDataGridViewTextBoxColumn.HeaderText = "PaketTeslimatyeri";
            this.paketTeslimatyeriDataGridViewTextBoxColumn.Name = "paketTeslimatyeriDataGridViewTextBoxColumn";
            // 
            // paketAğırlığıDataGridViewTextBoxColumn
            // 
            this.paketAğırlığıDataGridViewTextBoxColumn.DataPropertyName = "PaketAğırlığı";
            this.paketAğırlığıDataGridViewTextBoxColumn.HeaderText = "PaketAğırlığı";
            this.paketAğırlığıDataGridViewTextBoxColumn.Name = "paketAğırlığıDataGridViewTextBoxColumn";
            // 
            // paketKırılabilirDataGridViewCheckBoxColumn
            // 
            this.paketKırılabilirDataGridViewCheckBoxColumn.DataPropertyName = "PaketKırılabilir";
            this.paketKırılabilirDataGridViewCheckBoxColumn.HeaderText = "PaketKırılabilir";
            this.paketKırılabilirDataGridViewCheckBoxColumn.Name = "paketKırılabilirDataGridViewCheckBoxColumn";
            // 
            // tblPaketBindingSource3
            // 
            this.tblPaketBindingSource3.DataMember = "Tbl_Paket";
            this.tblPaketBindingSource3.DataSource = this.kuryeDataSet5;
            // 
            // kuryeDataSet5
            // 
            this.kuryeDataSet5.DataSetName = "KuryeDataSet5";
            this.kuryeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaketBindingSource2
            // 
            this.tblPaketBindingSource2.DataMember = "Tbl_Paket";
            this.tblPaketBindingSource2.DataSource = this.kuryeDataSet3;
            // 
            // kuryeDataSet3
            // 
            this.kuryeDataSet3.DataSetName = "KuryeDataSet3";
            this.kuryeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaketBindingSource
            // 
            this.tblPaketBindingSource.DataMember = "Tbl_Paket";
            this.tblPaketBindingSource.DataSource = this.paketDataSet;
            // 
            // paketDataSet
            // 
            this.paketDataSet.DataSetName = "PaketDataSet";
            this.paketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PaketTableAdapter
            // 
            this.tbl_PaketTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            this.label6.TextChanged += new System.EventHandler(this.label6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<- Kurye";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kuryeDataSet2
            // 
            this.kuryeDataSet2.DataSetName = "KuryeDataSet2";
            this.kuryeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaketBindingSource1
            // 
            this.tblPaketBindingSource1.DataMember = "Tbl_Paket";
            this.tblPaketBindingSource1.DataSource = this.kuryeDataSet2;
            // 
            // tbl_PaketTableAdapter1
            // 
            this.tbl_PaketTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_PaketTableAdapter2
            // 
            this.tbl_PaketTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_PaketTableAdapter3
            // 
            this.tbl_PaketTableAdapter3.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kurye_Paket ->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPaket";
            this.Text = "FrmPaket";
            this.Load += new System.EventHandler(this.FrmPaket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtPaketAğırlığı;
        private System.Windows.Forms.TextBox txtPaketBoyutu;
        private System.Windows.Forms.TextBox txtPaketTürü;
        private System.Windows.Forms.TextBox txtPaketİd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PaketDataSet paketDataSet;
        private System.Windows.Forms.BindingSource tblPaketBindingSource;
        private PaketDataSetTableAdapters.Tbl_PaketTableAdapter tbl_PaketTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private KuryeDataSet2 kuryeDataSet2;
        private System.Windows.Forms.BindingSource tblPaketBindingSource1;
        private KuryeDataSet2TableAdapters.Tbl_PaketTableAdapter tbl_PaketTableAdapter1;
        private KuryeDataSet3 kuryeDataSet3;
        private System.Windows.Forms.BindingSource tblPaketBindingSource2;
        private KuryeDataSet3TableAdapters.Tbl_PaketTableAdapter tbl_PaketTableAdapter2;
        private System.Windows.Forms.TextBox txtPaketTeslimatyeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KuryeDataSet5 kuryeDataSet5;
        private System.Windows.Forms.BindingSource tblPaketBindingSource3;
        private KuryeDataSet5TableAdapters.Tbl_PaketTableAdapter tbl_PaketTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketBoyutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketTeslimatyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketAğırlığıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paketKırılabilirDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}