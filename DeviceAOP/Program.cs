using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    class Device
    {

        [Required(ErrorMessage = "ID Property Requires Value")]

        public string Id { get; set; }
        [Range(10, 100, "Code Value Must Be Within 10-100")]
        public int Code { get; set; }

        [MaxLength(100, "Max of 100 Charcters are allowed")]
        public string Description { get; set; }

        [Regex("^Z[A-Z]{3}\\d{12}$", "Barcode should start with 4 alphabets, where 'z' is the first char followed by three char & End with 12 digits")]
        public string BarCode { get; set; }

        

    }

    class Program
    {
        static void Main()
        {
            Device deviceObj = new Device();
            List<string> errors;
            bool isValid = ObjectValidator.Validate(deviceObj, out  errors);
            if (!isValid)
            {
                foreach (string item in errors)
                {
                    System.Console.WriteLine(item);
             
                }
            }
            Console.ReadLine();
        }
    }
}
