namespace PortTester
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: PortTester <ipAddress> <port>");
                return;
            }

            string ipAddress = args[0];
            int port;

            if (!int.TryParse(args[1], out port))
            {
                Console.WriteLine("Invalid port number.");
                return;
            }

            bool isOpen = PortTester.TestPort(ipAddress, port);

            if (isOpen)
            {
                Console.WriteLine($"Port {port} is open on {ipAddress}.");
            }
            else
            {
                Console.WriteLine($"Port {port} is closed on {ipAddress}.");
            }
        }
    }
}