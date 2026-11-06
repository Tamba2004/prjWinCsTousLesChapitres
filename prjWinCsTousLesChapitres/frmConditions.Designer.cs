namespace prjWinCsTousLesChapitres
{
    partial class frmConditions
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
            btnEffacer = new Button();
            btnEvaluer = new Button();
            radConfidentiel = new RadioButton();
            radFemme = new RadioButton();
            radHomme = new RadioButton();
            txtNote = new TextBox();
            txtNom = new TextBox();
            lblResultat = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(438, 37);
            label1.TabIndex = 0;
            label1.Text = "STRUCTURES CONTIDIONNELLES";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(btnEffacer);
            groupBox1.Controls.Add(btnEvaluer);
            groupBox1.Controls.Add(radConfidentiel);
            groupBox1.Controls.Add(radFemme);
            groupBox1.Controls.Add(radHomme);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(lblResultat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 386);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations Etudiant";
            // 
            // btnEffacer
            // 
            btnEffacer.BackColor = Color.Silver;
            btnEffacer.Location = new Point(303, 223);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(153, 29);
            btnEffacer.TabIndex = 11;
            btnEffacer.Text = "Recommencer";
            btnEffacer.UseVisualStyleBackColor = false;
            // 
            // btnEvaluer
            // 
            btnEvaluer.BackColor = Color.Silver;
            btnEvaluer.Location = new Point(111, 223);
            btnEvaluer.Name = "btnEvaluer";
            btnEvaluer.Size = new Size(153, 29);
            btnEvaluer.TabIndex = 10;
            btnEvaluer.Text = "Evaluer";
            btnEvaluer.UseVisualStyleBackColor = false;
            btnEvaluer.Click += btnEvaluer_Click;
            // 
            // radConfidentiel
            // 
            radConfidentiel.AutoSize = true;
            radConfidentiel.Location = new Point(206, 122);
            radConfidentiel.Name = "radConfidentiel";
            radConfidentiel.Size = new Size(102, 21);
            radConfidentiel.TabIndex = 9;
            radConfidentiel.TabStop = true;
            radConfidentiel.Text = "Confidentiel";
            radConfidentiel.UseVisualStyleBackColor = true;
            // 
            // radFemme
            // 
            radFemme.AutoSize = true;
            radFemme.Location = new Point(206, 95);
            radFemme.Name = "radFemme";
            radFemme.Size = new Size(71, 21);
            radFemme.TabIndex = 8;
            radFemme.TabStop = true;
            radFemme.Text = "Femme";
            radFemme.UseVisualStyleBackColor = true;
            // 
            // radHomme
            // 
            radHomme.AutoSize = true;
            radHomme.Location = new Point(208, 68);
            radHomme.Name = "radHomme";
            radHomme.Size = new Size(75, 21);
            radHomme.TabIndex = 7;
            radHomme.TabStop = true;
            radHomme.Text = "Homme";
            radHomme.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(206, 169);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(82, 25);
            txtNote.TabIndex = 6;
            // 
            // txtNom
            // 
            txtNom.ForeColor = Color.Blue;
            txtNom.Location = new Point(206, 34);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(321, 25);
            txtNom.TabIndex = 5;
            // 
            // lblResultat
            // 
            lblResultat.BackColor = Color.FromArgb(128, 128, 255);
            lblResultat.ForeColor = Color.White;
            lblResultat.Location = new Point(37, 276);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(490, 85);
            lblResultat.TabIndex = 4;
            lblResultat.Text = "HJHJ";
            lblResultat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 172);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 3;
            label5.Text = "/100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 172);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 2;
            label4.Text = "Entrez Note:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 67);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 1;
            label3.Text = "Choisir Genre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 37);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 0;
            label2.Text = "Nom Complet:";
            // 
            // frmConditions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmConditions";
            Text = "frmConditions";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblResultat;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radConfidentiel;
        private RadioButton radFemme;
        private RadioButton radHomme;
        private TextBox txtNote;
        private TextBox txtNom;
        private Button btnEffacer;
        private Button btnEvaluer;
    }
}