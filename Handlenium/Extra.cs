﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlenium
{
    public static class Extra
    {
        /// <summary>
        /// Gera um CPF Fake Válido
        /// </summary>
        /// <returns>CPF Fake</returns>
        public static string FakeCPF()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string seed = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(seed[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            seed = seed + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(seed[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            seed = seed + resto;
            return seed;
        }
    }
}
