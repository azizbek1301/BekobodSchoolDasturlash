
// Massivlar - bu o'xshash ma'lumot turlari to'plamini ifodalalydi

//int[] sonlar;   // butun sonlar to'plami

//sonlar = [1,2,3,4,5,6,7,5,8,6,45,6,85];

//int[] sonlar1 = new int[4];  // avvaldan qiymat berish


//int[] sonlar2 = new int[7] { 100,369,1,87,454,88,62 };

//int[] sonlar3=new int[] {1,2,3,65,568,654,684,62,216874,6598};


//int[] sonlar4 = new[] {1,2,3,4,5,4,6,85,5};

//int[] sonlar5 ={1,2,3,4};








//string[] mashinalar = { "Ferrari", "Tiko", "Bugatti","BMW","Yutong" };


//char[] belgilar = { 'a', '=', '+','#','@' };


// c#12 dan boshlab quyidagicha e'lon qilish ham mumkin bo'ldi

//int[] nums1 = [1, 2, 3, 5];
//int[] nums2 = [];




//int[] numbers = { 1, 2, 3, 5,6 };

//Console.WriteLine(numbers[4]); 




//int n = numbers[1];     
//Console.WriteLine(n);
//




// MAssiv qiymatini o'zgartirish

//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers[1]);

//numbers[1] = 50;

//Console.WriteLine(numbers[1]); 


//int[] numbers = { 1, 2, 3, 5 };

//Console.WriteLine(numbers[4]);


// Massiv uzunligi


//int[] numbers = { 1, 2, 3, 5 };

//Console.WriteLine(numbers.Length);


//int[] numbers = { 1, 2, 3, 5 };
//                0, 1, 2, 3
// numbers.Length=4
//Console.WriteLine(numbers[numbers.Length - 1]);
//Console.WriteLine(numbers[numbers.Length - 2]);
//Console.WriteLine(numbers[numbers.Length - 3]);


//Yuqoridagi amal kodni birmuncha og'irlashtiradi.  c# 8.0 dan boshlab
//           '^'          belgi kiritilgan.


//Console.WriteLine("*******************");
//int[] numbers1 = { 1, 2, 3, 5 };
//Console.WriteLine(numbers1[^1]);

//Console.WriteLine(numbers1[^2]);
//Console.WriteLine(numbers1[^3]);


// foreach - loop

//int[] numbers = { 1, 2, 3, 4, 5 };
//Console.WriteLine(numbers);
//foreach (int son in numbers)
//{
//    Console.WriteLine(son);
//}


//string[] Mashinalar = { "Matiz","Cabolat","Maluba"};
//foreach (string item in Mashinalar)
//{
//    Console.WriteLine(item);
//}







// shu amal for sikli yordamida

//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

// forning afzalliklari massiv elementlari qiymatini o'zgartirishimiz mumkin



//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 3;
//    Console.WriteLine(numbers[i]);
//}


// Shu amallarni Whileda qilib ko'ramiz


//int[] numbers = { 1, 2, 3, 4, 5 };
//int i = 0;
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}


// Ikki o'lchamli massivlar


//int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

// 0,1,2,3,4,5



//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

/*
 
0,1,2
3,4,5


*/


// massivlarni e'lon qilish usullari

//int[,] nums1;
//int[,] nums2 = new int[2, 3];
//int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums4 = new int[,] { { 0, 1, 2,4,10 }, { 3, 4, 5,4,20 } };
//int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };



//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } ,{ 7, 8, 9} };
//foreach (int i in numbers)
//   Console.Write($"{i} ");



//int[,] numbers =
//    { 
//        { 1, 2, 3 }, 
//        { 4, 5, 6 }, 
//        { 6, 7, 8 },
//        { 7, 8, 9 },

//    };

