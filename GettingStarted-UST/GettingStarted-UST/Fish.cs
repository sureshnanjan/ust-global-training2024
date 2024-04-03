using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class Fish : Pet, ICookable, IMoveable
    {
        public override void Feed() {
        
        }

        public void GetCooked()
        {
            throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
