// 2. დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა მოცემული სტრინგი პალინდრომი
// (პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის) (2)



using System;
static bool getStatus(string myString)
{
    string first = myString.Substring(0, myString.Length / 2);
    char[] arr = myString.ToCharArray();

    Array.Reverse(arr);

    string temp = new string(arr);
    string second = temp.Substring(0, temp.Length / 2);

    return first.Equals(second);
}
