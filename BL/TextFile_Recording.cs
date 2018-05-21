using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class TextFile_Recording
    {
        public string Path { get; private set; }
        public TextFile_Recording(string path)
        {
            this.Path = path;
        }

        public void Lel(int n, string[] k)
        {
            FileStream deb = new FileStream(Path, FileMode.Truncate, FileAccess.Write);
            StreamWriter ZapFile = new StreamWriter(deb);
            for (int i = 0; i <= n; i++)
            {
                ZapFile.WriteLine(k[i]);
            }
            ZapFile.Close();
            deb.Close();
        }
    }
}
