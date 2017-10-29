using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{

    public class Video : Product
    {
        public int Playtime { get; private set; }

        public string Director { get; private set; }

        public Video(string title, decimal cost, int playtime, string director) : base(title, cost)
        {
            this.Director = director;
            this.Playtime = playtime;
        }

        public override string GetDescription()
        {
            return "Video "+ this.Title;
        }
    }

}
