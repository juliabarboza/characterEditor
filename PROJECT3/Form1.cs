using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT3
{
    public partial class Form1 : Form
    {
        string fn;
        string ln;
        int a;
        string r;
        string x;
        int s;
        int d;
        int c;
        int i;
        int w;
        int ch;
        int ability;
        string familiar;
        string petrace;
        string petsize;
        


        public Form1()
        {
            InitializeComponent();
        }
        public void ClearStuff()
        {
            firstnamebox.Clear();
            lastnamebox.Clear();
            age.Value = 0;
            Race.SelectedIndex = -1;
            classbox.SelectedIndex = -1;
            Charisma.Value = 0;
            Wisdom.Value = 0;
            constitution.Value = 0;
            intelligence.Value = 0;
            Dexterity.Value = 0;
            strength.Value = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character charc = (Character)listBox1.SelectedItem;
            ////firstnamebox.Text = charc.Getfirst;
            lastnamebox.Text = charc.Getlast;
            age.Value = charc.GetAge;
            Race.Text = charc.Getrace;
            Charisma.Value = charc.GetCharisma;
            constitution.Value = charc.GetConstitution;
            strength.Value = charc.GetStrength;
            intelligence.Value = charc.GetIntelligence;
            Dexterity.Value = charc.GetDexerity;
            Wisdom.Value = charc.GetWisdom;
            if (charc is Cleric)
            {
                special.Value = (charc as Cleric).GetAbility;
                classbox.SelectedIndex = 0;
            }
            else if (charc is Druid)
            {
                druidspecial.Text = (charc as Druid).GetFamiliar;
                classbox.SelectedIndex = 1;
            }
            else if (charc is Fighter)
            {
                special.Value = (charc as Fighter).GetAbility;
                classbox.SelectedIndex = 2;
            }
            else if (charc is Monk)
            {
                special.Value = (charc as Monk).GetAbility;
                classbox.SelectedIndex = 3;
            }
            else if (charc is Paladin)
            {
                special.Value = (charc as Paladin).GetAbility;
                classbox.SelectedIndex = 4;
            }
            else if (charc is Rogue)
            {
                special.Value = (charc as Rogue).GetAbility;
                classbox.SelectedIndex = 5;
            }
            else if (charc is Sorcerer)
            {
                special.Value = (charc as Sorcerer).GetAbility;
                classbox.SelectedIndex = 7;
            }
            else if (charc is Ranger)
            {
                petRace.Text = (charc as Ranger).GetpetRace;
                petSize.Text = (charc as Ranger).GetpetSize;
                classbox.SelectedIndex = 6;
            }
            else if (charc is Wizard)
            {
                special.Value = (charc as Wizard).GetAbility;
                wizardfamiliar.Text = (charc as Wizard).GetFamiliar;
                classbox.SelectedIndex = 8;
            }


        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rollbtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            strength.Value = rand.Next(1, 20);
            Dexterity.Value = rand.Next(1, 20);
            constitution.Value = rand.Next(1, 20);
            intelligence.Value = rand.Next(1, 20);
            Wisdom.Value = rand.Next(1, 20);
            Charisma.Value = rand.Next(1, 20);
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Race_SelectedIndexChanged(object sender, EventArgs e)
        {


        }      

        private void classbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classbox.SelectedIndex == 0)
            {
                special.Visible = true;
                clericlabel.Visible = true;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;

            }
            if (classbox.SelectedIndex == 1)
            {
                special.Visible = false;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = true;
                druidspecial.Visible = true;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            if (classbox.SelectedIndex == 2)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = true;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            if (classbox.SelectedIndex == 3)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = true;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            if (classbox.SelectedIndex == 4)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = true;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            if (classbox.SelectedIndex == 5)
            {
                special.Visible = false;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = true;
                rangerpetsizelabel.Visible = true;
                petRace.Visible = true;
                petSize.Visible = true;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
            }
            if (classbox.SelectedIndex == 6)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = true;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            if (classbox.SelectedIndex == 7)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = false;
                wizardlabel.Visible = false;
                wizardlabel2.Visible = false;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = true;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;

            }
            if (classbox.SelectedIndex == 8)
            {
                special.Visible = true;
                clericlabel.Visible = false;
                rangerpetracelabel.Visible = false;
                rangerpetsizelabel.Visible = false;
                wizardfamiliar.Visible = true;
                wizardlabel.Visible = true;
                wizardlabel2.Visible = true;
                roguelabel.Visible = false;
                druidlabel.Visible = false;
                druidspecial.Visible = false;
                sorcererlabel.Visible = false;
                monklabel.Visible = false;
                paladinlabel.Visible = false;
                fighterlabel.Visible = false;
                petRace.Visible = false;
                petSize.Visible = false;
            }
            int clss = classbox.SelectedIndex;
            if (clss >= 0)
            {
                Cleric cleric = classbox.Items[clss] as Cleric;
                Druid druid = classbox.Items[clss] as Druid;
                Fighter fighter = classbox.Items[clss] as Fighter;
                Monk monk = classbox.Items[clss] as Monk;
                Paladin paladin = classbox.Items[clss] as Paladin;
                Ranger ranger = classbox.Items[clss] as Ranger;
                Rogue rogue = classbox.Items[clss] as Rogue;
                Sorcerer sorcerer = classbox.Items[clss] as Sorcerer;
                Wizard wizard = classbox.Items[clss] as Wizard;

               
            }

        }
       
        private void clericspecial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clericlabel_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int clss = classbox.SelectedIndex;
            if (clss >= 0)
            {
                /* Cleric cleric = classbox.Items[clss] as Cleric;
                Druid druid = classbox.Items[clss] as Druid;
                Fighter fighter = classbox.Items[clss] as Fighter;
                Monk monk = classbox.Items[clss] as Monk;
                Paladin paladin = classbox.Items[clss] as Paladin;
                Ranger ranger = classbox.Items[clss] as Ranger;
                Rogue rogue = classbox.Items[clss] as Rogue;
                Sorcerer sorcerer = classbox.Items[clss] as Sorcerer;
                Wizard wizard = classbox.Items[clss] as Wizard; */

                
                if ( classbox.SelectedIndex == 0)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    d = (int)Dexterity.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    c = (int)constitution.Value;
                    ability = (int)special.Value;
                    Cleric cleric = new Cleric(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(cleric);
                    special.Value = 0;
                    ClearStuff();                           

                }
                if (classbox.SelectedIndex == 1)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    c = (int)constitution.Value;
                    d = (int)Dexterity.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    familiar = druidspecial.SelectedItem.ToString();
                    Druid druid = new Druid(fn, ln, r, x, a, s, d, c, i, w, ch, familiar);
                    listBox1.Items.Add(druid);
                    ClearStuff();
                    druidspecial.SelectedIndex = -1;
                }
                if (classbox.SelectedIndex == 2)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    c = (int)constitution.Value;
                    d = (int)Dexterity.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    Fighter fighter = new Fighter(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(fighter);
                    ClearStuff();
                    special.Value = 0;
                }
                if (classbox.SelectedIndex == 3)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    d = (int)Dexterity.Value;
                    c = (int)constitution.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    Monk monk = new Monk(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(monk);
                    ClearStuff();
                    special.Value = 0;
                }
                if (classbox.SelectedIndex == 4)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    d = (int)Dexterity.Value;
                    c = (int)constitution.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    Paladin paladin = new Paladin(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(paladin);
                    ClearStuff();
                    special.Value = 0;
                }
                if (classbox.SelectedIndex == 5)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    d = (int)Dexterity.Value;
                    c = (int)constitution.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    petrace = petRace.SelectedItem.ToString();
                    petsize = petSize.SelectedItem.ToString();
                    
                    Ranger ranger = new Ranger(fn, ln, r, x, a, s, d, c, i, w, ch, petrace, petsize);
                    listBox1.Items.Add(ranger);
                    ClearStuff();
                    petRace.SelectedIndex = -1;
                    petSize.SelectedIndex = -1;
                } 
                if (classbox.SelectedIndex == 6)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    c = (int)constitution.Value;
                    d = (int)Dexterity.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    Rogue rogue = new Rogue(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(rogue);
                    ClearStuff();
                    special.Value = 0;
                }
                if (classbox.SelectedIndex == 7)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    c = (int)constitution.Value;
                    d = (int)Dexterity.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    Sorcerer sorcerer = new Sorcerer(fn, ln, r, x, a, s, d, c, i, w, ch, a);
                    listBox1.Items.Add(sorcerer);
                    ClearStuff();
                    special.Value = -1;
                }
                if (classbox.SelectedIndex == 8)
                {
                    fn = firstnamebox.Text;
                    ln = lastnamebox.Text;
                    a = (int)age.Value;
                    r = Race.SelectedItem.ToString();
                    x = classbox.SelectedItem.ToString();
                    s = (int)strength.Value;
                    d = (int)Dexterity.Value;
                    c = (int)constitution.Value;
                    i = (int)intelligence.Value;
                    w = (int)Wisdom.Value;
                    ch = (int)Charisma.Value;
                    ability = (int)special.Value;
                    familiar = wizardfamiliar.SelectedItem.ToString();
                    Wizard wizard = new Wizard(fn, ln, r, x, a, s, d, c, i, w, ch, a, familiar);
                    listBox1.Items.Add(wizard);
                    ClearStuff();
                    special.Value = 0;
                    wizardfamiliar.SelectedIndex = -1;
                }
            
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            /* fn = firstnamebox.Text;
             ln = lastnamebox.Text;
             a = (int)age.Value;
             r = Race.SelectedItem.ToString();
             x = classbox.SelectedItem.ToString();
             s = (int)strength.Value;
             d = (int)Dexterity.Value;
             i = (int)intelligence.Value;
             w = (int)Wisdom.Value;
             ch = (int)Charisma.Value;
             */
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearStuff();
            listBox1.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

