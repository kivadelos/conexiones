namespace Vistas
{
    partial class TablaMySQL
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
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.btnEditM = new System.Windows.Forms.Button();
            this.btnSaveM = new System.Windows.Forms.Button();
            this.btnNewM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblUnidad = new System.Windows.Forms.Label();
            this.LblCant = new System.Windows.Forms.Label();
            this.LblBarcode = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(419, 41);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteM.TabIndex = 8;
            this.btnDeleteM.Text = "DELETE";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            // 
            // btnEditM
            // 
            this.btnEditM.Location = new System.Drawing.Point(278, 41);
            this.btnEditM.Name = "btnEditM";
            this.btnEditM.Size = new System.Drawing.Size(75, 23);
            this.btnEditM.TabIndex = 7;
            this.btnEditM.Text = "EDIT";
            this.btnEditM.UseVisualStyleBackColor = true;
            // 
            // btnSaveM
            // 
            this.btnSaveM.Location = new System.Drawing.Point(141, 41);
            this.btnSaveM.Name = "btnSaveM";
            this.btnSaveM.Size = new System.Drawing.Size(75, 23);
            this.btnSaveM.TabIndex = 6;
            this.btnSaveM.Text = "SAVE";
            this.btnSaveM.UseVisualStyleBackColor = true;
            // 
            // btnNewM
            // 
            this.btnNewM.Location = new System.Drawing.Point(6, 41);
            this.btnNewM.Name = "btnNewM";
            this.btnNewM.Size = new System.Drawing.Size(75, 23);
            this.btnNewM.TabIndex = 5;
            this.btnNewM.Text = "NEW";
            this.btnNewM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewM);
            this.groupBox1.Controls.Add(this.btnSaveM);
            this.groupBox1.Controls.Add(this.btnDeleteM);
            this.groupBox1.Controls.Add(this.btnEditM);
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(15, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(517, 45);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "MYSQL";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 196);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.LblUnidad);
            this.tabPage1.Controls.Add(this.LblCant);
            this.tabPage1.Controls.Add(this.LblBarcode);
            this.tabPage1.Controls.Add(this.LblPrice);
            this.tabPage1.Controls.Add(this.LblDescription);
            this.tabPage1.Controls.Add(this.LblName);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(134, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(134, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(134, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LblUnidad
            // 
            this.LblUnidad.AutoSize = true;
            this.LblUnidad.Location = new System.Drawing.Point(7, 141);
            this.LblUnidad.Name = "LblUnidad";
            this.LblUnidad.Size = new System.Drawing.Size(94, 13);
            this.LblUnidad.TabIndex = 5;
            this.LblUnidad.Text = "Unidad de Medida";
            // 
            // LblCant
            // 
            this.LblCant.AutoSize = true;
            this.LblCant.Location = new System.Drawing.Point(7, 118);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(49, 13);
            this.LblCant.TabIndex = 4;
            this.LblCant.Text = "Cantidad";
            // 
            // LblBarcode
            // 
            this.LblBarcode.AutoSize = true;
            this.LblBarcode.Location = new System.Drawing.Point(7, 89);
            this.LblBarcode.Name = "LblBarcode";
            this.LblBarcode.Size = new System.Drawing.Size(82, 13);
            this.LblBarcode.TabIndex = 3;
            this.LblBarcode.Text = "Código de barra";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(7, 54);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(37, 13);
            this.LblPrice.TabIndex = 2;
            this.LblPrice.Text = "Precio";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(7, 30);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Descripción";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(7, 7);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Existencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDesc,
            this.colCant});
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "colNombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "colDesc";
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colCant
            // 
            this.colCant.DataPropertyName = "colCant";
            this.colCant.HeaderText = "Cantidad";
            this.colCant.Name = "colCant";
            this.colCant.ReadOnly = true;
            // 
            // TablaMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablaMySQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaMySQL";
            this.Load += new System.EventHandler(this.TablaMySQL_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.Button btnEditM;
        private System.Windows.Forms.Button btnSaveM;
        private System.Windows.Forms.Button btnNewM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblUnidad;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Label LblBarcode;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
    }
}