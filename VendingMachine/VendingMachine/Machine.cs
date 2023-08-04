using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Machine
    {
        double _balance;
        private Product[] _products;
        public Product[] Products { get { return _products; } }
        public Machine()
        {
            FillTheMachine();
        }
        public void Inıt()
        {
            Console.WriteLine("For Product List pls press I");
            string _input = Console.ReadLine();
            if (_input.ToLower() == "i")
            {
                ListProducts();
            }
            else
            {
                throw new ArgumentException("Please Enter A valid Value");
            }

        }
        private void ListProducts()
        {
            foreach (var product in _products)
            {
                Console.WriteLine(product.ProductNumber + "=>   " + product.Name +"  $" + product.Price);
            }
            Console.WriteLine("Please Enter a Product Number");
            int productNumber = int.Parse(Console.ReadLine());
            GiveProduct(productNumber);
        }
        public void GiveProduct(int productNumber)
        {
            if(IsProductNumberValid(productNumber))
            {
                for (int i = 0; i < _products.Length; i++)
                {
                    if (_products[i].ProductNumber == productNumber)
                    {

                        if (_balance >= _products[i].Price)
                        {

                            Console.WriteLine("Your Product is " + _products[i].Name);
                            Console.WriteLine("Yor Exchange is " + (_balance - _products[i].Price));
                            _balance = 0;
                        }
                        else
                        {
                            GetMoney();
                            GiveProduct(productNumber);
                        }


                    }
                }
            }
            if(!IsProductNumberValid(productNumber))
            {
                Console.Clear();
                Console.WriteLine("Your Product Number was Invalid please check the lsit again");
                ListProducts();
            }
           

        }
        public void GetMoney()
        {
            Console.WriteLine("Pls insert Money");
            double _input = double.Parse(Console.ReadLine());
            if (_input <= 0)
                throw new ArgumentException("Pls Enter a valid value");
            _balance += _input;

        }
        private bool IsProductNumberValid(int productNumber)
        {
            foreach (var product in _products)
            {
                if(product.ProductNumber == productNumber)
                    return true;
            }
            return false;
        }

        void FillTheMachine()
        {
            _products = new Product[8];
            _products[0] = new Product("Çikolata", 2.5, 1);
            _products[1] = new Product("Sakız", 1.5, 2);
            _products[2] = new Product("Meyve Suyu", 4, 3);
            _products[3] = new Product("Elma", 7.5, 4);
            _products[4] = new Product("Gazoz", 15, 5);
            _products[5] = new Product("Balık kraker", 22, 6);
            _products[6] = new Product("Gofret", 0.5, 7);
            _products[7] = new Product("Kek", 9, 8);
          
        }

    }
}
