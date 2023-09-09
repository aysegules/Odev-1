internal class Program
{
    public static void Main(string[] args)
    {
        /*
        1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        */
        
        Console.Write("Lütfen pozitif bir sayi girin:");
        int sayi=Convert.ToInt32(Console.ReadLine());

        int[] dizi=new int[sayi];
        Console.WriteLine("Lütfen {0} adet sayi giriniz:",sayi);
        for (int i = 0; i <sayi; i++)
        {
            Console.WriteLine("{0}. sayi: ",i+1);
            dizi[i]=Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Girdiginiz sayilar icerisindeki cift sayilar:");
        foreach (var eleman in dizi)
        {
            if(eleman % 2==0)
            {
                Console.WriteLine(eleman);
            }
        }

    }
}