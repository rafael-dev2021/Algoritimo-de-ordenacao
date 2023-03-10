namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "banana", "uva", "maçã", "maracujá", "limão", "laranja" };
            MergeSort(frutas, 0, frutas.Length - 1);

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i] + " ");
            }
        }

        static void MergeSort(string[] frutas, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSort(frutas, l, m);
                MergeSort(frutas, m + 1, r);
                Merge(frutas, l, m, r);
            }
        }

        static void Merge(string[] frutas, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            string[] L = new string[n1];
            string[] R = new string[n2];

            for (int i = 0; i < n1; i++)
            {
                L[i] = frutas[l + i];
            }

            for (int j = 0; j < n2; j++)
            {
                R[j] = frutas[m + 1 + j];
            }

            int k = l;
            int x = 0;
            int y = 0;

            while (x < n1 && y < n2)
            {
                if (L[x].CompareTo(R[y]) <= 0)
                {
                    frutas[k] = L[x];
                    x++;
                }
                else
                {
                    frutas[k] = R[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                frutas[k] = L[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                frutas[k] = R[y];
                y++;
                k++;
            }
        }
    }
}