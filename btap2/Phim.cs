using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHDT2
{
    class Phim
    {
        Ve ve;
        Thoigian date;
        static string tenphim;
        public string Tenphim { get; set; }
        static string tenrap;
        static string diachirap;
        public string Diachirap { get; set; }
        public string Tenrap { get; set; }
        public Thoigian Date { get; set; }
        public Phim (string tenphim , string tenrap , Thoigian date )
        {
            Tenphim = tenphim;
            Tenrap = tenrap;
            date = date;
            
        }
        public Phim() { }
        ~ Phim  ()
        {
            date =null;
            ve = null;
        }
      
        
    }
}
