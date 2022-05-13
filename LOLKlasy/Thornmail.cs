using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class Thornmail : Item
    {
        //deprecated???
        //public int bonusHP = 350;
        public Thornmail()
        {
            //ustalamy nazwe itemu
            name = "Thornmail";
            // jego cene
            price = 2700;
            //i atrybuty
            AddStat(Stat.HP, 350);
            AddStat(Stat.AR; 60);
        }
    }
}