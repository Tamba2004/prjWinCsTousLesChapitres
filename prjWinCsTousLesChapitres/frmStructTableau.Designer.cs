namespace prjWinCsTousLesChapitres
{
    partial class frmStructTableau
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
            groupBox2 = new GroupBox();
            lstResultat = new ListBox();
            btnAfficher = new Button();
            groupBox1 = new GroupBox();
            btnAjouter = new Button();
            label6 = new Label();
            txtNoteFinale = new TextBox();
            txtNomPrenom = new TextBox();
            datNaissance = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(lstResultat);
            groupBox2.Controls.Add(btnAfficher);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(59, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 186);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Affichage du contenu du tableau et plus";
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
            btnAfficher.Text = "Afficher les informations du tableau de struct";
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Click += btnAfficher_Click;
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
            groupBox1.Location = new Point(59, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 186);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saisie des étudiants dans 1 tableau de struct";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Blue;
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(68, 136);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(284, 33);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter cet étudiant dans le tableau";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 58);
            label2.Name = "label2";
            label2.Size = new Size(489, 32);
            label2.TabIndex = 12;
            label2.Text = "Gestion Etudiant (Tableau Struct Max. 25)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 11;
            label1.Text = "COLLEGE LASALLE";
            // 
            // frmStructTableau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 514);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmStructTableau";
            Text = "frmStructTableau";
            Load += frmStructTableau_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox lstResultat;
        private Button btnAfficher;
        private GroupBox groupBox1;
        private Button btnAjouter;
        private Label label6;
        private TextBox txtNoteFinale;
        private TextBox txtNomPrenom;
        private DateTimePicker datNaissance;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}