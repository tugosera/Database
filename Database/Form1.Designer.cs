namespace Database
{
    partial class Form1
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
            this.Nimetus = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_DataSet = new Database.Database_DataSet();
            this.toodedTableAdapter = new Database.Database_DataSetTableAdapters.ToodedTableAdapter();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toodedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otsipilt_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kustuta_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            // 
            // Nimetus
            // 
            this.Nimetus.Location = new System.Drawing.Point(80, 93);
            this.Nimetus.Name = "Nimetus";
            this.Nimetus.Size = new System.Drawing.Size(105, 20);
            this.Nimetus.TabIndex = 1;
            this.Nimetus.TextChanged += new System.EventHandler(this.Nimetus_txt_TextChanged);
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(80, 139);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(105, 20);
            this.Kogus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus";
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(80, 181);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(105, 20);
            this.Hind.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hind";
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(68, 218);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(141, 35);
            this.lisa_btn.TabIndex = 7;
            this.lisa_btn.Text = "lisa button";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // toodedBindingSource
            // 
            this.toodedBindingSource.DataMember = "Tooded";
            this.toodedBindingSource.DataSource = this.database_DataSet;
            // 
            // database_DataSet
            // 
            this.database_DataSet.DataSetName = "Database_DataSet";
            this.database_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodedTableAdapter
            // 
            this.toodedTableAdapter.ClearBeforeFill = true;
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Location = new System.Drawing.Point(215, 218);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(141, 35);
            this.uuenda_btn.TabIndex = 9;
            this.uuenda_btn.Text = "Uuenda button";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            this.uuenda_btn.Click += new System.EventHandler(this.uuenda_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodedBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(68, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 170);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // toodedBindingSource2
            // 
            this.toodedBindingSource2.DataMember = "Tooded";
            this.toodedBindingSource2.DataSource = this.database_DataSet;
            // 
            // toodedBindingSource1
            // 
            this.toodedBindingSource1.DataMember = "Tooded";
            this.toodedBindingSource1.DataSource = this.database_DataSet;
            // 
            // otsipilt_btn
            // 
            this.otsipilt_btn.Location = new System.Drawing.Point(508, 218);
            this.otsipilt_btn.Name = "otsipilt_btn";
            this.otsipilt_btn.Size = new System.Drawing.Size(141, 35);
            this.otsipilt_btn.TabIndex = 11;
            this.otsipilt_btn.Text = "Lisa pilt";
            this.otsipilt_btn.UseVisualStyleBackColor = true;
            this.otsipilt_btn.Click += new System.EventHandler(this.otsipilt_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 108);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Location = new System.Drawing.Point(361, 218);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(141, 35);
            this.kustuta_btn.TabIndex = 13;
            this.kustuta_btn.Text = "kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otsipilt_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nimetus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nimetus;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lisa_btn;
        private Database_DataSet database_DataSet;
        private System.Windows.Forms.BindingSource toodedBindingSource;
        private Database_DataSetTableAdapters.ToodedTableAdapter toodedTableAdapter;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button otsipilt_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toodedBindingSource1;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.BindingSource toodedBindingSource2;
    }
}

