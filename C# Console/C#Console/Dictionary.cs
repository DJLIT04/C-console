

class Dictionary1
{
    public static void Dict1(string[] args)
    {
        Dictionary1<string, string> phonebook = new Dictionary1<string, string>();
        phonebook.Add("Alice", "123-456-7890"); 
        phonebook.Add("Bob", "214-331-3345");

        Console.WriteLine(phonebook["Alice"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, string> inventory = new Dictionary<string, int>();
        inventory.Add("Apples", 50);
        inventory.Add("Grapes", 40);
        inventory.Add("Mangos", 30);
        inventory.Add("Bananas", 20);


        foreach(KeyValuePAir<string, int> item in inventory)
        {
            Console.WriteLine(item.key + ": " + item.value);
        }
    }
}