using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_AlekseiStepanov
{
    internal class Country
    {
        private string _name;
        private int _year;
        public Country(string name, int year)
        {
            _name = name;
            _year = year;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string country(Dictionary<string, int> country)
        {
            string result = "Not found!";
            foreach (KeyValuePair<string, int> kvp in country)
            {
                if (kvp.Key == Name)
                {
                    Year = kvp.Value;
                    result = Name + " had joidned the Europian Union in " + kvp.Value.ToString();
                    break;
                }
                else
                {
                    result = "Not found!";
                }
            }
            return result;
        }
    }
}
