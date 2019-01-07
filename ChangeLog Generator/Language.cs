/*
 * ChangeLog Generator by Daniel Strayker Nowak
 * Copyright © 2018-2019 Daniel Strayker Nowak all rights reserved
 * GNU General Public License 2
 * https://github.com/StraykerPL/changelog_generator
 */

using ChangeLog_Generator.Properties;

namespace ChangeLog_Generator
{
    // Simple class for language support,
    public class Language
    {
        // Name can contain "en" or "pl", another strings won't work,
        private string name;

        // Constructor, reads saved language,
        public Language()
        {
            name = Settings.Default.lang;
        }
        
        // Method for saving language setting to setting.settings in Properties of project,
        public void Save_lang()
        {
            Settings.Default.lang = name;
            Settings.Default.Save();
        }

        // Method for setting new language,
        public void Lang_set(string lang_char)
        {
            name = lang_char;
            Save_lang();
        }

        // Method for returning actual language,
        public string Lang_get() { return name; }
    }
}
