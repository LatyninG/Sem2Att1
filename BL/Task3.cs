using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Task3
    {
        public List<BL_Student> St { get; private set; }
        public Task3 (List<BL_Student> st)
        {
            this.St = st;
        }

        public int Best_group()
        {
            int max_group = St[0].Group;
            for (int i = 0; i < St.Count; i++)
            {
                if (St[i].Group > max_group)
                    max_group = St[i].Group;
            }
            double[] sum = new double[max_group];
            int[] counter = new int[max_group];
            for (int i = 0; i < St.Count; i++)
            {
                sum[St[i].Group-1] += St[i].Sred_ball;
                counter[St[i].Group-1]++;
            }
            for (int i = 0; i < max_group; i++)
            {
                if (counter[i] != 0)
                    sum[i] /= counter[i];
                else
                    sum[i] = 0;
            }
            double max_element = sum.Max();
            int group = Array.IndexOf(sum, max_element) + 1;
            return group;
        }

        public List<BL_Student> BGL (int group)
        {
            List<BL_Student> bgl = new List<BL_Student>();
            for (int i = 0; i < St.Count; i++)
            {
                if (St[i].Group == group)
                {
                    BL_Student p = St[i];
                    bgl.Add(p);
                }
            }
            return bgl;
        }
    }
}
