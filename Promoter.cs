using System;
namespace OOP_API1
{
    public abstract class Promoter
    {
        private string _firstName;

        private string _lastName;

        private string _cellPhone;

        public string MyBusinessCard{
            get{
                return string.Format("{0} {1}, this is my cellphone number {2}", this._firstName, this._lastName, this._cellPhone);
            }
        }

        public Promoter(string firstName, string lastName, string cellPhone)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cellPhone = cellPhone;
        }

        public abstract void XSClubPromoter();

        public abstract void OmniaClubPromoter();


    }
}