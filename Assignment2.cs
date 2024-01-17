
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userChoice;
            Product[] product = null;
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Search for a Product");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                userChoice = Convert.ToInt32(Console.ReadLine());


                switch (userChoice)
                {

                    case 1:
                        Console.WriteLine("Enter number of products you want to Add: ");
                        int numOfProduct = Convert.ToInt32(Console.ReadLine());
                        product = new Product[numOfProduct];
                        for(int i = 0; i < numOfProduct; i++)
                        {
                            product[i] = new Product();
                            Console.WriteLine("Enter ProductId: ");
                            product[i].ProductId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Product Name: ");
                            product[i].Name = Console.ReadLine();
                            Console.WriteLine("Enter MfgDate: ");
                            product[i].Date = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Warranty: ");
                            product[i].Warranty = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Price: ");
                            product[i].Price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Stock");
                            product[i].Stock = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter GST: ");
                            product[i].GST = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Discount: ");
                            product[i].Discount = Convert.ToDouble(Console.ReadLine());
                        }
                        break;

                    case 2:

                        foreach(Product details in product)
                        {
                            Console.WriteLine(details.Display());
                        }
                        
                        break;

                    case 3:
                        Console.WriteLine("Find the product of ID: ");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        foreach(Product details in product)
                        {
                            if(details.ProductId == pid)
                            {
                                Console.WriteLine(details.Display());
                                break;
                            }
                        }
                        break;

                    default: break; 
                }
            } while (userChoice != 4);

        }
    }
    internal class Product
    {
        internal Product()
        {

        }
        internal Product(int pid, string pname, DateTime pmfg, DateTime pwarranty, double pprice, int pstock, int pGST, double pDiscount) : this()
        {
            ProductId = pid;
            Name = pname;
            Date = pmfg;
            Warranty = pwarranty;
            Price = pprice;
            Stock = pstock;
            GST = pGST;
            Discount = pDiscount;
        }
        private int m_intProductId;
        public int ProductId
        {
            get
            {
                return m_intProductId;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid ProductId");

                }
                else
                {
                    m_intProductId = value;
                }
            }
        }
        private string m_strName;
        public string Name
        {
            get
            {
                return m_strName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Invalid productName");

                }
                else
                {
                    m_strName = value;
                }
            }
        }
        private DateTime m_dtMfgDate;
        public DateTime Date
        {
            get
            {
                return m_dtMfgDate;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Manufacture Date cannot be After current date");
                }
                else
                {
                    m_dtMfgDate = value;
                }
            }
        }
        private DateTime m_dtWarranty;
        public DateTime Warranty
        {
            get
            {
                return m_dtWarranty;
            }
            set
            {
                m_dtWarranty = value;
            }
        }
        private double m_dblPrice;
        public double Price
        {
            get
            {
                return (double)m_dblPrice;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new Exception("Price must be greater than 0");
                }
                else
                {
                    m_dblPrice = value;
                }
            }
        }
        private int m_intStock;
        public int Stock
        {
            get
            {
                return m_intStock;
            }
            set
            {
                m_intStock = value;
            }
        }
        private int m_intGST;
        public int GST
        {
            get
            {
                return m_intGST;
            }
            set
            {
                if (value == 5 || value == 12 || value == 18 || value == 28)
                {
                    m_intGST = value;
                }
            }
        }
        private double m_dblDiscount;
        public double Discount
        {
            get
            {
                return m_dblDiscount;
            }
            set
            {
                if (value > 1 && value < 30)
                {
                    m_dblDiscount = value;
                }
            }
        }


        public string Display()
        {

            double TaxPrice = Price * Price * GST / 100;
            double DiscountPrice = TaxPrice * Discount;
            double TotalPrice = DiscountPrice * Stock;
            StringBuilder sb = new StringBuilder();
            sb.Append("Produt Id " + ProductId + "\n");
            sb.Append("Product Name " + Name + "\n");
            sb.Append("Product Manufacture Date " + Date.ToLongDateString() + "\n");
            sb.Append("Tax Price " + TaxPrice + "\n");
            sb.Append("Discount Price " + DiscountPrice + "\n");
            sb.Append("Total Price " + TotalPrice + "\n");
            return sb.ToString();

        }


    }
}
