using System;

namespace OOP_API1
{
    class Program
    {
        static void Main(string[] args)
        {
            GuysWriter guysWriter = new GuysWriter("John","Jones");

            guysWriter.BlogWrite();

            guysWriter.BookWriter();

            guysWriter.Vlog();

            GuysPromoter guysPromoter = new GuysPromoter("Alex", "Promoter", "555334343");

            guysPromoter.XSClubPromoter();

            guysPromoter.OmniaClubPromoter();

            guysPromoter.Vlog();

        }
    }
}
