/*
  ChangeLog Generator File
  This file is published under Strayker Free Software License v1.0
  Copyright 2019 Daniel Strayker Nowak
  All rights reserved by Copyright and this license
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
                label3.Text = "1. Header:";
                label4.Text = "2. Additional informations:";
                label5.Text = "3. To be in next version\n(Leave empty, if not wanted):";
                label6.Text = "4. Idditional informations\n(Leave empty, if not wanted):";
            }
            else if(lang == "pl")
            {
                label3.Text = "1. Nagłówek:";
                label4.Text = "2. Dodatkowe informacje:";
                label5.Text = "3. W następnej wersji\n(Leave empty, if not wanted):";
                label6.Text = "4. Dodatkowe informacje\n(Leave empty, if not wanted):";
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
