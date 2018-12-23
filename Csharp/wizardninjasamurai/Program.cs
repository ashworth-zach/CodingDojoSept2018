using System;

namespace wizardninjasamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Human
    {               
    public string name;
    //The { get; set; } format creates accessor methods for the field specified
    //This is done to allow flexibility
    public int health { get; set; }
    public int strength { get; set; }
    public int intelligence { get; set; }
    public int dexterity { get; set; }
    public Human(string person)
    {
        name = person;
        strength = 3;
        intelligence = 3;
        dexterity = 3;
        health = 100;
    }
    public Human(string person, int str, int intel, int dex, int hp)
    {
        name = person;
        strength = str;
        intelligence = intel;
        dexterity = dex;
        health = hp;
    }
    public void attack(Human target)
    {   
        if(target == null)
        {
            Console.WriteLine("Failed Attack");
        }
        else
        {
            target.health -= strength * 5;
        }
    }
    public class Wizard : Human{
        public bool magick = true;
        public int power;
        public Wizard(string x) : base(x) 
        {
            health = 50;
            intelligence = 25;
        }
        public void heal(){
            health += 10*intelligence;
        }
        public void fireball(object target){
            Random random = new Random();
            Human enemy = target as Human;
            try{
                enemy.health -= random.Next(20,50);
            }
            catch{
                Console.WriteLine("enemy doesnt exist, attack failed");
            }
        }
    }
    public class Ninja : Human{
        public Ninja(string x):base(x){
            dexterity=175;
        }
        public void steal(object target){
            Random random = new Random();
            Human enemy = target as Human;
            try{
                int healthsteal=random.Next(10,20);
                enemy.health -= healthsteal;
                health += healthsteal;
            }
            catch{
                Console.WriteLine("enemy doesnt exist, attack failed");
            }
        }
        public void get_away(){
            dexterity+=10;
            health -= 15;
        }
    }
    public class Samurai : Human{
        public Samurai(string x):base(x){
            health=200;
        }
        public void deathblow(object target){
            Human enemy= target as Human;
            if(enemy.health < 50){
                enemy.health=0;
            }
            else{
                attack(enemy);
            }
        }
        public void meditate(){
            health=200;
        }
    }
}
}
