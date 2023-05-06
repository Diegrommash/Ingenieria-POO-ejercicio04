using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Clases
{
    public class Barril
    {
        private string _numeroDeBarril;

        public string NumeroDeBarril
        {
            get { return _numeroDeBarril; }
            set { _numeroDeBarril = value; }
        }

        private Cerveza cerveza;

        public Cerveza Cerveza
        {
            get { return cerveza; }
            set { cerveza = value; }
        }

    }
}
