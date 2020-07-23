using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;

        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }

        public void CustomerBuysSoda()
        {
            // display options
            // choose soda
            // choose coin payment
            //customer.ChooseSodaCan;
        }

        public void AskCustomerForPayment()
        {

        }
    }
}
