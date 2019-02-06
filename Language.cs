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
