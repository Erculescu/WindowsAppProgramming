namespace Exersare_16
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listView1 = new ListView();
            progressBar1 = new ProgressBar();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(428, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(709, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1008, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1304, 79);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(506, 39);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(1947, 72);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 37);
            label1.Name = "label1";
            label1.Size = new Size(57, 32);
            label1.TabIndex = 6;
            label1.Text = "Cod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 37);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 7;
            label2.Text = "Culoare";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 39);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 8;
            label3.Text = "Grosime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1059, 37);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 9;
            label4.Text = "Eticheta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1487, 39);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 10;
            label5.Text = "Puncte";
            // 
            // listView1
            // 
            listView1.Location = new Point(141, 187);
            listView1.Name = "listView1";
            listView1.Size = new Size(1067, 691);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1304, 187);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(793, 46);
            progressBar1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1627, 250);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2434, 995);
            Controls.Add(label6);
            Controls.Add(progressBar1);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listView1;
        private ProgressBar progressBar1;
        private Label label6;
    }
}
