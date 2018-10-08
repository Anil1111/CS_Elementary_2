using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Order
    {
        private int payerAccount;
        private int beneficiaryAccount;
        private double transferredAmount;

        public int PayerAccount { get => payerAccount; }
        public int BeneficiaryAccount { get => beneficiaryAccount; }
        public double TransferredAmount { get => transferredAmount; }

        public Order(int payerAccount, int beneficiaryAccount, double transferredAmount)
        {
            Initializer(payerAccount, beneficiaryAccount, transferredAmount);
        }

        /// <summary>
        /// Инициализатор
        /// </summary>
        /// <param name="payerAccount">расчетный счет плательщика</param>
        /// <param name="beneficiaryAccount">расчетный счет получателя</param>
        /// <param name="transferredAmount">перечисляемая сумма</param>
        public void Initializer(int payerAccount, int beneficiaryAccount, double transferredAmount)
        {
            this.payerAccount = payerAccount;
            this.beneficiaryAccount = beneficiaryAccount;
            this.transferredAmount = transferredAmount;
        }

        /// <summary>
        ///  Ввод пользовательских данных
        /// </summary>
        /// <returns></returns>
        public static void InputUsersData(out int payerAccount, out int beneficiaryAccount, out double transferredAmount)
        {
            bool isInputCorrect;
            int inputPayerAccount, inputBeneficiaryAccount;
            double inputTransferredAmount;
            do
            {
                isInputCorrect = true;
                Console.Write("Input payer`s account\t\t: ");
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out inputPayerAccount))
                {
                    ShowFormatError();
                    isInputCorrect = false;
                }
                //if (isInputCorrect)
                //{
                Console.Write("Input beneficiary`s account\t: ");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out inputBeneficiaryAccount))
                {
                    ShowFormatError();
                    isInputCorrect = false;
                }
                //}
                //if (isInputCorrect)
                //{
                Console.Write("Input transferred amount\t: ");
                input = Console.ReadLine();
                if (!Double.TryParse(input, out inputTransferredAmount))
                {
                    ShowFormatError();
                    isInputCorrect = false;
                }
                //}
            } while (!isInputCorrect);
            payerAccount = inputPayerAccount;
            beneficiaryAccount = inputBeneficiaryAccount;
            transferredAmount = inputTransferredAmount;
        }



        public static void ShowFormatError()
        {
            Console.WriteLine("Wrong number format, try again");
        }

        /// <summary>
        /// Печать одного заказа
        /// </summary>
        public void PrintOrder()
        {
            Console.WriteLine($"Счет плательщика-> {PayerAccount}\tСчет получателя -> {BeneficiaryAccount}\tСумма платежа   -> {TransferredAmount}");
        }
    }
}
