using Assignment_4;

namespace Assignment_4
{
    enum UserType { Admin = 1, Customer }
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "y";
            Product[] product = new Product[10];

            List<Product> productList = new List<Product>();
            List<Product> cart = new List<Product>();


            while (ch == "y")
            {
                Console.WriteLine("Enter the user type : 1.Admin 2.Customer : ");
                int userType = Byte.Parse(Console.ReadLine());
                
                if (userType == (int)UserType.Admin)
                {
                    Console.WriteLine("Enter the amount of product you want to enter : ");
                    int numberOfProduct = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numberOfProduct; i++)
                    {
                        product[i] = new Product();
                        product[i].GetDetails();
                        productList.Add(product[i]);
                    }
                }
                else if (userType == (int)UserType.Customer)
                {
                    Console.WriteLine("Do you want to buy a specific product : 1.Yes  2.Show Bill 3.Display Products");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Product p = new Product();
                       
                        Console.WriteLine("Enter product name : ");
                        string specificProduct = Console.ReadLine();
                        p = productList.Find(x => x.pname == specificProduct);
                        if(p != null)
                        {
                            p.DisplayDetails();
                            cart.Add(p);
                            Console.WriteLine("Product added");

                        }
                        else
                        {
                            Console.WriteLine("Product Not found");
                        }


                    }
                    else if(choice == 2)
                    {
                        double sum = 0;
                        foreach (Product p in cart) {
                            sum = sum + p.Productprice;
                        }
                        if(DateTime.Now.Month == 1 && DateTime.Now.Day == 26) {
                            Console.WriteLine("Today is 26th Jan so we are giving 50% discount : ");
                            double newBill = sum / 2;
                            Console.WriteLine("Your total amount is : " + newBill);
                        }
                        else
                        {

                        Console.WriteLine("Total bill is : " + sum);
                        }
                    }
                    else if(choice == 3){
                        foreach (Product product1 in product)
                        {
                            if (product1 != null)
                                product1.DisplayDetails();
                        }
                    }
                    

                }

                Console.WriteLine("Do you want to continue --> y :: n");
                ch = Console.ReadLine();
            }
        }
    }
}
