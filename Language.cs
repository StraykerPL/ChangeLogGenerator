/*
	Copyright (c) 2018-2020 Daniel Strayker Nowak
	All rights reserved
*/

using ChangeLog_Generator.Properties;

namespace ChangeLog_Generator
{
    // Simple class for language support,
    public class Language
    {
        // Name can contain "en" or "pl", another strings won't work,
        private string Name;
        private readonly string[] SupportedLanguages = { "en", "pl" };

        // Constructor, reads saved language:
        public Language()
        {
            Name = Settings.Default.lang;
        }
        
        // Method for saving language setting to setting.settings in Properties of project:
        public void SaveLang()
        {
            Settings.Default.lang = Name;
            Settings.Default.Save();
        }

        // Method for setting new language, returns true if operation is complete, false if there's error with lang code:
        public bool SetLang(string langchar)
        {
            // Checks supported languages:
            for (int i = 0; i < SupportedLanguages.Length; i++)
            {
                if (langchar == SupportedLanguages[i]) continue;
                else return false;
            }

            Name = langchar;
            SaveLang();
            return true;
        }

        // Method for returning actual language:
        public string GetLang() { return Name; }
    }
}
