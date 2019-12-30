/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLog_Generator
{
    public partial class Info : Form
    {
        private string lang;
        private readonly Language a = new Language();

        public Info()
        {
            InitializeComponent();
            lang = a.GetLang();

            if (lang == "en")
            {
                ExitButton.Text = "Exit";
                LanguageButton.Text = "Language";
                label1.Text = "ChangeLog Generator";
                label2.Text = "Version: 1.0.0";
                label3.Text = "Simple generator of changelog files\nfor Strayex Shell";
                label4.Text = "Copyright © 2018-2020 Daniel Strayker Nowak";
                label5.Text = "All rights reserved under copyright laws\nand MIT/X11 license";
            }
            else if (lang == "pl")
            {
                ExitButton.Text = "Zamknij";
                LanguageButton.Text = "Język";
                label1.Text = "ChangeLog Generator";
                label2.Text = "Wersja: 1.0.0";
                label3.Text = "Prosty generator plików changelog dla\nStrayex Shell";
                label4.Text = "Copyright © 2018-2020 Daniel Strayker Nowak";
                label5.Text = "Wszelkie prawa zastrzeżone na mocy praw autorskich\ni licencji MIT/X11";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (lang == "en")
            {
                a.SetLang("pl");
                lang = "pl";
                a.SaveLang();
                Application.Restart();
            }
            else if(lang == "pl")
            {
                a.SetLang("en");
                lang = "en";
                a.SaveLang();
                Application.Restart();
            }
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/StraykerPL/changelog_generator");
        }
    }
}
