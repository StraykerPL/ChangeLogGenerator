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
using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLog_Generator
{
    public partial class info : Form
    {
        string lang;
        Language a = new Language();

        public info()
        {
            InitializeComponent();
            lang = a.Lang_get();

            if (lang == "en")
            {
                button1.Text = "Exit";
                button2.Text = "Language";
                label1.Text = "ChangeLog Generator";
                label2.Text = "Version: 0.1";
                label3.Text = "Simple generator of changelog files\nfor Strayex Development Pack";
                label4.Text = "Copyright © 2018-2019 Daniel Strayker Nowak";
                label5.Text = "All rights reserved under copyright laws\nand GNU General Public License 2";
            }
            else if (lang == "pl")
            {
                button1.Text = "Zamknij";
                button2.Text = "Język";
                label1.Text = "ChangeLog Generator";
                label2.Text = "Wersja: 0.1";
                label3.Text = "Prosty generator plików changelog dla\nStrayex Development Pack";
                label4.Text = "Copyright © 2018-2019 Daniel Strayker Nowak";
                label5.Text = "Wszelkie prawa zastrzeżone na mocy praw autorskich\ni GNU General Public License 2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lang == "en")
            {
                a.Lang_set("pl");
                lang = "pl";
                a.Save_lang();
                Application.Restart();
            }
            else if(lang == "pl")
            {
                a.Lang_set("en");
                lang = "en";
                a.Save_lang();
                Application.Restart();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/StraykerPL/changelog_generator");
        }
    }
}
