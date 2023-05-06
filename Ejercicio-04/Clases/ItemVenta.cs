using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Clases
{
    public class ItemVenta
    {
        private Barril _barril;

        public Barril Barril
        {
            get { return _barril; }
            set { _barril = value; }
        }

        private Recipiente _recipiente;

        public Recipiente Recipiente
        {
            get { return _recipiente; }
            set { _recipiente = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private decimal _subTotal;

        public decimal SubTotal
        {
            get 
            {
                calcularSubTotal();
                return _subTotal; 
            }
        }

        private void calcularSubTotal()
        {
            _subTotal = _barril.Cerveza.Precio / _recipiente.Capacidad * _cantidad;
        }
    }
}
