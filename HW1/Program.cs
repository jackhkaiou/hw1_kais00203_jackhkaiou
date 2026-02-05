using System;

class Program
{

    /* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            // Please write down your name first. 
            Console.WriteLine("My name is Jack Kaiser. My OU 4x4 is kais0023, and my GitHub account name is @jackhkai. \n");

            Console.WriteLine("=== CALCULATOR SYSTEM ===");
            Console.WriteLine("1) Calculate Sale Total");
            Console.WriteLine("2) Calculate Student Grade");
            Console.WriteLine("3) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                SaleTotal();
            }
            else if (input == "2")
            {
                StudentGrade();
            }
            else if (input == "3")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Question 1 ---

    static void SaleTotal()
    {
        Console.Clear();
        Console.WriteLine("--- Sale Total Calculator ---");

        // ENTER YOUR CODE HERE
        Console.WriteLine("\nWhat is the product name of the item you are purchasing?");
        string productname = Console.ReadLine();
        Console.WriteLine("\nHow many " + productname + "s do you want to buy?");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat is the price for each " + productname + "?");
        double price = double.Parse(Console.ReadLine());
        double subtotal = (quantity * price);
        double salestax = (subtotal * 0.085);
        double total = (subtotal + salestax);
        Console.WriteLine($"\nYour subtotal for your bill is {subtotal:C2}");
        Console.WriteLine($"Your sales tax for your bill is {salestax:C2}");
        Console.WriteLine($"Your total for your bill is {total:C2}");
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 2 ---

    static void StudentGrade()
    {
        Console.Clear();
        Console.WriteLine("--- Student Grade Calculator ---");

        // ENTER YOUR CODE HERE
        Console.WriteLine("What is your first name?");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();
        Console.WriteLine("What is your student ID?");
        int studentid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter homework grade:");
        double hgrade = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter homework percentage");
        double hperc = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter participation grade");
        double pgrade = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter participation percentage");
        double pperc = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter quizzes grade");
        double qgrade = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter quizzes percentage");
        double qperc = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter midterm grade");
        double mgrade = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter midterm percentage");
        double mperc = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter final grade");
        double fgrade = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter final percentage");
        double fperc = double.Parse(Console.ReadLine());
        double totalgrade = (((hgrade * hperc) + (pgrade * pperc) + (qgrade * qperc) + (mgrade * mperc) + (fgrade * fperc))*.01);
        Console.WriteLine("\nYour final grade is " + totalgrade + "%");
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}