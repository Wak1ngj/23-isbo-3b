﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employees;
using Lab_4;

namespace ClassLibrary2
{
    public class Var11PodraZdelenie
    {
        public string Nazvanie { get; }
        public employees Rukovoditel { get; }
        public Организация Организация { get; }
        public Var11PodraZdelenie(string Nazvanie, employees Rukovoditel, Организация Организация)
        {
            Nazvanie = Nazvanie;
            employees = Rukovoditel;
            Организация = Организация;
        }
    }
}
