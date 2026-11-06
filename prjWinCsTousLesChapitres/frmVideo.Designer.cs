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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtCarte = new TextBox();
            label6 = new Label();
            radAmex = new RadioButton();
            radMastercard = new RadioButton();
            radVisa = new RadioButton();
            groupBox2 = new GroupBox();
            radConjoint = new RadioButton();
            radSepare = new RadioButton();
            radMarie = new RadioButton();
            radCelibataire = new RadioButton();
            chkIdentite = new CheckBox();
            datNaissance = new DateTimePicker();
            txtAdresse = new TextBox();
            txtNom = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnRetourner = new Button();
            btnLouer = new Button();
            btnSauvegarder = new Button();
            groupBox5 = new GroupBox();
            lstFilm = new ListBox();
            label8 = new Label();
            txtTitre = new TextBox();
            lblTitre = new Label();
            btnAjouter = new Button();
            label7 = new Label();
            cboSpecial = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(84, 29);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 0;
            label1.Text = "VIDEOTHEQUE Netflix";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Red;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(chkIdentite);
            groupBox1.Controls.Add(datNaissance);
            groupBox1.Controls.Add(txtAdresse);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 598);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations du client";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(txtCarte);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(radAmex);
            groupBox3.Controls.Add(radMastercard);
            groupBox3.Controls.Add(radVisa);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(16, 403);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(403, 172);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Moyen de paiement";
            // 
            // txtCarte
            // 
            txtCarte.Location = new Point(57, 131);
            txtCarte.Name = "txtCarte";
            txtCarte.Size = new Size(190, 27);
            txtCarte.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 134);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 3;
            label6.Text = "N : ";
            // 
            // radAmex
            // 
            radAmex.AutoSize = true;
            radAmex.Location = new Point(18, 98);
            radAmex.Name = "radAmex";
            radAmex.Size = new Size(151, 24);
            radAmex.TabIndex = 2;
            radAmex.TabStop = true;
            radAmex.Text = "American Express";
            radAmex.UseVisualStyleBackColor = true;
            // 
            // radMastercard
            // 
            radMastercard.AutoSize = true;
            radMastercard.Location = new Point(18, 65);
            radMastercard.Name = "radMastercard";
            radMastercard.Size = new Size(106, 24);
            radMastercard.TabIndex = 1;
            radMastercard.TabStop = true;
            radMastercard.Text = "Mastercard";
            radMastercard.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            radVisa.AutoSize = true;
            radVisa.Location = new Point(18, 35);
            radVisa.Name = "radVisa";
            radVisa.Size = new Size(56, 24);
            radVisa.TabIndex = 0;
            radVisa.TabStop = true;
            radVisa.Text = "Visa";
            radVisa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(radConjoint);
            groupBox2.Controls.Add(radSepare);
            groupBox2.Controls.Add(radMarie);
            groupBox2.Controls.Add(radCelibataire);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(16, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 172);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Statut matrimonial";
            // 
            // radConjoint
            // 
            radConjoint.AutoSize = true;
            radConjoint.Location = new Point(18, 128);
            radConjoint.Name = "radConjoint";
            radConjoint.Size = new Size(106, 24);
            radConjoint.TabIndex = 3;
            radConjoint.TabStop = true;
            radConjoint.Text = "Conjoint(e)";
            radConjoint.UseVisualStyleBackColor = true;
            // 
            // radSepare
            // 
            radSepare.AutoSize = true;
            radSepare.Location = new Point(18, 98);
            radSepare.Name = "radSepare";
            radSepare.Size = new Size(94, 24);
            radSepare.TabIndex = 2;
            radSepare.TabStop = true;
            radSepare.Text = "Separé(e)";
            radSepare.UseVisualStyleBackColor = true;
            // 
            // radMarie
            // 
            radMarie.AutoSize = true;
            radMarie.Location = new Point(18, 65);
            radMarie.Name = "radMarie";
            radMarie.Size = new Size(87, 24);
            radMarie.TabIndex = 1;
            radMarie.TabStop = true;
            radMarie.Text = "Marié(e)";
            radMarie.UseVisualStyleBackColor = true;
            // 
            // radCelibataire
            // 
            radCelibataire.AutoSize = true;
            radCelibataire.Location = new Point(18, 35);
            radCelibataire.Name = "radCelibataire";
            radCelibataire.Size = new Size(101, 24);
            radCelibataire.TabIndex = 0;
            radCelibataire.TabStop = true;
            radCelibataire.Text = "Celibataire";
            radCelibataire.UseVisualStyleBackColor = true;
            // 
            // chkIdentite
            // 
            chkIdentite.AutoSize = true;
            chkIdentite.Location = new Point(161, 189);
            chkIdentite.Name = "chkIdentite";
            chkIdentite.Size = new Size(52, 24);
            chkIdentite.TabIndex = 7;
            chkIdentite.Text = "Oui";
            chkIdentite.UseVisualStyleBackColor = true;
            chkIdentite.CheckedChanged += chkIdentite_CheckedChanged;
            // 
            // datNaissance
            // 
            datNaissance.Format = DateTimePickerFormat.Custom;
            datNaissance.Location = new Point(159, 65);
            datNaissance.Name = "datNaissance";
            datNaissance.Size = new Size(250, 27);
            datNaissance.TabIndex = 6;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(161, 105);
            txtAdresse.Multiline = true;
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(250, 78);
            txtAdresse.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(159, 32);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(250, 27);
            txtNom.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 189);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 3;
            label5.Text = "Preuve Identité ? : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 105);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 2;
            label4.Text = "Adresse complète : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 70);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 1;
            label3.Text = "Date de naissance :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Prenom Nom :";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Red;
            groupBox4.Controls.Add(btnRetourner);
            groupBox4.Controls.Add(btnLouer);
            groupBox4.Controls.Add(btnSauvegarder);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(456, 83);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(254, 173);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Actions";
            // 
            // btnRetourner
            // 
            btnRetourner.BackColor = Color.Black;
            btnRetourner.Location = new Point(41, 121);
            btnRetourner.Name = "btnRetourner";
            btnRetourner.Size = new Size(172, 34);
            btnRetourner.TabIndex = 2;
            btnRetourner.Text = "Retourner Film Choisi";
            btnRetourner.UseVisualStyleBackColor = false;
            btnRetourner.Click += btnRetourner_Click;
            // 
            // btnLouer
            // 
            btnLouer.BackColor = Color.Black;
            btnLouer.Location = new Point(41, 70);
            btnLouer.Name = "btnLouer";
            btnLouer.Size = new Size(172, 35);
            btnLouer.TabIndex = 1;
            btnLouer.Text = "Louer le film";
            btnLouer.UseVisualStyleBackColor = false;
            btnLouer.Click += btnLouer_Click;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.BackColor = Color.Black;
            btnSauvegarder.Location = new Point(41, 24);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(172, 35);
            btnSauvegarder.TabIndex = 0;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = false;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Red;
            groupBox5.Controls.Add(cboSpecial);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(lstFilm);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txtTitre);
            groupBox5.Controls.Add(lblTitre);
            groupBox5.Controls.Add(btnAjouter);
            groupBox5.Font = new Font("Segoe UI", 12F);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(456, 268);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(254, 328);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Actions";
            // 
            // lstFilm
            // 
            lstFilm.ForeColor = Color.Blue;
            lstFilm.FormattingEnabled = true;
            lstFilm.Location = new Point(21, 148);
            lstFilm.Name = "lstFilm";
            lstFilm.Size = new Size(214, 109);
            lstFilm.TabIndex = 7;
            lstFilm.SelectedIndexChanged += lstFilm_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 101);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 6;
            label8.Text = "Film(s) Loué(s)";
            // 
            // txtTitre
            // 
            txtTitre.ForeColor = Color.Blue;
            txtTitre.Location = new Point(12, 55);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(151, 29);
            txtTitre.TabIndex = 5;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Location = new Point(6, 25);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(157, 21);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Entrez le titre du film:";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.Location = new Point(170, 53);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(65, 31);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "OK";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 283);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 8;
            label7.Text = "Spécial du jour : ";
            // 
            // cboSpecial
            // 
            cboSpecial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSpecial.FormattingEnabled = true;
            cboSpecial.Location = new Point(143, 283);
            cboSpecial.Name = "cboSpecial";
            cboSpecial.Size = new Size(92, 23);
            cboSpecial.TabIndex = 9;
            // 
            // frmVideo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(743, 693);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmVideo";
            Text = "frmVideo";
            Load += frmVideo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkIdentite;
        private DateTimePicker datNaissance;
        private TextBox txtAdresse;
        private TextBox txtNom;
        private GroupBox groupBox2;
        private RadioButton radConjoint;
        private RadioButton radSepare;
        private RadioButton radMarie;
        private RadioButton radCelibataire;
        private GroupBox groupBox3;
        private RadioButton radAmex;
        private RadioButton radMastercard;
        private RadioButton radVisa;
        private TextBox txtCarte;
        private Label label6;
        private GroupBox groupBox4;
        private Button btnSauvegarder;
        private Button btnLouer;
        private GroupBox groupBox5;
        private TextBox txtTitre;
        private Label lblTitre;
        private Button btnAjouter;
        private ListBox lstFilm;
        private Label label8;
        private Button btnRetourner;
        private ComboBox cboSpecial;
        private Label label7;
    }
}