using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Device
{
    [Required(ErrorMessage = "ID Property Requires Value")]

    public string Id { get; set; }
    [Range(10, 100, "Code Value Must Be Within 10-100")]
    public int Code { get; set; }

    [MaxLength(100, "Max of 100 Charcters are allowed")]
    public string Description { get; set}

}
public static class ObjectValidator
{
    public static bool Validate(Device obj,out List<string> errors)
    {
        errors = new List<string>();
        if (obj.Code < 10 || obj.Code > 100)
        {
            errors.Add("Code Value Must Be Within 10-100");
        }
        if (obj.Description != null && obj.Description.Length > 100)
        {
            errors.Add("Max of 100 Characters are allowed for Description");
        }
        if (obj.Id != null)
        {
            errors.Add("Id property requires Value");
        }
        return errors.Count == 0;

    }
}

class Program
{
    static void Main()
    {
        Device deviceObj = new Device();
        List<string> errors ;
        bool isValid = ObjectValidator.Validate(deviceObj,out errors);

        if (!isValid)
        {
            foreach (string item in errors)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

