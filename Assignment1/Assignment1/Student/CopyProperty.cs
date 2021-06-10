using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Student
{
    public static class CopyProperty
    {
        public static Y Copy<X, Y>(X first, Y second)
        {
            foreach (var parentProperty in first.GetType().GetProperties())
            {
                foreach (var childProperty in second.GetType().GetProperties())
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(second, parentProperty.GetValue(first));
                        break;
                    }
                }
            }
            return second;
        }
    }
}
