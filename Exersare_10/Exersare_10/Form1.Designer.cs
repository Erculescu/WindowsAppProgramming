namespace Exersare_10
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            IdCamera = new DataGridViewTextBoxColumn();
            Denumire = new DataGridViewTextBoxColumn();
            Pret = new DataGridViewTextBoxColumn();
            Cantitate = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            exportaToolStripMenuItem = new ToolStripMenuItem();
            importaToolStripMenuItem = new ToolStripMenuItem();
            printareToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1784, 961);
            splitContainer1.SplitterDistance = 886;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdCamera, Denumire, Pret, Cantitate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(886, 919);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // IdCamera
            // 
            IdCamera.HeaderText = "Id Camera";
            IdCamera.MinimumWidth = 10;
            IdCamera.Name = "IdCamera";
            IdCamera.Width = 200;
            // 
            // Denumire
            // 
            Denumire.HeaderText = "Denumire Camera";
            Denumire.MinimumWidth = 10;
            Denumire.Name = "Denumire";
            Denumire.Width = 200;
            // 
            // Pret
            // 
            Pret.HeaderText = "Pret";
            Pret.MinimumWidth = 10;
            Pret.Name = "Pret";
            Pret.Width = 200;
            // 
            // Cantitate
            // 
            Cantitate.HeaderText = "Cantitate";
            Cantitate.MinimumWidth = 10;
            Cantitate.Name = "Cantitate";
            Cantitate.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, exportaToolStripMenuItem, importaToolStripMenuItem, printareToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(115, 38);
            adaugaToolStripMenuItem.Text = "Adauga";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click;
            // 
            // exportaToolStripMenuItem
            // 
            exportaToolStripMenuItem.Name = "exportaToolStripMenuItem";
            exportaToolStripMenuItem.Size = new Size(113, 38);
            exportaToolStripMenuItem.Text = "Exporta";
            exportaToolStripMenuItem.Click += exportaToolStripMenuItem_Click;
            // 
            // importaToolStripMenuItem
            // 
            importaToolStripMenuItem.Name = "importaToolStripMenuItem";
            importaToolStripMenuItem.Size = new Size(117, 38);
            importaToolStripMenuItem.Text = "Importa";
            importaToolStripMenuItem.Click += importaToolStripMenuItem_Click;
            // 
            // printareToolStripMenuItem
            // 
            printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            printareToolStripMenuItem.Size = new Size(116, 38);
            printareToolStripMenuItem.Text = "Printare";
            printareToolStripMenuItem.Click += printareToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 961);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdCamera;
        private DataGridViewTextBoxColumn Denumire;
        private DataGridViewTextBoxColumn Pret;
        private DataGridViewTextBoxColumn Cantitate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem exportaToolStripMenuItem;
        private ToolStripMenuItem importaToolStripMenuItem;
        private ToolStripMenuItem printareToolStripMenuItem;
    }
}
