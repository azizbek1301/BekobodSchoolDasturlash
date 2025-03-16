
//DateTime dt= DateTime.Now;

//Console.WriteLine(dt);
























//DateTime tugilgankun = DateTime.Parse("1/13/2000");
//Console.WriteLine(tugilgankun);































DateTime now= DateTime.Now;

DateTime tkun = DateTime.Parse("2/22/2002");

TimeSpan farqi = now - tkun;
Console.WriteLine(farqi);

Console.WriteLine("-----------------------");

Console.WriteLine(farqi.Days);
Console.WriteLine("-----------------------");

Console.WriteLine(farqi.TotalSeconds);