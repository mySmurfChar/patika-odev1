namespace Algoritmalar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Alistirma1();
            program.Alistirma2();
            program.Alistirma3();
            program.Alistirma4();
        }
        private void Alistirma1()
        {
            Console.WriteLine("Alıştırma 1:");
            Console.WriteLine();
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Pozitif olmayan bir sayı girdiniz.");
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] array1 = new int[n];
            for (int i=0;i<array1.Length;i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int z in array1)
            {
                if (z % 2 == 0)
                {
                    Console.WriteLine(z.ToString());
                }

            }
        }
        private void Alistirma2()
        {
            Console.WriteLine("Alıştırma 2:");
            Console.WriteLine();
            Console.WriteLine("Lütfen 2 adet pozitif tamsayı giriniz.");
            Console.WriteLine("Birinci sayı:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayı:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen " + n.ToString() + " adet tamsayı giriniz.");
            int[] array2 = new int[n];
            Console.WriteLine(n.ToString() + " Kadar sayı giriniz");
            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine((i+1).ToString()+"\'ci sayıyı giriniz:");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int z in array2)
            {
                if(z%m==0||z==m)
                {
                    Console.WriteLine(z.ToString());
                }
            }


        }
        private void Alistirma3()
        {
            Console.WriteLine("Alıştırma 3:");
            Console.WriteLine();
            Console.WriteLine("Lütfen bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen n adet kelime giriniz.");
            string[] array3= new string[n];
            for(int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + "\'ci kelimeyi giriniz.");
                array3[i] = Console.ReadLine();

            }
            for(int i = array3.Length;i>0;i--)
            {
                Console.WriteLine(array3[i-1].ToString());
            }



        }
        private void Alistirma4()
        {
            Console.WriteLine("Alıştırma 4:");
            Console.WriteLine();
            Console.WriteLine("Lütfen bir cümle yazınız");
            string cumle = Console.ReadLine();
            int c = 0;
            for(int i = 0; i < cumle.Length; i++)
            {
                if(cumle.Substring(i, 1)!=" ")
                {
                    c++;//Harf sayısını hesaplar
                }
            }
            Console.WriteLine("Toplam harf sayısı:");
            Console.WriteLine(c.ToString());//Harf sayısını yazdırır
            int kelimeSayisi = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Toplam kelime sayısı:");
            Console.WriteLine(kelimeSayisi);



        }

    }
}
