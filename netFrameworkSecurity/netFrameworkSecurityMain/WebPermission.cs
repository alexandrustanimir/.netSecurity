using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace netFrameworkSecurityMain
{
    public class CustomWebPermission
    {
        public CustomWebPermission()
        {
            Regex locations = new Regex(@"www.google.com");
            WebPermission permission = new WebPermission(NetworkAccess.Connect, locations);

            permission.AddPermission(NetworkAccess.Connect, "www.google.ro");
            permission.Demand();
            IEnumerator it = permission.ConnectList;
            it.MoveNext();
            if (it != null)
                do
                {
                    Console.WriteLine("---");
                    Console.WriteLine(it.Current.ToString());
                }
                while (it.MoveNext());
        }

    }
}
.