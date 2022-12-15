using Common;
using GenericList;

class Program
{
    public static List<Option> options;
    public static SingleLinkedList myLinkedList = new SingleLinkedList();
    static void Main(string[] args)
    {
        // Create options that you want your menu to have
        options = new List<Option>
            {
                //new Option("add", () => AddIntElement()),
                new Option("add", () =>  AddElement()),
                new Option("size", () =>  PrintSize()),
                new Option("print", () =>  PrintNodes()),
                new Option("Exit", () => Environment.Exit(0)),
            };

        // Set the default index of the selected item to be the first
        int index = 0;

        // Write the menu out
        WriteMenu(options, options[index]);

        // Store key info in here
        ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();
            // Handle each key input (down arrow will write the menu again with a different selected item)
            if (keyinfo.Key == ConsoleKey.DownArrow)
            {
                if (index + 1 < options.Count)
                {
                    index++;
                    WriteMenu(options, options[index]);
                }
            }
            if (keyinfo.Key == ConsoleKey.UpArrow)
            {
                if (index - 1 >= 0)
                {
                    index--;
                    WriteMenu(options, options[index]);
                }
            }
            // Handle different action for the option
            if (keyinfo.Key == ConsoleKey.Enter)
            {
                options[index].Selected.Invoke();
                index = 0;
            }
        }
        while (keyinfo.Key != ConsoleKey.X);

        Console.ReadKey();

    }
    // Default action of all the options. You can create more methods
    static void WriteTemporaryMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(3000);
        WriteMenu(options, options.First());
    }
    static bool AddElement()
    {
        Console.Write("Type Int to be added: ");
        var elementToBeAdded = Console.ReadLine();
        int intToBeAdded;
        try
        {
            intToBeAdded = int.Parse(elementToBeAdded);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Could not parse {elementToBeAdded} into an Int.");
            Thread.Sleep(1000);
            WriteMenu(options, options.First());
            
            return false;
        }
        myLinkedList.InsertLast(new Node(int.Parse(elementToBeAdded)));
        Console.WriteLine($"Added {intToBeAdded} to the datastructure.");
        Thread.Sleep(1000);
        WriteMenu(options, options.First());
        return true;
    }

    static void PrintSize()
    {
        Console.Write($"The Datastructure contains {myLinkedList.count()} elements.");
        Thread.Sleep(1000);
        WriteMenu(options, options.First());
    }

    static void PrintNodes()
    {
        Console.Write(myLinkedList);
        Thread.Sleep(1000);
        WriteMenu(options, options.First());
    }


    static void WriteMenu(List<Option> options, Option selectedOption)
    {
        Console.Clear();

        foreach (Option option in options)
        {
            if (option == selectedOption)
            {
                Console.Write("> ");
            }
            else
            {
                Console.Write(" ");
            }

            Console.WriteLine(option.Name);
        }
    }
}

public class Option
{
    public string Name { get; }
    public Action Selected { get; }

    public Option(string name, Action selected)
    {
        Name = name;
        Selected = selected;
    }
}



