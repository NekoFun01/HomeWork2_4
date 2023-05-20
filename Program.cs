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


        int[] Max = new int[N - (K * 2)];
        for (int i = K; i < N - K; i++)
        {
            int result = 0;
            result += num[i];
            for (int k = 0; k < K; k++)
            {
               
                result += num[i+1];
                result += num[i-1];
            }
            
            Max[i-K] = result;
        }
        for(int j = 0;j < (N-(K*2))-1;j++)
        {
            if(final < Max[j])
            {
                final = Max[j];
            }
        }

        return final;

    }
}