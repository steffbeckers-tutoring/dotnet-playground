namespace Playground.ClassLibrary.ProgrammingAdvancedCup;

public class CandySharing
{
    public string CalculateTicks(string input)
    {
        int[] candies = Array.ConvertAll(input.Split(" "), int.Parse);

        // Check equality
        if (candies.All(x => x == candies[0]))
        {
            return "0";
        }

        // Check if divisible
        int totalCandies = candies.Sum();

        if (totalCandies % candies.Length != 0)
        {
            return "Infinite";
        }

        HashSet<string> memory = new HashSet<string>();
        int ticks = Tick(candies, memory, 0);

        return ticks == -1 ? "Infinite" : ticks.ToString();
    }

    private int Tick(int[] candies, HashSet<string> memory, int ticks)
    {
        // Check equality
        if (candies.All(c => c == candies[0]))
        {
            return ticks;
        }

        // Loop detection
        string state = string.Join(",", candies);

        if (memory.Contains(state))
        {
            return -1;
        }

        memory.Add(state);

        // Compute one tick (simultaneous transfer)
        int n = candies.Length;
        int[] next = (int[])candies.Clone();

        for (int i = 0; i < n; i++)
        {
            int right = (i + 1) % n;

            if (candies[i] > candies[right])
            {
                next[i]--;
                next[right]++;
            }
        }

        // Recursive call => next tick
        return Tick(next, memory, ticks + 1);
    }
}
