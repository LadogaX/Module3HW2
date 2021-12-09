using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Module3HW2.Models;
using Newtonsoft.Json;
using Module3HW2.Models.Abstraction;

namespace Module3HW2.Services
{
    public class ServiceConfig : IServiceConfig
    {
        public ServiceConfig()
        {
            Config = new Config();
            LoadConfig();
        }

        public Config Config { get; set; }

        public string FileName { get; set; } = "config.json";

        public void LoadConfig()
        {
            if (!File.Exists(FileName))
            {
                DefaultValues();
                SaveConfig();
            }
            else
            {
                SetCurrentLanguageAsCurrentCulture();
            }

            var configFile = File.ReadAllText(FileName);
            Config = JsonConvert.DeserializeObject<Config>(configFile);
        }

        public void SetCurrentLanguageAsCurrentCulture()
        {
            Config.CurrentLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        }

        public void SaveConfig()
        {
            var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }

        public List<char> GetListChars(string languageCode)
        {
            return Config.LanguageSetting.GetValueOrDefault(languageCode);
        }

        public void DefaultValues()
        {
            SetCurrentLanguageAsCurrentCulture();
            Config.LanguageSetting.Add("ru", GetRussianAlfaBet());
            Config.LanguageSetting.Add("en", GetEnglishAlfaBet());
        }

        public List<char> GetRussianAlfaBet()
        {
            List<char> alphabet = new List<char>();
            for (int i = 1040; i < 1072; i++)
            {
                alphabet.Add((char)i);

                if (i == 1045)
                {
                    alphabet.Add((char)1025);
                }
            }

            alphabet.TrimExcess();
            return alphabet;
        }

        public List<char> GetEnglishAlfaBet()
        {
            List<char> alphabet = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                alphabet.Add((char)i);
            }

            alphabet.TrimExcess();
            return alphabet;
        }
    }
}