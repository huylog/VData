class Car //
{
    //  declaring fields for class Car
    public string nickname;
    public Int32 year;
    public string make;
    public string model;
    public string package;
    public string description;
    public Car()
    {
        //Year Make Model Package Description questions
        nickname =         AskQ("Nickname?    | Choose a nickname.");
        year = Int32.Parse(AskQ("Year?        |"));
        make =             AskQ("Make?        |");
        model =            AskQ("Model?       |");
        package =          AskQ("Package?     | ex.--> 2.4L I4, Single Cab, Base");
        description =      AskQ("Description? | ex.--> Blue Body, Blue Camper Shell");

    }
    public string AskQ(string question) //over engineered way of stopping the user from entering a empty field, instead of moving on it prompts the question again.
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
