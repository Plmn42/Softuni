using System;

namespace supplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int litrespray = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalprice = 0;
            totalprice += pen * 5.8;
            totalprice += marker * 7.2;
            totalprice += litrespray * 1.2;

            double truedisc = totalprice * (discount / 100.0);
            totalprice -= truedisc;

            Console.WriteLine(totalprice);

        }
    }
}