﻿namespace Exersare_23
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
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(24, 86);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(622, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(903, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 191);
            button1.Name = "button1";
            button1.Size = new Size(1135, 46);
            button1.TabIndex = 4;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 51);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 5;
            label1.Text = "Nr Apartament";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 51);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 6;
            label2.Text = "Proprietar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 51);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 7;
            label3.Text = "Suprafata";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(936, 51);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 8;
            label4.Text = "Intretinerea";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 237);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}