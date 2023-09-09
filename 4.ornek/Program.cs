internal class Program
{
    public static void Main(string[] args)
    {
        
        // 4.Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        
        Console.Write("Lutfen bir cumle giriniz:");
        string cumle=Console.ReadLine();
        string[] kelime=cumle.Split(' ');
        int k=kelime.Length;

        char[] harf= cumle.Replace(" ","").ToCharArray();
        int h=harf.Length;

        Console.WriteLine("Kelime sayisi: {0}, Harf sayisi: {1}",k,h);

        Console.ReadKey();

    }
}