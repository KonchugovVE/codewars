// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"



int[] myarray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

for (int i = 0; i < myarray.Length; i++)
{
    if (i == 0)
    {
        System.Console.Write("(");
    }

    if (i < 2)
    {
        System.Console.Write(myarray[i]);
    }

    if (i == 3)
    {
        System.Console.Write(") ");
    }

    if (i > 2 && i < 5)
    {
        System.Console.Write(myarray[i]);
    }

    if (i == 6)
    {
        System.Console.Write("-");
    }

    if (i > 5)
    {
        System.Console.Write(myarray[i]);
    }
}