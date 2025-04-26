namespace Exersare_6
{
    partial class Form2
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
            citireToolStripMenuItem = new ToolStripMenuItem();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            adaugarePersonalizataToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { citireToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // citireToolStripMenuItem
            // 
            citireToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, adaugarePersonalizataToolStripMenuItem });
            citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            citireToolStripMenuItem.Size = new Size(90, 38);
            citireToolStripMenuItem.Text = "Citire";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(394, 44);
            fisierToolStripMenuItem.Text = "Fisier";
            fisierToolStripMenuItem.Click += fisierToolStripMenuItem_Click;
            // 
            // adaugarePersonalizataToolStripMenuItem
            // 
            adaugarePersonalizataToolStripMenuItem.Name = "adaugarePersonalizataToolStripMenuItem";
            adaugarePersonalizataToolStripMenuItem.Size = new Size(394, 44);
            adaugarePersonalizataToolStripMenuItem.Text = "Adaugare Personalizata";
            adaugarePersonalizataToolStripMenuItem.Click += adaugarePersonalizataToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem citireToolStripMenuItem;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem adaugarePersonalizataToolStripMenuItem;
    }
}