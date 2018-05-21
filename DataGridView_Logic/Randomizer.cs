using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BL;

namespace DataGridView_Logic
{
    public class Randomizer
    {
        private Random rm = new Random();

        public List<BL_Student> Rand()
        {
            List<BL_Student> spisok = new List<BL_Student>();
            int sq = 10, r_kurs, r_group; // sq - количество студентов
            double[] values;
            double sredball;
            DateTime date;
            string r_fio;
            for (int i = 0; i < sq; i++)
            {
                r_fio = Fio();
                date = Rojdennie();
                r_kurs = Kurs();
                values = Values(r_kurs);
                r_group = Group();
                sredball = SredBall(values, r_kurs);
                BL_Student p = new BL_Student(r_fio,date,values,r_kurs,r_group,sredball);
                spisok.Add(p);
            }
            return spisok;
        }

        public string Fio()
        {
            string[] names = { "Олег", "Виктор", "Василий", "Петр", "Александр", "Геннадий", "Сергей", "Евгений", "Алексей", "Борис" };
            string[] surnames = { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Морозов", "Волков", "Лебедев" };
            string[] patronymics = { "Ильич", "Сергеевич", "Никитич", "Олегович", "Матвеевич", "Денисович", "Геннадьевич", "Андреевич", "Аристархович", "Бенедиктович" };
            int r_n = rm.Next(9), r_s = rm.Next(9), r_p = rm.Next(9);
            string r_fio = surnames[r_s] + " " + names[r_n] + " " + patronymics[r_p];
            return r_fio;
        }

        public DateTime Rojdennie ()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (new DateTime(2000, 1, 1) - start).Days;
            start = start.AddDays(rm.Next(range));
            return start;
        }

        public int Kurs()
        {
            int r_kurs = rm.Next(1, 6);
            return r_kurs;
        }

        public double[] Values(int n)
        {
            double[] values = new double[n * 2];
            for (int j = 0; j < n * 2; j++)
            {
                values[j] = rm.NextDouble() * (5 - 3) + 3;
                values[j] = Math.Round(values[j], 2);
            }
            return values; 
        }

        public double SredBall(double[] arr, int n)
        {
            double sum = 0;
            for (int j = 0; j < n * 2; j++)
            {
                sum += arr[j];
            }
            sum = Math.Round(sum / (n * 2), 2);
            return sum;
        }

        public int Group()
        {
            int r_group = rm.Next(1, 6);
            return r_group;
        }
    }
}
