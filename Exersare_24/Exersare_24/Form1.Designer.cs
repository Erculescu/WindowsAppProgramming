﻿namespace Exersare_24
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
            listView1 = new ListView();
            menuStrip1 = new MenuStrip();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            exportaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(63, 88);
            listView1.Name = "listView1";
            listView1.Size = new Size(716, 621);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, exportaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1455, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(115, 36);
            adaugaToolStripMenuItem.Text = "Adauga";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click;
            // 
            // exportaToolStripMenuItem
            // 
            exportaToolStripMenuItem.Name = "exportaToolStripMenuItem";
            exportaToolStripMenuItem.Size = new Size(113, 36);
            exportaToolStripMenuItem.Text = "Exporta";
            exportaToolStripMenuItem.Click += exportaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 746);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 800);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem exportaToolStripMenuItem;
    }
}
