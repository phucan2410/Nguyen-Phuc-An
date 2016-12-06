using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.IO;

namespace BAITAPHDT2
{
    class Thoigian
    {
        List<string> ngaychieu = new List<string>();
        List<string> suatchieu = new List<string>();
        
        private DateTime ngay;
        private string suat;
        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public string Suat
        {
            get { return suat; }
            set { suat = value; }
        }
       
     public  Thoigian() { }
        public Thoigian( DateTime ngay, string suat)
        {
            Ngay = ngay;
            Suat = suat;
        }
        public List<string> dsngaychieu ( )
        {
            StreamReader read = new StreamReader("ngaychieu.txt");
            while (!read.EndOfStream)
            { ngaychieu.Add(read.ReadLine()); }
            read.Close();
            return ngaychieu;
        }
        public List<string> dssuatchieu()
        {
            StreamReader read2 = new StreamReader("giochieu.txt");
            while (!read2.EndOfStream)
            { suatchieu.Add(read2.ReadLine()); }
            read2.Close();
            return suatchieu;
        }
      



    }
}
