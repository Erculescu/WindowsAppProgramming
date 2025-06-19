namespace Exersare_21
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
            listBox1 = new ListBox();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(114, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 68);
            listBox1.TabIndex = 0;
            listBox1.Click += listBox1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(478, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(865, 298);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(114, 288);
            button1.Name = "button1";
            button1.Size = new Size(240, 46);
            button1.TabIndex = 2;
            button1.Text = "Adauga Candidat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1883, 960);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListView listView1;
        private Button button1;
    }
}
