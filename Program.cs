﻿// Run C# in Vscode: go to view-->terminal then add: 
// dotnet new console --force
// dotnet build
// dotnet run 

using System;

namespace learning_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World!"); // First hello world 
            // Prints a message to the same line 
            Console.Write("Congratulations");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code");
            // Create a char literal 
            Console.WriteLine('b');
            // Int literal
            Console.WriteLine(123);
            // Decimal literal, the m is called a literal suffix (tells the compiler is  a decimal value)
            Console.WriteLine(12.3m);
            // Bool literal
            Console.WriteLine(true);
            Console.WriteLine(false);
            // Declaring a variable
            string firstName;
            // Assigning a variable 
            firstName = "Gladys";
            // Retrieve a value stored in a variable 
            Console.WriteLine(firstName);
            // Reassign the value of a variable 
            firstName = "Beth";
            // Initializing the variable 
            string value = "Bob";
            // Implicitly typed local variables (instructs the C# compiler to infer the type)
            var message = "Hello world!";
            // Challenge 
            string name = "Bob";
            int inbox = 3;
            decimal temperature = 34.4m;
            Console.WriteLine($"Hello, {name}! You have {inbox} in your inbox. The temperature is {temperature} celsius.");
            // Escape character sequence (the \n sequence will add a new line, and a \t sequence will add a tab.)
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            // Handle the double double quotes
            Console.WriteLine("Hello \"Enrique\"!");
            // Display a path file just double escape 
            Console.WriteLine("c:\\source\\repos");
            // Verbatim string literal (use the @)
            Console.WriteLine(@"   c:\source\repos   
            (this is where your code goes)");
            // Unicode escape characters  (using the \u, character in Unicode (UTF-16))
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // Format output example 
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            // String concatenation operator 
            Console.WriteLine("Hello " + firstName);
            // Interpolation expression 
            string greeting = "Hey";
            Console.WriteLine($"{greeting} {firstName}!");
            // Combine verbatim literals and string interpolation 
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            // Challenge 
            //string projectName = "ACME";
            //string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            //Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
           // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
           // string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
           // Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

           // Add two numeric values 
           int firstNumber = 12;
           int secondNumber = 7;
           Console.WriteLine(firstNumber + secondNumber);
           // Mix data types
           string firstName = "Bob";
           int widgetsSold = 7;
           Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
           // Add parentheses to make the operation using the string
           string firstName = "Bob";
           int widgetsSold = 7;
           Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
           // Use decimals instead of int
           decimal decimalQuotient = 7.0m / 5;
           Console.WriteLine("Decimal quotient: " + decimalQuotient);
           //Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.
           int first = 7;
           int second = 5;
           decimal quotient = (decimal)first / (decimal)second;
           Console.WriteLine(quotient);
           // Order of operations PEMDAS (Parentheses, Exponent(System.Math.Pow(), Multiplication, Division, Addition, Subtraction))
           int value1 = 3 + 4 * 5;
           int value2 = (3 + 4) * 5;
           Console.WriteLine(value1);
           Console.WriteLine(value2);

           // Operators like +=, -=, *=, ++, and -- are known as compound assignment
           // Increment and decrement 
           int value = 0;
           value = value + 1;
           value++;
           // Challenge - convert temperature to Celsius
           int fahrenheit = 94;
           decimal convertToCelsius = (decimal)(fahrenheit - 32) * 5 / 9;
           Console.Write($"The temperature is {convertToCelsius} Celsius.");

           // Generate random number 
           Random dice = new Random();
           int roll = dice.Next(1, 7);
           Console.WriteLine(roll);

           // Creating an instance of a class (is called an object)
           Random dice = new Random();

           // Overloaded method 
           //For example, the Console.WriteLine() method has 19 different overloaded versions.
           // The Random.Next() method has three overloaded versions
           Random dice = new Random();
           int roll1 = dice.Next();
           int roll2 = dice.Next(101);
           int roll3 = dice.Next(50, 101);

           Console.WriteLine($"First roll: {roll1}");
           Console.WriteLine($"Second roll: {roll2}");
           Console.WriteLine($"Third roll: {roll3}");

           // Challenge: find the larger of two numbers
          int firstValue = 800;
          int secondValue = 600;
          int largerValue = Math.Max(firstValue, secondValue);
          Console.WriteLine($"The larger value is: {largerValue}");

          // Adding decisions
          Random dice = new Random();

          int roll1 = dice.Next(1,7);
          int roll2 = dice.Next(1,7);
          int roll3 = dice.Next(1,7);

          int total = roll1 + roll2 + roll3;

          Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

          if (total > 14)
          {
             Console.WriteLine("You win!!!");
          }
          if (total < 15 )
          {
             Console.WriteLine("You lose!!!");
          }

          // Boolean expressions
          string message = "The quick brown fox jumps over the lazy dog.";
          bool result = message.Contains("dog");
          Console.WriteLine(result);

          if (message.Contains("fox"))
          {
              Console.WriteLine("What does the fox say?");
          }

          // Doubles and triples example
          Random dice = new Random();

          int roll1 = dice.Next(1, 7);
          int roll2 = dice.Next(1, 7);
          int roll3 = dice.Next(1, 7);

          int total = roll1 + roll2 + roll3;

          Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

          if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
          {
             Console.WriteLine("You rolled doubles!  +2 bonus to total!");
             total += 2;
          }

          if ((roll1 == roll2) && (roll2 == roll3)) 
          {
             Console.WriteLine("You rolled triples!  +6 bonus to total!");
             total += 6;
          }

          if (total >= 15)
          {
             Console.WriteLine("You win!");
          }

         if (total < 15)
         {
            Console.WriteLine("Sorry, you lose.");
         }

         // Using else instead
         Random dice = new Random();

         int roll1 = dice.Next(1, 7);
         int roll2 = dice.Next(1, 7);
         int roll3 = dice.Next(1, 7);

         int total = roll1 + roll2 + roll3;

         Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

         if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
         {
         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
         total += 2;
         }

         if ((roll1 == roll2) && (roll2 == roll3))
        {
           Console.WriteLine("You rolled triples!  +6 bonus to total!");
           total += 6;
        }

        if (total >= 15)
        {
           Console.WriteLine("You win!");
        }
        else 
        {
          Console.WriteLine("Sorry, you lose.");
        }
        
        // Nesting 
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples!  +6 bonus to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            total += 2;
        }
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }
        else 
        {
            Console.WriteLine("Sorry, you lose.");
        }
      
        // Using else if 
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples!  +6 bonus to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            total += 2;
        }
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
        Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
        Console.WriteLine("You win a trip for two!");
        }
        else
        {
        Console.WriteLine("You win a kitten!");
        }

        // Challenge check subscriptions expiration
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        // Your code goes here
        Console.WriteLine(daysUntilExpiration);
        if (daysUntilExpiration >= 10)
        {
            Console.WriteLine("Your subscription will expire soon.\nRenew now!");
        }

        else if (daysUntilExpiration >= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
        }

        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }

        // Declare a new array
        string[] fraudulentOrderIDs = new string[3];

        // Assign values to an element on an array
        string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000"; ( this one caused an exception larger than the array)

        // Retrieve values of an array 
        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // Reassign the value of an array 
        fraudulentOrderIDs[0] = "F000";
        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // Initialize an array 
        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        // Getting the size of an array 
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        // Looping through an array with foreach
        string[] names = { "Bob", "Conrad", "Grant" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Initialize an array of int 
        int[] inventory = { 200, 400, 750, 175, 250 };

        // Iterate with foreach
        int[] inventory = { 200, 400, 750, 175, 250 };

        foreach (int items in inventory) 
        {
            Console.WriteLine(items);
        }

        // Add a variable to sum the value of each element in the array
        int[] inventory = { 200, 400, 750, 175, 250 };
        int sum = 0;
        foreach (int items in inventory) 
        {
            sum += items;
            Console.WriteLine(items);
        }

        // Display the final value of sum 
        Console.WriteLine($"We have {sum} items in the inventory");
        }

        // Option to display the running total
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");

        // Challenge - find in an array an element starting with letter B
        string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string order in orders)
        {
        if (order.StartsWith("B")) 
        {
        Console.WriteLine($"Order: {order} starts with letter B");

        // Variable declarations
        char userOption;
        int gameScore;
        float particlesPerMillion;
        bool processedCustomer;

        // Comment lines of code
        string firstName = "Bob";
        int widgetsPurchased = 7;
        // Testing a change to the message.
        // int widgetsSold = 7;
        // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
        Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

        // Multi line comment 
        /* 
        This is a long comment 
        that spans multiple lines
        just to prove that it can
        be done.
        */

        // Poorly commented code - the reader doesn't gain any insight into the purpose of this code
        Random random = new Random();
        string[] orderIDs = new string[5];
        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++)
        {
        // Get a random value that equates to ASCII letters A through E
        int prefixValue = random.Next(65, 70);
        // Convert the random value into a char, then a string
        string prefix = Convert.ToChar(prefixValue).ToString();
        // Create a random number, padd with zeroes
        string suffix = random.Next(1, 1000).ToString("000");
        // Combine the prefix and suffix together, then assign to current OrderID
        orderIDs[i] = prefix + suffix;
        }
        // Print out each orderID
        foreach (var orderID in orderIDs)
        {
        Console.WriteLine(orderID);

        // Whitespace is ignored by the C# Compiler
        // Example 1:
        Console
        .
        WriteLine
        (
        "Hello World!"
        )
        ;

        // Example 2:
        string firstWord="Hello";string lastWord="World";Console.WriteLine(firstWord+" "+lastWord+"!");

        // Challenge - make the code more readable
        /*The high-level purpose of this code is to reverse a string
        and count the number of times a particular character appears. */

        string originalMessage = "The quick brown fox jumps over the lazy dog.";

        char[] message = originalMessage.ToCharArray();
        Array.Reverse(message);

        int letterCount = 0;

        foreach (char letter in message)
        { 
            if (letter == 'o')
            { 
                letterCount++;
            }
        }
 
        string newMessage = new String(message);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");

        // Explicit conversions 
        double x = 1.2345;
        int y = (int)x;

        // Converting numeric types to string 
        int x = 4;
        string xAsString = x.ToString();

        double y = 3.14159;
        string yAsString = y.toString();

        // Checking for null or empty 
        //string.isNullOrEmpty();
        //string.isNullOrWhitespace();

        // Getting a substring 
        //str.subString(1);
        //str.subString(0,5);
        //str.subString(str.Length -1, 1)

        // Removing a substring 
        //str.Remove(1);

        // Replacing
        //str.Replace("world", "microsoft");

        // Searching strings
        // IndexOf() / LastIndexOf()
        // Contains()
        // StartsWith() / EndsWith()

        // Trimming whitespace
        //string str1 = str.TrimStart();
        //string str2 = str.TrimEnd();
        //string str3 = str.Trim();

        // Splitting 
        //string str = " HELLO WORLD";
        //string[] splitStr1 = str.Split();
        //string[] splitStr2 = str.Split("O");
        //string[] splitStr3 = str.Split("Z");

        // Formatted strings 
        //const string formatStr = "Hello {0}! Such lovely {1} we're having for a {2}, it only rained {3} times! The time is {4}";
        //const string user = "Gladys";
        //const string noun = "weather";
        //const string dayOfWeek = "Tuesday";

        //string str = string.Format(formatStr, user, noun, dayOfWeek, 5, DateTime.Now.ToShortTimeString());
        //string str2 = string.Format(formatStr); // error

        // Converting strings to other types
        //string boolStr = "true";
        //string intStr = "12345";
        //string doubleStr = "3.14159";

        //bool b = bool.Parse(boolStr); // true
        //int i = int.Parse(intStr); // 12345
        //double d = double.Parse(doubleStr); // 3.14159
        //double d2 = double.Parse(intStr); // 12345

        //int i2 = int.Parse(doubleStr); // error

        // Enumerations 
        //enum Mood 
        //{
          //  Undefined,  // defaults to 0
         //   Hungry,  // defaults to 1
          //  Sleepy = 50,
          //  Grumpy = 10, 
         //   Happy = 2,
       // }

       // Convert from enum to int 
      // var myMood = Mood.Happy;
      // int myMoodAsInt = (int) myMood;

       // Convert from enum to string
       //var myMood = Mood.Happy;
      // int myMoodAsStr = myMood.ToString();

      // Convert from int to enum 
     // int myInt = 10;
     // if (Enum.isDefined(typeof(Mood), myInt)) 
     // {
     //     var myMood = (Mood) myInt;
     // }
     // else 
     // {
          //handle error
      //}

      // Convert from string to enum 
     // var moodAsStr =  "happy";
      //var mood = Enum.Parse(typeof(Mood), moodAsStr, true); // Mood.Happy
     // var mood2 = Enum.Parse(typeof(Mood), moodAsStr) // error

     // STRUCTS  (container for related variables)
     //public struct Book 
     //{
       //  public double price;
       //  public string title;
       //  public string author;
     //}

     // Access the struct members with .
     //var myBook = new Book();

     //myBook.title = "Jurassic";
     //myBook.author = "Michael";
    // myBook.price = 9.99;

    // Reading from the console
    // Console.Read();
    // Console.ReadKey();
    // Console.ReadLine();
        }
        }
    }
    }
}
