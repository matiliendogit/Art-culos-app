using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace utilidades
{
    public class Validaciones
    {
     
        public bool esNumero(string valor)
        {
            return decimal.TryParse(valor.Trim(), NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
        }

        public bool esPrecioValido(string precioTexto)
        {
            if (string.IsNullOrWhiteSpace(precioTexto))
            {
                return false;
            }

            if(precioTexto.Count(c => c == '.') > 1 || precioTexto.Contains(','))
            {
                return false;
            }

            if(precioTexto.Count(c => c == '.') == 1)
            {
                int cantidadDecimales = contarDecimales(precioTexto);
                if (cantidadDecimales > 2)
                {
                    return false;
                }else if (cantidadDecimales == 1)
                {
                    precioTexto += "0";
                }
            }else
            {
                precioTexto += ".00";
            }
            return true;
        }

        public bool precioEnRango(string precioTexto, decimal limiteInferior, decimal limiteSuperior)
        {
            decimal precio = decimal.Parse(precioTexto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            if (precio < limiteInferior || precio > limiteSuperior)
            {
                return false;
            }
            return true;
        }

        public int contarDecimales(string valor)
        {
            int indicePuntoDecimal = valor.Trim().IndexOf('.');
            if (indicePuntoDecimal == -1)
            {
                return 0;
            }
            else
            {
                return valor.Trim().Length - indicePuntoDecimal - 1;
            }
        }

        public bool caracteresEnRango(string texto, int limiteInferior, int limiteSuperior)
        {
            if (string.IsNullOrEmpty(texto))
                return false;
            if(string.IsNullOrWhiteSpace(texto) && limiteInferior > 0)
                return false;
            if (texto.Length < limiteInferior || texto.Length > limiteSuperior)
                return false;
                
            return true;
        }

        public int cantidadDePalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        } 

        public bool EsCodigoValido(string codigo)
        {
            if(!caracteresEnRango(codigo, 3, 1000))
                return false;
            // Expresión regular para validar el formato del código: empieza con una mayúscula y le siguen al menos 2 numeros enteros
            string patron = @"^[A-Z]\d{2,}$";

            return Regex.IsMatch(codigo, patron);
        }

        public string ObtenerPrimeraPalabra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return string.Empty;
            }

            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length > 0 ? palabras[0] : string.Empty;
        }
        public bool EsSoloLetras(string palabra)
        {
            //Solo letras incluyendo tildes, diéresis y ñ
            return Regex.IsMatch(palabra, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+$");
        }
    }
}
