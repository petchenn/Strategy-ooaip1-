using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooaip1
{
    class Sort
    {
        public ISort sort { get; set; }
        public Sort(ISort sort)
        {
            this.sort = sort;
        }

        public int[] Ssort(int[] array, bool org)
        {
            return sort.Sort(array, org);
        }
    }
}
