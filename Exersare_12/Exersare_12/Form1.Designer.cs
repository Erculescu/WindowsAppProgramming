namespace Exersare_12
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
            Serie = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Pret = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            inserareToolStripMenuItem = new ToolStripMenuItem();
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
            splitContainer1.Size = new Size(1947, 1009);
            splitContainer1.SplitterDistance = 886;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Serie, Marca, Model, Pret });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(886, 967);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // Serie
            // 
            Serie.HeaderText = "Serie";
            Serie.MinimumWidth = 10;
            Serie.Name = "Serie";
            Serie.Width = 200;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 10;
            Marca.Name = "Marca";
            Marca.Width = 200;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 10;
            Model.Name = "Model";
            Model.Width = 200;
            // 
            // Pret
            // 
            Pret.HeaderText = "Pret";
            Pret.MinimumWidth = 10;
            Pret.Name = "Pret";
            Pret.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, salvareToolStripMenuItem, inserareToolStripMenuItem, printareToolStripMenuItem });
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
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(110, 38);
            salvareToolStripMenuItem.Text = "Salvare";
            salvareToolStripMenuItem.Click += salvareToolStripMenuItem_Click;
            // 
            // inserareToolStripMenuItem
            // 
            inserareToolStripMenuItem.Name = "inserareToolStripMenuItem";
            inserareToolStripMenuItem.Size = new Size(118, 38);
            inserareToolStripMenuItem.Text = "Inserare";
            inserareToolStripMenuItem.Click += inserareToolStripMenuItem_Click;
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
            ClientSize = new Size(1947, 1009);
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
        private DataGridViewTextBoxColumn Serie;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Pret;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem inserareToolStripMenuItem;
        private ToolStripMenuItem printareToolStripMenuItem;
    }
}
