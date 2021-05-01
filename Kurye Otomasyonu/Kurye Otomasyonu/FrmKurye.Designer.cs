namespace Kurye_Otomasyonu
{
    partial class FrmKurye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKurye));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKuryeSehir = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtKuryeMaas = new System.Windows.Forms.TextBox();
            this.txtKuryeSoyad = new System.Windows.Forms.TextBox();
            this.txtKuryeAd = new System.Windows.Forms.TextBox();
            this.txtKuryeİd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tblKuryeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet1 = new Kurye_Otomasyonu.KuryeDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.tbl_KuryeTableAdapter = new Kurye_Otomasyonu.KuryeDataSet1TableAdapters.Tbl_KuryeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kuryeDataSet4 = new Kurye_Otomasyonu.KuryeDataSet4();
            this.tblKuryeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KuryeTableAdapter1 = new Kurye_Otomasyonu.KuryeDataSet4TableAdapters.Tbl_KuryeTableAdapter();
            this.kuryeİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKuryeSehir);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtKuryeMaas);
            this.groupBox1.Controls.Add(this.txtKuryeSoyad);
            this.groupBox1.Controls.Add(this.txtKuryeAd);
            this.groupBox1.Controls.Add(this.txtKuryeİd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurye Sistemi";
            // 
            // cmbKuryeSehir
            // 
            this.cmbKuryeSehir.FormattingEnabled = true;
            this.cmbKuryeSehir.Location = new System.Drawing.Point(137, 173);
            this.cmbKuryeSehir.Name = "cmbKuryeSehir";
            this.cmbKuryeSehir.Size = new System.Drawing.Size(100, 21);
            this.cmbKuryeSehir.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(198, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 265);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtKuryeMaas
            // 
            this.txtKuryeMaas.Location = new System.Drawing.Point(137, 219);
            this.txtKuryeMaas.Name = "txtKuryeMaas";
            this.txtKuryeMaas.Size = new System.Drawing.Size(100, 20);
            this.txtKuryeMaas.TabIndex = 5;
            // 
            // txtKuryeSoyad
            // 
            this.txtKuryeSoyad.Location = new System.Drawing.Point(137, 127);
            this.txtKuryeSoyad.Name = "txtKuryeSoyad";
            this.txtKuryeSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtKuryeSoyad.TabIndex = 3;
            // 
            // txtKuryeAd
            // 
            this.txtKuryeAd.Location = new System.Drawing.Point(137, 81);
            this.txtKuryeAd.Name = "txtKuryeAd";
            this.txtKuryeAd.Size = new System.Drawing.Size(100, 20);
            this.txtKuryeAd.TabIndex = 2;
            // 
            // txtKuryeİd
            // 
            this.txtKuryeİd.Location = new System.Drawing.Point(137, 35);
            this.txtKuryeİd.Name = "txtKuryeİd";
            this.txtKuryeİd.Size = new System.Drawing.Size(100, 20);
            this.txtKuryeİd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "KuryeDurum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KuryeMaas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KuryeSehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KuryeSoyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KuryeAd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kuryeİd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(324, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İslemler";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(23, 162);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(107, 27);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(23, 116);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 26);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(23, 70);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 26);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(23, 24);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(107, 26);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(0, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(961, 193);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayitlar";
            // 
            // tblKuryeBindingSource
            // 
            this.tblKuryeBindingSource.DataMember = "Tbl_Kurye";
            this.tblKuryeBindingSource.DataSource = this.kuryeDataSet1;
            // 
            // kuryeDataSet1
            // 
            this.kuryeDataSet1.DataSetName = "KuryeDataSet1";
            this.kuryeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.TextChanged += new System.EventHandler(this.label7_TextChanged);
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbl_KuryeTableAdapter
            // 
            this.tbl_KuryeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Paket ->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kuryeİdDataGridViewTextBoxColumn,
            this.kuryeAdDataGridViewTextBoxColumn,
            this.kuryeSoyadDataGridViewTextBoxColumn,
            this.kuryeSehirDataGridViewTextBoxColumn,
            this.kuryeMaasDataGridViewTextBoxColumn,
            this.kuryeDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblKuryeBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kuryeDataSet4
            // 
            this.kuryeDataSet4.DataSetName = "KuryeDataSet4";
            this.kuryeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKuryeBindingSource1
            // 
            this.tblKuryeBindingSource1.DataMember = "Tbl_Kurye";
            this.tblKuryeBindingSource1.DataSource = this.kuryeDataSet4;
            // 
            // tbl_KuryeTableAdapter1
            // 
            this.tbl_KuryeTableAdapter1.ClearBeforeFill = true;
            // 
            // kuryeİdDataGridViewTextBoxColumn
            // 
            this.kuryeİdDataGridViewTextBoxColumn.DataPropertyName = "Kuryeİd";
            this.kuryeİdDataGridViewTextBoxColumn.HeaderText = "Kuryeİd";
            this.kuryeİdDataGridViewTextBoxColumn.Name = "kuryeİdDataGridViewTextBoxColumn";
            this.kuryeİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuryeAdDataGridViewTextBoxColumn
            // 
            this.kuryeAdDataGridViewTextBoxColumn.DataPropertyName = "KuryeAd";
            this.kuryeAdDataGridViewTextBoxColumn.HeaderText = "KuryeAd";
            this.kuryeAdDataGridViewTextBoxColumn.Name = "kuryeAdDataGridViewTextBoxColumn";
            // 
            // kuryeSoyadDataGridViewTextBoxColumn
            // 
            this.kuryeSoyadDataGridViewTextBoxColumn.DataPropertyName = "KuryeSoyad";
            this.kuryeSoyadDataGridViewTextBoxColumn.HeaderText = "KuryeSoyad";
            this.kuryeSoyadDataGridViewTextBoxColumn.Name = "kuryeSoyadDataGridViewTextBoxColumn";
            // 
            // kuryeSehirDataGridViewTextBoxColumn
            // 
            this.kuryeSehirDataGridViewTextBoxColumn.DataPropertyName = "KuryeSehir";
            this.kuryeSehirDataGridViewTextBoxColumn.HeaderText = "KuryeSehir";
            this.kuryeSehirDataGridViewTextBoxColumn.Name = "kuryeSehirDataGridViewTextBoxColumn";
            // 
            // kuryeMaasDataGridViewTextBoxColumn
            // 
            this.kuryeMaasDataGridViewTextBoxColumn.DataPropertyName = "KuryeMaas";
            this.kuryeMaasDataGridViewTextBoxColumn.HeaderText = "KuryeMaas";
            this.kuryeMaasDataGridViewTextBoxColumn.Name = "kuryeMaasDataGridViewTextBoxColumn";
            // 
            // kuryeDurumDataGridViewCheckBoxColumn
            // 
            this.kuryeDurumDataGridViewCheckBoxColumn.DataPropertyName = "KuryeDurum";
            this.kuryeDurumDataGridViewCheckBoxColumn.HeaderText = "KuryeDurum";
            this.kuryeDurumDataGridViewCheckBoxColumn.Name = "kuryeDurumDataGridViewCheckBoxColumn";
            // 
            // FrmKurye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(959, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmKurye";
            this.Text = "FrmKurye";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtKuryeMaas;
        private System.Windows.Forms.TextBox txtKuryeSoyad;
        private System.Windows.Forms.TextBox txtKuryeAd;
        private System.Windows.Forms.TextBox txtKuryeİd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private KuryeDataSet1 kuryeDataSet1;
        private System.Windows.Forms.BindingSource tblKuryeBindingSource;
        private KuryeDataSet1TableAdapters.Tbl_KuryeTableAdapter tbl_KuryeTableAdapter;
        private System.Windows.Forms.ComboBox cmbKuryeSehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KuryeDataSet4 kuryeDataSet4;
        private System.Windows.Forms.BindingSource tblKuryeBindingSource1;
        private KuryeDataSet4TableAdapters.Tbl_KuryeTableAdapter tbl_KuryeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kuryeDurumDataGridViewCheckBoxColumn;
    }
}

