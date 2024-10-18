using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia6._1.Modelo
{
    internal class RegexProcesableImp1 : IPrueba
    {
        public string Procesar(string patente, out string formateada)
        {
            Match match = null;
            
            

            match=Regex.Match(patente,@"^[A-Z]{3}[\s-]*\d{3}$",RegexOptions.IgnoreCase);
            formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();

            if (match.Success)
            {
                
                return "Automoviles y camiontes hasta 2016 ";
            }

            match=Regex.Match(patente,@"^[A-Z]{2}[\s-]*\d{3}[A-Z]{2}$",RegexOptions .IgnoreCase);
            if (match.Success)
            {
                return "Automoviles y camionetas desde 2016 ";
            }
            match= Regex.Match(patente,@"^[A-Z]{2}[\s-]*\d{4}$",RegexOptions.IgnoreCase) ;
            if(match.Success)
            {
                return "Acoplado";
            }
            match = Regex.Match(patente, @"^[A-Z]{2}[\s-]*\d{4}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return "Motocicleta";
            }
            else
            {
                return "Otro" + patente;
            }
        }
    }
}
