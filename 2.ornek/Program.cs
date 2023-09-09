using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        /*
        2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */
        Console.Write("Lutfen 1. pozitif sayiyi giriniz:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.Write("Lutfen 2. pozitif sayiyi giriniz:");
        int m=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lutfen {0} adet pozitif sayi giriniz:", n);

        int[] dizi=new int[n];

        for (int i = 0;  i< n; i++)
        {
            Console.WriteLine("{0}. sayi:",i+1);
            dizi[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girilen sayilardan {0} e esit olanlar veya tam bolunenler:",m);
        foreach (var eleman in dizi)
        {
            if(eleman == m || eleman % m ==0)
            {
                Console.WriteLine(eleman);
            }
        } 

    }
}