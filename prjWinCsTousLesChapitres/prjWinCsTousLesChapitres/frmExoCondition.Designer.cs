namespace prjWinCsTousLesChapitres
{
    partial class frmExoCondition
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
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnEvaluer = new System.Windows.Forms.Button();
            this.radFemme = new System.Windows.Forms.RadioButton();
            this.radHomme = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnEffacer);
            this.groupBox1.Controls.Add(this.btnEvaluer);
            this.groupBox1.Controls.Add(this.radFemme);
            this.groupBox1.Controls.Add(this.radHomme);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.lblResultat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 774);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Etudiant ";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.Silver;
            this.btnEffacer.Location = new System.Drawing.Point(572, 349);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(448, 76);
            this.btnEffacer.TabIndex = 11;
            this.btnEffacer.Text = "Recommencer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnEvaluer
            // 
            this.btnEvaluer.BackColor = System.Drawing.Color.Silver;
            this.btnEvaluer.Location = new System.Drawing.Point(151, 349);
            this.btnEvaluer.Name = "btnEvaluer";
            this.btnEvaluer.Size = new System.Drawing.Size(323, 76);
            this.btnEvaluer.TabIndex = 10;
            this.btnEvaluer.Text = "Evaluer";
            this.btnEvaluer.UseVisualStyleBackColor = false;
            this.btnEvaluer.Click += new System.EventHandler(this.btnEvaluer_Click);
            // 
            // radFemme
            // 
            this.radFemme.AutoSize = true;
            this.radFemme.Location = new System.Drawing.Point(339, 186);
            this.radFemme.Name = "radFemme";
            this.radFemme.Size = new System.Drawing.Size(161, 41);
            this.radFemme.TabIndex = 8;
            this.radFemme.Text = "Femme";
            this.radFemme.UseVisualStyleBackColor = true;
            // 
            // radHomme
            // 
            this.radHomme.AutoSize = true;
            this.radHomme.Checked = true;
            this.radHomme.Location = new System.Drawing.Point(341, 139);
            this.radHomme.Name = "radHomme";
            this.radHomme.Size = new System.Drawing.Size(165, 41);
            this.radHomme.TabIndex = 7;
            this.radHomme.TabStop = true;
            this.radHomme.Text = "Homme";
            this.radHomme.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.ForeColor = System.Drawing.Color.Blue;
            this.txtNote.Location = new System.Drawing.Point(339, 250);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(135, 44);
            this.txtNote.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.Color.Blue;
            this.txtNom.Location = new System.Drawing.Point(339, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(746, 44);
            this.txtNom.TabIndex = 5;
            // 
            // lblResultat
            // 
            this.lblResultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.ForeColor = System.Drawing.Color.White;
            this.lblResultat.Location = new System.Drawing.Point(87, 481);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(1000, 236);
            this.lblResultat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "/100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Entrez note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choisir Genre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Complet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1033, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "STRUCTURES CONDITIONNELLES";
            // 
            // frmExoCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 945);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmExoCondition";
            this.Text = "frmExoCondition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnEvaluer;
        private System.Windows.Forms.RadioButton radFemme;
        private System.Windows.Forms.RadioButton radHomme;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}