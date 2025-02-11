class CommandExecuter
{
    public void ExecuteHello()
    {
        System.Console.WriteLine("Hello");
    }

    public void ExecuteWorld()
    {
        System.Console.WriteLine("World");
    }

    public void ExecuteCustom(string command)
    {
        System.Console.WriteLine(command);
    }

    public void ExecuteAll(params Action[] commands)
    {
        foreach (var command in commands)
        {
            command();
        }
    }

    /*
    CommandExecuter comEx = new CommandExecuter();

        Action[] commands = {comEx.ExecuteWorld, comEx.ExecuteHello,() => comEx.ExecuteCustom("LoL")};
        comEx.ExecuteAll(commands);

        comEx.ExecuteAll(
            () => comEx.ExecuteHello(),
            () => comEx.ExecuteCustom("New"),
            () => comEx.ExecuteWorld()
        );
    */
}