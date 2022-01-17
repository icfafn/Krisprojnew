Person p = new("Kristian", "Pedersen", new DateTime(1990, 7, 15));
Console.WriteLine(p.GetFullName());
Console.WriteLine(p.BirthDateInDanishFormat);
Console.WriteLine(p.Age);
Console.WriteLine(p.TimeSpanInTotalDays);

Person p2 = new();
Console.WriteLine(p2.GetFullName());