using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Clases
{
    public class Venta
    {
        private List<ItemVenta> _items;

        public List<ItemVenta> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private decimal _total;

        public decimal Total
        {
            get 
            { 
                CalcularTotal();
                return _total; 
            }
        }

        private void CalcularTotal()
        {
           foreach (var item in _items)
           {
                _total += item.SubTotal;
           };
        }


    }
}
