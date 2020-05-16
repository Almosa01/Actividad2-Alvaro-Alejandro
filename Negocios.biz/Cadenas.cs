using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEval2
{
    public class Cadenas
    {
        #region Atributos y Propiedades
        private string palabra;
        
        public string Palabra { get { return palabra; } }
        #endregion

        #region Constructor
        public Cadenas(string pal)
        {
            palabra = pal;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Recibe un string por parámetro y devuelve su primer carácter.
        /// </summary>
        /// <param name="frase">String a calcular</param>
        /// <returns>Carácter calculado.</returns>
        public char PrimerCaracter()
        {
            return palabra[0];
        }

        /// <summary>
        /// Recibe un string por parámetro y devuelve su último carácter.
        /// </summary>
        /// <param name="frase">String a calcular</param>
        /// <returns>Carácter calculado.</returns>
        public char UltimoCaracter()
        {
            int ultimo = palabra.Length - 1;
            return palabra[ultimo];
        }

        /// <summary>
        /// Recibe un string por parámetro y devuelve el carácter indicado por parámetro.
        /// </summary>
        /// <param name="frase">String a calcular</param>
        /// <returns>Carácter calculado.</returns>
        public string ElegirCaracter(int numero)
        {
            if (numero > palabra.Length)
            {
                return "El numero excede los caracteres existentes";
            }
            else
            {
                return palabra.Substring(numero, 1);
            }
        }
        #endregion
    }
}
