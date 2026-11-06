namespace prjWinCsTousLesChapitres
{
    partial class frmCarnet
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
            label3 = new Label();
            txtNomPrenom = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAdresse = new TextBox();
            txtLoocalisation = new TextBox();
            btnSauvegarder = new Button();
            lblPrenom = new Label();
            lblNom = new Label();
            lblVille = new Label();
            lblProvince = new Label();
            lblCodeP = new Label();
            groupBox1 = new GroupBox();
            lblNumero = new Label();
            lblRue = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 42);
            label1.Name = "label1";
            label1.Size = new Size(552, 32);
            label1.TabIndex = 1;
            label1.Text = "LES FONCTIONS DE TRAITEMENT DES CHAINES\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 75);
            label2.Name = "label2";
            label2.Size = new Size(197, 42);
            label2.TabIndex = 2;
            label2.Text = "Carnet Adresse Des Amis\n\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 3;
            label3.Text = "Nom, Prenom\n";
            // 
            // txtNomPrenom
            // 
            txtNomPrenom.Location = new Point(74, 42);
            txtNomPrenom.Name = "txtNomPrenom";
            txtNomPrenom.Size = new Size(439, 23);
            txtNomPrenom.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 82);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 5;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 163);
            label5.Name = "label5";
            label5.Size = new Size(178, 17);
            label5.TabIndex = 6;
            label5.Text = "Ville, Province, Code Postal\n";
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(74, 119);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(439, 23);
            txtAdresse.TabIndex = 7;
            // 
            // txtLoocalisation
            // 
            txtLoocalisation.Location = new Point(74, 197);
            txtLoocalisation.Name = "txtLoocalisation";
            txtLoocalisation.Size = new Size(439, 23);
            txtLoocalisation.TabIndex = 8;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.Location = new Point(227, 242);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(122, 28);
            btnSauvegarder.TabIndex = 9;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = true;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // lblPrenom
            // 
            lblPrenom.BackColor = SystemColors.AppWorkspace;
            lblPrenom.BorderStyle = BorderStyle.FixedSingle;
            lblPrenom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrenom.ForeColor = Color.Red;
            lblPrenom.Location = new Point(74, 283);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(178, 27);
            lblPrenom.TabIndex = 10;
            // 
            // lblNom
            // 
            lblNom.BackColor = SystemColors.AppWorkspace;
            lblNom.BorderStyle = BorderStyle.FixedSingle;
            lblNom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNom.ForeColor = Color.Red;
            lblNom.Location = new Point(340, 283);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(173, 27);
            lblNom.TabIndex = 11;
            // 
            // lblVille
            // 
            lblVille.BackColor = SystemColors.AppWorkspace;
            lblVille.BorderStyle = BorderStyle.FixedSingle;
            lblVille.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVille.ForeColor = Color.Red;
            lblVille.Location = new Point(108, 505);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(72, 27);
            lblVille.TabIndex = 12;
            // 
            // lblProvince
            // 
            lblProvince.BackColor = SystemColors.AppWorkspace;
            lblProvince.BorderStyle = BorderStyle.FixedSingle;
            lblProvince.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProvince.ForeColor = Color.Red;
            lblProvince.Location = new Point(240, 505);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(72, 27);
            lblProvince.TabIndex = 13;
            // 
            // lblCodeP
            // 
            lblCodeP.BackColor = SystemColors.AppWorkspace;
            lblCodeP.BorderStyle = BorderStyle.FixedSingle;
            lblCodeP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodeP.ForeColor = Color.Red;
            lblCodeP.Location = new Point(387, 505);
            lblCodeP.Name = "lblCodeP";
            lblCodeP.Size = new Size(72, 27);
            lblCodeP.TabIndex = 14;
            lblCodeP.Click += lblCodeP_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(lblNumero);
            groupBox1.Controls.Add(lblRue);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSauvegarder);
            groupBox1.Controls.Add(lblPrenom);
            groupBox1.Controls.Add(txtNomPrenom);
            groupBox1.Controls.Add(txtAdresse);
            groupBox1.Controls.Add(txtLoocalisation);
            groupBox1.Controls.Add(lblNom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(34, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 425);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // lblNumero
            // 
            lblNumero.BackColor = SystemColors.AppWorkspace;
            lblNumero.BorderStyle = BorderStyle.FixedSingle;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.Red;
            lblNumero.Location = new Point(74, 339);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(72, 27);
            lblNumero.TabIndex = 16;
            // 
            // lblRue
            // 
            lblRue.BackColor = SystemColors.AppWorkspace;
            lblRue.BorderStyle = BorderStyle.FixedSingle;
            lblRue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRue.ForeColor = Color.Red;
            lblRue.Location = new Point(244, 330);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(269, 27);
            lblRue.TabIndex = 17;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(627, 160);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(627, 185);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(638, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 591);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblCodeP);
            Controls.Add(lblProvince);
            Controls.Add(lblVille);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmCarnet";
            Text = "frmCarnet";
            Load += frmCarnet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomPrenom;
        private Label label4;
        private Label label5;
        private TextBox txtAdresse;
        private TextBox txtLoocalisation;
        private Button btnSauvegarder;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblVille;
        private Label lblProvince;
        private Label lblCodeP;
        private GroupBox groupBox1;
        private Label lblNumero;
        private Label lblRue;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}