using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public interface IOrderInterface
    {
        int type { get; set; }
        int quantity { get; set; }
        int counter { get; set; }
    }
    public class Order : IOrderInterface
    {
        public int type { get; set; }
        public int quantity { get; set; }
        public int counter { get; set; }
    }
    public class OrderDI
    {
        public IOrderInterface o = null;
        public OrderDI(IOrderInterface or)
        {
            this.o = or;
        }
    }
}
