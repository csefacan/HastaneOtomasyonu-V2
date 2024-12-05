namespace HastaneOtomasyonu
{
    partial class Duyuru
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
            this.duyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new HastaneOtomasyonu.HastaneDataSet();
            this.duyuruTableAdapter = new HastaneOtomasyonu.HastaneDataSetTableAdapters.DuyuruTableAdapter();
            this.duyuruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet1 = new HastaneOtomasyonu.HastaneDataSet1();
            this.duyuruBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.duyuruTableAdapter1 = new HastaneOtomasyonu.HastaneDataSet1TableAdapters.DuyuruTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duyuruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehiridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // duyuruBindingSource
            // 
            this.duyuruBindingSource.DataMember = "Duyuru";
            this.duyuruBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duyuruTableAdapter
            // 
            this.duyuruTableAdapter.ClearBeforeFill = true;
            // 
            // duyuruBindingSource1
            // 
            this.duyuruBindingSource1.DataMember = "Duyuru";
            this.duyuruBindingSource1.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet1";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duyuruBindingSource2
            // 
            this.duyuruBindingSource2.DataMember = "Duyuru";
            this.duyuruBindingSource2.DataSource = this.hastaneDataSet1;
            // 
            // duyuruTableAdapter1
            // 
            this.duyuruTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyuruidDataGridViewTextBoxColumn,
            this.duyuruDataGridViewTextBoxColumn,
            this.sehiridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.duyuruBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 616);
            this.dataGridView1.TabIndex = 2;
            // 
            // duyuruidDataGridViewTextBoxColumn
            // 
            this.duyuruidDataGridViewTextBoxColumn.DataPropertyName = "Duyuruid";
            this.duyuruidDataGridViewTextBoxColumn.HeaderText = "Duyuruid";
            this.duyuruidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duyuruidDataGridViewTextBoxColumn.Name = "duyuruidDataGridViewTextBoxColumn";
            this.duyuruidDataGridViewTextBoxColumn.ReadOnly = true;
            this.duyuruidDataGridViewTextBoxColumn.Width = 125;
            // 
            // duyuruDataGridViewTextBoxColumn
            // 
            this.duyuruDataGridViewTextBoxColumn.DataPropertyName = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.HeaderText = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duyuruDataGridViewTextBoxColumn.Name = "duyuruDataGridViewTextBoxColumn";
            this.duyuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehiridDataGridViewTextBoxColumn
            // 
            this.sehiridDataGridViewTextBoxColumn.DataPropertyName = "sehirid";
            this.sehiridDataGridViewTextBoxColumn.HeaderText = "sehirid";
            this.sehiridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehiridDataGridViewTextBoxColumn.Name = "sehiridDataGridViewTextBoxColumn";
            this.sehiridDataGridViewTextBoxColumn.Width = 125;
            // 
            // duyuruBindingSource3
            // 
            this.duyuruBindingSource3.DataMember = "Duyuru";
            this.duyuruBindingSource3.DataSource = this.hastaneDataSet1;
            // 
            // Duyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Duyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru";
            this.Load += new System.EventHandler(this.Duyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource duyuruBindingSource;
        private HastaneDataSetTableAdapters.DuyuruTableAdapter duyuruTableAdapter;
        private System.Windows.Forms.BindingSource duyuruBindingSource1;
        private HastaneDataSet1 hastaneDataSet1;
        private System.Windows.Forms.BindingSource duyuruBindingSource2;
        private HastaneDataSet1TableAdapters.DuyuruTableAdapter duyuruTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehiridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource duyuruBindingSource3;
    }
}