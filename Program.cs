using System;
using System.Text.RegularExpressions;

namespace Lab7_RegExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the users input starting with name
            string userInput = GetUserInput("Please enter your first and last name seperated by a space:  ");

            //store the correctly formatted name for display at console
            string formattedName = Name(userInput);

            //Display correctly formatted name
            Console.WriteLine($"Formatted Name entered and saved: {formattedName}\n");

            //get the users input for email address
            userInput = GetUserInput("Please enter in your email address ex.(xxxxxx@xxxxx.xx or xxxxx@xxxxx.xxx):  ");

            //store the correctly formatted email for display at console
            string formattedEmail = Email(userInput);

            //Display correctly formatted email
            Console.WriteLine($"Formatted email entered and saved: {formattedEmail}\n");

            //get the users input for phone number
            userInput = GetUserInput("Please enter in your phone number ex.(xxx-xxx-xxx):  ");
            
            //store the correctly formatted phone number for display at console
            string formattedPhone = PhoneNumber(userInput);

            //Display correctly formatted phone number
            Console.WriteLine($"Formatted Phone Number entered and saved: {formattedPhone}\n");

            //get the users input for date
            userInput = GetUserInput("Please enter in a date ex.(xx/xx/xxxx):  ");

            //store the correctly formatted date for display at console
            string formattedDate = Date_D(userInput);

            //Display correctly formatted date
            Console.WriteLine($"Formatted date entered and saved: {formattedDate}\n");

            //get the users input for an html element 
            userInput = GetUserInput("Please enter in an Html element i.e.(<a></a>):  ");

            //store the correctly formatted html for display at console
            string formattedHtml = HTML(userInput);

            //Display correctly formatted date
            Console.WriteLine($"Formatted HTML entered and saved: {formattedHtml}\n");
        }

        //method to get users input
        public static string GetUserInput(string message)
        {
            //stores the input from thee user in the ReadLine below
            string userInput;

            //prints the message that is sent from the console
            Console.Write(message);

            //prompts the user for input
            userInput = Console.ReadLine();
            return userInput;
        }

        //method to check if Name is correctly formatted
        public static string Name(string name)
        {
            //counter for number of invalid entries (3 allowed)
            int count = 0;

            //variable to capture the users input
            string userInput = "";

            //check if name is properly formatted (i.e. Reginald Richardson)
            if (!Regex.IsMatch(name, @"(([A-Z])([a-z]+) ([A-Z])([a-z]+)){1,30}") && count < 3)
            {
                //if not properly formatted display message and prompt for re-entry
                Console.Write("Invalid format.  Please enter in your first and last name seperated by a space: ");
                userInput = Console.ReadLine();

                //recursive call while counter is less than 3 and user input for name is invalid
                return Name(userInput);
            }
            //check if invalid input has happened 3 times
            else if(count == 3)
            {
                Console.WriteLine("To many bad entries.  Exiting the program");

                //exits program if counter is 3
                Environment.Exit(0);
                return name;
            }

            //returns the input if correctly formatted
            else
            {
                return name;
            }
        }

        //method to check if email is correctly formatted
        public static string Email(string email)
        {
            //counter for number of invalid entries (3 allowed)
            int count = 0;

            //variable to capture the users input
            string userInput = "";

            //check if email is properly formatted (i.e. xxxxx@xxxxx.xx or xxxxx@xxxxx.xxx)
            if (!Regex.IsMatch(email, @"([A-Za-z]|[0-9]){5,30}(['@'])([A-Za-z]|[0-9]){5,10}(['.'])([A-Za-z]){1,3}") && count < 3)
            {
                //if not properly formatted display message and prompt for re-entry
                Console.Write("Invalid format.  Please enter in your email ex.(xxxxx@xxxxx.xxx or xxxxx@xxxxx.xx):  ");
                userInput = Console.ReadLine();
                count++;

                //recursive call while counter is less than 3 and user input for name is invalid
                return Email(userInput);
            }
            //exits program if counter is 3
            else if (count == 3)
            {
                Console.WriteLine("To many bad entries.  Exiting the program");
                Environment.Exit(0);
                return email;
            }

            //returns the input if correctly formatted
            else
            {
                return email;
            }
        }

        //method to check if phone number is correctly formatted
        public static string PhoneNumber(string phoneNum)
        {
            int count = 0;
            string userInput = "";

            //check if phone number is properly formatted (i.e. xxx-xxx-xxxx)
            if (!Regex.IsMatch(phoneNum, @"([0-9]){3}([-])([0-9]){3}([-])([0-9]){4}") && count < 3)
            {
                Console.Write("Invalid format.  Please enter in your phone number ex.(xxx-xxx-xxxx):  ");
                userInput = Console.ReadLine();
                count++;
                return PhoneNumber(userInput);
            }

            //exits program if counter is 3
            else if (count == 3)
            {
                Console.WriteLine("To many bad entries.  Exiting the program");
                Environment.Exit(0);
                return phoneNum;
            }

            //returns the input if correctly formatted
            else
            {
                return phoneNum;
            }
        }

        //method to check if date is correctly formatted
        public static string Date_D(string date)
        {
            int count = 0;
            string userInput = "";

            //check if date is properly formatted (i.e. xx/xx/xxxx)
            if (!Regex.IsMatch(date, @"([0-9]){2}[/]([0-9]{1,2})([/])([0-9]){4}") && count < 3)
            {
                Console.Write("Invalid format.  Please enter in a date ex.(09/21/2022):  ");
                userInput = Console.ReadLine();
                count++;
                return Date_D(userInput);
            }

            //exits program if counter is 3
            else if (count == 3)
            {
                Console.WriteLine("To many bad entries.  Exiting the program");
                Environment.Exit(0);
                return date;
            }

            //returns the input if correctly formatted
            else
            {
                return date;
            }
        }

        public static string HTML(string html)
        {
            int count = 0;
            string userInput = "";

            //check if the html tag is properly formatted (i.e. <a>xxxxxxxxxxxxxxxxx</a>)
            if (!Regex.IsMatch(html, @"(['<'])([A-Za-z]){1,15}(['>'])(.){1,20000}(['</'])([A-Za-z]){1,15}(['>'])") && count < 3)
            {
                Console.Write("Invalid format.  Please enter in a correclty formatted html tag ex.(<a>xxxxxxxxxxxxxxx</a>):  ");
                userInput = Console.ReadLine();
                count++;
                return HTML(userInput);
            }

            //exits program if counter is 3
            else if (count == 3)
            {
                Console.WriteLine("To many bad entries.  Exiting the program");
                Environment.Exit(0);
                return html;
            }

            //returns the input if correctly formatted
            else
            {
                return html;
            }
        }
    }
}
