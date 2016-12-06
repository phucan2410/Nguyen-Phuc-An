using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BAITAPHDT2
{
    class Vevip: Ve
    {
        
        List<string> vevip = new List<string>();
        public override int gangiave()
        {
            return 200;
        }
        public Vevip(string mave, bool daban):base(mave,daban) { }
        public override string inve()
        {
            return string.Format(Mave  + " " + Giave);
        } 
        public  Vevip() { }
        public void layslvevip()
        {
            StreamReader read = new StreamReader("vevip.txt");
            while( !read.EndOfStream)
            {
                
                vevip.Add(read.ReadLine());
            }
            read.Close();
            foreach (string i in vevip)
                Console.WriteLine(i);

        }
        public List<string> layslvevip2()
        {
            StreamReader read = new StreamReader("vevip.txt");
            while (!read.EndOfStream)
            {
                vevip.Add(read.ReadLine());
            }
            read.Close();
            return vevip;
        }
        public int slconlai(int a )
        {
            return layslvevip2().Count - a ;
        }
        
    }
}
