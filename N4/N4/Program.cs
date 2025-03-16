
// stringlarni birlashtirish

//string ism = "Azizbek ";
//string familiya = "Rahmatullayev";

//string tolliqIsmim = ism + familiya;
//Console.WriteLine(tolliqIsmim);




















// satr uzunligi  Length


//string matn = "Assalomu alaykum!!";
//int olchami = matn.Length;
//Console.WriteLine(olchami);


//string password;
//Console.WriteLine("Parolni kiriting");
//password = Console.ReadLine();
//int uzunligi=password.Length;
//if (uzunligi < 8)
//{
//    Console.WriteLine("Kamida 8 ta belgidan iborat bo'lishi kerak");
//}
//else
//{
//    Console.WriteLine("Done");
//}















// ToUpper()    vs      ToLower()


//string salomlash = "Assalomu alaykum";
//Console.WriteLine(salomlash.ToUpper());
//Console.WriteLine(salomlash.ToLower());



























// Concat - satrlarni birlashtirish

//string firstName = "Husan ";
//string lastName = " Abdumutalipov ";
//string fullName=string.Concat(lastName, firstName," 9-sinf");
//Console.WriteLine(fullName);


























//  !!! Eslab qoling Raqamlar qo'shiladi 
//                  Satrlar birlashtiriladi


//int x = 10;
//int y = 20;
//int z = x + y;
//Console.WriteLine(z);



//string x = "10";
//string y = "20";
//string z = x + y;
//Console.WriteLine(z);




























// String Interpolation


//string firstName = "Azizbek";
//string lastName = "Rahmatullayev";
//string fullName = $"To'lliq ismim: {firstName} {lastName}";
//Console.WriteLine(fullName);






























// Kirish satrlari - Satrning elementlariga indeks bo'yicha murojat qilish
// 

//var  salom = "Assalomu alaykum";
//var belgi = salom[3];
//Console.WriteLine(belgi);




























// IndexOf() - satrdagi ma'lum bir belgini indeksini topishimiz mumkin

//string salom = "Hello";
//Console.WriteLine(salom.IndexOf("o"));





























// SubString()  Satrni ma'lum bir indeksdan boshlab chiqaradi.

//string fullName = "Azizbek Rahmatullayev";
//Console.WriteLine(fullName);

//int harfOrni = fullName.IndexOf('R');// 8
//Console.WriteLine(harfOrni);

//string familiya = fullName.Substring(harfOrni);
//Console.WriteLine(familiya);



//Boshlanish indeksini berish
//Console.WriteLine(fullName.Substring(8));


// Boshlang'ich qiymat bilan uzunlikni ham berish mumkin

//Console.WriteLine(fullName.Substring(8,13));































// Special Characters


//string txt="Bizni butun dunyoda "Ozbeklar" deb atashadi";

//string txt = "Bizni butun dunyoda \"Ozbeklar\" deb atashadi";
//Console.WriteLine(txt);


//string txt = "Biz O\'zbeklarmiz";
//Console.WriteLine(txt);

//string txt = "Bu belgi \\ backslash deb ataladi";
//Console.WriteLine(txt);



// \b  Oldindagi belgini o'chiradi
//string txt = "Assa\blomu Alaykum";
//Console.WriteLine(txt);


// \n Yangi satrga o'tkazadi
//Console.WriteLine("sdafbhsdfkbsdkf\nfsdlkajfnsdkljnsdkj");
// \t bitta tabulyatsiyta tashlab beradi
//Console.WriteLine("sdafbhsdfkbsdkf \t fsdlkajfnsdkljnsdkj");
































// @ Verbatum string - Barcha maxsus belgilarni yo'q qiladi

//Console.WriteLine("Bizni butun dunyoda \"Ozbeklar\" deb atashadi");


//string faylManzili = @"D:\\Matematika Uchun\\Majburiy matematika\";
//Console.WriteLine(faylManzili);































// Format();

//string ism = "Azizbek";
//string familiya = "Rahmatullayev";
//string company = "Microsoft";

