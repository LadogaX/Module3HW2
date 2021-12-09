using System;
using System.Collections.Generic;

namespace Module3HW2.Models.Abstraction
{
    public interface IServiceConfig
    {
        Config Config { get; set; }
        void SaveConfig();

        List<char> GetListChars(string languageCode);

        void DefaultValues();

        List<char> GetRussianAlfaBet();

        List<char> GetEnglishAlfaBet();

        void LoadConfig();

        void SetCurrentLanguageAsCurrentCulture();
    }
}
