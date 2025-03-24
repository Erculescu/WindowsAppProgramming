namespace Seminar_6
{
    partial class FormPersoana
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
            labelNume = new Label();
            txtNume = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            radioMasculin = new RadioButton();
            radioFeminin = new RadioButton();
            SuspendLayout();
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(91, 90);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(85, 32);
            labelNume.TabIndex = 0;
            labelNume.Text = "Nume:";
            // 
            // txtNume
            // 
            txtNume.Location = new Point(255, 87);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(441, 39);
            txtNume.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(419, 380);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 46);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(597, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // radioMasculin
            // 
            radioMasculin.AutoSize = true;
            radioMasculin.Location = new Point(375, 215);
            radioMasculin.Name = "radioMasculin";
            radioMasculin.Size = new Size(140, 36);
            radioMasculin.TabIndex = 6;
            radioMasculin.TabStop = true;
            radioMasculin.Text = "Masculin";
            radioMasculin.UseVisualStyleBackColor = true;
            // 
            // radioFeminin
            // 
            radioFeminin.AutoSize = true;
            radioFeminin.Location = new Point(565, 215);
            radioFeminin.Name = "radioFeminin";
            radioFeminin.Size = new Size(131, 36);
            radioFeminin.TabIndex = 7;
            radioFeminin.TabStop = true;
            radioFeminin.Text = "Feminin";
            radioFeminin.UseVisualStyleBackColor = true;
            // 
            // FormPersoana
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(radioFeminin);
            Controls.Add(radioMasculin);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtNume);
            Controls.Add(labelNume);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPersoana";
            Text = "FormPersoana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNume;
        private TextBox txtNume;
        private Button btnOK;
        private Button btnCancel;
        private RadioButton radioMasculin;
        private RadioButton radioFeminin;
    }
}