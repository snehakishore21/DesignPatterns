using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal interface IState
    {
        internal void PressOn(VendingMachine machine);

        internal void InsertCoin(VendingMachine machine, int coins);

        internal void SelectProduct(VendingMachine machine, int code);

        internal void GetProduct(VendingMachine machine);

        internal int RefundCancel(VendingMachine machine);

        internal void Change(VendingMachine machine);
    }
    internal class IdleState:IState
    {
        public IdleState()
        {
            Console.WriteLine("Currently in Idle State");
        }
        public void Change(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine, int coins)
        {
            machine.Coins += coins;
            Console.WriteLine($"{coins} coins inserted, {machine.Coins} present");
            machine.CurrentState = new HasMoneyState();
        }

        public void PressOn(VendingMachine machine)
        {
           Console.WriteLine("Vending Machine is ON");
        }

        public int RefundCancel(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void SelectProduct(VendingMachine machine, int code)
        {
            throw new NotImplementedException();
        }
    }

    internal class HasMoneyState : IState
    {
        public HasMoneyState()
        {
            Console.WriteLine("Currently in Has Money State");
        }
        public void Change(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine, int coins)
        {
            machine.Coins += coins;
            Console.WriteLine($"{coins} coins inserted, {machine.Coins} present");
            machine.CurrentState = new HasMoneyState();
        }

        public void PressOn(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public int RefundCancel(VendingMachine machine)
        {
            machine.Coins = 0;
            Console.WriteLine("Refunded & Cancelled");
            machine.CurrentState = new IdleState();  
            return machine.Coins;
        }

        public void SelectProduct(VendingMachine machine, int code)
        {
            machine.Products.TryGetValue(code, out Product product);
            if (product==null)
            {
                throw new Exception($"No product with code {code} present.");
            }
            else if(product.Price>machine.Coins)
            {
                throw new Exception($"Not enough money to buy product with code {code}.");
            }
            else
            {
                Console.WriteLine($"Product with code {code} selected.");
                machine.CurrentState = new SelectedProductState(product);
            }
        }
    }

    internal class SelectedProductState : IState
    {
        private Product product;

        public SelectedProductState(Product product) 
        {
            this.product = product;
            Console.WriteLine("Currently in Selected Product State");
        }
        public void Change(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(VendingMachine machine)
        {
            machine.Coins -= product.Price;
            Console.WriteLine("Product dispensed");
            machine.CurrentState = new ProductDispensedState();
        }

        public void InsertCoin(VendingMachine machine, int coins)
        {
            throw new NotImplementedException();
        }

        public void PressOn(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public int RefundCancel(VendingMachine machine)
        {
            machine.Coins = 0;
            Console.WriteLine("Refunded & Cancelled");
            machine.CurrentState = new IdleState();
            return machine.Coins;
        }

        public void SelectProduct(VendingMachine machine, int code)
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductDispensedState : IState
    {
        public void Change(VendingMachine machine)
        {
            int change = machine.Coins;
            machine.Coins = 0;
            Console.WriteLine($"Change dispensed {change}");
        }

        public void GetProduct(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine, int coins)
        {
            throw new NotImplementedException();
        }

        public void PressOn(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public int RefundCancel(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void SelectProduct(VendingMachine machine, int code)
        {
            throw new NotImplementedException();
        }
    }
}
