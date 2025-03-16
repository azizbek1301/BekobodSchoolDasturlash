


#region static metod





/*



using Class_davomi;

Console.WriteLine(Math.Abs(-3));


Matematika.Modul(-2.3);


*/







/*

// Oddiy metoddan foydalanish (obyekt yaratish kerak)
Matematik m = new Matematik();
        Console.WriteLine(m.Kvadrat(5)); // Natija: 25

        // Static metoddan foydalanish (obyekt kerak emas)
        Console.WriteLine(Matematik.Kub(3)); // Natija: 27

class Matematik
{
    // Oddiy metod (obyekt yaratish talab qilinadi)
    public int Kvadrat(int son)
    {
        return son * son;
    }

    // Static metod (obyekt kerak emas)
    public static int Kub(int son)
    {
        return son * son * son;
    }
}
*/
#endregion



#region  params

/*
using Class_davomi;

int[] sonlar = { 2, 3, 5, 4, 1, 2, 5, 6 };

int summ = 0;
for(int i = 0; i < sonlar.Length; i++)
{
    summ+= sonlar[i];
}
Console.WriteLine(summ);


int[] sonlar1 = { 2,5,8,9,6,3,5,2, 3, 5, 4, 1, 2, 5, 6 };

int summ1 = 0;
for (int i = 0; i < sonlar1.Length; i++)
{
    summ1 += sonlar1[i];
}
Console.WriteLine(summ1);

Console.WriteLine("---------------------------------------");

Console.WriteLine(Matematika.Summa(sonlar));
Console.WriteLine(Matematika.Summa(sonlar1));


int[] son3 = { 1, 2, 3, 4, 5 };



Console.WriteLine("-----------------------");


string[] hayvonlar = { "ot", "quyon", "baliq", "mushuk" ,"begemot"};

Matematika.EkrangaChiqar(hayvonlar);


object[] aralash = { 4, 5, 6, "Quyon", "BMW", "Matiz", 3.2 ,false};
Matematika.EkrangaChiqar(aralash);

*/
#endregion



#region ref va out

/*


C# da ref va out Kalit So‘zlari
C# dasturlash tilida ref va out kalit so‘zlari metodlarga parametrlarni manzili bo‘yicha (reference) uzatish uchun ishlatiladi.
Ikkalasi ham metod ichida parametr qiymatini o‘zgartirish imkonini beradi, lekin ularning farqlari bor.


*/


/*
 
1. ref Kalit So‘zi
ref kalit so‘zi orqali o‘zgaruvchilar metodga manzili bo‘yicha uzatiladi. 
Bu shuni anglatadiki, metod ichida qiymat o‘zgarsa, tashqaridagi o‘zgaruvchi ham o‘zgaradi.

Muhim xususiyatlari:
 1 => ref ishlatilayotgan o‘zgaruvchi oldindan qiymatga ega bo‘lishi kerak.
 2 => ref parametri qiymati metod ichida o‘zgartirilishi mumkin, lekin bunday qilish shart emas.

*/
/*
int number = 10;
Console.WriteLine(number);


ChangeValue(ref number);
Console.WriteLine(number); // Natija: 20

void ChangeValue(ref int number)
{
    number = 20; // Tashqaridagi "number" ham o'zgaradi
}

*/

// out
/*
2. out Kalit So‘zi
out ham parametrni manzili bo‘yicha uzatadi, lekin u ref dan farqli ravishda:
✅ out o‘zgaruvchisi metodga uzatilishidan oldin qiymatga ega bo‘lishi shart emas.
✅ out parametri metod ichida albatta qiymat berilishi kerak, aks holda kompilyatsiya xatosi yuz beradi.
*/
/*
int result;
CalculateSquare(5, out result);
Console.WriteLine(result); // Natija: 25
    

 void CalculateSquare(int num, out int kvadrat)
{
    kvadrat = num * num; // out parametri albatta qiymat olishi kerak
}

*/

/*
ref va out O‘rtasidagi Asosiy Farqlar

                Xususiyat	                                                ref	        out

1.O‘zgaruvchi metodga uzatilishidan oldin qiymatga ega bo‘lishi kerak	    Ha ✅	    Yo‘q ❌
2.O‘zgaruvchi metod ichida albatta qiymat olishi kerak	                    Yo‘q ❌	    Ha ✅
3.O‘zgaruvchi metod ichida o‘zgarishi mumkin	                            Ha ✅	    Ha ✅


*/

/*

int a = 10;
int b;

ModifyRef(ref a);  
ModifyOut(out b);  

Console.WriteLine($"ref: {a}"); // Natija: 50
Console.WriteLine($"out: {b}"); // Natija: 100
  

 void ModifyRef(ref int x)
{
    x = 50; // 
}

void ModifyOut(out int y)
{
    y = 100; 
}

*/






// out ishlatilishi  hayotiy misol bilan 
/*
string input = "123";
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Son: {number}"); // Natija: Son: 123
}
else
{
    Console.WriteLine("Xato: Raqam emas!");
}
*/

#endregion




#region TryParse va Parse




//  Parse

/*
string son= "123";
int son2;
son2=int.Parse(son);

Console.WriteLine(son);
Console.WriteLine(son2);
*/


/*
int son;
son=int.Parse(Console.ReadLine());
Console.WriteLine(son);
*/


/*

int son;
son=int.Parse(Console.ReadLine());
Console.WriteLine(son);
*/


// TryParse

/*
bool tekshir;
tekshir=int.TryParse(Console.ReadLine(), out int son);

if (tekshir)
{
    Console.WriteLine(son);
}
else
{
    Console.WriteLine("xato! intga o'gira olmadim");
}
*/






/*

string input = "123";
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Muvaffaqiyatli o'zgartirildi: {number}");
}
else
{
    Console.WriteLine("Xato: Son emas!");
}

*/



/*

if (int.TryParse("abc", out int number))
{
    Console.WriteLine($"Son: {number}");
}
else
{
    Console.WriteLine("Xato: Son emas!");
}

*/

/*
string input = "3.14";
if (double.TryParse(input, out double result))
{
    Console.WriteLine($"Double qiymati: {result}");
}
else
{
    Console.WriteLine("Xato: Raqam emas!");
}
*/

/*
string input = "12345.67";
if (decimal.TryParse(input, out decimal result))
{
    Console.WriteLine($"Decimal qiymati: {result}");
}
*/

/*

string input = "true";
if (bool.TryParse(input, out bool result))
{
    Console.WriteLine($"Boolean qiymati: {result}");
}
*/



/*
Console.Write("Yoshingizni kiriting: ");
string input = Console.ReadLine();

if (uint.TryParse(input, out uint age)  )
{
    Console.WriteLine($"Siz {age} yoshdasiz.");
}
else
{
    Console.WriteLine("Xato: Iltimos, yoshni to'g'ri kiriting kiriting.");
}

*/


#endregion



