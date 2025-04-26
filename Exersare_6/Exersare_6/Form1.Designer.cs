namespace Exersare_6
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
            label1 = new Label();
            txtuser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtpwd = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(323, 78);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Bine ati venit!";
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.Right;
            txtuser.Location = new Point(230, 175);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(418, 39);
            txtuser.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(54, 175);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 2;
            label2.Text = "UserName:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(68, 261);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // txtpwd
            // 
            txtpwd.Anchor = AnchorStyles.Right;
            txtpwd.Location = new Point(230, 254);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(418, 39);
            txtpwd.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.Location = new Point(152, 373);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Location = new Point(483, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtpwd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Label label2;
        private Label label3;
        private TextBox txtpwd;
        private Button btnLogin;
        private Button btnCancel;
    }
}
