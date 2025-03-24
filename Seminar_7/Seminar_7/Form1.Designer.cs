namespace Seminar_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            deschideToolStripMenuItem = new ToolStripMenuItem();
            anuleazaToolStripMenuItem = new ToolStripMenuItem();
            ferestreToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            adaugareToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, ferestreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deschideToolStripMenuItem, anuleazaToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(89, 38);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // deschideToolStripMenuItem
            // 
            deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            deschideToolStripMenuItem.Size = new Size(359, 44);
            deschideToolStripMenuItem.Text = "Deschide";
            deschideToolStripMenuItem.Click += deschideToolStripMenuItem_Click;
            // 
            // anuleazaToolStripMenuItem
            // 
            anuleazaToolStripMenuItem.Name = "anuleazaToolStripMenuItem";
            anuleazaToolStripMenuItem.Size = new Size(359, 44);
            anuleazaToolStripMenuItem.Text = "Anuleaza";
            // 
            // ferestreToolStripMenuItem
            // 
            ferestreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem, adaugareToolStripMenuItem });
            ferestreToolStripMenuItem.Name = "ferestreToolStripMenuItem";
            ferestreToolStripMenuItem.Size = new Size(119, 38);
            ferestreToolStripMenuItem.Text = "Ferestre";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(359, 44);
            listaToolStripMenuItem.Text = "Lista";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // adaugareToolStripMenuItem
            // 
            adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            adaugareToolStripMenuItem.Size = new Size(359, 44);
            adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 665);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Persoane";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem deschideToolStripMenuItem;
        private ToolStripMenuItem anuleazaToolStripMenuItem;
        private ToolStripMenuItem ferestreToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem adaugareToolStripMenuItem;
    }
}
