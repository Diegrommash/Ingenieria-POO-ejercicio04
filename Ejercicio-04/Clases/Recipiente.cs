using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Clases
{
    public class Recipiente
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private decimal _capacidad;

        public decimal Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }


    }
}
