class Task_TransposingArray
{
    static int rows = 3, columns = 3;
    static int[,] TwoArrays;
    static Random rnd = new Random();
    public static void Start()
    {
        TwoArrays = new int[rows, columns];
        int[,] newMassive = new int[TwoArrays.GetLength(0), TwoArrays.GetLength(1)];

        OutputMassive(TwoArrays, '1', true);

        for (int i = 0; i < TwoArrays.GetLength(1); i++)
        {
            Transposition(TwoArrays, i, newMassive);
        }

        OutputMassive(newMassive, '2', false);
    }

    private static void Transposition(int[,] massive, int columnIndex, int[,] newMassive)
    {
        for (int i = 0; i < TwoArrays.GetLength(0); i++)
        {
            for (int k = columnIndex; k < TwoArrays.GetLength(1); k++) 
            {
                newMassive[k,i] = TwoArrays[i, k];
                break;
            }
        }
    }

    private static void OutputMassive(int[,] massive, char massiveNum, bool isPacking)
    {
        System.Console.WriteLine($"Данные в массиве {massiveNum}:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int k = 0; k < massive.GetLength(1); k++)
            {
                if(isPacking == true)
                {massive[i, k] = rnd.Next(0, 10);}
                System.Console.Write(massive[i, k] + "\t");
            }
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("");
    }
}