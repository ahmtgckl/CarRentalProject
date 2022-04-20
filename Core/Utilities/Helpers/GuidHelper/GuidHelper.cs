using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Core.Utilities.Helpers
{
    public static class GuidHelper
    {
        public static string CreateGuid()
        {

            return Guid.NewGuid().ToString(); 
        }
    }
}
