using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class Customer
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public bool Active { get; private set; }

        public Customer(string name)
        {
            this.Id = 0;
            this.Name = name;
        }

        public void Activate()
        {
            this.Active = true;
        }
    }
}
