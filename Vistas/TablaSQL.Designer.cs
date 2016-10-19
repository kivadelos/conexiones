namespace Vistas
{
    partial class TablaSQL
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
            this.dataGridView1S = new System.Windows.Forms.DataGridView();
            this.btnNewS = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.btnDeleteD = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1S)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1S
            // 
            this.dataGridView1S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1S.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1S.Name = "dataGridView1S";
            this.dataGridView1S.Size = new System.Drawing.Size(517, 179);
            this.dataGridView1S.TabIndex = 11;
            // 
            // btnNewS
            // 
            this.btnNewS.Location = new System.Drawing.Point(6, 41);
            this.btnNewS.Name = "btnNewS";
            this.btnNewS.Size = new System.Drawing.Size(75, 23);
            this.btnNewS.TabIndex = 5;
            this.btnNewS.Text = "NEW";
            this.btnNewS.UseVisualStyleBackColor = true;
            // 
            // btnSaveS
            // 
            this.btnSaveS.Location = new System.Drawing.Point(141, 41);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveS.TabIndex = 6;
            this.btnSaveS.Text = "SAVE";
            this.btnSaveS.UseVisualStyleBackColor = true;
            // 
            // btnDeleteD
            // 
            this.btnDeleteD.Location = new System.Drawing.Point(419, 41);
            this.btnDeleteD.Name = "btnDeleteD";
            this.btnDeleteD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteD.TabIndex = 8;
            this.btnDeleteD.Text = "DELETE";
            this.btnDeleteD.UseVisualStyleBackColor = true;
            // 
            // btnEditS
            // 
            this.btnEditS.Location = new System.Drawing.Point(278, 41);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(75, 23);
            this.btnEditS.TabIndex = 7;
            this.btnEditS.Text = "EDIT";
            this.btnEditS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewS);
            this.groupBox1.Controls.Add(this.btnSaveS);
            this.groupBox1.Controls.Add(this.btnDeleteD);
            this.groupBox1.Controls.Add(this.btnEditS);
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
            this.pictureBox2.Location = new System.Drawing.Point(12, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(517, 45);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "SQL";
            // 
            // TablaSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1S);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablaSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaSQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1S)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1S;
        private System.Windows.Forms.Button btnNewS;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.Button btnDeleteD;
        private System.Windows.Forms.Button btnEditS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}