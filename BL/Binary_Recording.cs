using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace BL
{
    public class Binary_Recording
    {
        public string Path { get; private set; }
        public Binary_Recording(string path)
        {
            this.Path = path;
        }

        public void Write(List<BL_Student> people)
        {
            FileStream fs = new FileStream(Path,FileMode.Truncate,FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, people);
            fs.Close();
        }

        public List<BL_Student> Read()
        {
            FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            List<BL_Student> people = (List<BL_Student>)formatter.Deserialize(fs);
            fs.Close();
            return people;
        }
    }
}
