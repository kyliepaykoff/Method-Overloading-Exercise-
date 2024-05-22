 using MethodOverloading;
using System.Runtime.Intrinsics.X86;

    var answer = Methods.Add(7, 8);
    decimal answer2 = Methods.Add(9.2m, 10.1m);
    string answer3 = Methods.Add(4, 8, true);
    Console.WriteLine($"{answer}, {answer2}, {answer3}");