//// eng katta qiymatli satrni qaytaradi
//int rows = numbers.GetUpperBound(0) +1;
//Console.WriteLine(rows);
//Console.WriteLine("-------------------");
//int columns = numbers.Length / rows;
//Console.WriteLine(columns);
//Console.WriteLine("----------------------");

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{numbers[i, j]} \t");
//    }
//    Console.WriteLine();
//}


// Jagged Array
//int[,] sonlar = new[,] { { 1,2,3,4},{ 3,56,45,85} };


//int[][] nums = new int[3][];
//nums[0] = new int[2] { 1, 2 };
//nums[1] = new int[3] { 1, 2, 3 };
//nums[2] = new int[5] { 1, 2, 3, 4, 5 };



//int[][] numbers =
//    {
//        new int[] { 1, 2 },
//        new int[] { 1, 2, 3 },
//        new int[] { 1, 2, 3, 4, 5 }
//    };


//foreach bilan chiqarish

//int[][] numbers = new int[4][];
//numbers[0] = new int[] { 1, 2 };
//numbers[1] = new int[] { 1, 2, 3 };
//numbers[2] = new int[] { 1, 2, 3, 4, 5 };
//numbers[3] = new int[] { 4, 5 };

/*
 
1   2
1   2   3
1   2   3   4   5
4   5 
 */


//foreach (int[] row in numbers)
//{
//    foreach (int number in row)
//    {
//        Console.Write($"{number} \t");
//    }
//    Console.WriteLine();
//}



// for bilan


//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers[i].Length; j++)
//    {
//        Console.Write($"{numbers[i][j]} \t");
//    }
//    Console.WriteLine();
//}

// Massivlar ustida amallar

// Sonlar to'plamidagi musbat sonlarni sanash

//int[] numbers = { -4,25,36,-200,11, -3, -2, -1, 0, 1, 2, 3, 4,0,0,0,1 };
//int musbatlari = 0,manfiylari=0,nol=0;

//foreach (int son in numbers)
//{
//    if (son > 0)
//    {
//        musbatlari++;
//    }
//    else if(son < 0)
//    {
//        manfiylari++;
//    }
//    else
//    {
//        nol++;
//    }
//}
//Console.WriteLine($"Noldan katta elementlar soni: {musbatlari}");
//Console.WriteLine($"Noldan kichik elementlar soni: {manfiylari}");
//Console.WriteLine($"Nol elementlar soni: {nol}");


// Sortlash (Sort)


//int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
//int temp;
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}

//Console.WriteLine("Tartiblangandan keyin");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write(nums[i]+" ");
//}




// Revers qilish( Teskarisiga o'girish)


//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i} \t");
//}



// Sortlash ( Saralash)


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//Array.Sort(cars);
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}
/*
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
Array.Sort(nums);
foreach (var item in nums)
{
    Console.Write(item+" ");
}
*/

// Sort  int

//int[] myNumbers = { 5, 1, 8, 9 ,0};
//Array.Sort(myNumbers);
//foreach (int i in myNumbers)
//{
//    Console.WriteLine(i);
//}
























// Min, Max, Sum

//int[] myNumbers = { 5, 1, 8, 9 };
//Console.WriteLine(myNumbers.Max());//9
//Console.WriteLine(myNumbers.Min());//1
//Console.WriteLine(myNumbers.Sum());//23




//  Misollar



// Karra jadvali


/*
int n;

Console.WriteLine("Necha karragacha chiqarmoqchisiz");
n = int.Parse(Console.ReadLine());


for(int i=1;i<n;i++)
{
    Console.WriteLine($"{i} karra jadvali");
    Console.WriteLine();
    for (int j=1;j<11;j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }

    Console.WriteLine();
}
*/



// 2- topshiriq

/*
int[] sonlar = { 5,6,0,0,0,3,2,1,5,40,0,0,2,5,3,-5,-69,54,-325,0,0,0};



for(int i=0; i<sonlar.Length;i++)
{
    if (sonlar[i]!=0)
    {
        Console.Write(sonlar[i]+"  ");
    }
}
*/


















































































