
namespace Seance0422
{
    partial class Form1
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
            this.HeaderMnStp = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesStagairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesStagiairesParModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderMnStp.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderMnStp
            // 
            this.HeaderMnStp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.stagiaireToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.HeaderMnStp.Location = new System.Drawing.Point(0, 0);
            this.HeaderMnStp.Name = "HeaderMnStp";
            this.HeaderMnStp.Size = new System.Drawing.Size(800, 24);
            this.HeaderMnStp.TabIndex = 0;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // stagiaireToolStripMenuItem
            // 
            this.stagiaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.suprimerToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.stagiaireToolStripMenuItem.Name = "stagiaireToolStripMenuItem";
            this.stagiaireToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.stagiaireToolStripMenuItem.Text = "Stagiaire";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesStagairesToolStripMenuItem,
            this.listeDesStagiairesParModuleToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // listeDesStagairesToolStripMenuItem
            // 
            this.listeDesStagairesToolStripMenuItem.Name = "listeDesStagairesToolStripMenuItem";
            this.listeDesStagairesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listeDesStagairesToolStripMenuItem.Text = "Liste des Stagaires";
            // 
            // listeDesStagiairesParModuleToolStripMenuItem
            // 
            this.listeDesStagiairesParModuleToolStripMenuItem.Name = "listeDesStagiairesParModuleToolStripMenuItem";
            this.listeDesStagiairesParModuleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listeDesStagiairesParModuleToolStripMenuItem.Text = "Liste des Stagiaires par Module";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeaderMnStp);
            this.MainMenuStrip = this.HeaderMnStp;
            this.Name = "Form1";
            this.Text = "Application GSTAG";
            this.HeaderMnStp.ResumeLayout(false);
            this.HeaderMnStp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HeaderMnStp;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesStagairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesStagiairesParModuleToolStripMenuItem;
    }
}

