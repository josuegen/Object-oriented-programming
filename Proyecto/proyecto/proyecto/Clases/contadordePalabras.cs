using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class contadordePalabras
    {
        
        private int palabras = 0;
        private char[] discriminantes = new char[] { ' ', '\r', '\n' };

        public contadordePalabras()
        {

        }
        public int cantidadDePalabras(string texto)
        {
            palabras=texto.Split(discriminantes, StringSplitOptions.RemoveEmptyEntries).Length;
            return palabras;
        }
    }
}
