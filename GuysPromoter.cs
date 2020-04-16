using System;
namespace OOP_API1
{
    public class GuysPromoter : Promoter, IVlogger, IBodyBuilder
    {
        public GuysPromoter(string firstName, string lastName, string cellPhone) : base(firstName, lastName, cellPhone)
        {
        }

        public override void OmniaClubPromoter()
        {
            Console.WriteLine("I'm {0} and I'm a Promoter of Omnia Club", this.MyBusinessCard);
        }

        public override void XSClubPromoter()
        {
            Console.WriteLine("I'm {0} and I'm a Promoter of XS Club", this.MyBusinessCard);
        }

        public void Vlog()
        {
            Console.WriteLine("And I'm also a Vlogger");
        }

        public void Workout()
        {
            throw new System.NotImplementedException();
        }
    }
}