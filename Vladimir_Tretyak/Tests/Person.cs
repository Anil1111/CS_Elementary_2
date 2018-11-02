using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Hillel
{
    [Serializable]
    class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string skype;
        private string webSite;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Skype
        {
            get
            {
                return skype;
            }

            set
            {
                skype = value;
            }
        }

        public string WebSite
        {
            get
            {
                return webSite;
            }

            set
            {
                webSite = value;
            }
        }
        public Person(string lastName,string firstName,string phoneNumber,string skype,string webSite)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Skype = skype;
            WebSite = webSite;            
        }
    }
}

