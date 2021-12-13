using Odevdeneme;
using System;

namespace odevdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new MLModel1.ModelInput();
            Console.WriteLine("FUTBOLCUNUN PİYASA DEĞERİNİ TAHMİN EDEN PROGRAM\n");

            args = new string[9];

            sampleData.Name = args[0];
            sampleData.Position = args[1];
            sampleData.Age = args[2];
            sampleData.Country = args[3];
            sampleData.Club = args[4];
            sampleData.Goals = args[5];
            sampleData.Assists = args[6];
            sampleData.Yellow_Cards = args[7];
            sampleData.Red_Cards = args[8];


          

            for (int i = 0; i < args.Length; i++)

            {
                Console.WriteLine("Oyuncunun İsmini Yazınız :");
                sampleData.Name = Console.ReadLine();
                Console.WriteLine(@"Oyuncu adı : " + sampleData.Name);

                Console.WriteLine("Oyuncunun Pozisyonunu Yazınız :");
                sampleData.Position = Console.ReadLine();
                Console.WriteLine(@"Pozisyon : " + sampleData.Position);

                Console.WriteLine("Oyuncunun yaşını Yazınız :");
                sampleData.Age = Console.ReadLine();
                Console.WriteLine(@"Yaş : " + sampleData.Age);

                Console.WriteLine("Oyuncunun ülkesini Yazınız :");
                sampleData.Country = Console.ReadLine();
                Console.WriteLine(@"Ülke : " + sampleData.Country);

                Console.WriteLine("Oyuncunun kulübünü Yazınız :");
                sampleData.Club = Console.ReadLine();
                Console.WriteLine(@"Kulüp : " + sampleData.Club);


                Console.WriteLine("Oyuncunun gol sayısını Yazınız :");
                sampleData.Goals = Console.ReadLine();
                Console.WriteLine(@"Gol : " + sampleData.Goals);

                Console.WriteLine("Oyuncunun asist sayısını Yazınız :");
                sampleData.Assists = Console.ReadLine();
                Console.WriteLine(@"Asist : " + sampleData.Assists);

                Console.WriteLine("Oyuncunun gördüğü sarı kart sayısını Yazınız :");
                sampleData.Yellow_Cards = Console.ReadLine();
                Console.WriteLine(@"Sarı kart : " + sampleData.Yellow_Cards);

                Console.WriteLine("Oyuncunun gördüğü kırımızı kart Yazınız :");
                sampleData.Red_Cards = Console.ReadLine();
                Console.WriteLine(@"Kırmızı kart : " + sampleData.Red_Cards);

                var result = MLModel1.Predict(sampleData);
                Console.WriteLine($"\n\nToplam Piyasa Değeri : {result.Score} Milyon Euro\n\n");



            }
            Console.ReadLine();




        }

    }
}

