using System;

namespace vacation_book_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookpage = int.Parse(Console.ReadLine());
            int pageperh = int.Parse(Console.ReadLine());
            int daysperbook = int.Parse(Console.ReadLine());

            int hourperbook = bookpage / pageperh;
            int timeperday = hourperbook / daysperbook;

            Console.WriteLine(timeperday);
            
        }
    }
}