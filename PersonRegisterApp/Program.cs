using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                FirstName = "Erik",
                LastName = "Potkukelkka",
                SocialSecNum = "543543543-543"

            };
            Person person2 = new Person()
            {
                FirstName = "Matt",
                LastName = "Hunwick",
                SocialSecNum = "23323232-3244"

            };
            Person person3 = new Person()
            {
                FirstName = "John",
                LastName = "Willmore",
                SocialSecNum = "987987987-9987"

            };
            Persons myFriends = new Persons();

            //add person to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from persons
            Person person4 = myFriends.GetPerson(8);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            // print the whole fucking thing
            myFriends.PrintCollection();

            // find person
            string sotu = "23326232-3244";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());

            }
            else
            {
                Console.WriteLine("Can't find dude");
            }
        }
    }
}
