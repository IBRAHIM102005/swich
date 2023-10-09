namespace swich_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DUKANIMIZA XOS GELMISINIZ!!! \n  mehsullardan birini secin: \n alma--1  \n armud--2  \n heyva--3 \n uzum--4");
            int mehsul=int.Parse( Console.ReadLine());
            Console.WriteLine("kilosunu qeyd edin:");
            int kilo=int.Parse(Console.ReadLine());

            switch (mehsul)
            {
                case 1:
                    int qiymet = 3;
                    Console.WriteLine(kilo * qiymet);
                    break;
                case 2:
                    int qiymet2 = 2;
                    Console.WriteLine(kilo * qiymet2);
                    break;
                case 3:
                    int qiymet3 = 4;
                    Console.WriteLine(kilo * qiymet3);
                    break;
                case 4:
                    int qiymet4 = 5;
                    Console.WriteLine(kilo * qiymet4);
                    break;

            }
            


        }
    }
}