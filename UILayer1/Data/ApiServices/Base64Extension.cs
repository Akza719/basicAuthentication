using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILayer.Models
{
    public static class Base64Extension
    {
        public static string Base64Encode(this String stringToEncode)
        {
            byte[] textAsBytes = Encoding.UTF8.GetBytes(stringToEncode);
            return Convert.ToBase64String(textAsBytes);
        }
    }
}
