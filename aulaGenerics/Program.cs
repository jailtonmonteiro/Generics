namespace aulaGenerics{
    class Program{
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());


            for(int i =0; i < n; i++){
                Console.Write($"Valor {i}: ");
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}