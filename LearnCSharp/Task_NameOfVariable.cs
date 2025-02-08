class Task_NameOfVariable
{
    public static void Start()
    {
        string symbols;
        int number;
        float numberWithDot;

        symbols = "Число";
        number = 5;
        numberWithDot = 5.0f;

        System.Console.WriteLine($"{symbols} {number} это тоже самое, что {numberWithDot}");
    }
}