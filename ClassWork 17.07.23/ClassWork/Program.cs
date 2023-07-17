
//static void GetFullData(string surname,string name = "Cahangir")
//{
//    string result = $"Name - {name} , Surname - {surname}";
//    Console.WriteLine(result);
//}

//GetFullData("Axundov");


//static void GetNumsOfArray(int num, params int[] arr)
//{
//	foreach (var item in arr)
//	{
//        Console.WriteLine(item);
//    }
//}

//GetNumsOfArray(1, 2, 3, 4);


////////////ref

//int a = 8;
//Test( ref a);
//Console.WriteLine(a);


//static void Test( ref int a)
//{
//     a = 20;
//    Console.WriteLine(a);
//}


////////////out

//int a;
//Test(out a);
//Console.WriteLine(a);


//static void Test(out int a)
//{
//    a = 20;
//    Console.WriteLine(a);
//}

///////////StingBulider ozunu sirf referance type kimi aparir


//StringBuilder stringBuilder = new StringBuilder("Salam");
//stringBuilder.Append("- Azerbaycan");

//Console.WriteLine(stringBuilder);


//String methods

//string name = "Cahangir";
//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.Trim());
//Console.WriteLine(name.Replace("a"," "));

//var arr = name.Split(",");//stringi stringlerden ibaret arraye cevirir

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(name.Substring(2));

//Console.WriteLine(name.Contains("h"));


