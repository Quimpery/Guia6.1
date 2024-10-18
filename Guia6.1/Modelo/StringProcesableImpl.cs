using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6._1.Modelo
{
    internal class StringProcesableImpl:IPrueba
    {
        public string Procesar(string patente, out string formateada)
        {
            String patenteAjustada = patente.Replace(" ", "").Replace("-", "").ToUpper();

            bool ishasta2016 = patenteAjustada.Length == 6;
            for(int n = 0;n < patenteAjustada.Length && ishasta2016 == true; n++)
            {
                char d=patenteAjustada[n];
                ishasta2016 &= (char.IsLetter(d) && n < 3) || (char.IsNumber(d) && n < 6 && n >= 3);
            }
            if(ishasta2016 == true)
            {
                formateada=patenteAjustada;
                return "Automoviles y camionestas hasta 2016";
            }

            bool isDesde2016 = patenteAjustada.Length == 7;
            for(int n = 0; n < patenteAjustada.Length && isDesde2016==true; n++)
            {

                char d=patenteAjustada[n];
                isDesde2016 &= (char.IsLetter(d) && n<2) || (char.IsLetter(d) && n<5 && n>=3 || (char.IsLetter(d) && n<7 && n>2));
            }
            if(isDesde2016 == true)
            {
                formateada = patenteAjustada;
                return "Automoviles y camionetas desde 2016";
            }

            bool motocicleta = patenteAjustada.Length == 8;
            for(int n = 0;n < patenteAjustada.Length && motocicleta==true;n++)
            {
                char d=patenteAjustada[n];
                motocicleta &= (char.IsLetter(d) && n < 2) || (char.IsNumber(d) && n < 5 && n >= 2 || (char.IsLetter(d) && n < 8 && n >= 5));
            }
            if(motocicleta == true)
            {
                formateada=patenteAjustada;
                return "Motocicleta";
            }

            bool Acoplado = patenteAjustada.Length == 6;
            for (int n = 0; n < patenteAjustada.Length && Acoplado == true; n++)
            {
                char d = patenteAjustada[n];
                Acoplado &= (char.IsLetter(d) && n < 2) || (char.IsNumber(d) && (n < 6 && n >= 2));
            }
            if(Acoplado == true)
            {
                formateada = patenteAjustada;
                return "Acoplado";
            }
            else
            {
                formateada = patenteAjustada;
                return "Pertenecec a otro tipo de patente"+formateada.ToString();
            }
            
        }
        

        
    }
}
