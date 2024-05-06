static int Candy(int[] ratings) {
    if (ratings == null || ratings.Length == 0) 
        return 0;

    if (ratings.Length == 1)
        return 1;
    
    int[] candy = new int[ratings.Length];
    candy[0] = 1;

    for (int i = 1; i < ratings.Length; i++) {
        if (ratings[i] > ratings[i-1]) {
            candy[i] = candy[i-1] + 1;
        }
        else
            candy[i] = 1;
    }

    for (int i = 0; i < candy.Length; i++) {
        System.Console.Write($"{candy[i]}\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"candy.Sum() = {candy.Sum()}");

    for (int i = ratings.Length - 2; i >= 0; i--) {
        if (ratings[i] > ratings[i+1]) {
            candy[i] = Math.Max(candy[i], candy[i+1] + 1);
        }
    }

    return candy.Sum();
}

// int[] input = [1,0,2];      // ans: 5
int[] input = [1,2,2];   // ans: 4
int answer = Candy(input);
System.Console.WriteLine($"answer = {answer}");