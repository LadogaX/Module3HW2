using System;
using Module3HW2.Models;
using Module3HW2.Services;

namespace Module3HW2.Helpers
{
    public static class LetterGroupHelper
    {
        public static void Display(ServiceLetterGroup serviceLetterGroup)
        {
            Console.WriteLine();
            Console.WriteLine($"{serviceLetterGroup.GetCurrentLanguage()}");
            foreach (var letter in serviceLetterGroup.LettersGroup.List)
            {
                Console.Write($"{letter.Key}:");
                foreach (var item in letter.Value)
                {
                    Console.WriteLine($"{"\t"}{item.FullName,-30}{item.Phone,-30} {item.EMail}");
                }
            }
        }
    }
}
