namespace prjWinCsTousLesChapitres
{
    partial class frmRepetitions
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
            btnDoWhile = new Button();
            btnWhile = new Button();
            btnFor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            txtIntervalle = new TextBox();
            lstIncrement = new ListBox();
            SuspendLayout();
            // 
            // btnDoWhile
            // 
            btnDoWhile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDoWhile.Location = new Point(20, 178);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(109, 26);
            btnDoWhile.TabIndex = 0;
            btnDoWhile.Text = "Do - While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnWhile
            // 
            btnWhile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnWhile.Location = new Point(20, 238);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(109, 26);
            btnWhile.TabIndex = 1;
            btnWhile.Text = "While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnFor
            // 
            btnFor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFor.Location = new Point(20, 295);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(109, 26);
            btnFor.TabIndex = 2;
            btnFor.Text = "For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 27);
            label1.Name = "label1";
            label1.Size = new Size(273, 30);
            label1.TabIndex = 3;
            label1.Text = "STRUCTURES REPETITIVES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(20, 98);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 4;
            label2.Text = "Début : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(131, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 5;
            label3.Text = "Fin : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(218, 98);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 6;
            label4.Text = "Intervalle : ";
            // 
            // txtDebut
            // 
            txtDebut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtDebut.Location = new Point(76, 94);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(37, 25);
            txtDebut.TabIndex = 7;
            // 
            // txtFin
            // 
            txtFin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtFin.Location = new Point(169, 94);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(37, 25);
            txtFin.TabIndex = 8;
            // 
            // txtIntervalle
            // 
            txtIntervalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtIntervalle.Location = new Point(303, 94);
            txtIntervalle.Name = "txtIntervalle";
            txtIntervalle.Size = new Size(37, 25);
            txtIntervalle.TabIndex = 9;
            // 
            // lstIncrement
            // 
            lstIncrement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstIncrement.FormattingEnabled = true;
            lstIncrement.Location = new Point(173, 178);
            lstIncrement.Name = "lstIncrement";
            lstIncrement.Size = new Size(167, 199);
            lstIncrement.TabIndex = 10;
            // 
            // frmRepetitions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 427);
            Controls.Add(lstIncrement);
            Controls.Add(txtIntervalle);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFor);
            Controls.Add(btnWhile);
            Controls.Add(btnDoWhile);
            Name = "frmRepetitions";
            Text = "frmRepetitions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoWhile;
        private Button btnWhile;
        private Button btnFor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDebut;
        private TextBox txtFin;
        private TextBox txtIntervalle;
        private ListBox lstIncrement;
    }
}