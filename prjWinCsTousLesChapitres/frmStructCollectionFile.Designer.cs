namespace prjWinCsTousLesChapitres
{
    partial class frmStructCollectionFile
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
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblInformation = new Label();
            btnPrecedent = new Button();
            btnDernier = new Button();
            btnSuivant = new Button();
            btnPremier = new Button();
            btnAjouter = new Button();
            btnAnnuler = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnSauvegarder = new Button();
            txtNumero = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtNoteFinale = new TextBox();
            txtNomPrenom = new TextBox();
            datNaissance = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            lblInfoEtudiant = new Label();
            lstNumero = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(489, 32);
            label2.TabIndex = 14;
            label2.Text = "Gestion Etudiant (Tableau Struct Max. 25)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 29);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 13;
            label3.Text = "COLLEGE LASALLE";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Bisque;
            groupBox1.Controls.Add(lblInformation);
            groupBox1.Controls.Add(btnPrecedent);
            groupBox1.Controls.Add(btnDernier);
            groupBox1.Controls.Add(btnSuivant);
            groupBox1.Controls.Add(btnPremier);
            groupBox1.Controls.Add(btnAjouter);
            groupBox1.Controls.Add(btnAnnuler);
            groupBox1.Controls.Add(btnSupprimer);
            groupBox1.Controls.Add(btnModifier);
            groupBox1.Controls.Add(btnSauvegarder);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNoteFinale);
            groupBox1.Controls.Add(txtNomPrenom);
            groupBox1.Controls.Add(datNaissance);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(41, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 289);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saisie des étudiants dans 1collection de struct";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblInformation
            // 
            lblInformation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformation.ForeColor = Color.Red;
            lblInformation.Location = new Point(62, 232);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(379, 39);
            lblInformation.TabIndex = 20;
            lblInformation.Text = "Information";
            lblInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrecedent
            // 
            btnPrecedent.BackColor = Color.Black;
            btnPrecedent.ForeColor = Color.Bisque;
            btnPrecedent.Location = new Point(129, 175);
            btnPrecedent.Name = "btnPrecedent";
            btnPrecedent.Size = new Size(100, 36);
            btnPrecedent.TabIndex = 19;
            btnPrecedent.Text = "Precedent";
            btnPrecedent.UseVisualStyleBackColor = false;
            btnPrecedent.Click += btnPrecedent_Click;
            // 
            // btnDernier
            // 
            btnDernier.BackColor = Color.Black;
            btnDernier.ForeColor = Color.Bisque;
            btnDernier.Location = new Point(332, 175);
            btnDernier.Name = "btnDernier";
            btnDernier.Size = new Size(100, 36);
            btnDernier.TabIndex = 18;
            btnDernier.Text = "Dernier";
            btnDernier.UseVisualStyleBackColor = false;
            btnDernier.Click += btnDernier_Click;
            // 
            // btnSuivant
            // 
            btnSuivant.BackColor = Color.Black;
            btnSuivant.ForeColor = Color.Bisque;
            btnSuivant.Location = new Point(232, 175);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(100, 36);
            btnSuivant.TabIndex = 17;
            btnSuivant.Text = "Suivant";
            btnSuivant.UseVisualStyleBackColor = false;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // btnPremier
            // 
            btnPremier.BackColor = Color.Black;
            btnPremier.ForeColor = Color.Bisque;
            btnPremier.Location = new Point(23, 175);
            btnPremier.Name = "btnPremier";
            btnPremier.Size = new Size(100, 36);
            btnPremier.TabIndex = 16;
            btnPremier.Text = "Premier";
            btnPremier.UseVisualStyleBackColor = false;
            btnPremier.Click += btnPremier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.SaddleBrown;
            btnAjouter.ForeColor = Color.Bisque;
            btnAjouter.Location = new Point(448, 23);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(100, 36);
            btnAjouter.TabIndex = 15;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.SaddleBrown;
            btnAnnuler.ForeColor = Color.Bisque;
            btnAnnuler.Location = new Point(448, 175);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(100, 36);
            btnAnnuler.TabIndex = 14;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.SaddleBrown;
            btnSupprimer.ForeColor = Color.Bisque;
            btnSupprimer.Location = new Point(448, 99);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(100, 36);
            btnSupprimer.TabIndex = 13;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.SaddleBrown;
            btnModifier.ForeColor = Color.Bisque;
            btnModifier.Location = new Point(448, 61);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(100, 36);
            btnModifier.TabIndex = 12;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.BackColor = Color.SaddleBrown;
            btnSauvegarder.ForeColor = Color.Bisque;
            btnSauvegarder.Location = new Point(448, 137);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(100, 36);
            btnSauvegarder.TabIndex = 10;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = false;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(139, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(207, 25);
            txtNumero.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 38);
            label7.Name = "label7";
            label7.Size = new Size(110, 17);
            label7.TabIndex = 8;
            label7.Text = "Numéro étudiant:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 132);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 6;
            label6.Text = "/100";
            // 
            // txtNoteFinale
            // 
            txtNoteFinale.Location = new Point(139, 126);
            txtNoteFinale.Name = "txtNoteFinale";
            txtNoteFinale.Size = new Size(100, 25);
            txtNoteFinale.TabIndex = 5;
            // 
            // txtNomPrenom
            // 
            txtNomPrenom.Location = new Point(139, 62);
            txtNomPrenom.Name = "txtNomPrenom";
            txtNomPrenom.Size = new Size(207, 25);
            txtNomPrenom.TabIndex = 4;
            // 
            // datNaissance
            // 
            datNaissance.Location = new Point(139, 95);
            datNaissance.Name = "datNaissance";
            datNaissance.Size = new Size(207, 25);
            datNaissance.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 132);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 2;
            label5.Text = "Note finale : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 101);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 1;
            label4.Text = "Date naissance : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 0;
            label1.Text = "Prenom Nom : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lblInfoEtudiant);
            groupBox2.Controls.Add(lstNumero);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(41, 448);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 261);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche et Affichage d'un étudiant dans la collection";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 21);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 10;
            label8.Text = "Choisir un numéro";
            // 
            // lblInfoEtudiant
            // 
            lblInfoEtudiant.ForeColor = Color.Black;
            lblInfoEtudiant.Location = new Point(268, 47);
            lblInfoEtudiant.Name = "lblInfoEtudiant";
            lblInfoEtudiant.Size = new Size(280, 144);
            lblInfoEtudiant.TabIndex = 9;
            lblInfoEtudiant.Text = "Information";
            // 
            // lstNumero
            // 
            lstNumero.BackColor = Color.White;
            lstNumero.ForeColor = Color.Blue;
            lstNumero.FormattingEnabled = true;
            lstNumero.Location = new Point(35, 47);
            lstNumero.Name = "lstNumero";
            lstNumero.Size = new Size(175, 89);
            lstNumero.TabIndex = 8;
            lstNumero.SelectedIndexChanged += lstNumero_SelectedIndexChanged;
            // 
            // frmStructCollectionFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(703, 732);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            ForeColor = Color.Bisque;
            Name = "frmStructCollectionFile";
            Text = "frmStructCollectionFile";
            FormClosing += frmStructCollectionFile_FormClosing;
            Load += frmStructCollectionFile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtNoteFinale;
        private TextBox txtNomPrenom;
        private DateTimePicker datNaissance;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnSauvegarder;
        private TextBox txtNumero;
        private Label label7;
        private Button btnAjouter;
        private Button btnAnnuler;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnPrecedent;
        private Button btnDernier;
        private Button btnSuivant;
        private Button btnPremier;
        private Label lblInformation;
        private GroupBox groupBox2;
        private Label lblInfoEtudiant;
        private ListBox lstNumero;
        private Label label8;
    }
}