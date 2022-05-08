using SAIRCMS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Application.Utility
{
    public class Suppress
    {
        public bool SuppressProperty(PropertyInfo property)
        {
            var attribute = Attribute.GetCustomAttribute(property, typeof(KeyAttribute));
            var ignoreCase = Attribute.GetCustomAttribute(property, typeof(IgnoreCase));

            if (attribute != null || ignoreCase != null) return true;

            return false;
        }

        public string SuppressClass(PropertyInfo property)
        {
            var cascadingType = Attribute.GetCustomAttribute(property, typeof(CascadingType));

            if (cascadingType != null)
            {
                return $"{property.Name}Id";
            }
            return null;
        }
    }
}
