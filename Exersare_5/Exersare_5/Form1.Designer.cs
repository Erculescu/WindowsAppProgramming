namespace Exersare_5
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
            btnAdauga = new Button();
            btnSalvare = new Button();
            radioMasc = new RadioButton();
            radioFem = new RadioButton();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnAdauga
            // 
            btnAdauga.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdauga.Location = new Point(40, 380);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 0;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnSalvare
            // 
            btnSalvare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvare.Location = new Point(264, 380);
            btnSalvare.Name = "btnSalvare";
            btnSalvare.Size = new Size(150, 46);
            btnSalvare.TabIndex = 1;
            btnSalvare.Text = "Salveaza";
            btnSalvare.UseVisualStyleBackColor = true;
            btnSalvare.Click += btnSalvare_Click;
            // 
            // radioMasc
            // 
            radioMasc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radioMasc.AutoSize = true;
            radioMasc.Location = new Point(461, 383);
            radioMasc.Name = "radioMasc";
            radioMasc.Size = new Size(140, 36);
            radioMasc.TabIndex = 2;
            radioMasc.TabStop = true;
            radioMasc.Text = "Masculin";
            radioMasc.UseVisualStyleBackColor = true;
            // 
            // radioFem
            // 
            radioFem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radioFem.AutoSize = true;
            radioFem.Location = new Point(665, 385);
            radioFem.Name = "radioFem";
            radioFem.Size = new Size(131, 36);
            radioFem.TabIndex = 3;
            radioFem.TabStop = true;
            radioFem.Text = "Feminin";
            radioFem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(857, 352);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 457);
            Controls.Add(textBox1);
            Controls.Add(radioFem);
            Controls.Add(radioMasc);
            Controls.Add(btnSalvare);
            Controls.Add(btnAdauga);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdauga;
        private Button btnSalvare;
        private RadioButton radioMasc;
        private RadioButton radioFem;
        private TextBox textBox1;
    }
}
