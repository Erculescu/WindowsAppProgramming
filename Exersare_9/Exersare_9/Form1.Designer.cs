namespace Exersare_9
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCost = new Button();
            btnAdauga = new Button();
            btnAnuleaza = new Button();
            listBox1 = new ListBox();
            txtAdresa = new TextBox();
            sosAlb = new RadioButton();
            sosRosiiD = new RadioButton();
            sosRosiiP = new RadioButton();
            menuStrip1 = new MenuStrip();
            generareToolStripMenuItem = new ToolStripMenuItem();
            generareRaportClientiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduceti comanda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 138);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 1;
            label2.Text = "Tip Pizza:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 195);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 2;
            label3.Text = "Adresa:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 248);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 3;
            label4.Text = "Sos:";
            // 
            // btnCost
            // 
            btnCost.Location = new Point(51, 360);
            btnCost.Name = "btnCost";
            btnCost.Size = new Size(201, 46);
            btnCost.TabIndex = 4;
            btnCost.Text = "Calculeaza Cost";
            btnCost.UseVisualStyleBackColor = true;
            btnCost.Click += btnCost_Click;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(307, 360);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 5;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnAnuleaza
            // 
            btnAnuleaza.Location = new Point(522, 360);
            btnAnuleaza.Name = "btnAnuleaza";
            btnAnuleaza.Size = new Size(150, 46);
            btnAnuleaza.TabIndex = 6;
            btnAnuleaza.Text = "Anuleaza";
            btnAnuleaza.UseVisualStyleBackColor = true;
            btnAnuleaza.Click += btnAnuleaza_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Diavola", "Quattro Stagioni", "Carnivora", "Hawaian" });
            listBox1.Location = new Point(205, 141);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(467, 36);
            listBox1.TabIndex = 7;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(205, 194);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(467, 39);
            txtAdresa.TabIndex = 8;
            // 
            // sosAlb
            // 
            sosAlb.AutoSize = true;
            sosAlb.Location = new Point(206, 253);
            sosAlb.Name = "sosAlb";
            sosAlb.Size = new Size(80, 36);
            sosAlb.TabIndex = 9;
            sosAlb.TabStop = true;
            sosAlb.Text = "Alb";
            sosAlb.UseVisualStyleBackColor = true;
            // 
            // sosRosiiD
            // 
            sosRosiiD.AutoSize = true;
            sosRosiiD.Location = new Point(338, 253);
            sosRosiiD.Name = "sosRosiiD";
            sosRosiiD.Size = new Size(162, 36);
            sosRosiiD.TabIndex = 10;
            sosRosiiD.TabStop = true;
            sosRosiiD.Text = "Rosii Dulce";
            sosRosiiD.UseVisualStyleBackColor = true;
            // 
            // sosRosiiP
            // 
            sosRosiiP.AutoSize = true;
            sosRosiiP.Location = new Point(522, 253);
            sosRosiiP.Name = "sosRosiiP";
            sosRosiiP.Size = new Size(165, 36);
            sosRosiiP.TabIndex = 11;
            sosRosiiP.TabStop = true;
            sosRosiiP.Text = "Rosii Picant";
            sosRosiiP.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { generareToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // generareToolStripMenuItem
            // 
            generareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generareRaportClientiToolStripMenuItem });
            generareToolStripMenuItem.Name = "generareToolStripMenuItem";
            generareToolStripMenuItem.Size = new Size(131, 38);
            generareToolStripMenuItem.Text = "Generare";
            // 
            // generareRaportClientiToolStripMenuItem
            // 
            generareRaportClientiToolStripMenuItem.Name = "generareRaportClientiToolStripMenuItem";
            generareRaportClientiToolStripMenuItem.Size = new Size(396, 44);
            generareRaportClientiToolStripMenuItem.Text = "Generare Raport Clienti";
            generareRaportClientiToolStripMenuItem.Click += generareRaportClientiToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sosRosiiP);
            Controls.Add(sosRosiiD);
            Controls.Add(sosAlb);
            Controls.Add(txtAdresa);
            Controls.Add(listBox1);
            Controls.Add(btnAnuleaza);
            Controls.Add(btnAdauga);
            Controls.Add(btnCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCost;
        private Button btnAdauga;
        private Button btnAnuleaza;
        private ListBox listBox1;
        private TextBox txtAdresa;
        private RadioButton sosAlb;
        private RadioButton sosRosiiD;
        private RadioButton sosRosiiP;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem generareToolStripMenuItem;
        private ToolStripMenuItem generareRaportClientiToolStripMenuItem;
    }
}
