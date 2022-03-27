using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsTasks
{
    public class Pirates
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
                
                if(gunners.ContainsValue("nay"))
                {
                    return "Shiver me timbers!";
                }
                if (gunners.ContainsValue("aye")&& !gunners.ContainsValue("nay"))
                {
                    return "Fire!";
                }
      
            return "x";
        }
    }
}
