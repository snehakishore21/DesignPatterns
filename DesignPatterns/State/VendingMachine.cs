using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }

        public int Price { get; private set; }

        public bool Present { get; internal set; }

        public Product(int code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
            Present = true;
        }
    }   
    internal class VendingMachine
    {
        public IState CurrentState { get; internal set; }

        public VendingMachine()
        {
            CurrentState = new IdleState();
            Coins = 0;
            Products = new Dictionary<int, Product>();
        }
        public int  Coins { get; set; }

        public Dictionary<int, Product> Products { get; internal set; }

        public void AddProducts(List<Product> products)
        {
            foreach (var item in products)
            {
                AddProduct(item);
            }
        }

        public Product GetProduct(int code)
        {
            if (this.Products.ContainsKey(code))
            {
                if( this.Products[code].Present)
                {
                    return this.Products[code];
                };
            }
            return null;
        }

        private void AddProduct(Product product)
        {
            this.Products.Add(product.Code, product);
        }
    }

    internal class VendingMachineActor
    {
        public VendingMachine Machine { get; private set; }

        public VendingMachineActor(VendingMachine machine)
        {
            Machine = machine;
        }
        public void InsertCoin(int coins)
        {
            Machine.CurrentState.InsertCoin(Machine, coins);
        }

        public void PressOn()
        {
            Machine.CurrentState.PressOn(Machine);
        }

        public void SelectProduct(int code)
        {
            Machine.CurrentState.SelectProduct(Machine, code);
        }

        public void GetProduct()
        {
            Machine.CurrentState.GetProduct(Machine);
        }

        public int RefundCancel()
        {
            return Machine.CurrentState.RefundCancel(Machine);
        }

        public void Change()
        {
            Machine.CurrentState.Change(Machine);
        }
    }
}
