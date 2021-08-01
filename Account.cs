using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* @author Tran Thien Trong - GCS290283
*
* @date - 10/October/2019 
*/
namespace ATM_SYSTEM
{   
    public class Account
    {
        // Variables declaration
        public string password;
        public string name;

        // Variables Initialization 
        public double amount = 0.0F;
        public double loan = 0.0F;
        public double deposit = 0.0F;
        public double withdraw = 0.0F;

        /// <summary>
        /// Constructor of Account Class
        /// </summary>
        public Account() {
            name = "";
            password = "";
            amount = 0;
            loan = 0;
            deposit = 0;
            withdraw = 0;
        }
        
        /// <summary>
        /// Contructor of Account Class to initialize all information for Account Object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="amount"></param>
        /// <param name="loan"></param>
        /// <param name="deposit"></param>
        /// <param name="withdraw"></param>
        public Account(string name, string password, double amount,
                       double loan, double deposit, double withdraw)
        {
            this.password = password;
            this.name = name;
            this.amount = amount;
            this.loan = loan;
            this.deposit = deposit;
            this.withdraw = withdraw;
        }
    }
}

