/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Windows.Forms;
using System.IO;

namespace ChangeLog_Generator
{
    public partial class Edit : Form
    {
        StreamWriter save;
        string dir = ""; // For directory for changelog,
        readonly Language a = new Language();
        string lang = "";

        public Edit(string sciezka)
        {
            InitializeComponent();
            this.dir = sciezka;
            lang = a.GetLang();

            if(lang == "en")
            {
                label3.Text = "1. Header:";
                label4.Text = "2. Additional informations:";
                label5.Text = "3. To be in next version\n(Leave empty, if not wanted):";
                label6.Text = "4. Idditional informations\n(Leave empty, if not wanted):";

                ExitButton.Text = "Exit";
                GenerateButton.Text = "Generate";
            }
        }

        public void button1_Click(object sender, EventArgs e) // Exit button:
        {
            var formy = Application.OpenForms;
            formy[0].Show();
            Close();
        }

        public void button2_Click(object sender, EventArgs e) // Generate file button:
        {
            if((textBox_naglowek.Text == null) || (textBox_info_dod.Text == null))
            {
                if (lang == "en")
                {
                    MessageBox.Show("Textboxes 1 and 2 are needed to create file!", "ChangeLog Generator", MessageBoxButtons.OK);
                }
                else if (lang == "pl")
                {
                    MessageBox.Show("Pola tekstowe numer 1 i 2 są wymagane do utworzenia pliku!", "ChangeLog Generator", MessageBoxButtons.OK);
                }
            }
            else
            {
                Wpis_do_pliku();
                if (lang == "en")
                {
                    MessageBox.Show("File generation completed succesfully! File is in: " + dir + " !", "ChangeLog Generator", MessageBoxButtons.OK);
                }
                else if (lang == "pl")
                {
                    MessageBox.Show("Generowanie pliku ukończone pomyślnie! Plik znajduje się w: " + dir + " !", "ChangeLog Generator", MessageBoxButtons.OK);
                }
                
                var formy = Application.OpenForms;
                formy[0].Show();
                Close();
            }
        }
        
        public void Wpis_do_pliku()
        {
            if (lang == "en")
            {
                save = new StreamWriter(dir + "\\changelog.txt");
                save.WriteLine("*ChangeLog*");
                save.WriteLine();
                save.WriteLine("Information from author:");
                save.WriteLine();
                save.Write(textBox_naglowek.Text);
                save.WriteLine();
                save.WriteLine();
                save.WriteLine("What's new?");
                save.WriteLine();
                save.Write(textBox_info_dod.Text);
                save.WriteLine();

                if (textBox_info_zap.Text != "")
                {
                    save.WriteLine();
                    save.WriteLine("What will be added in next update?");
                    save.WriteLine();
                    save.Write(textBox_info_zap.Text);
                    save.WriteLine();
                }

                if (textBox_info_dodatk.Text != "")
                {
                    save.WriteLine();
                    save.WriteLine("Additional informations:");
                    save.WriteLine();
                    save.Write(textBox_info_dodatk.Text);
                    save.WriteLine();
                }

                save.WriteLine();
                save.WriteLine(" ====================== Advertisment ====================== ");
                save.WriteLine(" | This ChangeLog was created with                        | ");
                save.WriteLine(" | ChangeLog Generator by                                 | ");
                save.WriteLine(" | Daniel Strayker Nowak!                                 | ");
                save.WriteLine(" | https://straykerpl.github.io                           | ");
                save.WriteLine(" | https://github.com/StraykerPL/changelog_generator      | ");
                save.WriteLine(" ========================================================== ");
            }
            else if (lang == "pl")
            {
                save = new StreamWriter(dir + "\\changelog.txt");
                save.WriteLine("*ChangeLog*");
                save.WriteLine();
                save.WriteLine("Informacje od autora:");
                save.WriteLine();
                save.Write(textBox_naglowek.Text);
                save.WriteLine();
                save.WriteLine();
                save.WriteLine("Co nowego?");
                save.WriteLine();
                save.Write(textBox_info_dod.Text);
                save.WriteLine();

                if (textBox_info_zap.Text != "")
                {
                    save.WriteLine();
                    save.WriteLine("Co zostanie dodane w następnej aktualizacji?");
                    save.WriteLine();
                    save.Write(textBox_info_zap.Text);
                    save.WriteLine();
                }

                if (textBox_info_dodatk.Text != "")
                {
                    save.WriteLine();
                    save.WriteLine("Dodatkowe informacje:");
                    save.WriteLine();
                    save.Write(textBox_info_dodatk.Text);
                    save.WriteLine();
                }

                save.WriteLine();
                save.WriteLine(" ================================ Reklama ================================ ");
                save.WriteLine(" | Ten ChangeLog został wygenerowany przy pomocy                         | ");
                save.WriteLine(" | ChangeLog Generator stworzonego przez                                 | ");
                save.WriteLine(" | Daniel Strayker Nowak!                                                | ");
                save.WriteLine(" | https://straykerpl.github.io                                          | ");
                save.WriteLine(" | https://github.com/StraykerPL/changelog_generator                     | ");
                save.WriteLine(" ========================================================================= ");
            }
            
            save.Close();
            save.Dispose();
        }
    }
}
