using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCardAccount
    {
        private double airtimebalance;

        public SimCardAccount()
        {
        }

        public SimCardAccount(double airtimebalance)
        {
            this.airtimebalance = airtimebalance;
        }

        public double Balance
        {
            get { return airtimebalance; }
        }

        public void RechargeAirtime(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            else if (amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            airtimebalance += amount;
        }

        public void BuyData(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            airtimebalance -= amount;
        }

        public void BorrowAirtime(double amount)
        {
            if (Balance != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }


            airtimebalance += amount;
        }
        public void ToDeductFromBalanceAfterTransfer(double amount)
        {
            if (amount > airtimebalance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            airtimebalance -= amount;
        }

        public void TransferAirtimeTo(SimCardAccount OtherSimCard, double amount)
        {
            if (OtherSimCard == null)
            {
                throw new ArgumentOutOfRangeException(nameof(OtherSimCard));
            }

            ToDeductFromBalanceAfterTransfer(amount);
            OtherSimCard.RechargeAirtime(amount);
        }


        public bool Airtime_BalanceIsLow()
        {
            if (Balance < 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
