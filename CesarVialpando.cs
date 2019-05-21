using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DK_Prikolchik
{
    public static class CesarVialpondo
    {
        public static string Encrypt(string Mes, int key = 1)
        {
            StringBuilder newMes = new StringBuilder(Mes);

            for (int i = 0; i < Mes.Length; i++)
            {
                if (char.IsLetter(Mes[i]))
                {
                    if(char.IsLetter((char)(newMes[i] + key)))
                        newMes[i] = (char)(newMes[i] + key);
                    else
                        newMes[i] = (char)(newMes[i] + key - 26);
                }
            }

            return newMes.ToString();
        }

        public static string Decrypt(string Mes, int key = 1) => Encrypt(Mes, -key);
    }
}