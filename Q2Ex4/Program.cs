// 4. (ბონუსი) დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად გამეორებული ელემენტის რაოენობას და დაბეჭდავს ამ ელემენტს. (2)


Console.WriteLine("Duplicate number");
int[] number = new int[10] { 5, 5, 9, 6, 5, 5, 5, 8, 3, 7 };

var duplicates = number.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

Console.WriteLine(String.Join(", ", duplicates));