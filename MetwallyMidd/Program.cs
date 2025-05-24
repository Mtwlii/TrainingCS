namespace MetwallyMidd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //double x = 25;
            //int y = 10;
            //var z = x % y;
            //Console.WriteLine($"{x}+{y} = {x + y}");
            //Console.WriteLine($"{x}-{y} = {x - y}");
            //Console.WriteLine($"{x}*{y} = {x * y}");
            //Console.WriteLine($"{x}/{y} = {x / y}");
            //Console.WriteLine(z);
            //Console.WriteLine($"50 + 10 = { 50 + 10 } ");
            //Console.WriteLine($"50 - 10 = {50 - 10} ");
            //Console.WriteLine($"50 / 10 = {50 / 10} ");
            //Console.WriteLine($"50 * 10 = {50 * 10} ");
            //Console.WriteLine($"50 % 10 = {50 % 10} ");
            //string x = "2314567" + 10;
            //Console.Write("Enter Your birth date: ");
            //string birthDate = Console.ReadLine();
            //int intYear = int.Parse(birthDate);
            //Console.WriteLine($"Your age until 2025: {2025 - intYear}");
            //Console.Write("Enter your Number: ");
            //string number = Console.ReadLine();
            //int parsedNumber = int.Parse(number);

            //if (parsedNumber == 0 ){
            //    Console.WriteLine("The number is zero.");
            //}
            //else if (parsedNumber % 2 == 0)
            //{
            //    Console.WriteLine($"{parsedNumber} is even.");
            //}
            //else
            //{
            //    Console.WriteLine($"{parsedNumber} is odd.");
            //}

            /*
               [arrays]
            */

            //int [] numbers = {1,3,4,7,9,2,5};
            //int[] member =new int[7];
            //Array.Copy(numbers, member, numbers.Length);
            //Console.WriteLine(member[2]);

            //Console.WriteLine(numbers[6]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[6]);
            //int x =50;

            //for (int i = 0; i <= 10; i++ )
            //{ 
            //    Console.WriteLine( x );
            //    x += 5;
            //}

            //--------------------------------------

            //for (int i = 1; i <= 9;i++)
            //{ 
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine( $"{i} is Even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} is odd.");
            //    }
            //}
            // int[] numbers = { 1, 2, 3, 4, 5 };
            //  numbers = new int[] { 6, 7, 8, 9, 10 };
            // int[] numbers3 = { 11, 12, 13, 14, 15 };
            // CalculateAverage(numbers);
            //// CalculateAverage(numbers2);
            // CalculateAverage(numbers3, true);
            // static double CalculateAverage(int[] numbers , bool printToConsole = false)
            // {
            //     int sum = 0;
            //     foreach (int number in numbers)
            //     {
            //         sum += number;
            //     }
            //     double average = (double)sum / numbers.Length;
            //     if (printToConsole == true)
            //     Console.WriteLine($"The average is: {average}");
            //     return average;
            // }

            //Console.WriteLine("Please Enter The Number Of Items: ");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] nums = new int[arraySize];
            //for (int i = 0; i < arraySize; i++)
            //{
            //    Console.Write($"Please Enter The Item {i + 1}: ");
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0,  smallestNum = int.MaxValue,  greatestNum = 0;

            //foreach (int  num in nums) {
            //    sum +=num;
            //    if (num < smallestNum)
            //        smallestNum = num;

            //    if (num > greatestNum)
            //        greatestNum = num;
            //}
            //double average = (double)sum / arraySize;
            //Console.WriteLine($"smallest number is: {smallestNum}");
            //Console.WriteLine($"greatest number is: {greatestNum}");
            //Console.WriteLine($"The average is: {average}");



            //while (true)
            //{
            //    Console.Write("Enter a world to check :  ");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        Console.WriteLine("Please enter a valid word.");
            //        continue;
            //    }
            //    string reversed = string.Empty;
            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        reversed += input[i];
            //    }
            //    if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"{input} is a palindrome.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{input} is not a palindrome.");
            //    }
            //}

            //while (true)
            //{
            //    Console.Write("Please enter a word to check : ");
            //    string word = Console.ReadLine();
            //    word = word.ToLower();
            //    bool isPalindrome = false;
            //    int length = word.Length;
            //    for (int i = 0; i < length / 2; i++)
            //    {
            //        if (word[i] != word[length - 1 - i])
            //        {
            //            isPalindrome = true;
            //            break;
            //        }

            //    }
            //    if (isPalindrome == false)
            //    {
            //        Console.WriteLine($"{word} is a palindrome.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{word} is not a palindrome.");
            //    }
            //}

            //int num1 = 5;
            //int num2 = num1;
            //num1 = 10;
            //Console.WriteLine($"num1: {num1}"); // Output: 10
            //Console.WriteLine($"num2: {num2}"); // Output: 5
            //Console.WriteLine("-----------------");

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = numbers1;
            //numbers1[0] = 10;
            //Console.WriteLine($"numbers1[0]: {numbers1[0]}"); // Output: 10
            //Console.WriteLine($"numbers2[0]: {numbers2[0]}"); // Output: 10


            //int num = 5;
            //DuplicateValue(num);
            //Console.WriteLine($"num: {num}"); // Output: 5
            //int[] numbers = { 1, 2, 3 };
            //DuplicateArrayValue(numbers);
            //Console.WriteLine($"numbers[0]: {numbers[0]}"); // Output: 2
            //Console.WriteLine($"numbers[1]: {numbers[1]}"); // Output: 4
            //Console.WriteLine($"numbers[2]: {numbers[2]}"); // Output: 6
            //Console.WriteLine("-----------------");

            //-------------------intersted in this part string format------------------

            //string str = "Hello {0}, My Nmame Is {1}";
            //Console.WriteLine(str);
            //str = string.Format(str, "Mohamed", "Metwally");
            //Console.WriteLine(str);
            //Student[] students = new Student[10];
            //Student ahmed = new Student( "Ahmed");
            //Student mohamed = new("Mohamed", 22, "B");
            //Student[] students = { ahmed, mohamed };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //Console.WriteLine(ahmed.Name);
            //}


            // Student student = new ();
            //student.SetName("Metwally Mohamed");
            //Console.WriteLine(student.GetName());

            //---------------using properties------------------
            //student.Name = "Metwally Mohamed";
            //student.Age = 22;
            //student.Grade = "B";
            //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            //Console.WriteLine($"Name: {student.Name}");
            
            //Student student = new("Metwally Mohamed");
            //Console.WriteLine($"Name: {student.Name}");

            //Student student = new Student{ Name = "Metwally Mohamed" };
            //Console.WriteLine($"Name: {student.Name}");



        }

        //static void DuplicateValue(int number)
        //{
        //    number *= 2;

        //}
        //static void DuplicateArrayValue(int[] number)
        //{
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        number[i] *= 2;
        //    }
        //}

    }
}

    