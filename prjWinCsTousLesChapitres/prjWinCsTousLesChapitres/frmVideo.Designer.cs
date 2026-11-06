namespace prjWinCsTousLesChapitres
{
    partial class frmVideo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCarte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radAmex = new System.Windows.Forms.RadioButton();
            this.radMastercard = new System.Windows.Forms.RadioButton();
            this.radVisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radConjoint = new System.Windows.Forms.RadioButton();
            this.radSepare = new System.Windows.Forms.RadioButton();
            this.radMarie = new System.Windows.Forms.RadioButton();
            this.radCelibataire = new System.Windows.Forms.RadioButton();
            this.chkIdentite = new System.Windows.Forms.CheckBox();
            this.datNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLouer = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstFilms = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSpecial = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(380, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIDEOTHEQUE NETFLIX";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkIdentite);
            this.groupBox1.Controls.Add(this.datNaissance);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(49, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 1167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du client ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.txtCarte);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radAmex);
            this.groupBox3.Controls.Add(this.radMastercard);
            this.groupBox3.Controls.Add(this.radVisa);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(46, 811);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(861, 311);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modes de Paiement";
            // 
            // txtCarte
            // 
            this.txtCarte.Location = new System.Drawing.Point(130, 236);
            this.txtCarte.Name = "txtCarte";
            this.txtCarte.Size = new System.Drawing.Size(686, 50);
            this.txtCarte.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "N :";
            // 
            // radAmex
            // 
            this.radAmex.AutoSize = true;
            this.radAmex.Location = new System.Drawing.Point(65, 167);
            this.radAmex.Name = "radAmex";
            this.radAmex.Size = new System.Drawing.Size(335, 46);
            this.radAmex.TabIndex = 2;
            this.radAmex.TabStop = true;
            this.radAmex.Text = "American Express";
            this.radAmex.UseVisualStyleBackColor = true;
            // 
            // radMastercard
            // 
            this.radMastercard.AutoSize = true;
            this.radMastercard.Location = new System.Drawing.Point(65, 112);
            this.radMastercard.Name = "radMastercard";
            this.radMastercard.Size = new System.Drawing.Size(233, 46);
            this.radMastercard.TabIndex = 1;
            this.radMastercard.TabStop = true;
            this.radMastercard.Text = "Mastercard";
            this.radMastercard.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            this.radVisa.AutoSize = true;
            this.radVisa.Location = new System.Drawing.Point(65, 60);
            this.radVisa.Name = "radVisa";
            this.radVisa.Size = new System.Drawing.Size(118, 46);
            this.radVisa.TabIndex = 0;
            this.radVisa.TabStop = true;
            this.radVisa.Text = "Visa";
            this.radVisa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.radConjoint);
            this.groupBox2.Controls.Add(this.radSepare);
            this.groupBox2.Controls.Add(this.radMarie);
            this.groupBox2.Controls.Add(this.radCelibataire);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(46, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 311);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statut Matrimonial ";
            // 
            // radConjoint
            // 
            this.radConjoint.AutoSize = true;
            this.radConjoint.Location = new System.Drawing.Point(65, 231);
            this.radConjoint.Name = "radConjoint";
            this.radConjoint.Size = new System.Drawing.Size(228, 46);
            this.radConjoint.TabIndex = 3;
            this.radConjoint.TabStop = true;
            this.radConjoint.Text = "Conjoint(e)";
            this.radConjoint.UseVisualStyleBackColor = true;
            // 
            // radSepare
            // 
            this.radSepare.AutoSize = true;
            this.radSepare.Location = new System.Drawing.Point(65, 174);
            this.radSepare.Name = "radSepare";
            this.radSepare.Size = new System.Drawing.Size(197, 46);
            this.radSepare.TabIndex = 2;
            this.radSepare.TabStop = true;
            this.radSepare.Text = "Separe(e)";
            this.radSepare.UseVisualStyleBackColor = true;
            // 
            // radMarie
            // 
            this.radMarie.AutoSize = true;
            this.radMarie.Location = new System.Drawing.Point(65, 119);
            this.radMarie.Name = "radMarie";
            this.radMarie.Size = new System.Drawing.Size(186, 46);
            this.radMarie.TabIndex = 1;
            this.radMarie.TabStop = true;
            this.radMarie.Text = "Marie(e)";
            this.radMarie.UseVisualStyleBackColor = true;
            // 
            // radCelibataire
            // 
            this.radCelibataire.AutoSize = true;
            this.radCelibataire.Location = new System.Drawing.Point(65, 67);
            this.radCelibataire.Name = "radCelibataire";
            this.radCelibataire.Size = new System.Drawing.Size(224, 46);
            this.radCelibataire.TabIndex = 0;
            this.radCelibataire.TabStop = true;
            this.radCelibataire.Text = "Celibataire";
            this.radCelibataire.UseVisualStyleBackColor = true;
            // 
            // chkIdentite
            // 
            this.chkIdentite.AutoSize = true;
            this.chkIdentite.Location = new System.Drawing.Point(344, 372);
            this.chkIdentite.Name = "chkIdentite";
            this.chkIdentite.Size = new System.Drawing.Size(110, 46);
            this.chkIdentite.TabIndex = 7;
            this.chkIdentite.Text = "Oui";
            this.chkIdentite.UseVisualStyleBackColor = true;
            this.chkIdentite.CheckedChanged += new System.EventHandler(this.chkIdentite_CheckedChanged);
            // 
            // datNaissance
            // 
            this.datNaissance.Location = new System.Drawing.Point(344, 133);
            this.datNaissance.Name = "datNaissance";
            this.datNaissance.Size = new System.Drawing.Size(563, 50);
            this.datNaissance.TabIndex = 6;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(344, 203);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(564, 163);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(344, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(564, 50);
            this.txtNom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preuve Identite ? :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresse complete :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenom Nom :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.btnRetourner);
            this.groupBox4.Controls.Add(this.btnLouer);
            this.groupBox4.Controls.Add(this.btnSauvegarder);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1014, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 314);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions ";
            // 
            // btnLouer
            // 
            this.btnLouer.BackColor = System.Drawing.Color.Black;
            this.btnLouer.Location = new System.Drawing.Point(62, 145);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(425, 68);
            this.btnLouer.TabIndex = 1;
            this.btnLouer.Text = "Louer un Film";
            this.btnLouer.UseVisualStyleBackColor = false;
            this.btnLouer.Click += new System.EventHandler(this.btnLouer_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.Location = new System.Drawing.Point(62, 61);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(425, 68);
            this.btnSauvegarder.TabIndex = 0;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Red;
            this.groupBox5.Controls.Add(this.cboSpecial);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lstFilms);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTitre);
            this.groupBox5.Controls.Add(this.lblTitre);
            this.groupBox5.Controls.Add(this.btnAjouter);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(1014, 559);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(543, 797);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions ";
            // 
            // lstFilms
            // 
            this.lstFilms.ForeColor = System.Drawing.Color.Blue;
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.ItemHeight = 42;
            this.lstFilms.Location = new System.Drawing.Point(35, 293);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(489, 298);
            this.lstFilms.TabIndex = 5;
            this.lstFilms.SelectedIndexChanged += new System.EventHandler(this.lstFilms_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Film(s) Loué(s)";
            // 
            // txtTitre
            // 
            this.txtTitre.ForeColor = System.Drawing.Color.Blue;
            this.txtTitre.Location = new System.Drawing.Point(35, 115);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(365, 50);
            this.txtTitre.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(28, 52);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(395, 42);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Entrer le Titre du Film :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(406, 110);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(119, 58);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "OK";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRetourner
            // 
            this.btnRetourner.BackColor = System.Drawing.Color.Black;
            this.btnRetourner.Location = new System.Drawing.Point(62, 227);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(425, 68);
            this.btnRetourner.TabIndex = 2;
            this.btnRetourner.Text = "Retourner Film Choisi";
            this.btnRetourner.UseVisualStyleBackColor = false;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 42);
            this.label8.TabIndex = 6;
            this.label8.Text = "Special du Jour :";
            // 
            // cboSpecial
            // 
            this.cboSpecial.FormattingEnabled = true;
            this.cboSpecial.Location = new System.Drawing.Point(35, 709);
            this.cboSpecial.Name = "cboSpecial";
            this.cboSpecial.Size = new System.Drawing.Size(466, 50);
            this.cboSpecial.TabIndex = 7;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1604, 1419);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmVideo";
            this.Text = "frmVideo";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datNaissance;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.CheckBox chkIdentite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radConjoint;
        private System.Windows.Forms.RadioButton radSepare;
        private System.Windows.Forms.RadioButton radMarie;
        private System.Windows.Forms.RadioButton radCelibataire;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radAmex;
        private System.Windows.Forms.RadioButton radMastercard;
        private System.Windows.Forms.RadioButton radVisa;
        private System.Windows.Forms.TextBox txtCarte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstFilms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.ComboBox cboSpecial;
        private System.Windows.Forms.Label label8;
    }
}