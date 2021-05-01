namespace Kurye_Otomasyonu
{
    partial class FrmKuryePaket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblKuryeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet8 = new Kurye_Otomasyonu.KuryeDataSet8();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tblPaketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet9 = new Kurye_Otomasyonu.KuryeDataSet9();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kuryePaketİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKuryePaketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet6 = new Kurye_Otomasyonu.KuryeDataSet6();
            this.tbl_KuryePaketTableAdapter = new Kurye_Otomasyonu.KuryeDataSet6TableAdapters.Tbl_KuryePaketTableAdapter();
            this.kuryeDataSet7 = new Kurye_Otomasyonu.KuryeDataSet7();
            this.tblKuryeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KuryeTableAdapter = new Kurye_Otomasyonu.KuryeDataSet7TableAdapters.Tbl_KuryeTableAdapter();
            this.tbl_KuryeTableAdapter1 = new Kurye_Otomasyonu.KuryeDataSet8TableAdapters.Tbl_KuryeTableAdapter();
            this.tbl_PaketTableAdapter = new Kurye_Otomasyonu.KuryeDataSet9TableAdapters.Tbl_PaketTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tblKuryeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kuryeDataSet10 = new Kurye_Otomasyonu.KuryeDataSet10();
            this.tbl_KuryeTableAdapter2 = new Kurye_Otomasyonu.KuryeDataSet10TableAdapters.Tbl_KuryeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryePaketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurye Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kurye Soyad :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tblKuryeBindingSource1
            // 
            this.tblKuryeBindingSource1.DataMember = "Tbl_Kurye";
            this.tblKuryeBindingSource1.DataSource = this.kuryeDataSet8;
            // 
            // kuryeDataSet8
            // 
            this.kuryeDataSet8.DataSetName = "KuryeDataSet8";
            this.kuryeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(158, 158);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tblPaketBindingSource
            // 
            this.tblPaketBindingSource.DataMember = "Tbl_Paket";
            this.tblPaketBindingSource.DataSource = this.kuryeDataSet9;
            // 
            // kuryeDataSet9
            // 
            this.kuryeDataSet9.DataSetName = "KuryeDataSet9";
            this.kuryeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paket No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kuryeİd :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kuryePaketİdDataGridViewTextBoxColumn,
            this.kuryeAdDataGridViewTextBoxColumn,
            this.kuryeSoyadDataGridViewTextBoxColumn,
            this.paketNoDataGridViewTextBoxColumn,
            this.kuryeİdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKuryePaketBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 92);
            this.dataGridView1.TabIndex = 0;
            // 
            // kuryePaketİdDataGridViewTextBoxColumn
            // 
            this.kuryePaketİdDataGridViewTextBoxColumn.DataPropertyName = "KuryePaketİd";
            this.kuryePaketİdDataGridViewTextBoxColumn.HeaderText = "KuryePaketİd";
            this.kuryePaketİdDataGridViewTextBoxColumn.Name = "kuryePaketİdDataGridViewTextBoxColumn";
            this.kuryePaketİdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // paketNoDataGridViewTextBoxColumn
            // 
            this.paketNoDataGridViewTextBoxColumn.DataPropertyName = "PaketNo";
            this.paketNoDataGridViewTextBoxColumn.HeaderText = "PaketNo";
            this.paketNoDataGridViewTextBoxColumn.Name = "paketNoDataGridViewTextBoxColumn";
            // 
            // kuryeİdDataGridViewTextBoxColumn
            // 
            this.kuryeİdDataGridViewTextBoxColumn.DataPropertyName = "Kuryeİd";
            this.kuryeİdDataGridViewTextBoxColumn.HeaderText = "Kuryeİd";
            this.kuryeİdDataGridViewTextBoxColumn.Name = "kuryeİdDataGridViewTextBoxColumn";
            // 
            // tblKuryePaketBindingSource
            // 
            this.tblKuryePaketBindingSource.DataMember = "Tbl_KuryePaket";
            this.tblKuryePaketBindingSource.DataSource = this.kuryeDataSet6;
            // 
            // kuryeDataSet6
            // 
            this.kuryeDataSet6.DataSetName = "KuryeDataSet6";
            this.kuryeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KuryePaketTableAdapter
            // 
            this.tbl_KuryePaketTableAdapter.ClearBeforeFill = true;
            // 
            // kuryeDataSet7
            // 
            this.kuryeDataSet7.DataSetName = "KuryeDataSet7";
            this.kuryeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKuryeBindingSource
            // 
            this.tblKuryeBindingSource.DataMember = "Tbl_Kurye";
            this.tblKuryeBindingSource.DataSource = this.kuryeDataSet7;
            // 
            // tbl_KuryeTableAdapter
            // 
            this.tbl_KuryeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_KuryeTableAdapter1
            // 
            this.tbl_KuryeTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_PaketTableAdapter
            // 
            this.tbl_PaketTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(158, 229);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // tblKuryeBindingSource2
            // 
            this.tblKuryeBindingSource2.DataMember = "Tbl_Kurye";
            this.tblKuryeBindingSource2.DataSource = this.kuryeDataSet10;
            // 
            // kuryeDataSet10
            // 
            this.kuryeDataSet10.DataSetName = "KuryeDataSet10";
            this.kuryeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KuryeTableAdapter2
            // 
            this.tbl_KuryeTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmKuryePaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKuryePaket";
            this.Text = "FrmKuryePaket";
            this.Load += new System.EventHandler(this.FrmKuryePaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryePaketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKuryeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryeDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KuryeDataSet6 kuryeDataSet6;
        private System.Windows.Forms.BindingSource tblKuryePaketBindingSource;
        private KuryeDataSet6TableAdapters.Tbl_KuryePaketTableAdapter tbl_KuryePaketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryePaketİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeİdDataGridViewTextBoxColumn;
        private KuryeDataSet7 kuryeDataSet7;
        private System.Windows.Forms.BindingSource tblKuryeBindingSource;
        private KuryeDataSet7TableAdapters.Tbl_KuryeTableAdapter tbl_KuryeTableAdapter;
        private KuryeDataSet8 kuryeDataSet8;
        private System.Windows.Forms.BindingSource tblKuryeBindingSource1;
        private KuryeDataSet8TableAdapters.Tbl_KuryeTableAdapter tbl_KuryeTableAdapter1;
        private KuryeDataSet9 kuryeDataSet9;
        private System.Windows.Forms.BindingSource tblPaketBindingSource;
        private KuryeDataSet9TableAdapters.Tbl_PaketTableAdapter tbl_PaketTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private KuryeDataSet10 kuryeDataSet10;
        private System.Windows.Forms.BindingSource tblKuryeBindingSource2;
        private KuryeDataSet10TableAdapters.Tbl_KuryeTableAdapter tbl_KuryeTableAdapter2;
    }
}