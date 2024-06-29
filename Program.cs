namespace PUPPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PUP Points System");

            Console.Write("Enter your faculty or student number to access: ");

            string userinput = Console.ReadLine();
            
            if(Account.Login(userinput))
            {
                Menu.Show(userinput);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}