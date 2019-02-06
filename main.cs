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
// using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLog_Generator
{
    public partial class main : Form
    {
        string lang;

        public main()
        {
            InitializeComponent();
            var a = new Language();
            lang = a.Lang_get();
            
            if(lang == "en")
            {
                button1.Text = "Generate file";
                button3.Text = "Documentation";
                button4.Text = "Informations about app";
            }
            else if(lang == "pl")
            {
                button1.Text = "Generuj plik";
                button3.Text = "Dokomentacja";
                button4.Text = "Informacje o programie";
            }
        }

        public void button3_Click(object sender, EventArgs e) // Documentation button:
        {
            // Process.Start("http://www.strayker.cba.pl/docs/docs.html"); Webpage under mainteinance!
        }

        public void button4_Click(object sender, EventArgs e) // Informations about app button:
        {
            // Opens app's info screen:
            Form info = new info();
            info.Show();
        }

        public void button1_Click(object sender, EventArgs e) // New file button:
        {
            // Configures and shows dialog box for choosing directory, text in dialog,
            if (lang == "en")
            {
                folderBrowserDialog1.Description = "Choose directory to create file in:";
            }
            else if(lang == "pl")
            {
                folderBrowserDialog1.Description = "Wybierz ścieżkę, gdzie ma być wygenerowany plik";
            }

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) // Checks, what was pressed,
            {
                if(folderBrowserDialog1.SelectedPath != null)
                { //If dialog box returned directory:
                    //Open creator window,
                    Form edit = new edit(folderBrowserDialog1.SelectedPath);
                    edit.Show();
                    Hide();
                }
            }
        }
    }
}
