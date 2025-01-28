/*

SayHello(); // Hello
SayHello(); // Hello

void SayHello()
{
    Console.WriteLine("Hello");
}

*/






/*

void SayHelloUz()
{
    Console.WriteLine("salom");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}


string language ;
Console.WriteLine("uz")
Console.WriteLine("en")
Console.WriteLine("fr")
language=Console.ReadLine();

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "uz":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}


*/

















/*
void SayHello() => Console.WriteLine("Hello");
*/























/*

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello world");           
PrintMessage("Hello Bekobod");   
PrintMessage("Hello C#");

*/


















/*
void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}

Sum(10, 15);

*/

















/*

void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

Sum(10, 15);
*/

















/*
void Sum(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

int a;
int b = 15;
Sum(a, b);

*/


















/*
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

PrintPerson("Jeki Chan", 24);

*/


















/*
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

byte b = 37;
PrintPerson("Messi", b);

*/
















/*

void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Neymar", 37, "Santos");  
PrintPerson("Boltaboy", 37);              
PrintPerson("Tuzik");
*/

















/*
void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Jumavoy", company: "Microsoft", age: 37);  
PrintPerson(age: 41, name: "Robinzon");          
PrintPerson(company: "Google", name: "Matqobil");

*/
















// Qiymat Qaytaruvchi funksiya
/*

string GetMessage()
{
    return "Hello";
}

Console.WriteLine(GetMessage());
*/

















/*
string GetMessage()
{
    return 3;   
}
*/


















/*
string GetMessage()
{
    return "Hello";
}

string message = GetMessage();  
Console.WriteLine(message);
*/

















/*
string GetMessage()
{
    return "Hello";
}
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
PrintMessage(GetMessage());
*/


















/*

int Sum(int x, int y)
{
    return x + y;
}

int result = Sum(10, 15);   
Console.WriteLine(result);   

Console.WriteLine(Sum(5, 6));
*/

















/*
void PrintPerson(string name, int age)
{
    if (age > 120 || age < 1)
    {
        Console.WriteLine("Bunday yosh mavjud emas");
        return;
    }
    Console.WriteLine($"ism: {name}  Yosh: {age}");
}

PrintPerson("Shoqosim", 37);         
PrintPerson("Ketmonali", 1234);
*/


















using N2_Sinflar_Funksiya_;

Salomlashish salom=new Salomlashish();
salom.SayHallo();













