using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result =1;
            for (int i = 0; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler istance = new Islemler();
            Console.WriteLine(istance.Expo(3, 4));

            string ifade = "Mahmut Muhammet Çevik";
            bool sonuc = ifade.CheckSpances();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemovethiteSpaces());
            }
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());

            int[] dizi = { 9, 3, 5, 7, 1, 8, 2, 4, 6, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEventNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
                return sayi;
            return Expo(sayi, us-1)*sayi;
        }
    }

    public static class Extansion 
    {
        private const string V = "";

        public static bool CheckSpances(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemovethiteSpaces(this string param)
        {
            string[] dizi = param.Split();
            return string.Join("", dizi);
        }

        public static string MakeUperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLoverCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }

        public static bool IsEventNumber(this int param) { return param%2 == 0; }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }

}
