using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProj
{
    public class InsertDialogData
    {
        private string firstName;
        private string secondName;
        private string email;
        private string skype;
        private decimal phone;
        private string adress;

        public InsertDialogData(string firstName, string secondName, string email, string skype, decimal phone, string adress)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.email = email;
            this.skype = skype;
            this.phone = phone;
            this.adress = adress;
        }

        public string FirstName=>firstName;
        public string SecondName=>secondName;
        public string Email=>email;
        public string Skype=>skype;
        public decimal Phone=>phone;
        public string Adress=>adress;

    }
}
