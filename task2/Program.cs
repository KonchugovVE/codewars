// Цифровой корень — это рекурсивная сумма всех цифр числа.

// Учитывая n, возьмите сумму цифр n. Если это значение имеет более одной цифры, продолжайте уменьшать таким образом, пока не будет получено однозначное число. Ввод будет неотрицательным целым числом.
//     16  -->  1 + 6 = 7
//    942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
// 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
// 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

long Enter(string text)
{
    System.Console.WriteLine(text);
    long num = Convert.ToInt64(Console.ReadLine());
    return num;
}

long num = Enter("enter");

int DigitalRoot(long num)
{
    long summ = num;

    long summ1 = 0;

    while (summ > 9)
    {
        if (summ > 99)
        {
            for (long j = summ; j > 0; j /= 10)
            {
                summ1 = summ1 + j % 10;
            }
            summ = summ1;
        }
        else
        {
            summ = summ / 10 + summ % 10;
        }

    }
    int num1 = (int)summ;
    return num1;
}

int DigitalRootV2(long num)
{
 int DigitalRoot = (1+(num-1)%9);
 return DigitalRoot;
}

System.Console.WriteLine(DigitalRoot(num));