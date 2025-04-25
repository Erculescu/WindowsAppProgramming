namespace Exersare_4
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
            nr1 = new TextBox();
            operatie = new TextBox();
            nr2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            rez = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // nr1
            // 
            nr1.Location = new Point(12, 164);
            nr1.Name = "nr1";
            nr1.Size = new Size(230, 39);
            nr1.TabIndex = 0;
            // 
            // operatie
            // 
            operatie.Location = new Point(356, 164);
            operatie.Name = "operatie";
            operatie.Size = new Size(94, 39);
            operatie.TabIndex = 1;
            // 
            // nr2
            // 
            nr2.Location = new Point(524, 164);
            nr2.Name = "nr2";
            nr2.Size = new Size(264, 39);
            nr2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 106);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 3;
            label1.Text = "Primul numar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 106);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 4;
            label2.Text = "Tipul Operatiei\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 106);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 5;
            label3.Text = "Al doilea Numar\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(209, 319);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(101, 329);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "Calculeaza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 259);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 8;
            label4.Text = "Rezultat:";
            label4.Click += label4_Click;
            // 
            // rez
            // 
            rez.Location = new Point(409, 259);
            rez.Name = "rez";
            rez.Size = new Size(200, 39);
            rez.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(389, 329);
            button3.Name = "button3";
            button3.Size = new Size(272, 46);
            button3.TabIndex = 10;
            button3.Text = "Refoloseste rezultat\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(rez);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nr2);
            Controls.Add(operatie);
            Controls.Add(nr1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nr1;
        private TextBox operatie;
        private TextBox nr2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox rez;
        private Button button3;
    }
}
