using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Reflection;

//  program class
class VData 
{
    // declaring the dictionary "garage"
    public static Dictionary<string, Car> garage = new Dictionary<string, Car>(); //string nickname is stored in class Car, but is used as key for dictionary. value is all other fields in Car.

    //  main method
    public static void Main(string[] args) 
    {
        Msg m = new Msg(); //header for console
        m.clearconsole();
        m.titlebanner();


        //  if there are no cars logged, user is prompted to add atleast one.
        do //do while user has no cars in their garage-> console informs user that there are no cars and to add one-> user is forced to add a car
        {
            Console.WriteLine("Looks like you do not have any cars in your garage.\n               Add your first:\n");

            Car user = new Car();
            garage.Add(user.nickname, user);
        }
        while (garage.Count == 0); 

        //  main running loop
        do  //do while the user has atleast one car in their garage-> console will display nicknames as options-> with the option to add another car or exit.
        {
            m.clearconsole();
            m.titlebanner();

            foreach (string n in garage.Keys) //grabbin' car info from garage
            {
                garage[n].getOfficialName();
            }

            m.commandlist();

            var input = Console.ReadLine();
            if (input == "add car") //user command to add car
            {
                m.clearconsole();
                m.titlebanner();
                Car user = new Car();
                garage.Add(user.nickname, user);
            }
            else if (input == "exit") //user commmand end program
            {
                Environment.Exit(0);
            }
        }
        while (garage.Count > 0);
    }
}










//nice