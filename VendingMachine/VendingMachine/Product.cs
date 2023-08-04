using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Product
    {
        private int _productNumber;
        public int ProductNumber {get { return _productNumber;}}
        private string _productName;
        public string Name { get { return _productName; } set { _productName = value; } }
        private double _price;
        public double Price { get => _price; set { _price = value; } }
        public Product(string name,double price, int productNumber)
        {
            _productName = name;
            _price = price;
            _productNumber = productNumber;
        }
        
    }
}
