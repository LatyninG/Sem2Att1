using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Task3
    {

        public int Best_group(List<BL_Student> st)
        {
            int group;
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            for (int i = 0; i < st.Count; i++)
            {
                group = st[i].Group;
                if (group == 1)
                {
                    sum1 += st[i].Sred_ball;
                    count1++;
                }
                else if (group == 2)
                {
                    sum2 += st[i].Sred_ball;
                    count2++;
                }
                else if (group == 3)
                {
                    sum3 += st[i].Sred_ball;
                    count3++;
                }
                else if (group == 4)
                {
                    sum4 += st[i].Sred_ball;
                    count4++;
                }
                else if (group == 5)
                {
                    sum5 += st[i].Sred_ball;
                    count5++;
                }
            }
            if( (sum1/count1 >= sum2/count2) && (sum1/count1 >= sum3/count3) && (sum1 / count1 >= sum4 / count4) && (sum1 / count1 >= sum5 / count5) )
            {
                group = 1;
                return group;
            }
            if ((sum2 / count2 > sum1 / count1) && (sum2 / count2 >= sum3 / count3) && (sum2 / count2 >= sum4 / count4) && (sum2 / count2 >= sum5 / count5) )
            {
                group = 2;
                return group;
            }
            if ((sum3 / count3 > sum1 / count1) && (sum3 / count3 > sum2 / count2) && (sum3 / count3 >= sum4 / count4) && (sum3 / count3 >= sum5 / count5) )
            {
                group = 3;
                return group;
            }
            if ((sum4 / count4 > sum1 / count1) && (sum4 / count4 > sum2 / count2) && (sum4 / count4 > sum3 / count3) && (sum4 / count4 >= sum5 / count5) )
            {
                group = 4;
                return group;
            }
            else
            {
                group = 5;
                return group;
            }
        }

        public List<BL_Student> BGL (List<BL_Student> bl, int group)
        {
            List<BL_Student> bgl = new List<BL_Student>();
            for (int i = 0; i < bl.Count; i++)
            {
                if (bl[i].Group == group)
                {
                    BL_Student p = bl[i];
                    bgl.Add(p);
                }
            }
            return bgl;
        }
    }
}
