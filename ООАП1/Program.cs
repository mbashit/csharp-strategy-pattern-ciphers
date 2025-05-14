using lab1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to encryption!");
        int option = 0;
        do
        {
            Console.WriteLine("Select the one of 3 offered ciphers:");
            Console.WriteLine("1. Caesar\n2. XOR\n3. Reverse\n0. Exit");
            try
            {
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the text: ");
                            string source = Console.ReadLine();
                            Console.WriteLine("Enter shift value: ");
                            int shift = int.Parse(Console.ReadLine());
                            Encryptor encryptor = new Encryptor(new CaesarCipher(shift));
                            Console.WriteLine(encryptor.encode(source));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter the text to encrypt: ");
                            string source = Console.ReadLine();
                            Console.WriteLine("Enter key: ");
                            char key = char.Parse(Console.ReadLine());
                            Encryptor encryptor = new Encryptor(new XorCipher(key));
                            Console.WriteLine(encryptor.encode(source));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the text to encrypt: ");
                            string source = Console.ReadLine();
                            Encryptor encryptor = new Encryptor(new ReverseCipher());
                            Console.WriteLine(encryptor.encode(source));
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input corrupted!");
                option = 5;
            }
        } while (option > 0);
    }
}