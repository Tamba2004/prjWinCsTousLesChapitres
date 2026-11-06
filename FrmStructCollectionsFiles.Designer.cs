namespace prjWinCsTousLesChapitres
{
    partial class FrmStructCollectionsFiles
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumEtudiant = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.datNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtNonPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstNumero = new System.Windows.Forms.ListBox();
            this.lblInfoEtudiant = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestion Etudiants (Collections De Structs )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "COLLEGE LA SALLE ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.lblInformation);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnSauvegarder);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumEtudiant);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.datNaissance);
            this.groupBox1.Controls.Add(this.txtNonPrenom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(13, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(946, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "saisie des etudiants dans 1 Collections de struct ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblInformation
            // 
            this.lblInformation.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblInformation.Location = new System.Drawing.Point(60, 271);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(802, 41);
            this.lblInformation.TabIndex = 17;
            this.lblInformation.Text = "Informations";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformation.Click += new System.EventHandler(this.lblInformation_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Black;
            this.btnPrecedent.ForeColor = System.Drawing.Color.Bisque;
            this.btnPrecedent.Location = new System.Drawing.Point(234, 203);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(148, 44);
            this.btnPrecedent.TabIndex = 16;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Black;
            this.btnSuivant.ForeColor = System.Drawing.Color.Bisque;
            this.btnSuivant.Location = new System.Drawing.Point(403, 203);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(148, 44);
            this.btnSuivant.TabIndex = 15;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.Black;
            this.btnDernier.ForeColor = System.Drawing.Color.Bisque;
            this.btnDernier.Location = new System.Drawing.Point(607, 203);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(148, 44);
            this.btnDernier.TabIndex = 14;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.Black;
            this.btnPremier.ForeColor = System.Drawing.Color.Bisque;
            this.btnPremier.Location = new System.Drawing.Point(24, 203);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(148, 44);
            this.btnPremier.TabIndex = 13;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnnuler.Location = new System.Drawing.Point(761, 19);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(164, 44);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModifier.ForeColor = System.Drawing.Color.Bisque;
            this.btnModifier.Location = new System.Drawing.Point(759, 60);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(166, 44);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSupprimer.ForeColor = System.Drawing.Color.Bisque;
            this.btnSupprimer.Location = new System.Drawing.Point(759, 110);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(166, 44);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.Bisque;
            this.btnSauvegarder.Location = new System.Drawing.Point(761, 160);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(164, 44);
            this.btnSauvegarder.TabIndex = 9;
            this.btnSauvegarder.Text = "Sauvegarder ";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAjouter.ForeColor = System.Drawing.Color.Bisque;
            this.btnAjouter.Location = new System.Drawing.Point(759, 210);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(166, 44);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(55, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numero Etudiant :";
            // 
            // txtNumEtudiant
            // 
            this.txtNumEtudiant.Location = new System.Drawing.Point(297, 33);
            this.txtNumEtudiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumEtudiant.Name = "txtNumEtudiant";
            this.txtNumEtudiant.Size = new System.Drawing.Size(455, 30);
            this.txtNumEtudiant.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(277, 160);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(150, 30);
            this.txtNote.TabIndex = 5;
            // 
            // datNaissance
            // 
            this.datNaissance.Location = new System.Drawing.Point(287, 117);
            this.datNaissance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datNaissance.Name = "datNaissance";
            this.datNaissance.Size = new System.Drawing.Size(455, 30);
            this.datNaissance.TabIndex = 4;
            // 
            // txtNonPrenom
            // 
            this.txtNonPrenom.Location = new System.Drawing.Point(292, 70);
            this.txtNonPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNonPrenom.Name = "txtNonPrenom";
            this.txtNonPrenom.Size = new System.Drawing.Size(455, 30);
            this.txtNonPrenom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(55, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(110, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Note Final :                                     /100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(83, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prenom Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.lstNumero);
            this.groupBox2.Controls.Add(this.lblInfoEtudiant);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(13, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(946, 317);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche et affichage d un etudiant dans la collection ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstNumero
            // 
            this.lstNumero.ForeColor = System.Drawing.Color.Blue;
            this.lstNumero.FormattingEnabled = true;
            this.lstNumero.ItemHeight = 25;
            this.lstNumero.Location = new System.Drawing.Point(51, 89);
            this.lstNumero.Name = "lstNumero";
            this.lstNumero.Size = new System.Drawing.Size(384, 179);
            this.lstNumero.TabIndex = 18;
            // 
            // lblInfoEtudiant
            // 
            this.lblInfoEtudiant.ForeColor = System.Drawing.Color.Black;
            this.lblInfoEtudiant.Location = new System.Drawing.Point(479, 76);
            this.lblInfoEtudiant.Name = "lblInfoEtudiant";
            this.lblInfoEtudiant.Size = new System.Drawing.Size(437, 203);
            this.lblInfoEtudiant.TabIndex = 17;
            this.lblInfoEtudiant.Text = "Informations";
            this.lblInfoEtudiant.Click += new System.EventHandler(this.lblInfoEtudiant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(55, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Choisir un numero ";
            // 
            // FrmStructCollectionsFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(963, 844);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Bisque;
            this.Name = "FrmStructCollectionsFiles";
            this.Text = "FrmStructCollectionsFiles";
            this.Load += new System.EventHandler(this.FrmStructCollectionsFiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumEtudiant;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker datNaissance;
        private System.Windows.Forms.TextBox txtNonPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInfoEtudiant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstNumero;
    }
}