using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Product : Program
    {

        readonly string pcode;
        public string pname;
        int qty_in_stock;
        int discount_allowed;
        static String brand;
        public double Productprice;

        public Product()
        {
            Console.WriteLine("Enter product code : ");
            pcode = Console.ReadLine();
        }

        static Product()
        {
            brand = "Lewis";

        }

        Product(string pcode, int qty_in_Stock, int discount_allowed, String pname, double productprice)
        {
            this.pcode = pcode;
            this.qty_in_stock = qty_in_Stock;
            this.discount_allowed = discount_allowed;
            this.pname = pname;
            this.Productprice = productprice;
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter Product quantity : ");
            qty_in_stock = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter product code : ");
            //pcode = Console.ReadLine();

            Console.WriteLine("Enter discount percentage : ");
            discount_allowed = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter product name : ");
            pname = Console.ReadLine();

            Console.WriteLine("Enter Product price : ");
            Productprice = double.Parse(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            //Console.WriteLine(pcode + pname + qty_in_stock + discount_allowed);
            Console.WriteLine("Product code is : " + pcode);
            Console.WriteLine("Product Name is : " + pname);
            Console.WriteLine("Product Quantity is : " + qty_in_stock);
            Console.WriteLine("Discount on Product : " + discount_allowed + "%");
            Console.WriteLine("Product Brand is : " + brand);
            Console.WriteLine("Product Price is : " + Productprice);
        }

        //public void productBill(int amount)
        //{

            
        //}

    }
}
