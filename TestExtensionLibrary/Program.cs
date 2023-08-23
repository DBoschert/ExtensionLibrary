using ExtensionLibrary;

var s = "$123,456.78";
var s1 = "nfkfdkfksdnfke";

s1.WriteLine("The value of s1 is ", " Pretty cool!!!");

Console.WriteLine($"{s} as a decimal is {s.ToDecimal():C}");

int fn = 10;
Console.WriteLine($"fn {fn} = X^2 + 3X + 5 evaluates to {fn.Eval()}");








/*

var s = "kfnGfFGvkHFHfjGdHFHnklvsNk";

var sAllCaps = s.AllCaps();
var SAllSmall = sAllCaps.AllSmall();

Console.WriteLine($"{s} as all caps is {sAllCaps} and al small is {sAllCaps.AllSmall}");

*/