namespace prjWinCsTousLesChapitres
{
    partial class frmMacdoShift
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
            lblResultat = new Label();
            SuspendLayout();
            // 
            // lblResultat
            // 
            lblResultat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultat.ForeColor = Color.Red;
            lblResultat.Location = new Point(102, 77);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(148, 36);
            lblResultat.TabIndex = 0;
            // 
            // frmMacdoShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 200);
            Controls.Add(lblResultat);
            Name = "frmMacdoShift";
            Text = "frmMacdoShift";
            Load += frmMacdoShift_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResultat;
    }
}