using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Device
{
    internal class ObjectValidator
    {
        public static bool Validate(Object deviceObj,out List<string> errors)
        {
            errors = new List<string>();
            Type type = deviceObj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object[] validationAttributes = property.GetCustomAttributes(typeof(AttributeValidator), true);
                foreach (Attribute validationAttributeObj in validationAttributes) {
                    object value = property.GetValue(deviceObj, null);
                    AttributeValidator attributeValidatorObj = (AttributeValidator)validationAttributeObj;
                    if (attributeValidatorObj != null)
                    {
                        if (attributeValidatorObj.isValid(value))
                        {
                            errors.Add(attributeValidatorObj.ErrorMessage);
                        }
                    }
                }
            }
            return errors.Count == 0;
        }

    }
}
