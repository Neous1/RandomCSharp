using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphismVirtualFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Caller();
            var r = new Rectangle(10, 7);
            var t = new Triangle(10, 5);
            c.CallArea(r);
            c.CallArea(t);
            
        }
    }
}
