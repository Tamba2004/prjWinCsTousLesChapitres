namespace prjWinCsTousLesChapitres
{
    partial class frmPrincipale
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
            menuStrip1 = new MenuStrip();
            demarrerToolStripMenuItem = new ToolStripMenuItem();
            chapitresToolStripMenuItem = new ToolStripMenuItem();
            mnuConditions = new ToolStripMenuItem();
            mnuRepetitions = new ToolStripMenuItem();
            mnuStructures = new ToolStripMenuItem();
            mnuCollections = new ToolStripMenuItem();
            mnuFonction = new ToolStripMenuItem();
            projetsToolStripMenuItem = new ToolStripMenuItem();
            mnuVideo = new ToolStripMenuItem();
            mnuCarnet = new ToolStripMenuItem();
            mnuMcDo = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuQuitter = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            mnuApropos = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { demarrerToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // demarrerToolStripMenuItem
            // 
            demarrerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chapitresToolStripMenuItem, projetsToolStripMenuItem, toolStripSeparator1, mnuQuitter });
            demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            demarrerToolStripMenuItem.Size = new Size(87, 23);
            demarrerToolStripMenuItem.Text = "Demarrer";
            // 
            // chapitresToolStripMenuItem
            // 
            chapitresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuConditions, mnuRepetitions, mnuStructures, mnuCollections, mnuFonction });
            chapitresToolStripMenuItem.Name = "chapitresToolStripMenuItem";
            chapitresToolStripMenuItem.Size = new Size(180, 24);
            chapitresToolStripMenuItem.Text = "Chapitres";
            // 
            // mnuConditions
            // 
            mnuConditions.Name = "mnuConditions";
            mnuConditions.Size = new Size(180, 24);
            mnuConditions.Text = "Conditions";
            mnuConditions.Click += mnuConditions_Click;
            // 
            // mnuRepetitions
            // 
            mnuRepetitions.Name = "mnuRepetitions";
            mnuRepetitions.Size = new Size(180, 24);
            mnuRepetitions.Text = "Repétitions";
            // 
            // mnuStructures
            // 
            mnuStructures.Name = "mnuStructures";
            mnuStructures.Size = new Size(180, 24);
            mnuStructures.Text = "Structures";
            // 
            // mnuCollections
            // 
            mnuCollections.Name = "mnuCollections";
            mnuCollections.Size = new Size(180, 24);
            mnuCollections.Text = "Collections";
            mnuCollections.Click += connexionsToolStripMenuItem_Click;
            // 
            // mnuFonction
            // 
            mnuFonction.Name = "mnuFonction";
            mnuFonction.Size = new Size(180, 24);
            mnuFonction.Text = "Fonction";
            // 
            // projetsToolStripMenuItem
            // 
            projetsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuVideo, mnuCarnet, mnuMcDo });
            projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            projetsToolStripMenuItem.Size = new Size(180, 24);
            projetsToolStripMenuItem.Text = "Projets";
            // 
            // mnuVideo
            // 
            mnuVideo.Name = "mnuVideo";
            mnuVideo.Size = new Size(187, 24);
            mnuVideo.Text = "Videothèque";
            mnuVideo.Click += mnuVideo_Click;
            // 
            // mnuCarnet
            // 
            mnuCarnet.Name = "mnuCarnet";
            mnuCarnet.Size = new Size(187, 24);
            mnuCarnet.Text = "Carnet adresses";
            // 
            // mnuMcDo
            // 
            mnuMcDo.Name = "mnuMcDo";
            mnuMcDo.Size = new Size(187, 24);
            mnuMcDo.Text = "Mc-Donald shift";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnuQuitter
            // 
            mnuQuitter.Name = "mnuQuitter";
            mnuQuitter.ShortcutKeys = Keys.Alt | Keys.X;
            mnuQuitter.Size = new Size(180, 24);
            mnuQuitter.Text = "Quitter";
            mnuQuitter.Click += mnuQuitter_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuApropos });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(52, 23);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // mnuApropos
            // 
            mnuApropos.Name = "mnuApropos";
            mnuApropos.Size = new Size(137, 24);
            mnuApropos.Text = "A propos";
            // 
            // frmPrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipale";
            Text = "Collège Lasalle 420-CT2-AS Concepts de la program. O. O. ";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem demarrerToolStripMenuItem;
        private ToolStripMenuItem chapitresToolStripMenuItem;
        private ToolStripMenuItem mnuConditions;
        private ToolStripMenuItem mnuRepetitions;
        private ToolStripMenuItem mnuStructures;
        private ToolStripMenuItem mnuFonction;
        private ToolStripMenuItem mnuCollections;
        private ToolStripMenuItem projetsToolStripMenuItem;
        private ToolStripMenuItem mnuVideo;
        private ToolStripMenuItem mnuCarnet;
        private ToolStripMenuItem mnuMcDo;
        private ToolStripMenuItem mnuQuitter;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem mnuApropos;
        private ToolStripSeparator toolStripSeparator1;
    }
}