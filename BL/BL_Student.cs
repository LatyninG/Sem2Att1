using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    [Serializable]
    public class BL_Student
    {
        public string Fio { get; private set; }
        public DateTime Year { get; private set; }
        public String MedB { get; private set; }
        public int Kurs { get; private set; }
        public int Group { get; private set; }
        public double Sred_ball { get; set; }

        public BL_Student(string fio, DateTime year, List<double> medB, int kurs, int group, double sred_ball)
        {
            Fio = fio;
            Year = year;
            MedB = ListToString(medB);
            Kurs = kurs;
            Group = group;
            Sred_ball = sred_ball;
        }

       public string ListToString (List<double> medB)
        {
            return string.Join(", ", medB);
        }
    }
}
