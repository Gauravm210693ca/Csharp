
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
            Dictionary<int,Product> products = new Dictionary<int,Product>();
            string str = "Y";
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display All Product");
                Console.WriteLine("3. Search for a Product");
                Console.WriteLine("4. Remove a Product");
                //Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                userChoice = Convert.ToInt32(Console.ReadLine());


                switch (userChoice)
                {

                    case 1:
                        Product product = new Product();
                        try
                        {
                            //work on same product id
                            Console.WriteLine("Enter Product Id: ");
                            product.ProductId = Convert.ToInt32(Console.ReadLine());
                            if (products.ContainsKey(product.ProductId))
                            {
                                throw new DuplicateKeyException($"Product with Product Id {product.ProductId} already exists.");
                            }
                            Console.WriteLine("Enter Product Name: ");
                            product.Name = Console.ReadLine();
                            Console.WriteLine("Enter Manufacture Date of Product");
                            product.Date = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Product Warranty: ");
                            product.Warranty = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Product Price: ");
                            product.Price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Stock: ");
                            product.Stock = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter GST: ");
                            product.GST = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Discount: ");
                            product.Discount = Convert.ToDouble(Console.ReadLine());
                            products.Add(product.ProductId, product);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (DuplicateKeyException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex) { 
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:

                        foreach (KeyValuePair<int,Product> values in products)
                        {
                            Console.WriteLine(values.Value.Display());
                        }

                        break;

                    case 3:
                        Console.WriteLine("Find the product of ID: ");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        if (products.ContainsKey(pid)){
                            Console.WriteLine(products[pid].Display());
                        }
                        else
                        {
                            Console.WriteLine("Product Not Found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter the id for the Product to remove ");
                        int pidToRemove = Convert.ToInt32((Console.ReadLine()));
                        products.Remove(pidToRemove);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue(Y/N)");
                str = Console.ReadLine();
            } while (str != "N");

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
                else{
                    throw new Exception("GST must be (5% or 12% or 18% or 28%");
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
                else
                {
                    throw new Exception("Discount value must be between 1 and 30");
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
    internal class DuplicateKeyException : Exception
    {
        public DuplicateKeyException(string message) : base(message)
        {

        }
        
    }
}
