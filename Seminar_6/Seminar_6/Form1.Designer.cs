namespace Seminar_6
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
            persoane = new TextBox();
            SuspendLayout();
            // 
            // btnAdauga
            // 
            btnAdauga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdauga.AutoSize = true;
            btnAdauga.Location = new Point(518, 392);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(270, 46);
            btnAdauga.TabIndex = 0;
            btnAdauga.Text = "Adauga Persoana";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // persoane
            // 
            persoane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            persoane.Location = new Point(29, 34);
            persoane.Multiline = true;
            persoane.Name = "persoane";
            persoane.ScrollBars = ScrollBars.Vertical;
            persoane.Size = new Size(756, 348);
            persoane.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(800, 450);
            Controls.Add(persoane);
            Controls.Add(btnAdauga);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdauga;
        private TextBox persoane;
    }
}
