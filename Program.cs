namespace OneThree {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());
            bool[] a = new bool[n + 1];
            a[0] = true;
            a[1] = true;
            double sqrN = Math.Sqrt(n);
            for (int i = 2; i <= sqrN; ++i) {
                for (int s = i*i; s <= n; s += i) {
                    a[s] = true;                   
                }         
            }
            for(int i = 0; i <= n; ++i) {
                if (!a[i]) {
                    Console.Write(i + " ");
                }
            }
        }
    }
}