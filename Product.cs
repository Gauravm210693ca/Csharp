// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

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
            List<Product> productList = new List<Product>();
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                
                
                switch (userChoice)
                {
                    
                    case 1:
                        Product prod = new Product();
                        Console.WriteLine("Enter ProductId: ");
                        prod.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name: ");
                        prod.Name = Console.ReadLine();
                        Console.WriteLine("Enter MfgDate: ");
                        prod.Date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Warranty: ");
                        prod.Warranty = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Price: ");
                        prod.Price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Stock");
                        prod.Stock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter GST: ");
                        prod.GST = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Discount: ");
                        prod.Discount = Convert.ToDouble(Console.ReadLine());
                        productList.Add(prod);
                        break;
                        
                    case 2:
                    
                     foreach (Product details in productList)
                    {
                          Console.WriteLine(details.Display());
                    }
                    break;
                    
                    case 3:
                        Console.WriteLine("Thankyou");
                        break;
                }
            } while (userChoice != 3);

        }
    } 
internal class Product
{
    internal Product(){
        
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
