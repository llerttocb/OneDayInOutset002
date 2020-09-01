using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayInOutset002
{
    public class Loc
    {
        public string name
        {
            get;
            set;
        }
        public string desc
        {
            get;
            set;
        }
        public List<Cho> locchoice
        {
            get;
            set;
        }
        public List<Loc> locconnect
        {
            get;
            set;
        }
        public Loc(string lname, string ldesc)
        {
            name = lname;
            desc = ldesc;
            locchoice = new List<Cho>();
            locconnect = new List<Loc>();
        }
    }
}
