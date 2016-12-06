using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace BAITAPHDT2
{
    class Program
    {


        static void Main(string[] args)
        {
            int luachon = 0;
            int sovethuong = 0, sovevip = 0;
            int xlmenu = 0;
            string back;
            Thoigian thoigian = new Thoigian();
            Phim phim = new Phim();
            Menu(ref xlmenu);
            switch (xlmenu)
            {
                case 1:
                    Hienthi1();
                    break;
                case 2:
                    Hienthi2(ref phim, ref thoigian, ref sovethuong, ref sovevip);
                    Hienthi3(ref phim, ref thoigian, ref sovethuong, ref sovevip);
                    break;
                case 3:
                    Console.WriteLine("Chuc nang danh cho nguoi quan ly");
                    Console.WriteLine("1 - Chuc nang lay so luong ve con lai va da ban");
                    Console.WriteLine("2 - Chuc nang hien thi phim dang chieu" );
                    Console.WriteLine("3 - Chuc nang hien thi phim sap chieu");
                    Console.WriteLine("4 - Chuc nang hien thi rap tham gia he thong");
                    Console.WriteLine(" Moi ban chon");

                    int chucnang = int.Parse(Console.ReadLine());
                    while ((chucnang > 4) || (chucnang < 1))
                    {
                        Console.WriteLine("Ban chon so nam ngoai pham vi cac so tren menu.");
                        Console.Write("Moi ban chon lai :");
                        chucnang = int.Parse(Console.ReadLine());
                    }
                    switch (chucnang)
                    {
                        case 1:
                            Hienthiveconlai( ref sovethuong, ref  sovevip);
                            break;
                        case 2:
                            Hienthiphimdangchieu();
                            break;
                        case 3:
                            Hienthiphimsapchieu();
                            break;
                        case 4:
                            Hienthidanhsachrap();
                            break;
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
           
            Console.ReadLine();
        }
        public static void Hienthi1()
        {
            Danhsachphim dsp = new Danhsachphim();
            dsp.layDSphim();
            dsp.layDSrap();
           dsp.layDSngay_xuatchieu();
            dsp.layDsve();

        }
        public static void Hienthi2(ref Phim phim, ref Thoigian thoigian, ref int sovethuong, ref int sovevip)
        {
            chonphim(ref phim);
            chonrap(ref phim);
            chonngaychieu(ref thoigian);
            phim.Date = thoigian;
            chonve(ref sovethuong, ref sovevip);
        }
        public static void Hienthi3(ref Phim phim, ref Thoigian thoigian, ref int sovethuong, ref int sovevip)
        {
            Console.WriteLine(" Thong Tin Dat Ve Cua Quy Khach :");
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Ten Phim : {0}", phim.Tenphim);
            Console.WriteLine("Rap Phim : {0}", phim.Tenrap);
            Console.WriteLine("Dia Chi Rap phim : {0}", phim.Diachirap);
            Console.WriteLine("Ngay Chieu : {0}", phim.Date.Ngay, phim.Date.Suat);
            Console.WriteLine("Suat Chieu : {0}", phim.Date.Suat);
            Console.WriteLine("Ma ve tuong ung: " + invedaban(sovethuong, sovevip));
            Console.WriteLine(tinhtongtien(sovethuong, sovevip));
            Console.WriteLine("");
        }
        public static void chonphim(ref Phim phim)
        {

            Danhsachphim dsp = new Danhsachphim();
            dsp.layDSphim();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Moi ban chon phim ");
            string stt = Console.ReadLine();
            phim.Tenphim = stt;
            Console.WriteLine();

        }
        public static void chonrap(ref Phim phim)
        {

            Danhsachphim dsp = new Danhsachphim();
            dsp.layDSrap();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Moi ban chon rap");
            Console.WriteLine("( Yeu cau: Nhap dung rap )");
            string stt = Console.ReadLine();
            phim.Tenrap = stt;
            Console.WriteLine("Moi ban nhap dia chi rap");
            Console.WriteLine("( Yeu cau: Nhap dung dia chi rap )");
            phim.Diachirap = Console.ReadLine();

        }
        public static void chonngaychieu(ref Thoigian thoigian)
        {
            Danhsachphim dsp = new Danhsachphim();

            dsp.layDSngay_xuatchieu();
            Console.WriteLine("Moi ban chon ngay chieu ");
            Console.WriteLine("( Yeu cau: Nhap dung thong tin )");
            DateTime ngay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Moi ban chon  suat chieu");
            Console.WriteLine("( Yeu cau: Nhap dung thong tin )");
            string suat = Console.ReadLine();
            thoigian.Suat = suat;
            thoigian.Ngay = ngay;

        }
        public static void chonve(ref int sovethuong, ref int sovevip)
        {
            Console.WriteLine("Chon loai ve :\n 1 _ Thuong\n 2 _ Vip \n 3 _ Cahai");
            Console.WriteLine("Yeu cau nhap dung thong tin ------- Nhap theo dang - VD:Thuong");
            string a = Console.ReadLine();                                         
            while (a != "Thuong" && a != "Vip" && a != "Cahai")
            {
                Console.WriteLine("nhap lai");
                a = Console.ReadLine();
            }
            if (a == "Thuong")
            {
                Console.WriteLine("so luong ve thuong ");
                int sl = int.Parse(Console.ReadLine());
                int sovethuong2 = 0;
                chonvethuong(sl, ref sovethuong2);
                sovethuong = sovethuong2;

            }
            else if (a == "Vip")
            {

                Console.WriteLine("so luong ve vip");
                int sl = int.Parse(Console.ReadLine());
                int sovevip2 = 0;
                chonvevip(sl, ref sovevip2);
                sovevip = sovevip2;
            }
            else
            {

                Console.WriteLine("so luong ve thuong ");
                int sl = int.Parse(Console.ReadLine());
                Console.WriteLine("so luong ve vip");
                int sl2 = int.Parse(Console.ReadLine());
                int sovethuong2 = 0, sovevip2 = 0;
                choncahai(sl, sl2, ref sovethuong2, ref sovevip2);
                sovethuong = sovethuong2;
                sovevip = sovevip2;
            }
        }
        public static void chonvethuong(int sl, ref int sovethuong2)
        {
            Vethuong[] vt = new Vethuong[sl];
            Vethuong vethuong2 = new Vethuong();
            List<string> xx = vethuong2.layslvethuong2();
            for (int i = 0; i < sl; i++)
            {
                vt[i] = new Vethuong();
                vt[i].Mave = xx.ElementAt(i);
                vt[i].Giave = vt[i].gangiave();
                vt[i].Daban = true;
            }
            sovethuong2 = vt.Length;

        }
        public static void chonvevip(int sl, ref int sovevip2)
        {

            Vevip[] vv = new Vevip[sl];
            Vevip vevip2 = new Vevip();
            List<string> yy = vevip2.layslvevip2(); 

            for (int i = 0; i < sl; i++)
            {
                vv[i] = new Vevip();
                vv[i].Mave = yy.ElementAt(i);
                vv[i].Giave = vv[i].gangiave();
                vv[i].Daban = true;
            }
            sovevip2 = vv.Length;

        }
        public static void choncahai(int sl, int sl2, ref int sovethuong2, ref int sovevip2)
        {
            Vethuong vethuong2 = new Vethuong();
            List<string> xx = vethuong2.layslvethuong2();
            Vevip vevip2 = new Vevip();
            List<string> yy = vevip2.layslvevip2();
            Ve[] ch = new Ve[sl + sl2];
            int i, j = 0;
            for (i = 0; i < sl + sl2; i++)
            {
                ch[i] = new Vethuong();
                ch[i].Mave = xx.ElementAt(i);
                ch[i].Giave = ch[i].gangiave();
                ch[i].Daban = true;
            }
            for (i = sl; i < sl + sl2; i++)
            {
                ch[i] = new Vevip();
                ch[i].Mave = yy.ElementAt(j);
                ch[i].Giave = ch[j].gangiave();
                ch[i].Daban = true;
                j++;
            }
            sovevip2 = j;
            sovethuong2 = ch.Length - sovevip2;



        }
        public static string tinhtongtien(int sovethuong, int sovevip)
        {
            string a = string.Format("So tien ban can thanh thoan la :{0}", sovethuong * 100 + sovevip * 200);
            return a;
        }
        public static string invedaban(int sovethuong, int sovevip)
        {
            if (sovethuong != 0 && sovevip == 0)
            {
                Vethuong vethuong = new Vethuong();
                List<string> mave = vethuong.layslvethuong2();
                string inve = "";

                for (int i = 0; i < sovethuong; i++)
                    inve = inve + mave.ElementAt(i) + "    ";
                return inve;
            }

            else if (sovethuong == 0 && sovevip != 0)
            {
                Vevip vevip = new Vevip();
                List<string> mave = vevip.layslvevip2();
                string inve = "";
                for (int i = 0; i < sovevip; i++)
                    inve = inve + mave.ElementAt(i) + "    ";
                return inve;
            }
            else
            {
                Vethuong vethuong = new Vethuong();
                List<string> mave1 = vethuong.layslvethuong2();
                Vevip vevip = new Vevip();
                List<string> mave2 = vevip.layslvevip2(); string inve = "";
                int i, j = 0;
                for (i = 0; i < sovethuong; i++)
                {
                    inve = inve + mave1.ElementAt(i) + "    ";
                }
                for (i = sovethuong; i < sovethuong + sovevip; i++)
                {
                    inve = inve + mave2.ElementAt(j) + "   "; j++;
                }
                return inve;
            }
        }
        public static void Hienthiveconlai(ref int sovethuong, ref int sovevip)
        {
            Vethuong vethuong = new Vethuong();
            Vevip vevip = new Vevip();
            int a = vethuong.slveconlai(sovethuong) + vevip.slconlai(sovevip);
            Console.WriteLine("So luong ve con lai la : {0}", a);
            Console.WriteLine("So luong ve da ban la : {0}", sovethuong + sovevip);
        }
        public static void Hienthiphimdangchieu()
        {
            List<string> thongtin = new List<string>();
            List<string> thoigian = new List<string>();
            List<string> tenphim = new List<string>();
            DateTime ngayhientai = new DateTime(2016, 12, 6);
            Console.WriteLine("Ngay hien tai :" + ngayhientai.ToShortDateString());
            StreamReader reader = new StreamReader("test.txt");
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

        }
        public static void Hienthiphimsapchieu()
        {
            List<string> thongtin = new List<string>();
            List<string> thoigian = new List<string>();
            List<string> tenphim = new List<string>();
            DateTime ngayhientai = new DateTime(2016, 12, 6);
            Console.WriteLine("Ngay hien tai :" + ngayhientai.ToShortDateString());
            StreamReader reader = new StreamReader("test.txt");
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
            Console.WriteLine("Danh sach phim sap chieu :");
            for (int i = 0; i < thoigian2.Length; i++)
            {
                if (DateTime.Compare(ngayhientai, Convert.ToDateTime(thoigian2[i])) < 0)
                    Console.WriteLine(tenphim2[i]);
            }
        }
        public static void Hienthidanhsachrap()
        {
            Danhsachphim a = new Danhsachphim();
            a.layDSrap();
        }
        public static void Hienthichucnang(ref int sovethuong, ref int sovevip)
        {
            Hienthiveconlai(ref sovethuong, ref sovevip);
            Hienthiphimdangchieu();
            Hienthiphimsapchieu();
            Hienthidanhsachrap();
        }
       
        public static void Menu( ref int xlmenu )
        {
            Console.WriteLine("CHUONG TRINH BAN VE TU DONG");
            Console.WriteLine();
            Console.WriteLine("1 Hien thi thong tin phim dang chieu");
            Console.WriteLine("2 Chon mua ve va xem thong tin ve da chon");
            Console.WriteLine("3 Cac thong tin thong ke danh cho quan ly");
            Console.WriteLine("4 Thoat ra khoi chuong trinh");
            Console.WriteLine("");
            Console.WriteLine(" Tu 1 - 4, Ban hay chon chuc nang tuong ung ");
            Console.WriteLine("Yeucau : nhap theo so thu tu  hien thi chuc nang");
            Console.WriteLine("VD :1 Hien thi thong tin");
            Console.WriteLine("VD :2 Chon mua ve va xem thong tin ve da chon");
            Console.WriteLine("VD :3 Cac thong tin thong ke danh cho quan ly");
            Console.WriteLine("VD :4 Thoat"); 
            int menu = int.Parse(Console.ReadLine());
            xlmenu=XulyChonMenu( menu);
           
        }
        public static int XulyChonMenu( int menu)
        {
            
            while ((menu>4)||( menu<1))
            {
                Console.WriteLine("Ban chon so nam ngoai pham vi cac so tren menu.");
                Console.Write("Ban hay chon lai so khac :");
                menu = int.Parse(Console.ReadLine());
            }
            int menu2 = menu;
            
            return menu2;

        }
        
    }
}
