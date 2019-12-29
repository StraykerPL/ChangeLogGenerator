/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLog_Generator
{
    public partial class main : Form
    {
        public string lang;

        public main()
        {
            InitializeComponent();
            var a = new Language();
            lang = a.GetLang();
            
            if(lang == "en")
            {
                NewFileButton.Text = "Generate file";
                DocumentationButton.Text = "Documentation";
                AboutAppButton.Text = "Informations about app";
            }
            else if(lang == "pl")
            {
                NewFileButton.Text = "Generuj plik";
                DocumentationButton.Text = "Dokomentacja";
                AboutAppButton.Text = "Informacje o programie";
            }
        }

        public void DocumentationButton_Click(object sender, EventArgs e) // Documentation button:
        {
            Process.Start("https://github.com/StraykerPL/changelog_generator#using");
        }

        public void ApoutAppButton_Click(object sender, EventArgs e) // Informations about app button:
        {
            // Opens app's info screen:
            var a = new Info();
            a.Show();
        }

        public void NewFileButton_Click(object sender, EventArgs e) // New file button:
        {
            // Configures and shows dialog box for choosing directory, text in dialog:
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
                    var a = new Edit(folderBrowserDialog1.SelectedPath);
                    a.Show();
                    Hide();
                }
            }
        }
    }
}
