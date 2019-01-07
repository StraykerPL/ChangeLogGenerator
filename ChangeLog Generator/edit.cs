/*
 * ChangeLog Generator by Daniel Strayker Nowak
 * Copyright © 2018-2019 Daniel Strayker Nowak all rights reserved
 * GNU General Public License 2
 * https://github.com/StraykerPL/changelog_generator
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace ChangeLog_Generator
{
    public partial class edit : Form
    {
        StreamWriter save;
        // For directory for changelog,
        string sciezka = "";
        Language a = new Language();
        string lang = "";

        public edit(string sciezka)
        {
            InitializeComponent();
            this.sciezka = sciezka;
            lang = a.Lang_get();

            if(lang == "en")
            {

            }
            else if(lang == "pl")
            {

            }
        }

        public void button1_Click(object sender, EventArgs e) // Exit button:
        {
            FormCollection formy = Application.OpenForms;
            formy[0].Show();
            Close();
        }

        public void edit_Load(object sender, EventArgs e) // Before form is loaded,
        {

        }

        public void button2_Click(object sender, EventArgs e) // Generate file button:
        {
            if((textBox_naglowek.Text == null) || (textBox_info_dod.Text == null))
            {
                if (lang == "en")
                {

                }
                else if (lang == "pl")
                {

                }
                MessageBox.Show("Pola tekstowe numer 1 i 2 są wymagane do utworzenia pliku!", "ChangeLog Generator", MessageBoxButtons.OK);
            }
            else
            {
                Wpis_do_pliku();
                if (lang == "en")
                {

                }
                else if (lang == "pl")
                {

                }
                MessageBox.Show("Generowanie pliku ukończone pomyślnie! Plik znajduje się w: " + sciezka + " !", "ChangeLog Generator", MessageBoxButtons.OK);
                FormCollection formy = Application.OpenForms;
                formy[0].Show();
                Close();
            }
        }
        
        public void Wpis_do_pliku()
        {
            if (lang == "en")
            {

            }
            else if (lang == "pl")
            {

            }
            save = new StreamWriter(sciezka + "\\changelog.txt");
            save.WriteLine("*ChangeLog*");
            save.WriteLine();
            save.WriteLine("Informations from author:");
            save.WriteLine();
            save.Write(textBox_naglowek.Text);
            save.WriteLine();
            save.WriteLine();
            save.WriteLine("What's new?");
            save.WriteLine();
            save.Write(textBox_info_dod.Text);
            save.WriteLine();

            if(textBox_info_zap.Text != "")
            {
                save.WriteLine("What will be added in next update?");
                save.WriteLine();
                save.Write(textBox_info_zap.Text);
                save.WriteLine();
            }

            if(textBox_info_dodatk.Text != "")
            {
                save.WriteLine("Additional informations:");
                save.WriteLine();
                save.Write(textBox_info_dodatk.Text);
                save.WriteLine();
            }

            save.WriteLine();
            save.WriteLine(" ======================= Advertisment ===================== ");
            save.WriteLine(" | This ChangeLog was created with                        | ");
            save.WriteLine(" | ChangeLog Generator by                                 | ");
            save.WriteLine(" | Daniel Strayker Nowak!                                 | ");
            save.WriteLine(" | http://www.strayker.cba.pl                             | ");
            save.WriteLine(" | https://github.com/StraykerPL/changelog_generator      | ");
            save.WriteLine(" ========================================================== ");
            save.Close();
            save.Dispose();
        }
    }
}
