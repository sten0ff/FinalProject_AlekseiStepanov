using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProject_AlekseiStepanov
{
    internal class Age:Country
    {
        int _reality = DateTime.Today.Year;

        public Age(string name, int year) : base(name, year)
        {
        }
        public string age_of_country(int year)
        {
           int result = _reality - year;
            return base.Name + " is member of the Europian Union for " + result.ToString() + " years.";
        }
    }
}
