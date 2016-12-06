using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BAITAPHDT2
{
     abstract class Ve     
    {
        private bool daban;
        private int giave;
        private string mave;
        public string Mave
        {
            get { return mave; }
            set { mave = value; }
        }
        
        public bool Daban
        {
            get { return daban; }
            set { daban = value; }
        }
       
        public int Giave
        {
           get { return giave; }
            set {
                giave = value; }
        }
        public abstract int gangiave();    
        public abstract string inve();
        
        public Ve (string mave  ,bool daban)
        {
            Daban = daban;
            Mave = mave;
            Giave = gangiave();
        }
        public Ve() { }
        
        
    }
}
