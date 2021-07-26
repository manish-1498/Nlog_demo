using System;
using System.Collections.Generic;
using System.Text;

namespace NlogProject
{
    class Sum
    {
        static Nlog nlog = new Nlog();
        public int Addition(int firstnumber, int secondnumber)
        {
            
            if (firstnumber == 0 || secondnumber == 0)
            {

            nlog.LogInfo("Sub method");
            nlog.LogDebug("Debug Successful");
            nlog.LogError("First number or second number is zero");
            return 0;
            }
            int result = firstnumber + secondnumber;
            nlog.LogInfo("Sub method");
            nlog.LogDebug("Debug Successful");
            nlog.LogWarn("Warning");
            return result;
        }
    }
}
