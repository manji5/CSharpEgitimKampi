using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders33_35
{
    internal class Ogrenci
    {
        private int _not;

        public int Not
        {
            get { return _not; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Not değeri 0 ile 100 arasında olmalıdır.");
                }

                _not = value;
            }
        }
    }
}
