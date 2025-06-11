namespace Seminar_13
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
            Cod = new DataGridViewTextBoxColumn();
            Denumire = new DataGridViewTextBoxColumn();
            Valoare = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1275, 684);
            splitContainer1.SplitterDistance = 635;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cod, Denumire, Valoare, Data });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(635, 684);
            dataGridView1.TabIndex = 0;
            // 
            // Cod
            // 
            Cod.HeaderText = "Cod";
            Cod.MinimumWidth = 10;
            Cod.Name = "Cod";
            Cod.ReadOnly = true;
            Cod.Width = 200;
            // 
            // Denumire
            // 
            Denumire.HeaderText = "Denumire";
            Denumire.MinimumWidth = 10;
            Denumire.Name = "Denumire";
            Denumire.ReadOnly = true;
            Denumire.Width = 200;
            // 
            // Valoare
            // 
            Valoare.HeaderText = "Valoare";
            Valoare.MinimumWidth = 10;
            Valoare.Name = "Valoare";
            Valoare.ReadOnly = true;
            Valoare.Width = 200;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 10;
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 684);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn Denumire;
        private DataGridViewTextBoxColumn Valoare;
        private DataGridViewTextBoxColumn Data;
    }
}
