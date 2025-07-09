using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03
{
    public class Thing : IInventory
    {
        public int Number { get; set; }
        public string Description { get; set; }
    }
}
