using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace EnumeratorsAndEnumerables3
{
    public class sdarot : IEnumerable
    {
        public int num { get; set; }
        public sdarot(int num)
        {
            this.num = num;
        }
        
      

        public IEnumerator GetEnumerator()
        {
           
            for (int i = 1; i <= 10; i++)
            {
                
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
    }
}
