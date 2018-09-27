using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class Order
    {
        private int payerAccount;
        private int beneficiaryAccount;
        private int tranzactionSum;


        public int PayerAccount
        {
            get
            {
                return payerAccount;
            }
            set
            {
                if ((double)value / 10000000 < 1 || (double)value / 100000000 >= 1)
                {
                    throw new FormatException("\nPayer's account has the wrong format\n");
                }
                else
                {
                    payerAccount = value;
                }
            }
        }

        public int BeneficiaryAccount
        {
            get
            {
                return beneficiaryAccount;
            }
            set
            {
                if ((double)value / 10000000 < 1 || (double)value / 100000000 >= 1)
                {
                    throw new FormatException("\nBeneficiary's account has the wrong format\n");
                }
                else
                {
                    beneficiaryAccount = value;
                }
            }
        }

        public int TranzactionSum
        {
            get
            {
                return tranzactionSum;
            }
            set
            {
                tranzactionSum = value;
            }
        }

        public Order()
        {
            TranzactionSum = 0;
            PayerAccount = 10000000;
            BeneficiaryAccount = 10000000;
        }

        public Order(int payerAccount, int beneficiaryAccount, int tranzactionSum)
        {
            PayerAccount = payerAccount;
            BeneficiaryAccount = beneficiaryAccount;
            TranzactionSum = tranzactionSum;
        }

        public override string ToString()
        {
            return string.Format("Payer account " + this.PayerAccount + " Beneficiary account " + this.BeneficiaryAccount + " Tranzaction sum " + this.TranzactionSum);
        }
    }
}
