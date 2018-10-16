using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROJECT3
{
    class Character
    {
        string firstname;
        string lastname;
        string race;
        string cLass;
        int age;
        int strength;
        int dexerity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        public Character(string _firstname, string _lastname,string _race, string _class, 
            int _age, int _str, int _dex, int _cons, int _intelligence, int _wis, int _char)
        {
            firstname = _firstname;
            lastname = _lastname;
            race = _race;
            cLass = _class;
            age = _age;
            strength = _str;
            dexerity = _dex;
            constitution = _cons;
            intelligence = _intelligence;
            wisdom = _wis;
            charisma = _char;
        }
        public override string ToString()
        {
            return firstname + " " + lastname;
        }
        public string Getfirst
        {
            get { return firstname; }
            set { firstname = value; }           
        }
        public string Getlast
        {
            get { return lastname; }
            set { lastname = value; }
        }
       public string Getrace
        {
            get { return race; }
            set { race = value; }
        }
        public string Getclass
        {
            get {  return cLass; }
            set { cLass = value; }
        }
        public int GetAge
        {
            get { return age; }
            set { age = value; }
        }
        public int GetStrength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int GetDexerity
        {
            get { return dexerity; }
            set { dexerity = value; }
        }
        public int GetConstitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        public int GetWisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        public int GetCharisma
        {
            get { return charisma; }
            set { strength = value; }
        }
        public int GetIntelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
    }
}
