using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.Helpers
{
    public static class ParameterValidator
    {
        public static void ValidateString(string parameter, bool allowEmpty = true)
        {
            if (!allowEmpty)
            {
                if (parameter == null)
                {
                    throw new ArgumentOutOfRangeException("parameter", "Parameter is null.");
                }
            }
            else if (string.IsNullOrEmpty(parameter))
            {
                throw new ArgumentOutOfRangeException("parameter", "Parameter is null or empty.");
            }
        }
    }
}
