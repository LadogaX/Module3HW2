﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models
{
    public class LettersGroup
    {
        public LettersGroup()
        {
            List = new SortedList<char, List<Person>>();
        }

        public SortedList<char, List<Person>> List { get; set; }
    }
}
