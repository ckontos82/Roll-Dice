using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp
{
    internal class Die
    {
        private readonly int side;
        private Random random = new Random();

        public Die()
        {
            side = random.Next(1, 7);
        }

        public int Side
        {
            get { return side; }
        }

    }
}
