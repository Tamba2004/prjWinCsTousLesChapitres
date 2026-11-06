namespace prjWinCsTousLesChapitres
{
    partial class frmRepetitions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDowhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.lstResultats = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDebut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie des valeurs ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debut:";
            // 
            // txtDebut
            // 
            this.txtDebut.ForeColor = System.Drawing.Color.Blue;
            this.txtDebut.Location = new System.Drawing.Point(145, 74);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(103, 44);
            this.txtDebut.TabIndex = 1;
            // 
            // txtFin
            // 
            this.txtFin.ForeColor = System.Drawing.Color.Blue;
            this.txtFin.Location = new System.Drawing.Point(407, 77);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(103, 44);
            this.txtFin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fin :";
            // 
            // txtInterval
            // 
            this.txtInterval.ForeColor = System.Drawing.Color.Blue;
            this.txtInterval.Location = new System.Drawing.Point(756, 78);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(103, 44);
            this.txtInterval.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lstResultats);
            this.groupBox2.Controls.Add(this.btnFor);
            this.groupBox2.Controls.Add(this.btnDowhile);
            this.groupBox2.Controls.Add(this.btnWhile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les Boucles";
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(45, 85);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(357, 56);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "Boucle While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDowhile
            // 
            this.btnDowhile.ForeColor = System.Drawing.Color.Red;
            this.btnDowhile.Location = new System.Drawing.Point(45, 177);
            this.btnDowhile.Name = "btnDowhile";
            this.btnDowhile.Size = new System.Drawing.Size(357, 56);
            this.btnDowhile.TabIndex = 1;
            this.btnDowhile.Text = "Boucle Do While";
            this.btnDowhile.UseVisualStyleBackColor = true;
            this.btnDowhile.Click += new System.EventHandler(this.btnDowhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.ForeColor = System.Drawing.Color.Blue;
            this.btnFor.Location = new System.Drawing.Point(45, 271);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(357, 56);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "Boucle For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // lstResultats
            // 
            this.lstResultats.FormattingEnabled = true;
            this.lstResultats.ItemHeight = 37;
            this.lstResultats.Location = new System.Drawing.Point(460, 37);
            this.lstResultats.Name = "lstResultats";
            this.lstResultats.Size = new System.Drawing.Size(427, 448);
            this.lstResultats.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(764, 61);
            this.label4.TabIndex = 2;
            this.label4.Text = "STRUCTURES REPETITIVES";
            // 
            // frmRepetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 923);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRepetitions";
            this.Text = "frmRepetitions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstResultats;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnDowhile;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Label label4;
    }
}