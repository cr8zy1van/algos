static void Main(string[] args)
{
    //Problem Statement: Given a rod of length n inches and an array of prices that contains prices of all pieces of size smaller than n.
    //Determine the maximum value obtainable by cutting up the rod and selling the pieces.
    //Time Complexity: O(n^2)
    //Space Complexity: O(n)

    List<int> prices = new List<int> { 10, 52, 84, 93, 101, 17, 117, 20 };
    int n = prices.Count;

    List<int> bestPrice = new List<int>();
    bestPrice.Add(0);

    for (int i = 1; i <= n; i++)
    {
        int tMax = Int32.MinValue;

        for (int j = 0; j < i; j++)
            tMax = Math.Max(tMax, prices[j] + bestPrice[i - j - 1]);

        bestPrice.Add(tMax);
    }
    
    Console.WriteLine($"Maximum obtainable value is ${bestPrice.Last()}");
}
