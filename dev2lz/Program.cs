namespace Dev
{
    class Dev
    {
        static void Main()
        {
            Console.WriteLine("1 for +");
            Console.WriteLine("2 for -");
            Console.WriteLine("3 for *");
            Console.WriteLine("4 for /");
            var zxc = Console.ReadLine();
            Console.WriteLine("insert symbols for operation");
            var zxc1 = Console.ReadLine();

            Console.WriteLine(logic.run(zxc, zxc1));
        }
    }
}