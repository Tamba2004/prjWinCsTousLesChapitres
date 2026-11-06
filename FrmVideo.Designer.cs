namespace prjWinCsTousLesChapitres
{
    partial class FrmVideo
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.radAmex = new System.Windows.Forms.RadioButton();
            this.radMastercard = new System.Windows.Forms.RadioButton();
            this.radVisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMarie = new System.Windows.Forms.RadioButton();
            this.radSepare = new System.Windows.Forms.RadioButton();
            this.radConjoint = new System.Windows.Forms.RadioButton();
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
            this.btnRetourner = new System.Windows.Forms.Button();
            this.btnLouer = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboSpecial = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstFilms = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 46);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(663, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du client";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCard);
            this.groupBox3.Controls.Add(this.radAmex);
            this.groupBox3.Controls.Add(this.radMastercard);
            this.groupBox3.Controls.Add(this.radVisa);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(11, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(648, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode de paiement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "N :";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(311, 118);
            this.txtCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(333, 32);
            this.txtCard.TabIndex = 4;
            // 
            // radAmex
            // 
            this.radAmex.AutoSize = true;
            this.radAmex.Location = new System.Drawing.Point(14, 73);
            this.radAmex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radAmex.Name = "radAmex";
            this.radAmex.Size = new System.Drawing.Size(231, 30);
            this.radAmex.TabIndex = 3;
            this.radAmex.TabStop = true;
            this.radAmex.Text = "American Express";
            this.radAmex.UseVisualStyleBackColor = true;
            // 
            // radMastercard
            // 
            this.radMastercard.AutoSize = true;
            this.radMastercard.Location = new System.Drawing.Point(14, 118);
            this.radMastercard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMastercard.Name = "radMastercard";
            this.radMastercard.Size = new System.Drawing.Size(155, 30);
            this.radMastercard.TabIndex = 2;
            this.radMastercard.TabStop = true;
            this.radMastercard.Text = "Mastercard";
            this.radMastercard.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            this.radVisa.AutoSize = true;
            this.radVisa.Location = new System.Drawing.Point(14, 39);
            this.radVisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radVisa.Name = "radVisa";
            this.radVisa.Size = new System.Drawing.Size(84, 30);
            this.radVisa.TabIndex = 0;
            this.radVisa.TabStop = true;
            this.radVisa.Text = "Visa";
            this.radVisa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.radMarie);
            this.groupBox2.Controls.Add(this.radSepare);
            this.groupBox2.Controls.Add(this.radConjoint);
            this.groupBox2.Controls.Add(this.radCelibataire);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(9, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(650, 131);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statut Matrimonial";
            // 
            // radMarie
            // 
            this.radMarie.AutoSize = true;
            this.radMarie.Location = new System.Drawing.Point(481, 44);
            this.radMarie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMarie.Name = "radMarie";
            this.radMarie.Size = new System.Drawing.Size(125, 30);
            this.radMarie.TabIndex = 3;
            this.radMarie.TabStop = true;
            this.radMarie.Text = "Marie(e)";
            this.radMarie.UseVisualStyleBackColor = true;
            // 
            // radSepare
            // 
            this.radSepare.AutoSize = true;
            this.radSepare.Location = new System.Drawing.Point(16, 90);
            this.radSepare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSepare.Name = "radSepare";
            this.radSepare.Size = new System.Drawing.Size(142, 30);
            this.radSepare.TabIndex = 2;
            this.radSepare.TabStop = true;
            this.radSepare.Text = "Separé(e)";
            this.radSepare.UseVisualStyleBackColor = true;
            this.radSepare.CheckedChanged += new System.EventHandler(this.radSepare_CheckedChanged);
            // 
            // radConjoint
            // 
            this.radConjoint.AutoSize = true;
            this.radConjoint.Location = new System.Drawing.Point(481, 90);
            this.radConjoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radConjoint.Name = "radConjoint";
            this.radConjoint.Size = new System.Drawing.Size(154, 30);
            this.radConjoint.TabIndex = 1;
            this.radConjoint.TabStop = true;
            this.radConjoint.Text = "Conjoint(e)";
            this.radConjoint.UseVisualStyleBackColor = true;
            // 
            // radCelibataire
            // 
            this.radCelibataire.AutoSize = true;
            this.radCelibataire.Location = new System.Drawing.Point(16, 44);
            this.radCelibataire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCelibataire.Name = "radCelibataire";
            this.radCelibataire.Size = new System.Drawing.Size(152, 30);
            this.radCelibataire.TabIndex = 0;
            this.radCelibataire.TabStop = true;
            this.radCelibataire.Text = "Celibataire";
            this.radCelibataire.UseVisualStyleBackColor = true;
            // 
            // chkIdentite
            // 
            this.chkIdentite.AutoSize = true;
            this.chkIdentite.Location = new System.Drawing.Point(220, 176);
            this.chkIdentite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkIdentite.Name = "chkIdentite";
            this.chkIdentite.Size = new System.Drawing.Size(70, 30);
            this.chkIdentite.TabIndex = 8;
            this.chkIdentite.Text = "oui";
            this.chkIdentite.UseVisualStyleBackColor = true;
            this.chkIdentite.CheckedChanged += new System.EventHandler(this.chkIdentite_CheckedChanged);
            // 
            // datNaissance
            // 
            this.datNaissance.Location = new System.Drawing.Point(217, 65);
            this.datNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datNaissance.Name = "datNaissance";
            this.datNaissance.Size = new System.Drawing.Size(442, 32);
            this.datNaissance.TabIndex = 7;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(217, 101);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(442, 71);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(217, 33);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(442, 32);
            this.txtNom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date Naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preuve Identite ? :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adress Complete :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenom Nom :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.btnRetourner);
            this.groupBox4.Controls.Add(this.btnLouer);
            this.groupBox4.Controls.Add(this.btnSauvegarder);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(669, 44);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(474, 134);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btnRetourner
            // 
            this.btnRetourner.BackColor = System.Drawing.Color.Black;
            this.btnRetourner.Location = new System.Drawing.Point(0, 91);
            this.btnRetourner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(474, 39);
            this.btnRetourner.TabIndex = 13;
            this.btnRetourner.Text = "Retourner Film Choisi";
            this.btnRetourner.UseVisualStyleBackColor = false;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // btnLouer
            // 
            this.btnLouer.BackColor = System.Drawing.Color.Black;
            this.btnLouer.Location = new System.Drawing.Point(244, 40);
            this.btnLouer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(230, 43);
            this.btnLouer.TabIndex = 12;
            this.btnLouer.Text = "Louer un Film";
            this.btnLouer.UseVisualStyleBackColor = false;
            this.btnLouer.Click += new System.EventHandler(this.btnLouer_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.Location = new System.Drawing.Point(0, 40);
            this.btnSauvegarder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(230, 43);
            this.btnSauvegarder.TabIndex = 11;
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
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(669, 182);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(474, 383);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // cboSpecial
            // 
            this.cboSpecial.FormattingEnabled = true;
            this.cboSpecial.Location = new System.Drawing.Point(10, 338);
            this.cboSpecial.Name = "cboSpecial";
            this.cboSpecial.Size = new System.Drawing.Size(456, 40);
            this.cboSpecial.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Special du Jour";
            // 
            // lstFilms
            // 
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.ItemHeight = 32;
            this.lstFilms.Location = new System.Drawing.Point(0, 143);
            this.lstFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(466, 100);
            this.lstFilms.TabIndex = 15;
            this.lstFilms.SelectedIndexChanged += new System.EventHandler(this.lstFilms_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Film(s) Louer";
            // 
            // txtTitre
            // 
            this.txtTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTitre.Location = new System.Drawing.Point(8, 68);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(222, 39);
            this.txtTitre.TabIndex = 13;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(4, 34);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitre.Size = new System.Drawing.Size(329, 32);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Entrer le Titre Du Film :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(234, 67);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(82, 40);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "OK";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1151, 581);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVideo";
            this.Text = "FrmVideo";
            this.Load += new System.EventHandler(this.FrmVideo_Load);
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
        private System.Windows.Forms.RadioButton radMarie;
        private System.Windows.Forms.RadioButton radSepare;
        private System.Windows.Forms.RadioButton radConjoint;
        private System.Windows.Forms.RadioButton radCelibataire;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.RadioButton radAmex;
        private System.Windows.Forms.RadioButton radMastercard;
        private System.Windows.Forms.RadioButton radVisa;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstFilms;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.ComboBox cboSpecial;
        private System.Windows.Forms.Label label8;
    }
}