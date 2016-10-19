namespace Vistas
{
    partial class TablaPostgress
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
            this.dataGridView1P = new System.Windows.Forms.DataGridView();
            this.btnNewP = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnEditP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1P)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1P
            // 
            this.dataGridView1P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1P.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1P.Name = "dataGridView1P";
            this.dataGridView1P.Size = new System.Drawing.Size(517, 177);
            this.dataGridView1P.TabIndex = 11;
            // 
            // btnNewP
            // 
            this.btnNewP.Location = new System.Drawing.Point(6, 41);
            this.btnNewP.Name = "btnNewP";
            this.btnNewP.Size = new System.Drawing.Size(75, 23);
            this.btnNewP.TabIndex = 5;
            this.btnNewP.Text = "NEW";
            this.btnNewP.UseVisualStyleBackColor = true;
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(141, 41);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveP.TabIndex = 6;
            this.btnSaveP.Text = "SAVE";
            this.btnSaveP.UseVisualStyleBackColor = true;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Location = new System.Drawing.Point(419, 41);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteP.TabIndex = 8;
            this.btnDeleteP.Text = "DELETE";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            // 
            // btnEditP
            // 
            this.btnEditP.Location = new System.Drawing.Point(278, 41);
            this.btnEditP.Name = "btnEditP";
            this.btnEditP.Size = new System.Drawing.Size(75, 23);
            this.btnEditP.TabIndex = 7;
            this.btnEditP.Text = "EDIT";
            this.btnEditP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewP);
            this.groupBox1.Controls.Add(this.btnSaveP);
            this.groupBox1.Controls.Add(this.btnDeleteP);
            this.groupBox1.Controls.Add(this.btnEditP);
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(14, 3);
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
            this.label1.Location = new System.Drawing.Point(225, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "POSTGRES";
            // 
            // TablaPostgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1P);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablaPostgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaPostgress";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1P)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1P;
        private System.Windows.Forms.Button btnNewP;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnEditP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}