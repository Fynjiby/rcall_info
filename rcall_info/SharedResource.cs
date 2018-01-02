using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace rcall_info
{
    public class SharedResource
    {
        public static string GetNameRes(string Name){
            return Name + "_" + CultureInfo.CurrentCulture.Name;
        }
    }
}
