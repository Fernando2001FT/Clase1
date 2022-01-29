using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_romanos_2
{
   public class convertidor
    {
        public static string convertirarabicoaromano(int numeconvertirarabicoaromanoroArabico)
        {
            var resultado = new StringBuilder();
            var restante = numeconvertirarabicoaromanoroArabico;
            if (numeconvertirarabicoaromanoroArabico == 6)
               resultado .Append("VI");
            else if (numeconvertirarabicoaromanoroArabico == 5)
                resultado .Append("V");
            else if (numeconvertirarabicoaromanoroArabico == 4)
                resultado. Append("IV");
            else
            for (int i = 0; i< numeconvertirarabicoaromanoroArabico; i++  )
            {
                resultado.Append("I");
            }
            return resultado.ToString();
        
        }
    }
}
