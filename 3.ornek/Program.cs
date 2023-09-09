using System.Data;

internal class Program
{
    public static void Main(string[] args)
    {
       /*
       3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
       */

       Console.WriteLine("Lutfen pozitif bir sayi giriniz:");
       int n=Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("{0} adet kelime girin:",n);

       string[] dizi=new string[n];
       for (int i = 0; i < n; i++)
       {
        Console.WriteLine("{0}. kelime:",i+1);
        dizi[i]=Console.ReadLine();
       }

       Array.Reverse(dizi);
       Console.WriteLine("Sondan başa dogru girdiginiz kelimeler:");
       foreach (var eleman in dizi)
       {
            Console.Write(eleman);
       }
    }
}