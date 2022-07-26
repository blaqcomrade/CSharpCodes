using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging
{
    internal class message
    {
        public class Message
        {
            public static string GetMessage(string lang)
            {
                if (lang.Equals("Ha")) {
                    return "zo";
                }
                else if (lang.Equals("Yb"))
                {
                    return "ywaa";
                }
                else if (lang.Equals("ig"))
                {
                    return "byia";
                }
                else if (lang.Equals("en"))
                {
                    return "come";
                }
                else
                {
                    return "empty";
                }
            }
        }
    }
}
