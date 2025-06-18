namespace Exersare_12
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
            textBoxModel = new TextBox();
            textBoxAn = new TextBox();
            textBoxVin = new TextBox();
            button1 = new Button();
            textBoxPret = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(273, 128);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 36);
            listBox1.TabIndex = 0;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(581, 128);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(230, 39);
            textBoxModel.TabIndex = 1;
            // 
            // textBoxAn
            // 
            textBoxAn.Location = new Point(861, 128);
            textBoxAn.Name = "textBoxAn";
            textBoxAn.Size = new Size(254, 39);
            textBoxAn.TabIndex = 2;
            // 
            // textBoxVin
            // 
            textBoxVin.Location = new Point(39, 125);
            textBoxVin.Name = "textBoxVin";
            textBoxVin.Size = new Size(200, 39);
            textBoxVin.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 277);
            button1.Name = "button1";
            button1.Size = new Size(1189, 46);
            button1.TabIndex = 4;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(490, 199);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(200, 39);
            textBoxPret.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 202);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 6;
            label1.Text = "Pret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 81);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 7;
            label2.Text = "Serie sasiu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 86);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 8;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 86);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 9;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(911, 81);
            label5.Name = "label5";
            label5.Size = new Size(151, 32);
            label5.TabIndex = 10;
            label5.Text = "An Fabricatie";
            label5.Click += label5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 323);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPret);
            Controls.Add(button1);
            Controls.Add(textBoxVin);
            Controls.Add(textBoxAn);
            Controls.Add(textBoxModel);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBoxModel;
        private TextBox textBoxAn;
        private TextBox textBoxVin;
        private Button button1;
        private TextBox textBoxPret;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}