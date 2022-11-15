// 1. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
// a. კენტი რიცხვების ჯამი
// b. ლუწი რიცხვების ნამრავლი
// c. დაითვლის მასივში თითოეული ელემენტის რაოდენობას (3)

// 1.

int[] number = new int[10];
Console.WriteLine("Enter Number");
for (int i = 0; i < number.Length; i++)
number[i] = Convert.ToInt32(Console.ReadLine());
int index = 0;
int sum = 0;

// a.
for (int i = 0; i < number.Length; i+=2)
{
    sum += number[i];
    Console.WriteLine("Even number sum is: " + sum);
}

// b.

for (int i = 0; i < number.Length; i += 2)
    if (number % 2 == 1)
    sum += number;
    Console.WriteLine(number1);

// c.
totalNumbers = numbers.Count();