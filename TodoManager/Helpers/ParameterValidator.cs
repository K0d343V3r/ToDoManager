using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.Helpers
{
    public static class ParameterValidator
    {
        public static void CheckNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, "Parameter is null.");
            }
        }

        public static void CheckString(string value, string parameterName, bool allowEmpty = true)
        {
            if (!allowEmpty)
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(parameterName, "Parameter is null.");
                }
            }
            else if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException(parameterName, "Parameter is null or empty.");
            }
        }
    }
}
