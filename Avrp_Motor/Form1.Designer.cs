namespace Avrp_Motor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btngunc = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avrupa_MotorDataSet = new Avrp_Motor.Avrupa_MotorDataSet();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.servisTableAdapter = new Avrp_Motor.Avrupa_MotorDataSetTableAdapters.ServisTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.avrupa_MotorDataSet1 = new Avrp_Motor.Avrupa_MotorDataSet1();
            this.servisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servisTableAdapter1 = new Avrp_Motor.Avrupa_MotorDataSet1TableAdapters.ServisTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracSahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islem8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncellemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrupa_MotorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrupa_MotorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(9, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1273, 611);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Avrp_Motor.Properties.Resources.avrp;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(472, 352);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(264, 34);
            this.textBox14.TabIndex = 40;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(472, 310);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(264, 34);
            this.textBox13.TabIndex = 39;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(472, 270);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(264, 34);
            this.textBox12.TabIndex = 38;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(471, 230);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(264, 34);
            this.textBox11.TabIndex = 37;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(472, 190);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(264, 34);
            this.textBox10.TabIndex = 36;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(471, 150);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(264, 34);
            this.textBox9.TabIndex = 35;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(471, 110);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(264, 34);
            this.textBox8.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(471, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(264, 34);
            this.textBox7.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1099, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(670, 423);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 34);
            this.textBox5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "FİYAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "YAPILANLAR LİSTESİ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 34);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 34);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 34);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 34);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "ARAÇ PLAKA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "ARAÇ SAHİBİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "ARAÇ MODEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞASE NO:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Avrp_Motor.Properties.Resources.avrp;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btngunc);
            this.tabPage2.Controls.Add(this.btnsil);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Listesi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btngunc
            // 
            this.btngunc.Location = new System.Drawing.Point(1008, 166);
            this.btngunc.Name = "btngunc";
            this.btngunc.Size = new System.Drawing.Size(173, 43);
            this.btngunc.TabIndex = 4;
            this.btngunc.Text = "GÜNCELLE";
            this.btngunc.UseVisualStyleBackColor = true;
            this.btngunc.Click += new System.EventHandler(this.btngunc_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1034, 117);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(121, 43);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "Servis";
            this.servisBindingSource.DataSource = this.avrupa_MotorDataSet;
            // 
            // avrupa_MotorDataSet
            // 
            this.avrupa_MotorDataSet.DataSetName = "Avrupa_MotorDataSet";
            this.avrupa_MotorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(44, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(316, 30);
            this.textBox6.TabIndex = 1;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "AVRUPA MOTOR MÜŞTERİ BİLGİ";
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.saseNoDataGridViewTextBoxColumn,
            this.aracModelDataGridViewTextBoxColumn,
            this.aracSahibiDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.islem1DataGridViewTextBoxColumn,
            this.islem2DataGridViewTextBoxColumn,
            this.islem3DataGridViewTextBoxColumn,
            this.islem4DataGridViewTextBoxColumn,
            this.islem5DataGridViewTextBoxColumn,
            this.islem6DataGridViewTextBoxColumn,
            this.islem7DataGridViewTextBoxColumn,
            this.islem8DataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.guncellemeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(44, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(849, 487);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_2);
            // 
            // avrupa_MotorDataSet1
            // 
            this.avrupa_MotorDataSet1.DataSetName = "Avrupa_MotorDataSet1";
            this.avrupa_MotorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisBindingSource1
            // 
            this.servisBindingSource1.DataMember = "Servis";
            this.servisBindingSource1.DataSource = this.avrupa_MotorDataSet1;
            // 
            // servisTableAdapter1
            // 
            this.servisTableAdapter1.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // saseNoDataGridViewTextBoxColumn
            // 
            this.saseNoDataGridViewTextBoxColumn.DataPropertyName = "Sase_No";
            this.saseNoDataGridViewTextBoxColumn.HeaderText = "Sase_No";
            this.saseNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saseNoDataGridViewTextBoxColumn.Name = "saseNoDataGridViewTextBoxColumn";
            this.saseNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // aracModelDataGridViewTextBoxColumn
            // 
            this.aracModelDataGridViewTextBoxColumn.DataPropertyName = "Arac_Model";
            this.aracModelDataGridViewTextBoxColumn.HeaderText = "Arac_Model";
            this.aracModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracModelDataGridViewTextBoxColumn.Name = "aracModelDataGridViewTextBoxColumn";
            this.aracModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // aracSahibiDataGridViewTextBoxColumn
            // 
            this.aracSahibiDataGridViewTextBoxColumn.DataPropertyName = "Arac_Sahibi";
            this.aracSahibiDataGridViewTextBoxColumn.HeaderText = "Arac_Sahibi";
            this.aracSahibiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracSahibiDataGridViewTextBoxColumn.Name = "aracSahibiDataGridViewTextBoxColumn";
            this.aracSahibiDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // islem1DataGridViewTextBoxColumn
            // 
            this.islem1DataGridViewTextBoxColumn.DataPropertyName = "islem1";
            this.islem1DataGridViewTextBoxColumn.HeaderText = "islem1";
            this.islem1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem1DataGridViewTextBoxColumn.Name = "islem1DataGridViewTextBoxColumn";
            this.islem1DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem2DataGridViewTextBoxColumn
            // 
            this.islem2DataGridViewTextBoxColumn.DataPropertyName = "islem2";
            this.islem2DataGridViewTextBoxColumn.HeaderText = "islem2";
            this.islem2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem2DataGridViewTextBoxColumn.Name = "islem2DataGridViewTextBoxColumn";
            this.islem2DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem3DataGridViewTextBoxColumn
            // 
            this.islem3DataGridViewTextBoxColumn.DataPropertyName = "islem3";
            this.islem3DataGridViewTextBoxColumn.HeaderText = "islem3";
            this.islem3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem3DataGridViewTextBoxColumn.Name = "islem3DataGridViewTextBoxColumn";
            this.islem3DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem4DataGridViewTextBoxColumn
            // 
            this.islem4DataGridViewTextBoxColumn.DataPropertyName = "islem4";
            this.islem4DataGridViewTextBoxColumn.HeaderText = "islem4";
            this.islem4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem4DataGridViewTextBoxColumn.Name = "islem4DataGridViewTextBoxColumn";
            this.islem4DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem5DataGridViewTextBoxColumn
            // 
            this.islem5DataGridViewTextBoxColumn.DataPropertyName = "islem5";
            this.islem5DataGridViewTextBoxColumn.HeaderText = "islem5";
            this.islem5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem5DataGridViewTextBoxColumn.Name = "islem5DataGridViewTextBoxColumn";
            this.islem5DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem6DataGridViewTextBoxColumn
            // 
            this.islem6DataGridViewTextBoxColumn.DataPropertyName = "islem6";
            this.islem6DataGridViewTextBoxColumn.HeaderText = "islem6";
            this.islem6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem6DataGridViewTextBoxColumn.Name = "islem6DataGridViewTextBoxColumn";
            this.islem6DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem7DataGridViewTextBoxColumn
            // 
            this.islem7DataGridViewTextBoxColumn.DataPropertyName = "islem7";
            this.islem7DataGridViewTextBoxColumn.HeaderText = "islem7";
            this.islem7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem7DataGridViewTextBoxColumn.Name = "islem7DataGridViewTextBoxColumn";
            this.islem7DataGridViewTextBoxColumn.Width = 125;
            // 
            // islem8DataGridViewTextBoxColumn
            // 
            this.islem8DataGridViewTextBoxColumn.DataPropertyName = "islem8";
            this.islem8DataGridViewTextBoxColumn.HeaderText = "islem8";
            this.islem8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islem8DataGridViewTextBoxColumn.Name = "islem8DataGridViewTextBoxColumn";
            this.islem8DataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // guncellemeTarihiDataGridViewTextBoxColumn
            // 
            this.guncellemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "GuncellemeTarihi";
            this.guncellemeTarihiDataGridViewTextBoxColumn.HeaderText = "GuncellemeTarihi";
            this.guncellemeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guncellemeTarihiDataGridViewTextBoxColumn.Name = "guncellemeTarihiDataGridViewTextBoxColumn";
            this.guncellemeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(381, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 25);
            this.label14.TabIndex = 76;
            this.label14.Text = "İşlem 8 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(381, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 75;
            this.label13.Text = "İşlem 7 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(381, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 74;
            this.label12.Text = "İşlem 6 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(381, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 73;
            this.label11.Text = "İşlem 5 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(381, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 72;
            this.label10.Text = "İşlem 4 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(380, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "İşlem 3 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(380, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 70;
            this.label8.Text = "İşlem 2 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(380, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 69;
            this.label15.Text = "İşlem 1 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 683);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVRUPA MOTOR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrupa_MotorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrupa_MotorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private Avrupa_MotorDataSet avrupa_MotorDataSet;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private Avrupa_MotorDataSetTableAdapters.ServisTableAdapter servisTableAdapter;
        private System.Windows.Forms.Button btngunc;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Avrupa_MotorDataSet1 avrupa_MotorDataSet1;
        private System.Windows.Forms.BindingSource servisBindingSource1;
        private Avrupa_MotorDataSet1TableAdapters.ServisTableAdapter servisTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracSahibiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islem8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guncellemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
    }
}

