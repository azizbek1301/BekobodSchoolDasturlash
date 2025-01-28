

// 2 xil funksiya 
//  1. Qiymat qaytarmaydigan funksiya
//  2. Qiymat qaytaradigan funksiya


// qiymat qaytarmaydiggan funksiya
/*
Salomlash();


void Salomlash()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Dunyo");
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

string til ;
Console.WriteLine("uz");
Console.WriteLine("en");
Console.WriteLine("fr");
til=Console.ReadLine();

switch (til)
{
    case "en":
        SayHelloEn();
        break;
    case "uz":
        SayHelloUz();
        break;
    case "fr":
        SayHelloFr();
        break;
}

*/


















/*

void SayHello() => Console.WriteLine("Hello");

void SayHello1()=>   Console.WriteLine("Hello1");


SayHello();
SayHello1();
*/




















/*
void PrintMessage(string xabar)
{
    Console.WriteLine(xabar);
}

PrintMessage("salom"); 

PrintMessage("Hello Bekobod");   
PrintMessage("Hello C#");
*/
/*
void Yugur(string xabar)
{
    Console.WriteLine(xabar);
}


Yugur("yutqazding");
*/
















/*
void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
    Console.WriteLine(x+" + "+y+" = "+result);
}

Sum(12, 14);
*/
/*
void Sum(int x, int y)
{
   
    Console.WriteLine($"= {x+y}");
   
}

Sum(12, 14);
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
void kopaytir(int x, int y,int c)
{
    Console.WriteLine(x*y*c);
}

int a=5;
int b = 15;


int a, b;
a=int.Parse(Console.ReadLine());
b=int.Parse(Console.ReadLine());
Sum(a, b);
Sum(25, 14);
kopaytir(a, b, 0);

*/


















/*
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

PrintPerson("Ahmed", 18);
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
void PrintPerson(string name, string company = "Toza havoga direktor", int age = 25 )
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}


PrintPerson(  "microsoft","Mansur",17);

*/
















/*

void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Jumavoy", company: "Microsoft", age: 37);

PrintPerson( "Matqobul", age: 66, "Pensioner");

*/
















// Qiymat Qaytaruvchi funksiya
/*

string GetMessage()
{
    return "Hello";
}



string Kelganxabar=GetMessage();
Console.WriteLine(Kelganxabar);
*/














/*

string GetMessage()
{
    return "3";   
}

Console.WriteLine(GetMessage());

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

Console.WriteLine(Sum(10, 15));
*/
















/*

void PrintPerson(string name, int age)
{
    if (age > 120 || age < 1)
    {
        Console.WriteLine("Bunday yosh mavjud emas");
        
    }
    else
    {
        Console.WriteLine($"ism: {name}  Yosh: {age}");

    }
}

PrintPerson("Shoqosim", 37);         
PrintPerson("Ketmonali", 1234);
*/




using N2_Sinflar_Funksiya_;

Salomlashish salom=new Salomlashish();
salom.Ism("Azizbek");

Taqqoslash taqqoslash=new Taqqoslash();
taqqoslash.Solishtir(32, 45);





















































