// See https://aka.ms/new-console-template for more information
using System.Collections;

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

//int a = 45; int b = 70;

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

//int twentythree = 23;

//Console.WriteLine($"Ahsan age is {twentythree}");

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

//int[] itemPrice = [460, 885, 1150, 225, 964, 870, 665, 750];

//foreach (var item in itemPrice)
//{
//    Console.WriteLine(item);
//}

//string[] countries = ["Pak", "Iran", "China", "Pak", "Afg", "Ban" ];

//////Array.Sort(countries);
////Array.Reverse(countries);


////foreach (var country in countries)
////{
////    Console.WriteLine(country);
////}

//Console.WriteLine(Array.IndexOf(countries, "China"));
//Console.WriteLine(Array.LastIndexOf(countries, "Pak"));

// Multi-Dimentional Arrays

//int[,] multiArr =
//{
//    {56, 65},
//    {11, 22},
//    {33, 44},
//    {77, 88},
//    {43, 23},
//    {32, 35},
//    {98, 89},
//};

//Console.WriteLine(multiArr[5,0]);

//for (int i = 0; i < multiArr.GetLength(0); i++)
//{
//    for (int j = 0; j < multiArr.GetLength(1); j++)
//    {
//        Console.WriteLine(multiArr[i,j]);
//    }
//}

//C# unintialized variable bool = true, int = 0,str = null by default

//Math.power

//Console.WriteLine(Math.Pow(2, 3));

//Jagged  Array
//size of sub array is not fixed

//string[][] skillSet =
//{
//    new string[6] {"HTML", "CSS", "JS", "Bootstrap", "SEO", "UIUX"},
//    new string[5] {"MySQL", "PHP", "LARAVEL", "CMS", "FME"},
//    new string[4] {"SQL SERVER", "C#", "DOTNET", "Angular"},
//    new string[3] {"MongoDB", "ReactJS", "EXPRESSJS" },
//    new string[2] {"DART", "FLUTTER" }
//};


//Console.WriteLine(skillSet[2][2]);

//for(int i = 0; i < skillSet.Length; i++)
//{
//    for(int j = 0; j < skillSet[i].Length; j++)
//    {
//        Console.WriteLine(skillSet[i][j]);
//    }
//}

//foreach(var  skills in skillSet)
//{
//    foreach(var skill in skills)
//    {
//        Console.WriteLine(skill);
//    }
//}

// FUNCTIONS IN C#

//return type  funcName() {body}
//No return no parameter
//void Greet()
//{
//    Console.WriteLine("Good Afternoon 2509C2");
//}

//calling
//Greet();
//Greet();
//Greet();


//No return with parameter
//void Greet(string name)
//{
//    Console.WriteLine($"Hi, {name}, Good Afternoon!");
//}

////calling
//Greet("Imran");
//Greet("Saqib");
//Greet("Farmil");

// return no parameter
//string Greet()
//{
//    return "Welcome to our Company!";
//}

////calling
//Console.WriteLine(Greet());

//int Add()
//{
//    return 32 + 35;
//}
//Console.WriteLine(Add());



////return with parameter

//string empDetails(string name, byte age)
//{
//    return ($"Employee name: {name}. \nEmployee age: {age}");
//}

//Console.WriteLine(empDetails("Imran", 24));

// DATA STRUCTURES
//COLLECTIONS

//GENERIC COLLECTION = datatype zaroor batani prhte hai | Fixed Datatype
//LIST, STACK, QUEUE, Dictionary

//LIST: Add, Remove, Contains, AddRange, RemoveRange

//List<string> SuperCars = new List<string>();
//SuperCars.Add("Supra");
//SuperCars.Add("Mark X");
//SuperCars.Add("BMW");
//SuperCars.Add("Audi");


//List<string> Cars = new List<string>();
//Cars.Add("Accord");
//Cars.Add("City");
//Cars.Add("Civic");
//Cars.Add("Carolla");
//Cars.Add("Cultus");

////Console.WriteLine(Cars[4]);
////Console.WriteLine(Cars.Count);
//Console.WriteLine(Cars.Contains("Civic"));
////Console.WriteLine(Cars.Revmove("Civic"));
////Cars.RemoveAt(0);

//Cars.AddRange(SuperCars);
//Cars.RemoveRange(1, 5);
//Cars.Insert(3, "Boss");


//foreach (string Car in Cars)
//{
//    Console.WriteLine(Car);
//}

////QUEUE (FIFO: first in first out)
////ENQUEUE: Add / Insert

//Queue<string> stdNames = new Queue<string>();
//stdNames.Enqueue("Imran");
//stdNames.Enqueue("Hunzila");
//stdNames.Enqueue("Saqib");
//stdNames.Enqueue("Rayyan");
//stdNames.Enqueue("Anwar");
//stdNames.Enqueue("Abubakar");
//stdNames.Enqueue("Nabeel");

////DEQUEUE: Remove / Delete
//stdNames.Dequeue(); //Imran
//stdNames.Dequeue(); //Hunzila
//stdNames.Dequeue(); //Saqib

//foreach (var name in stdNames)
//{
//    Console.WriteLine(name);
//}

////STACK (LIFO: Last in first out)
////Push: Add / Insert

//Stack<string> birds = new Stack<string>();
//birds.Push("Electus");
//birds.Push("Amazon");
//birds.Push("Finch");
//birds.Push("Maccow");
//birds.Push("Love Birds");


////Pop: Remove / Delete
//birds.Pop();//Love Birds

//foreach (var name in birds)
//{
//    Console.WriteLine(name);
//}


// Dictionary(key: value)
//add, remove

//Dictionary<string, string> empDetails = new Dictionary<string, string>();

