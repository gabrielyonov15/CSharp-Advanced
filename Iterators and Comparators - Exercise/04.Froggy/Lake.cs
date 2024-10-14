using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;
        public Lake(params int[] stones)
        {
            this.stones = new List<int>(stones);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }
            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return stones[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}