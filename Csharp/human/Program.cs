using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human x= new Human("zach",5,100,1,65);
            Human y= new Human("bobbert",1,100,1,65);
            Console.WriteLine(x.name+x.Strength);
            x.attack(y);
            Console.WriteLine(y.Health);
        }
        class Human{
            public string name;
            private int strength =3;
            public int Strength
            {
                get { return strength; }
            }
            private int dexterity=3;
            public int Dexterity
            {
                get { return dexterity; }
            }
            private int intelligence=3;
            public int Intelligence
            {
                get { return intelligence; }
            }
            private int health=100;
            public int Health
            {
                get { return health; }
                set { health=value; }
            }
            public Human(string namemake, int strengthmake, int dexteritymake, int intelligencemake, int healthmake){
                name=namemake;
                strength=strengthmake;
                dexterity=dexteritymake;
                intelligence=intelligencemake;
                health=healthmake;
            }
            public void attack(Human victim){
                int damage=this.Strength*5;
                victim.Health=victim.Health-damage;
            }
        }
    }
}
