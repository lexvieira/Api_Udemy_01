using System;
namespace OOP_API1
{
    public class GuysWriter : Writer, IVlogger
    {
        public GuysWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void BlogWrite()
        {
            Console.WriteLine("I'm {0} and I'm a Blog Writer ;)",this.AuthorBio);
        }

        public override void BookWriter()
        {
            Console.WriteLine("I'm {0} and I'm a Book Writer ;)",this.AuthorBio);
        }

        public void Vlog()
        {
            Console.WriteLine("I'm a Vlogger ;)");
        }
    }
}