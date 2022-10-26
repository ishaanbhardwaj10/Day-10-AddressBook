namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Use Case #5: Add multiple person in Address Book");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 5:
                    AddressBook addressBookFive = new AddressBook();
                    //adding multiple contacts through console and then displaying them
                    //a List from collection class is used to achieve this
                    addressBookFive.AddContact();
                    addressBookFive.AddContact();
                    addressBookFive.AddContact();
                    addressBookFive.AddContact();
                    addressBookFive.Display();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}