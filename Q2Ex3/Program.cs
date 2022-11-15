// 3. დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს. 
// მაგ 1 1 2 2 2 3 4 2 2 - უნდა დაბეჭდოს 3 და 2. (3)

using System;

int[] number = new int[10] { 5, 5, 9, 6, 5, 5, 5, 8, 3, 7 };
int count = 1;
for (int i = 0; i < number.Length; i++)
{
    for (int j = i; j < number.Length - 1; j++)
    {
        if (number[j] == number[j + 1])
            count = count + 1;
    }
    Console.WriteLine("\t\n " + number[i] + "occurs" + count);
}
Console.WriteLine();