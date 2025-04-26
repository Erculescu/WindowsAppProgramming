using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_6
{
    public partial class Form3: Form
    {
        public Form3(string text)
        {
            InitializeComponent();
            PopulateLabels(text);
        }
        private void PopulateLabels(string text)
        {
            string[] linii = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int poz = 35;
            foreach (string linie in linii)
            {
                System.Windows.Forms.GroupBox groupbox = new System.Windows.Forms.GroupBox
                {
                    Location = new Point(10, poz),
                    Size = new Size(900, 100),
                    Text = ""
                };
                Label lbl = new Label
                {
                    Text = linie,
                    Location = new Point(10, 15),
                    AutoSize = true
                };
                groupbox.Controls.Add(lbl);
                System.Windows.Forms.RadioButton rb_complet = new System.Windows.Forms.RadioButton
                {
                    Text = "Complet",
                    Location = new Point(400, 15),
                    AutoSize = true

                };
                System.Windows.Forms.RadioButton rb_in_curs = new System.Windows.Forms.RadioButton
                {
                    Text = "In curs",
                    Location = new Point(550, 15),
                    AutoSize = true

                };
                groupbox.Controls.Add(rb_complet);
                groupbox.Controls.Add(rb_in_curs);
                this.Controls.Add(groupbox);
                poz += 100;
            }
            Button Generare_raport = new Button
            {
                Text = "Generare raport",
                Height = 50,
                Dock = DockStyle.Bottom
            };
            this.Controls.Add(Generare_raport);
            Generare_raport.Click += (s, args) =>
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save report";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                var complet = 0; var in_curs = 0;
                                foreach (Control control in this.Controls)
                                {
                                    if (control is System.Windows.Forms.GroupBox groupBox)
                                    {
                                        foreach (Control innerControl in groupBox.Controls)
                                        {
                                            if (innerControl is System.Windows.Forms.RadioButton rb && rb.Checked)
                                            {
                                                if (rb.Text == "Complet")
                                                {
                                                    complet++;
                                                }
                                                else if (rb.Text == "In curs")
                                                {
                                                    in_curs++;
                                                }
                                            }
                                        }
                                    }
                                }
                                writer.WriteLine($"Task-uri complete: {complet}");
                                writer.WriteLine($"Task-uri in curs: {in_curs}");
                            }
                            MessageBox.Show("Raport generat cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Eroare la generarea raportului: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };

        }

    }
}
