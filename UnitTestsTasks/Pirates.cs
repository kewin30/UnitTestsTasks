using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsTasks
{
    public class Pirates
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            foreach (var item in gunners)
            {
                
                if(item.Value == "nay")
                {
                    return "Shiver me timbers!";
                }
                if (item.Value == "aye")
                {
                    return "Fire!";
                }

            }         
            return "x";
        }
    }
}
