class Homework_4
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] lenght = new int[N];

        if (N >= 1 || N <= 10000 && 1 <= K || K <= 100)
        {
            for (int i = 0; i < N; i++)
            {
                lenght[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(Cal(lenght, K, N));
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    static int Cal(int[] num, int K, int N)
    {
        int final = 0;
        
        int[] Max = new int[N -(K*2)];
        for (int i = K; i <= N - (K*2); i++)
        {
            int result = 0;
            result = result + num[i];
            for (int j = 1; j <= K; j++)
            {
                result = result + num[i + j] + num[i - j];
            }
            Max[i-K] = result;
        }
        for (int l = 0; l < N - (K*2); l++)
        {
            if (final < Max[l])
            {
                final = Max[l];
            }
        }
        return final;

    }
}