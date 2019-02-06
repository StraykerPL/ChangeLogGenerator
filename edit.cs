/*
  This file is part of ChangeLog Generator.

    ChangeLog Generator is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 3 of the License, or
    (at your option) any later version.

    ChangeLog Generator is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

    Ten plik jest częścią ChangeLog Generator.

    ChangeLog Generator jest wolnym oprogramowaniem: możesz go rozprowadzać dalej
    i/lub modyfikować na warunkach Powszechnej Licencji Publicznej GNU,
    wydanej przez Fundację Wolnego Oprogramowania - według wersji 3 tej
    Licencji lub (według twojego wyboru) którejś z późniejszych wersji.

    ChangeLog Generator rozpowszechniany jest z nadzieją, iż będzie on
    użyteczny - jednak BEZ JAKIEJKOLWIEK GWARANCJI, nawet domyślnej
    gwarancji PRZYDATNOŚCI HANDLOWEJ albo PRZYDATNOŚCI DO OKREŚLONYCH
    ZASTOSOWAŃ. W celu uzyskania bliższych informacji sięgnij do     Powszechnej Licencji Publicznej GNU.

    Z pewnością wraz z ChangeLog Generator otrzymałeś też egzemplarz
    Powszechnej Licencji Publicznej GNU (GNU General Public License).
    Jeśli nie - zobacz <http://www.gnu.org/licenses/>.
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
