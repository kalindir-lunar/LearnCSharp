using System.Globalization;

class Task_SumOfDigits
{
    static public int SumOfDigits(int input_number)
    {
        int sum = 0;
        bool isNegative = input_number < 0; // Проверяем, отрицательное ли число

        // Преобразуем число в строку для доступа к отдельным цифрам
        string numberString = Math.Abs(input_number).ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            int digit = numberString[i] - '0'; // Преобразуем символ в цифру

            if (isNegative && i == 0) // Если число отрицательное и это первая цифра
            {
                sum -= digit; // Вычитаем первую цифру
            }
            else
            {
                sum += digit; // Добавляем остальные цифры
            }
        }

        return sum;
    }
}