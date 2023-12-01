using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Reflection;


class VData
{
    public static Dictionary<string, Car> garage = new Dictionary<string, Car>();

    public static void Main(string[] args)
    {
        Msg m = new Msg();
        m.clearconsole();
        m.titlebanner();



        do   // if there are no cars logged, user is prompted to add atleast one.
        {
            Console.WriteLine("Looks like you do not have any cars in your garage.");
            Console.WriteLine("Add your first:");

            Car user = new Car();
            garage.Add(user.nickname, user);
        }
        while (garage.Count == 0);

        //main running loop
        do    //else the user has atleast one car in his garage-> console will display nicknames as options-> with the option to add another car.
        {
            m.clearconsole();
            m.titlebanner();

            foreach (string n in garage.Keys) //grabbin' car info from garage
            {
                garage[n].getOfficialName();
            }

            m.commandlist();

            var input = Console.ReadLine();
            if (input == "a car")
            {
                m.clearconsole();
                m.titlebanner();
                Car user = new Car();
                garage.Add(user.nickname, user);
            }
            else if (input == "exit")
            {
                Environment.Exit(0);
            }
        }
        while (garage.Count > 0);
    }
}
