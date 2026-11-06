namespace prjWinCsTousLesChapitres
{
    partial class frmTableau
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnAjouter = new Button();
            label6 = new Label();
            txtNoteFinale = new TextBox();
            txtNomPrenom = new TextBox();
            datNaissance = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lstResultat = new ListBox();
            btnAfficher = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 48);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "COLLEGE LASALLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 100);
            label2.Name = "label2";
            label2.Size = new Size(415, 32);
            label2.TabIndex = 1;
            label2.Text = "Gestion Etudiant (Tableau Max. 25)";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(btnAjouter);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNoteFinale);
            groupBox1.Controls.Add(txtNomPrenom);
            groupBox1.Controls.Add(datNaissance);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(80, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 186);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saisie des étudiants dans 3 tableaux";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Blue;
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(68, 136);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(284, 33);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter cet étudiant dans les 3 tableaux";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 100);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 6;
            label6.Text = "/100";
            // 
            // txtNoteFinale
            // 
            txtNoteFinale.Location = new Point(126, 94);
            txtNoteFinale.Name = "txtNoteFinale";
            txtNoteFinale.Size = new Size(100, 25);
            txtNoteFinale.TabIndex = 5;
            // 
            // txtNomPrenom
            // 
            txtNomPrenom.Location = new Point(126, 30);
            txtNomPrenom.Name = "txtNomPrenom";
            txtNomPrenom.Size = new Size(100, 25);
            txtNomPrenom.TabIndex = 4;
            // 
            // datNaissance
            // 
            datNaissance.Location = new Point(126, 63);
            datNaissance.Name = "datNaissance";
            datNaissance.Size = new Size(207, 25);
            datNaissance.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 100);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 2;
            label5.Text = "Note finale : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 69);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 1;
            label4.Text = "Date naissance : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 38);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 0;
            label3.Text = "Prenom Nom : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(lstResultat);
            groupBox2.Controls.Add(btnAfficher);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(80, 381);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 186);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Affichage du contenu des 3 tableaux et plus";
            // 
            // lstResultat
            // 
            lstResultat.BackColor = Color.Blue;
            lstResultat.FormattingEnabled = true;
            lstResultat.Location = new Point(63, 40);
            lstResultat.Name = "lstResultat";
            lstResultat.Size = new Size(297, 89);
            lstResultat.TabIndex = 8;
            // 
            // btnAfficher
            // 
            btnAfficher.BackColor = Color.Red;
            btnAfficher.ForeColor = Color.White;
            btnAfficher.Location = new Point(68, 142);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(284, 33);
            btnAfficher.TabIndex = 7;
            btnAfficher.Text = "Afficher les informations des 3 tableaux ";
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // frmTableau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(564, 597);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "frmTableau";
            Text = "frmTableau";
            Load += frmTableau_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAjouter;
        private Label label6;
        private TextBox txtNoteFinale;
        private TextBox txtNomPrenom;
        private DateTimePicker datNaissance;
        private GroupBox groupBox2;
        private Button btnAfficher;
        private ListBox lstResultat;
    }
}