namespace Exersare_15
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnAdauga = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(629, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 79);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 5;
            label1.Text = "Nume Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 79);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 6;
            label2.Text = "Adresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(686, 79);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 8;
            label4.Text = "Tranzactie";
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(983, 112);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 9;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(36, 188);
            listView1.Name = "listView1";
            listView1.Size = new Size(1097, 729);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2033, 1007);
            Controls.Add(listView1);
            Controls.Add(btnAdauga);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnAdauga;
        private ListView listView1;
    }
}
