using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BAITAPHDT2
{
    class Danhsachphim
    {
        const string test = "test.txt";      
        List<string> thongtin = new List<string>();
        public void layDSphim()
        {
            List<string> thongtin = new List<string>();
            List<string> thoigian = new List<string>();
            List<string> tenphim = new List<string>();
            DateTime ngayhientai = new DateTime(2016, 12, 6);
            StreamReader reader = new StreamReader(test);
            Console.WriteLine("");
            while (!reader.EndOfStream)
            {
                thongtin.Add(reader.ReadLine());
            }
            reader.Close();
            for (int i = 0; i < thongtin.Count; i++)
            {
                string a = thongtin.ElementAt(i);
                string[] tt = thongtin.ElementAt(i).Split(' ');
                thoigian.Add(tt[4]);
                tenphim.Add(tt[0]);
            }
            string[] thoigian2 = thoigian.ToArray();
            string[] tenphim2 = tenphim.ToArray();
            Console.WriteLine("Danh sach phim dang chieu :");
            for (int i = 0; i < thoigian2.Length; i++)
            {
                if (DateTime.Compare(ngayhientai, Convert.ToDateTime(thoigian2[i])) == 0)
                    Console.WriteLine(tenphim2[i]);
            }
           
            Console.WriteLine("");
            Console.WriteLine();
      

        }
        public void layDSrap()
        {
            StreamReader reader = new StreamReader(test);
            while (!reader.EndOfStream)         
            {
                thongtin.Add(reader.ReadLine());
            }
            reader.Close();
            Console.WriteLine("");
            Console.WriteLine("Danh sach cac rap phim: ");
            Console.WriteLine();
            for (int i = 0; i < thongtin.Count; i++)
            {
                string a = thongtin.ElementAt(i);
                string[] tt = thongtin.ElementAt(i).Split(' ');
                Console.WriteLine(tt[1]+" "+tt[2]);

            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine();
        }
        public void layDSngay_xuatchieu ()
        {
            StreamReader reader = new StreamReader(test);
            while (!reader.EndOfStream)
            {
                thongtin.Add(reader.ReadLine());
            }
            reader.Close();
            Console.WriteLine("");
            Console.WriteLine("Danh sach cac suat chieu: ");
            Console.WriteLine();
            
            for (int i = 0; i < thongtin.Count; i++)
            {
                string a = thongtin.ElementAt(i);
                string[] tt = thongtin.ElementAt(i).Split(' ');
                Console.WriteLine(tt[3] + " " + tt[4]);

            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine();

        }
        public void layDsve()
        {
            Console.WriteLine("Gia ve vip: 200$");
            Vevip vip = new Vevip();
            Console.WriteLine("so luong ve vip: {0}", vip.layslvevip2().Count);
            Console.WriteLine("Gia ve thuong: 100$");
            Vethuong thuong = new Vethuong();
            Console.WriteLine("So luong ve thuong: {0}", thuong.layslvethuong2().Count);
            Console.WriteLine();
            
         
        }


    }
}
