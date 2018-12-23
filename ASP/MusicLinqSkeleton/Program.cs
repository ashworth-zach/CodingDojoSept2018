using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================


            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // List<Artist> artist = Artists.Where(art => art.Hometown=="Mount Vernon").ToList();
	        // Console.WriteLine(artist[0].RealName+" "+artist[0].Age);

           
            //Who is the youngest artist in our collection of artists?
            // int minage=Artists.Min(b => b.Age);
            // List<Artist> artist = Artists.Where(p => p.Age == minage).ToList();
            // Console.WriteLine(artist[0].RealName);

           
            //Display all artists with 'William' somewhere in their real name
            // List<Artist> artist = Artists.Where(name => name.RealName.Contains("William")).ToList();
            // foreach(var x in artist){
            // Console.WriteLine(x.RealName);
            // }
           
            //Display the 3 oldest artist from Atlanta
            // List<Artist> Atlanta = Artists.Where(town => town.Hometown == "Atlanta").ToList();
            // List<Artist> elderly = Atlanta.OrderByDescending(person => person.Age).Take(3).ToList();
            // foreach(Artist person in elderly)
            // {
            //     Console.WriteLine(person.ArtistName);
            // }       

            //Display all groups with names less than 8 characters in length.
            List<Group> underEight = Groups.Where(name => name.GroupName.Length < 8).ToList();
            foreach(Group name in underEight)
            {
                Console.WriteLine(name.GroupName);
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
