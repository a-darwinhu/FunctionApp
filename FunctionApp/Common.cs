using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp
{
    class Common
    {
        public static string generateUUID(string szID)
        {
            string guid = Guid.NewGuid().ToString() ;
            string szvalue = guid.Remove(0, szID.Length).Insert(0, szID);
            return szvalue;
        }
    }
}
