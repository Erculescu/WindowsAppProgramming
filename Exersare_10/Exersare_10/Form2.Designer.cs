namespace Exersare_10
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBoxPret = new TextBox();
            textBoxCantitate = new TextBox();
            btnAdauga = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(60, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(368, 36);
            listBox1.TabIndex = 0;
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(493, 167);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(261, 39);
            textBoxPret.TabIndex = 1;
            // 
            // textBoxCantitate
            // 
            textBoxCantitate.Location = new Point(804, 167);
            textBoxCantitate.Name = "textBoxCantitate";
            textBoxCantitate.Size = new Size(328, 39);
            textBoxCantitate.TabIndex = 2;
            // 
            // btnAdauga
            // 
            btnAdauga.Dock = DockStyle.Bottom;
            btnAdauga.Location = new Point(0, 264);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(1232, 46);
            btnAdauga.TabIndex = 3;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 121);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 4;
            label1.Text = "Denumire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 121);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 5;
            label2.Text = "Pret";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(905, 121);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 6;
            label3.Text = "Cantitate";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 310);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdauga);
            Controls.Add(textBoxCantitate);
            Controls.Add(textBoxPret);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBoxPret;
        private TextBox textBoxCantitate;
        private Button btnAdauga;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}