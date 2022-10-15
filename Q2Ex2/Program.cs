// 2. დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა მოცემული სტრინგი პალინდრომი
// (პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის) (2)



int i = 0;
int j = value.Length - 1;
bool IsPalindrome(string value)
while (true)
{
    if (i > j)
    {
        return true;
    }
    char a = value[i];
    char b = value[j];
    if (char.ToLower(a) != char.ToLower(b))
    {
        return false;
    }
    i++;
    j--;
}