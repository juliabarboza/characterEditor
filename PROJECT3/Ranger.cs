using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT3
{
    class Ranger : Character
    {
        string rce;
        string size;

        public Ranger(string _firstname, string _lastname, string _race, string _class,
            int _age, int _str, int _dex, int _cons, int _intelligence, int _wis, int _char, string _rce, string _size)  
            : base(_firstname, _lastname, _race, _class,
             _age, _str, _dex, _cons, _intelligence, _wis, _char)
        {
            rce = _rce;
            size = _size;
        }

        public string GetpetRace
        {
            get { return rce; }
            set { rce = value; }
        }
        public string GetpetSize
        {
            get { return size; }
            set { size = value; }
        }
    }
}
