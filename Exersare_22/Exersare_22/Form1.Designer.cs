namespace Exersare_22
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
            dataGridView1 = new DataGridView();
            Cod = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Salariul = new DataGridViewTextBoxColumn();
            IdCompanie = new DataGridViewTextBoxColumn();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cod, Nume, Salariul, IdCompanie });
            dataGridView1.Location = new Point(45, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(886, 547);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // Cod
            // 
            Cod.HeaderText = "Cod";
            Cod.MinimumWidth = 10;
            Cod.Name = "Cod";
            Cod.Width = 200;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 10;
            Nume.Name = "Nume";
            Nume.Width = 200;
            // 
            // Salariul
            // 
            Salariul.HeaderText = "Salariul";
            Salariul.MinimumWidth = 10;
            Salariul.Name = "Salariul";
            Salariul.Width = 200;
            // 
            // IdCompanie
            // 
            IdCompanie.HeaderText = "Id Companie";
            IdCompanie.MinimumWidth = 10;
            IdCompanie.Name = "IdCompanie";
            IdCompanie.Width = 200;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(45, 797);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(886, 46);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 750);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 938);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Salariul;
        private DataGridViewTextBoxColumn IdCompanie;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
