﻿namespace Tema_Suplimentara
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
            btnAdauga = new Button();
            textBoxCant = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPret = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 186);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 36);
            listBox1.TabIndex = 0;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(330, 344);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 1;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // textBoxCant
            // 
            textBoxCant.Location = new Point(588, 186);
            textBoxCant.Name = "textBoxCant";
            textBoxCant.Size = new Size(200, 39);
            textBoxCant.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 151);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 4;
            label1.Text = "Denumire Produs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 146);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 6;
            label3.Text = "Cantitatea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 146);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 5;
            label2.Text = "Pret";
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(369, 186);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(200, 39);
            textBoxPret.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCant);
            Controls.Add(textBoxPret);
            Controls.Add(btnAdauga);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnAdauga;
        private TextBox textBoxCant;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBoxPret;
    }
}