//string info = "Salom men {0} {1}. Hozirda {2} korparatsiyasida ishlab kelmoqdaman";
//Console.WriteLine(info);


//string formatlash = string.Format(info,ism,familiya,company);
//Console.WriteLine(formatlash);

//Console.WriteLine(info, familiya, ism, company);















//  Davomi

// Split - bo'lib yuborish


var matn = "Assalomu alaykum. Men sizlarga shahrimiz haqida gapirib bermoqchiman. " +
    "Shahrimiz juda ham chiroyli va chang. Maktabimni yomon ko'raman. " +
    "har kuni erta turish menga yoqmaydi va enga yomini darslar kechgacha. Huddiki qamoqxonaga tushib qolgandekman." +
    "UStozlarim meni tushunmaydi. Bitta Iphone 16 bo'lsa mazza qilib maqtanib yursam!" +
    "Shunaqa ham ahmoqona jumal bo'ladimi? Agar shu yozgan matnimni ona tili ustozim ko'rsa yig'lab yuborgan bo'lar edim";
//var gaplar = txt.Split();

//Console.WriteLine(gaplar);
//foreach (var soz in gaplar)
//{
//    Console.WriteLine(soz);
//}



//var yangiGaplar = matn.Split("Iphone");
//foreach (var soz in yangiGaplar)
//{
//    Console.WriteLine(soz);
//}






// Join
//var words = matn.Split('.');
//var yangi = string.Join('?', words);
//Console.WriteLine(yangi);


// Cases  - Lower, Upper
// camelCase   yangiSonlar    
// PascalCase  YangiSonlar
// snake_case  yangi_sonlar
// kebab-case





// Searching

//Console.WriteLine(matn.Contains("16"));
//Console.WriteLine(matn.Contains("Iphone"));



//Console.WriteLine(matn.Contains("IPHone"));
//string qidir;
//Console.WriteLine("nima qidirmoqchisiz");
//qidir =Console.ReadLine();
//Console.WriteLine(matn.Contains(qidir,StringComparison.OrdinalIgnoreCase));


//var sozlar = matn.Split();
//for (int i = 0; i < sozlar.Length; i++)
//{
//    Console.WriteLine(sozlar[i]);
//    Console.WriteLine(i);
//}
//Console.WriteLine(Array.IndexOf(sozlar, "Iphone"));




// Replacing



//var xabar = "Qande bolajonlar, IShlar cho'tkimi?. Futbol o'ynaylik";



//string yangi = xabar.Replace("Futbol", "Hokkey");
//Console.WriteLine(xabar);
//Console.WriteLine(yangi);


//string InputIsm, InputFamiliya, InputEmail;

//string xabar = "Salom {{Ism}} {{familiya}}. Siz {{email}} email bilan ro'yxatdan o'tdingiz";

//Console.WriteLine("Ismini kiriting");
//InputIsm=Console.ReadLine();



//Console.WriteLine("Familiyani kiriting");
//InputFamiliya = Console.ReadLine();



//Console.WriteLine("emailni kiriting");
//InputEmail = Console.ReadLine();

//string tahrirlash = xabar.Replace("{{Ism}}", InputIsm)
//    .Replace("{{familiya}}", InputFamiliya)
//    .Replace("{{email}}", InputEmail);
//Console.WriteLine(tahrirlash);






// trim

//var masala = "           text           ";
//Console.WriteLine(masala);
//Console.WriteLine(masala.Trim());

//Console.WriteLine(masala.TrimStart());
//Console.WriteLine(masala.TrimEnd());




/*
String immutable toifa hisoblanadi. Ya'ni ular yasalgandan keyin
o'zgartirib bo'lmaydi. Yuqorida ko'rib o'tgan barcha qiymatini o'zgartirishga qaratilgan string metodlar
bizga yangi string qaytaradi.


*/


//int parol = 9987897;

//for(int i=1;i<10000000;i++)
//{
//    Console.WriteLine(i);
//    if (parol==i)
//    {
//        Console.WriteLine("Ochildi");
//        break;
//    }
//}















































































































































