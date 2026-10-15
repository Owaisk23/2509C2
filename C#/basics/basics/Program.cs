// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////DATATYPES
////string

//string userName = "Saqib";

//char bloodGroup = 'A';

//Console.WriteLine(userName + " " + bloodGroup);

////numbers

//byte age = 255; //max num 255

//int qaidiNo = 804;

//long largeNum = 1314963456956437686L;

//float height = 5.11F;

//double dNum = 990.788D;

//decimal deciNum = 778899.5687M;

////Boolean

//bool isValid = false;

//// Arithematic Operations

//Console.WriteLine(66 + 45);
//Console.WriteLine(66 - 45);
//Console.WriteLine(66 * 45);
//Console.WriteLine(66 / 45);
//Console.WriteLine(66 % 45);

////ASSIGNMENT OPERATOR

//int num = 12;

//Console.WriteLine(num += 4); //num = num + 4
//Console.WriteLine(num -= 4); //num = num - 4
//Console.WriteLine(num *= 4); //num = num * 4
//Console.WriteLine(num /= 4); //num = num / 4
//Console.WriteLine(num %= 4); //num = num % 4

//Comparison Operators

int a = 45; int b = 70;

//Console.WriteLine(a == b); // F
//Console.WriteLine(a != b); // T
//Console.WriteLine(a >= b); // F
//Console.WriteLine(a <= b); // T
//Console.WriteLine(a < b); // T
//Console.WriteLine(a > b); // F

// Logical Operators(AND &&, OR ||,NOT ! )
// AND
// T   T = T
// T   F = F
// F   T = F
// F   F = F

//Console.WriteLine(a <= b && a != b); // T
//Console.WriteLine(a >= b && a != b); // F

// OR
// T   T = T
// T   F = T
// F   T = T
// F   F = F

//Console.WriteLine(a <= b || a != b); // T
//Console.WriteLine(a >= b || a != b); // T
//Console.WriteLine(a >= b || a == b); // F

// NOT !

//Console.WriteLine(a != b); // T
//Console.WriteLine(!(a == b)); // T
//Console.WriteLine(!(a != b)); // F

////SALARY SYSTEM

//Console.WriteLine("Enter salary...");

//int salary = Int32.Parse(Console.ReadLine());

////Console.WriteLine(salary);

//if (salary > 90000 && !(salary >= 120000))
//{
//    Console.WriteLine("Good salary...");
//}
//else if(salary < 90000)
//{
//    Console.WriteLine("Do you get fuel allowance?");
//    string answer = Console.ReadLine();

//    answer = answer.ToLower();

//    if (answer == "yes" || answer == "y")
//    {
//        Console.WriteLine("Sounds Good");
//    }
//    else if (answer == "no" || answer == "n")
//    {
//        Console.WriteLine("Try to switch your job...");
//    }
//    else
//    {
//        Console.WriteLine("Please enter yes or no");
//    }
//}
//else
//{
//    Console.WriteLine("MASHALLAH!");
//}

// SWITCH 1 - 7 // Monday == 1, Tuesday == 2

//Console.WriteLine("Enter num b/w 1 to 7");
//int num = Int32.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid Num");
//        break;

//}

// STRING INTERPOLATION

int twentythree = 23;

Console.WriteLine($"Ahsan age is {twentythree}");

//FOR LOOP

//for(int i = 1; i <= twentythree; i++)
//{
//    Console.WriteLine(i);
//}


//for (int i = 50; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

// ODD Nums

//for (int i = 1; i <= 101; i++)
//{
//    if(i%2 != 0)
//    {
//        Console.WriteLine(i);
//    }

//}

//PRIME NUMBER


// WHILE LOOP
//while (twentythree < 25)
//{
//    Console.WriteLine(twentythree);
//    twentythree++;
//}

//DO-While Loop (Atlease 1 time excute it.)
//int j = 23;


//do
//{
//    Console.WriteLine("J");
//    j++;
//}
//while (j < 23);


//int num;
//char ans;

//do
//{
//    Console.WriteLine("Enter any number");
//    num = Convert.ToInt32(Console.ReadLine());

//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Even number");
//    }
//    else
//    {
//        Console.WriteLine("Odd number");
//    }

//    Console.WriteLine("Do you want to continue? Press Y");
//    ans = Convert.ToChar(Console.ReadLine());

//} while (ans == 'Y' || ans == 'y');

//ARRAY FIXED SIZE

//int[] temperatures = new int[6];
//temperatures[0] = 23;
//temperatures[1] = 33;
//temperatures[2] = 40;
//temperatures[3] = 42;
//temperatures[4] = 16;
//temperatures[5] = 20;


//Console.WriteLine(temperatures[5]);

int[] itemPrice = [460, 885, 1150, 225, 964, 870, 665, 750];

foreach (var item in itemPrice)
{
    Console.WriteLine(item);
}

string[] countries = ["Pak", "Iran", "China", "Pak", "Afg", "Ban" ];

////Array.Sort(countries);
//Array.Reverse(countries);


//foreach (var country in countries)
//{
//    Console.WriteLine(country);
//}

Console.WriteLine(Array.IndexOf(countries, "China"));
Console.WriteLine(Array.LastIndexOf(countries, "Pak"));




















