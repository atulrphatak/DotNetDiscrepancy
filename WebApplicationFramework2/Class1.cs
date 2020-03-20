using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mail;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Globalization;

[assembly: StringFreezingAttribute()]



namespace WebApplicationFramework2
{

    public class Class1
    {
        public static void Main()
        {
            CultureInfo current = CultureInfo.CurrentCulture;
            Console.WriteLine("The current culture is {0}", current.Name);
            CultureInfo newCulture;
            if (current.Name.Equals("fr-FR"))
                newCulture = new CultureInfo("fr-LU");
            else
                newCulture = new CultureInfo("fr-sFR");

            //CultureInfo.CurrentCulture = newCulture;
            Console.WriteLine("The current culture is now {0}",
                              CultureInfo.CurrentCulture.Name);
        }
    }
}