

// 2 xil funksiya 
//  1. Qiymat qaytarmaydigan funksiya
//  2. Qiymat qaytaradigan funksiya


// qiymat qaytarmaydigan funksiya


/*
Salomlash();


void Salomlash()
{
    Console.WriteLine("Hello Dunyo");
    
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
    Console.WriteLine("Sava");
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



void Sayhello()=>   Console.WriteLine("Hello1");


SayHello();
Sayhello();

*/


















/*
void PrintMessage(string ism)
{
    Console.WriteLine(ism);
}

PrintMessage("Muhammadamin");
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

    
}

Sum(14, 25);
*/
/*
void Sum(int x, int y)
{
   
    Console.WriteLine($"{x} + {y}= {x+y}");
   
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

//int a=5;
//int b = 15;


int a, b;
Console.WriteLine("A ni kiriting");
a =int.Parse(Console.ReadLine());
Console.WriteLine("B ni kiriting");
b =int.Parse(Console.ReadLine());
Sum(a, b);

*/



















/*
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}


PrintPerson("Avzalbek", 15);
*/




















/*
void PrintPerson(string name, byte age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

byte b = 15;
PrintPerson("Muhammadamin", b);
*/


















/*
void Xabar(string ism, string kompaniya = "Toza havoga direktor", int yosh = 25 )
{
    Console.WriteLine($"Ism: {ism}  Yosh: {yosh}  kompaniya: {kompaniya}");
}

//Xabar("Avzalbek", "Microsoft", 15);
//Xabar("Hasan", "Apple");
Xabar("Azizbek");
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
string XabarBer()
{
    return "Hello";
}
Console.WriteLine(XabarBer());
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
string Salomlash()
{
    return "Hello";
}
void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage(Salomlash());
*/



















/*

int Sum(int x, int y)
{
    return x + y;
}
Console.WriteLine(Sum(10, 20));

*/
















/*
void PrintPerson(string name, int age)
{
    if (age > 120 | age < 1)
    {
        Console.WriteLine("Bunday yosh mavjud emas");
        
    }
    else
    {
        Console.WriteLine($"ism: {name}  Yosh: {age}");

    }
}

PrintPerson("Azizbek", 12);
*/



/*
using N2_Sinflar_Funksiya_;

Salomlashish salom=new Salomlashish();
salom.Ism("Azizbek");

Taqqoslash taqqoslash=new Taqqoslash();
taqqoslash.Solishtir(32, 45);
*/




















































