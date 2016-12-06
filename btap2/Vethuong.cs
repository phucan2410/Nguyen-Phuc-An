using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BAITAPHDT2
{
    class Vethuong: Ve
    {
        List<string> vethuong = new List<string>();
        public override int gangiave()
        {
            return 100;
            
        }
        int conlai;
        public Vethuong ( string mave , bool daban): base(mave ,daban) { }
        public  override string inve()
        {
            return string.Format(Mave + " "  + " "+Giave );

        } 
        public Vethuong() { }
        public void layslvethuong()
        {
            
            StreamReader read = new StreamReader("vethuong.txt");
            while (!read.EndOfStream)
            {
                vethuong.Add(read.ReadLine());
            }
            read.Close();
            foreach ( string i in vethuong)
                Console.WriteLine(i);
        }
        public List<string> layslvethuong2 ()
        {
            List<string> vethuong = new List<string>();
            StreamReader read = new StreamReader("vethuong.txt");
            while (!read.EndOfStream)
            { vethuong.Add(read.ReadLine()); }
            read.Close();
            return vethuong;
        }
        public int slveconlai(int a )
        {
           ;
            return layslvethuong2().Count - a;
        }
        public void inveconlai()
        {
            Console.WriteLine( " so luogn con lai"  );
           for( int i =conlai;i<vethuong.Count;i++)
            {
                Console.WriteLine(vethuong.ElementAt(i));
            }
            
        }
       
       
    }
}
