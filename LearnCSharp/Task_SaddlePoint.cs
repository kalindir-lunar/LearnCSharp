class Task_SaddlePoint
{
    const int ROWS = 3, COLUMNS = 3;
    static int[,] TwoArrays;
    static int saddle_point = -1;
    static int minimal_number_in_row;
    static int columnOfMinimalIndex = 0;
    static Random rnd = new Random();

    public static void Start()
    {
        TwoArrays = new int[ROWS, COLUMNS] { { 2, 2, 1 }, { 0, 0, 0 }, { 0, 0, 0 } };
        OutputMassive(TwoArrays, '1', false);

        if (FindSaddlePoint(TwoArrays))
        {
            Console.WriteLine($"Седловая точка найдена: {saddle_point}");
        }
        else
        {
            Console.WriteLine("Седловая точка отсутствует.");
        }
    }

    private static bool FindSaddlePoint(int[,] massive)
    {
        for (int rowCount = 0; rowCount < massive.GetLength(0); rowCount++)
        {
            minimal_number_in_row = massive[rowCount, 0];
            columnOfMinimalIndex = 0;

            for (int col = 1; col < massive.GetLength(1); col++)
            {
                if (massive[rowCount, col] < minimal_number_in_row)
                {
                    minimal_number_in_row = massive[rowCount, col];
                    columnOfMinimalIndex = col;
                }
            }

            bool isMaxInColumn = true;
            for (int row = 0; row < massive.GetLength(0); row++)
            {
                if (massive[row, columnOfMinimalIndex] > minimal_number_in_row)
                {
                    isMaxInColumn = false;
                    break;
                }
            }

            if (isMaxInColumn)
            {
                saddle_point = minimal_number_in_row;
                return true;
            }
        }

        return false;
    }

    private static void OutputMassive(int[,] massive, char massiveNum, bool isPacking)
    {
        System.Console.WriteLine($"Данные в массиве {massiveNum}:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int k = 0; k < massive.GetLength(1); k++)
            {
                if (isPacking == true)
                {
                    massive[i, k] = rnd.Next(0, 10);
                }
                System.Console.Write(massive[i, k] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}