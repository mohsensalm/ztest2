using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal interface IAccount
    {
        // members and function declaration, properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }

    //regular savings account 
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 4) / 100;
            if (Balance < 1000) interest -= (Balance * 2) / 100;
            if (Balance < 50000) interest += (Balance * 4) / 100;

            return interest;
        }
    }

    //Salary savings account 
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 5) / 100;
            return interest;
        }
    }

    //Corporate Account
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 3) / 100;
            return interest;
        }
    }
}
