namespace prjWinCsTousLesChapitres
{
    partial class FrmConditions
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.btnEvaluer = new System.Windows.Forms.Button();
            this.radConfidentiel = new System.Windows.Forms.RadioButton();
            this.radFemme = new System.Windows.Forms.RadioButton();
            this.radHomme = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "STRUCTURES CONDITIONNELLES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnRecommencer);
            this.groupBox1.Controls.Add(this.btnEvaluer);
            this.groupBox1.Controls.Add(this.radConfidentiel);
            this.groupBox1.Controls.Add(this.radFemme);
            this.groupBox1.Controls.Add(this.radHomme);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.lblResultat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 518);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Etudiant";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.Gray;
            this.btnRecommencer.Location = new System.Drawing.Point(518, 260);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(214, 38);
            this.btnRecommencer.TabIndex = 10;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = false;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // btnEvaluer
            // 
            this.btnEvaluer.BackColor = System.Drawing.Color.Gray;
            this.btnEvaluer.Location = new System.Drawing.Point(47, 260);
            this.btnEvaluer.Name = "btnEvaluer";
            this.btnEvaluer.Size = new System.Drawing.Size(169, 38);
            this.btnEvaluer.TabIndex = 9;
            this.btnEvaluer.Text = "Evaluer";
            this.btnEvaluer.UseVisualStyleBackColor = false;
            this.btnEvaluer.Click += new System.EventHandler(this.btnEvaluer_Click);
            // 
            // radConfidentiel
            // 
            this.radConfidentiel.AutoSize = true;
            this.radConfidentiel.Location = new System.Drawing.Point(225, 154);
            this.radConfidentiel.Name = "radConfidentiel";
            this.radConfidentiel.Size = new System.Drawing.Size(152, 29);
            this.radConfidentiel.TabIndex = 8;
            this.radConfidentiel.TabStop = true;
            this.radConfidentiel.Text = "Confidentiel";
            this.radConfidentiel.UseVisualStyleBackColor = true;
            // 
            // radFemme
            // 
            this.radFemme.AutoSize = true;
            this.radFemme.Location = new System.Drawing.Point(225, 120);
            this.radFemme.Name = "radFemme";
            this.radFemme.Size = new System.Drawing.Size(108, 29);
            this.radFemme.TabIndex = 7;
            this.radFemme.TabStop = true;
            this.radFemme.Text = "Femme";
            this.radFemme.UseVisualStyleBackColor = true;
            // 
            // radHomme
            // 
            this.radHomme.AutoSize = true;
            this.radHomme.Location = new System.Drawing.Point(225, 85);
            this.radHomme.Name = "radHomme";
            this.radHomme.Size = new System.Drawing.Size(110, 29);
            this.radHomme.TabIndex = 6;
            this.radHomme.TabStop = true;
            this.radHomme.Text = "Homme";
            this.radHomme.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.ForeColor = System.Drawing.Color.Blue;
            this.txtNote.Location = new System.Drawing.Point(225, 189);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(115, 30);
            this.txtNote.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.Color.Blue;
            this.txtNom.Location = new System.Drawing.Point(231, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(305, 30);
            this.txtNom.TabIndex = 4;
            // 
            // lblResultat
            // 
            this.lblResultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.ForeColor = System.Drawing.Color.White;
            this.lblResultat.Location = new System.Drawing.Point(63, 331);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(644, 172);
            this.lblResultat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Entrer Note :                            /100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choisir Genre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom complet :";
            // 
            // FrmConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConditions";
            this.Text = "FrmConditions";
            this.Load += new System.EventHandler(this.FrmConditions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radConfidentiel;
        private System.Windows.Forms.RadioButton radFemme;
        private System.Windows.Forms.RadioButton radHomme;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnEvaluer;
        private System.Windows.Forms.Button btnRecommencer;
    }
}