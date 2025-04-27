namespace Exersare_8
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
            texBoxVect = new TextBox();
            btnCalculeaza = new Button();
            SuspendLayout();
            // 
            // texBoxVect
            // 
            texBoxVect.Location = new Point(73, 47);
            texBoxVect.Multiline = true;
            texBoxVect.Name = "texBoxVect";
            texBoxVect.ScrollBars = ScrollBars.Vertical;
            texBoxVect.Size = new Size(652, 287);
            texBoxVect.TabIndex = 0;
            // 
            // btnCalculeaza
            // 
            btnCalculeaza.Dock = DockStyle.Bottom;
            btnCalculeaza.Location = new Point(0, 404);
            btnCalculeaza.Name = "btnCalculeaza";
            btnCalculeaza.Size = new Size(800, 46);
            btnCalculeaza.TabIndex = 1;
            btnCalculeaza.Text = "Calculeaza";
            btnCalculeaza.UseVisualStyleBackColor = true;
            btnCalculeaza.Click += btnCalculeaza_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculeaza);
            Controls.Add(texBoxVect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texBoxVect;
        private Button btnCalculeaza;
    }
}
