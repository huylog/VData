class Msg //Msg m = new Msg(); m.titlebanner(); m.commandlist();    //for messaging the user declared strings
{
    public void commandlist() //command list
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine(" a car -> Add a car to your garage");
        Console.WriteLine(" exit -> Exits Console");
        Console.WriteLine("----------------------------------");
    }
    public void titlebanner() //displays title banner
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("     <Vehicle Spec. Database>");
        Console.WriteLine("----------------------------------");
    }
    public void clearconsole() { Console.Clear(); } //console clear method (why? because im obssesive)
}
