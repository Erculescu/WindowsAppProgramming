namespace Exersare_11
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bttnadauga = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(380, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 106);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 2;
            label1.Text = "IdStudent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 3;
            label2.Text = "Nume";
            // 
            // bttnadauga
            // 
            bttnadauga.Dock = DockStyle.Bottom;
            bttnadauga.Location = new Point(0, 299);
            bttnadauga.Name = "bttnadauga";
            bttnadauga.Size = new Size(679, 46);
            bttnadauga.TabIndex = 4;
            bttnadauga.Text = "Adauga";
            bttnadauga.UseVisualStyleBackColor = true;
            bttnadauga.Click += bttnadauga_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 345);
            Controls.Add(bttnadauga);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button bttnadauga;
    }
}