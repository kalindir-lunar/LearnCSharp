class Task_ColumnSum
{
    static int rows, columns;
    static int[,] TwoArrays;
    static Random rnd = new Random();

    public static void Start()
    {
        rows = inputNum(rows);
        columns = inputNum(columns);
        NewLine();

        TwoArrays = new int[rows, columns];

        for (int i = 0; i < TwoArrays.GetLength(0); i++)
        {
            for (int k = 0; k < TwoArrays.GetLength(1); k++)
            {
                TwoArrays[i, k] = rnd.Next(0, 10);
                System.Console.Write(TwoArrays[i, k] + "\t");
            }
            NewLine();
        }

        SearchingMagicColumn(TwoArrays);
    }

    private static int inputNum(int x)
    {
        int.TryParse(Console.ReadLine(), out x);
        return x;
    }

    private static void SearchingMagicColumn(int[,] Array)
    {
        NewLine();
        
        for (int i = 0; i < TwoArrays.GetLength(1); i++)
        {
            Console.WriteLine($"Сумма {i+1} столбца = {SumColumn(i,0)}");
        }
    }

    private static int SumColumn(int columnIndex, int sumOfColumn)
    {
        for (int i = 0; i < TwoArrays.GetLength(0); i++)
        {
            for (int k = columnIndex; k < TwoArrays.GetLength(1); k++)
            {
                sumOfColumn += TwoArrays[i, k];
                break;
            }
        }
        return sumOfColumn;
    }

    private static void NewLine()
    {
        System.Console.WriteLine();
    }
}