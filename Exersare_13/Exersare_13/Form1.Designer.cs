namespace Exersare_13
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
            listView2 = new ListView();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            previewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(56, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(579, 654);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(734, 73);
            listView2.Name = "listView2";
            listView2.Size = new Size(639, 654);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1501, 135);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1524, 73);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 3;
            label1.Text = "ValoareTotala";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { previewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1950, 42);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // previewToolStripMenuItem
            // 
            previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            previewToolStripMenuItem.Size = new Size(116, 38);
            previewToolStripMenuItem.Text = "Preview";
            previewToolStripMenuItem.Click += previewToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1950, 1010);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listView2);
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
        private ListView listView2;
        private TextBox textBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem previewToolStripMenuItem;
    }
}
