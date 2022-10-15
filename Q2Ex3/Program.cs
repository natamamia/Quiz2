// 3. დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს. 
// მაგ 1 1 2 2 2 3 4 2 2 - უნდა დაბეჭდოს 3 და 2. (3)


int main()
{
    int n, i, j, a[10000], temp, count = 0;
    int diff = a[1] - a[0];

    scanf("%d", &n);
    getchar();

    for (i = 0; i < n; i++)
    {
        scanf("%d", &a[i]);
        getchar();
    }

    for (i = 0; i < n - 1; i++)
    {
        for (j = 0; j < n - i - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
    }
    for (i = 0; i < n - 1; i++)
    {
        if (a[i + 1] - a[i] > diff)
        {
            diff = a[i + 1] - a[i];
            count++;
        }
    }
    for (i = 0; i < count; i++)
    {
        printf("%d %d ", a[i], a[i + 1]);
    }
    printf("\n");

    return 0;
}
