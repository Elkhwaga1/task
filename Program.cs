namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char choice = ' ';

            while (choice != 'Q')
            {
                Console.WriteLine("\nP - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean");
                Console.WriteLine("S - Display smallest number");
                Console.WriteLine("L - Display largest number");
                Console.WriteLine("F - Find a number in the list");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");

                string input = Console.ReadLine() ?? "";

                if (input.Length > 0)
                {
                    choice = char.ToUpper(input[0]);
                }
                else
                {
                    choice = ' ';
                }

                switch (choice)
                {
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }

                            Console.WriteLine("]");
                        }
                        break;

                    case 'A':
                        Console.Write("Enter an integer to add: ");

                        string numberInput = Console.ReadLine() ?? "";
                        int number;

                        if (int.TryParse(numberInput, out number))
                        {
                            numbers.Add(number);
                            Console.WriteLine(number + " added");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number");
                        }
                        break;

                    case 'M':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine(
                                "Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }

                            double mean = (double)sum / numbers.Count;

                            Console.WriteLine("The mean is " + mean);
                        }
                        break;

                    case 'S':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine(
                                "Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }

                            Console.WriteLine(
                                "The smallest number is " + smallest);
                        }
                        break;

                    case 'L':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine(
                                "Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }

                            Console.WriteLine(
                                "The largest number is " + largest);
                        }
                        break;

                    case 'F':
                        Console.Write("Enter a number to find: ");

                        string searchInput = Console.ReadLine() ?? "";
                        int searchNumber;

                        if (int.TryParse(searchInput, out searchNumber))
                        {
                            bool found = false;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == searchNumber)
                                {
                                    Console.WriteLine(
                                        searchNumber + " found at index " + i);

                                    found = true;
                                    break;
                                }
                            }

                            if (found == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid number");
                        }
                        break;

                    case 'C':
                        numbers.Clear();
                        Console.WriteLine("List cleared");
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine(
                            "Unknown selection, please try again");
                        break;
                }
            }
        }
    }
}
        
    