//empDetails.Add("empName", "Haris");
//empDetails.Add("empDesignation", "DCAH");
//empDetails.Add("empAddress", "Johar Khi");
//empDetails.Add("empImg", "haris.jpg");
//empDetails.Add("empEmail", "haris@aptechnorth.edu.pk");
//empDetails.Add("empPass", "Haris7778");


//Console.WriteLine(empDetails["empImg"]);
//foreach (var item in empDetails)
//{
//    string[] test = (item.ToString().Split(','));   
//    //string key = test[0]; // [
//    //string value = test[1]; // ]

//    string key = test[0].Trim('[');
//    string value = test[1].Trim(']');

//    Console.WriteLine(key);
//    Console.WriteLine(value);
//    Console.WriteLine(item);


//    Console.WriteLine($"The employee has key property: {key} and value property: {value}");
//}



//foreach (var item in empDetails)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

// Hashtables

//Hashtable students = new Hashtable();
//students.Add("stdName", "Imran");
//students.Add("stdMarks", 89);
//students.Add("stdExamStatus", "Pass");
//students.Add("stdImg", "imran.jpg");
//students.Add("stdValid", true);

//Console.WriteLine(students["stdName"]);
//Console.WriteLine(students.Contains("stdMarks"));
//Console.WriteLine(students.ContainsValue(89));

//foreach(DictionaryEntry student in students)
//{
//    Console.WriteLine(student.Key + " : " + student.Value);
//}

//Console.WriteLine(students.GetHashCode());

//NON-GENERIC Collections (No FIX DATATYPES)

//ARRAYLIST

//ArrayList Cars = new ArrayList();
//Cars.Add("Civic");
//Cars.Add("Honda");
//Cars.Add("Black");
//Cars.Add(1800);
//Cars.Add(.70f);
//Cars.Add(true);

//Console.WriteLine(Cars.Count);
////Console.WriteLine(Cars.Contains("Boss"));
//Cars.RemoveAt(3);

//foreach (var Car in Cars)
//{
//    Console.WriteLine(Car);
//}


//String Methods

//string test = """{ "name": "John Doe"}""";
//string test = "John Doe";

//string test = "we are learning \"C#\"";

//Console.WriteLine(test);
//Console.WriteLine(test.Replace("learning", "Mastering"));

//CODING BEST PRACTICES
// Indentation (Readable by using spaces and new lines)
//Comments
//Meaningful Identifiers(Variables names) student -> std || X->a,b,c
//errors (exception handling)
// less repeatation

//OOP(Object Oriented Programming)
//it is an approach to code cleaner and better
//readable
//reuseable
//optimize
//proper structure of the code is maintained.

//Interitance
//1. Single level inheritance Vehicle -> Car
//2. Multi level inheritance Vehicle -> Car -> ECar
//3. Heirarchial inheritance Vehicle -> Car, Vehicle -> Bike 
//4. Multiple Inheritance
//5. Hybrid Inheritance Vehicle -> Car, Vehicle -> Car -> ECar, Car -> ECar



//Aeroplane Boeing707 = new Aeroplane();//default constructor
//CLASS   OBJNAME          CONSTRUCTOR

//Boeing707.Name = "Boeing 707";
//Boeing707.takeOff();
//Console.WriteLine(Boeing707.AirLine);

//Aeroplane f16 = new Aeroplane("PAF");
//f16.takeOff();

//Aeroplane f17 = new Aeroplane("PAF", "F-17 Thunder", 2, 2, "8500hp");
//f17.takeOff();
//f17.land();

//class ClassNamae{
//default constructor
//parametrized constructor
//methods
//}






//public class Aeroplane
//{
//    //access modifiers: public: access from anywhere, private: access within the class, protected: access within the class + child classes
//    public string? AirLine;
//    public string? Name;
//    public int Seats;
//    public int Crew;
//    public string? Power;

//    //Contstructor
//    public Aeroplane()
//    {
//        this.AirLine = "Not specified";
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }

//    public Aeroplane(string Name)
//    {
//        this.AirLine = "Not specified";
//        this.Name = Name;
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }


//    //    //Paremeterized constructor (Overloading)
//    public Aeroplane(string ALine, string name, int seat, int crew, string pow)
//    {
//        this.AirLine = ALine;
//        this.Name = name;
//        this.Seats = seat;
//        this.Crew = crew;
//        this.Power = pow;
//    }
//    // Methods
//    public void takeOff()
//    {
//        Console.WriteLine($"{this.Name} is taking off. Best Wishes..!");
//    }
//    public void land()
//    {
//        Console.WriteLine($"{this.Name} is Landing at the 4th runway..! ");
//    }

//}

//2. Polymorphism
// Method Overloading
// Method Overriding
//3. Abstraction
//4. Encapsulation

//Inheritance
//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();


Car mercedez = new Car("TZ-8908", "Black", "Mercedez", "Benz C-Class", 20000000);
//mercedez.Run();
mercedez.Run(500);

//// Parent class | Base Class | Super Class
public class Vehicle
{
    public string regNo;
    public string color;

    public Vehicle(string regno, string color)
    {
        this.regNo = regno;
        this.color = color;
    }
    public void Run()
    {
        Console.WriteLine($"{this.regNo} vehicle started running");
    }
}
//// Child class | Derived Class | Sub Class
public class Car : Vehicle
{

    public string brand;
    public string model;
    public int price;

    public Car(string regno, string color, string brand, string model, int price) : base(regno, color)
    {
        this.brand = brand;
        this.model = model;
        this.price = price;
    }

    //method overriding
    public void Run()
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
    }
    //method overloading
    public void Run(int speed)
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
    }

}







































































