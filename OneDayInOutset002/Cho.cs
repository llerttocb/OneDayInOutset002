using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayInOutset002
{
    public class Cho
    {
        public string name;
        public string text;
        public List<Cho> choices;
        public Cho(string cname, string ctext)
        {
            name = cname;
            text = ctext;
            choices = new List<Cho>();
        }
    }
}
