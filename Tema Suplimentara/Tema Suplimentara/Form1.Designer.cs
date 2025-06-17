namespace Tema_Suplimentara
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
            IdProdus = new DataGridViewTextBoxColumn();
            DenumireProdus = new DataGridViewTextBoxColumn();
            PretProdus = new DataGridViewTextBoxColumn();
            CantitateProdus = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            adaugareToolStripMenuItem = new ToolStripMenuItem();
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
            splitContainer1.Dock = DockStyle.Left;
            splitContainer1.Location = new Point(0, 42);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 637);
            splitContainer1.SplitterDistance = 439;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdProdus, DenumireProdus, PretProdus, CantitateProdus });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(439, 637);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ContextMenuStripChanged += dataGridView1_ContextMenuStripChanged;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // IdProdus
            // 
            IdProdus.HeaderText = "Id Produs";
            IdProdus.MinimumWidth = 10;
            IdProdus.Name = "IdProdus";
            IdProdus.Width = 200;
            // 
            // DenumireProdus
            // 
            DenumireProdus.HeaderText = "Denumire Produs";
            DenumireProdus.MinimumWidth = 10;
            DenumireProdus.Name = "DenumireProdus";
            DenumireProdus.Width = 200;
            // 
            // PretProdus
            // 
            PretProdus.HeaderText = "Pret Produs";
            PretProdus.MinimumWidth = 10;
            PretProdus.Name = "PretProdus";
            PretProdus.Width = 200;
            // 
            // CantitateProdus
            // 
            CantitateProdus.HeaderText = "Cantitate Produs";
            CantitateProdus.MinimumWidth = 10;
            CantitateProdus.Name = "CantitateProdus";
            CantitateProdus.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adaugareToolStripMenuItem, salvareToolStripMenuItem, inserareToolStripMenuItem, printareToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            adaugareToolStripMenuItem.Size = new Size(136, 38);
            adaugareToolStripMenuItem.Text = "Adaugare";
            adaugareToolStripMenuItem.Click += adaugareToolStripMenuItem_Click;
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
            ClientSize = new Size(800, 679);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdProdus;
        private DataGridViewTextBoxColumn DenumireProdus;
        private DataGridViewTextBoxColumn PretProdus;
        private DataGridViewTextBoxColumn CantitateProdus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adaugareToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem inserareToolStripMenuItem;
        private ToolStripMenuItem printareToolStripMenuItem;
    }
}
