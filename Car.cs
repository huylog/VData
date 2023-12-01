class Car //
{
    public string nickname;
    public Int32 year;
    public string make;
    public string model;
    public string package;
    public string description;
    public Car()
    {
        //Year Make Model Package Description Questions
        nickname = AskQ("Nickname?");
        year = Int32.Parse(AskQ("Year?"));
        make = AskQ("Make?");
        model = AskQ("Model?");
        package = AskQ("Package?");
        description = AskQ("Description?");

    }
    public string AskQ(string question)
    {
        Console.WriteLine(question);
        String answer = Console.ReadLine() + "";
        if (answer == "")
        {
            return AskQ(question);
        }
        else
        {
            return answer;
        }
    }
    public void getOfficialName()
    {
        Console.WriteLine(nickname + "\n| " + year + " " + make + " " + model + " | " + package + "\n| " + description);
    }
}
