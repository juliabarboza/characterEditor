using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT3
{
    class Wizard : Character
    {
        string familiar;
        int ability;

        public Wizard(string _firstname, string _lastname, string _race, string _class,
            int _age, int _str, int _dex, int _cons, int _intelligence, int _wis, int _char, int _ability, string _familiar)
            : base(_firstname, _lastname, _race, _class,
             _age, _str, _dex, _cons, _intelligence, _wis, _char)
        {
            familiar = _familiar;
            ability = _ability;
        }
        public int GetAbility
        {
            get { return ability; }
            set { ability = value; }
        }
        public string GetFamiliar
        {
            get { return familiar; }
            set { familiar = value; }
        }
    }
}
