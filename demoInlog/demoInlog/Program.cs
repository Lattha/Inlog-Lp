namespace demoInlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool passwordOk;

            Console.Write("Gebruikersnaam: ");
            string userName = Console.ReadLine();

            Console.Write("Wachtwoord (pincode van 4 getallen): ");
            passwordOk = int.TryParse(Console.ReadLine(), out int passWord);

            if (!passwordOk || passWord < 999 || passWord >= 9999)
            {
                Console.WriteLine("Verkeerde ingave...");
            }

        }
    }
}
