/*
	Copyright (c) 2018-2019 Daniel Strayker Nowak
	All rights reserved
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
                label3.Text = "Simple generator of changelog files\nfor Strayex Shell";
                label4.Text = "Copyright © 2018-2019 Daniel Strayker Nowak";
                label5.Text = "All rights reserved under copyright laws\nand MIT/X11 license";
            }
            else if (lang == "pl")
            {
                button1.Text = "Zamknij";
                button2.Text = "Język";
                label1.Text = "ChangeLog Generator";
                label2.Text = "Wersja: 0.1";
                label3.Text = "Prosty generator plików changelog dla\nStrayex Shell";
                label4.Text = "Copyright © 2018-2019 Daniel Strayker Nowak";
                label5.Text = "Wszelkie prawa zastrzeżone na mocy praw autorskich\ni licencji MIT/X11";
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
