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

Console.WriteLine("Enter num b/w 1 to 7");
int num = Int32.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid Num");
        break;

}




