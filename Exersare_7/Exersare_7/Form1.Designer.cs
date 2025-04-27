namespace Exersare_7
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
            textBox1 = new TextBox();
            btnAdauga = new Button();
            btnStergere = new Button();
            btnAnulare = new Button();
            menuStrip1 = new MenuStrip();
            stocuriToolStripMenuItem = new ToolStripMenuItem();
            generareRaportStocuriToolStripMenuItem = new ToolStripMenuItem();
            generareRepartitieTransportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(255, 63);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 0;
            label1.Text = "Adaugati un produs nou:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 110);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(759, 247);
            textBox1.TabIndex = 1;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(61, 369);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 2;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnStergere
            // 
            btnStergere.Location = new Point(334, 369);
            btnStergere.Name = "btnStergere";
            btnStergere.Size = new Size(150, 46);
            btnStergere.TabIndex = 3;
            btnStergere.Text = "Sterge";
            btnStergere.UseVisualStyleBackColor = true;
            btnStergere.Click += btnStergere_Click;
            // 
            // btnAnulare
            // 
            btnAnulare.Location = new Point(592, 369);
            btnAnulare.Name = "btnAnulare";
            btnAnulare.Size = new Size(150, 46);
            btnAnulare.TabIndex = 4;
            btnAnulare.Text = "Anuleaza";
            btnAnulare.UseVisualStyleBackColor = true;
            btnAnulare.Click += btnAnulare_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stocuriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // stocuriToolStripMenuItem
            // 
            stocuriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generareRaportStocuriToolStripMenuItem, generareRepartitieTransportToolStripMenuItem });
            stocuriToolStripMenuItem.Name = "stocuriToolStripMenuItem";
            stocuriToolStripMenuItem.Size = new Size(107, 38);
            stocuriToolStripMenuItem.Text = "Stocuri";
            // 
            // generareRaportStocuriToolStripMenuItem
            // 
            generareRaportStocuriToolStripMenuItem.Name = "generareRaportStocuriToolStripMenuItem";
            generareRaportStocuriToolStripMenuItem.Size = new Size(458, 44);
            generareRaportStocuriToolStripMenuItem.Text = "Generare Raport Stocuri";
            generareRaportStocuriToolStripMenuItem.Click += generareRaportStocuriToolStripMenuItem_Click;
            // 
            // generareRepartitieTransportToolStripMenuItem
            // 
            generareRepartitieTransportToolStripMenuItem.Name = "generareRepartitieTransportToolStripMenuItem";
            generareRepartitieTransportToolStripMenuItem.Size = new Size(458, 44);
            generareRepartitieTransportToolStripMenuItem.Text = "Generare Repartitie Transport";
            generareRepartitieTransportToolStripMenuItem.Click += generareRepartitieTransportToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnulare);
            Controls.Add(btnStergere);
            Controls.Add(btnAdauga);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button btnAdauga;
        private Button btnStergere;
        private Button btnAnulare;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stocuriToolStripMenuItem;
        private ToolStripMenuItem generareRaportStocuriToolStripMenuItem;
        private ToolStripMenuItem generareRepartitieTransportToolStripMenuItem;
    }
}
