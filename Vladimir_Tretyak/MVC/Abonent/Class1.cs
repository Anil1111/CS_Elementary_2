using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Abonent
    {
        private int id;
        private string lastName;
        private string firstName;
        private string phoneNumber;
        private string skype;
        private string telegram;
        private string eMail;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public string Telegram
        {
            get
            {
                return telegram;
            }

            set
            {
                telegram = value;
            }
        }

        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
            }
        }


        public Abonent()
        {
            id = Id;
            lastName = LastName;
            firstName = FirstName;
            phoneNumber = PhoneNumber;
            skype = Skype;
            telegram = Telegram;
            eMail = EMail;
        }
        public Abonent(int id, string lastName, string firstName, string phoneNumber, string skype, string telegram, string eMail)                  
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Skype = skype;
            Telegram = telegram;
            EMail = eMail;
        }
    }
}
