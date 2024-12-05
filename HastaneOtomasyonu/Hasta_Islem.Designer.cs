namespace HastaneOtomasyonu
{
    partial class Hasta_Islem
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
            this.button4 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuİlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuKlinikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new HastaneOtomasyonu.HastaneDataSet();
            this.randevuTableAdapter = new HastaneOtomasyonu.HastaneDataSetTableAdapters.RandevuTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button4.Location = new System.Drawing.Point(223, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(104, 290);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(104, 219);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(345, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(345, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label10.Location = new System.Drawing.Point(17, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label7.Location = new System.Drawing.Point(17, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label8.Location = new System.Drawing.Point(17, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Klinik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label9.Location = new System.Drawing.Point(17, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Hastane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label11.Location = new System.Drawing.Point(17, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "İl";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button3.Location = new System.Drawing.Point(52, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "Bilgileri Değiştir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(223, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button1.Location = new System.Drawing.Point(52, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 120);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Bilgi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.Location = new System.Drawing.Point(99, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label3.Location = new System.Drawing.Point(99, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label6.Location = new System.Drawing.Point(99, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "SOYİSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(486, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 436);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevularım";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.randevuİlDataGridViewTextBoxColumn,
            this.randevuKlinikDataGridViewTextBoxColumn,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.randevuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(803, 409);
            this.dataGridView2.TabIndex = 0;
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuidDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuİlDataGridViewTextBoxColumn
            // 
            this.randevuİlDataGridViewTextBoxColumn.DataPropertyName = "Randevuİl";
            this.randevuİlDataGridViewTextBoxColumn.HeaderText = "Randevuİl";
            this.randevuİlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuİlDataGridViewTextBoxColumn.Name = "randevuİlDataGridViewTextBoxColumn";
            this.randevuİlDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuKlinikDataGridViewTextBoxColumn
            // 
            this.randevuKlinikDataGridViewTextBoxColumn.DataPropertyName = "RandevuKlinik";
            this.randevuKlinikDataGridViewTextBoxColumn.HeaderText = "RandevuKlinik";
            this.randevuKlinikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuKlinikDataGridViewTextBoxColumn.Name = "randevuKlinikDataGridViewTextBoxColumn";
            this.randevuKlinikDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            this.randevuTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            this.hastaTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataMember = "Randevu";
            this.randevuBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuTableAdapter
            // 
            this.randevuTableAdapter.ClearBeforeFill = true;
            // 
            // Hasta_Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1321, 515);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hasta_Islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta_Islem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hasta_Islem_FormClosed);
            this.Load += new System.EventHandler(this.Hasta_Islem_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private HastaneDataSetTableAdapters.RandevuTableAdapter randevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuİlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuKlinikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
    }
}