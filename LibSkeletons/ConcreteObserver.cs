using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSkeletons
{
    public class ConcreteObserver : IObserver
    {
        int count=0;
        public int update()
        {
            return count++;
        }
    }
}
