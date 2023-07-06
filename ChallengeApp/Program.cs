string name = "Eva";
var name2 = "women";
var myAge = 33;
var myAge2 = 18;
var myAge3 = 16;
var myAge4 = 30;
//1
if (name2 == "women" &&  myAge4 < 50)
{
    Console.WriteLine("kobieta poniżej 30");
}
else
{
    Console.WriteLine("kobieta powyzej 30");
}
//2
string result = name + myAge;
Console.WriteLine(result);
//3
if (myAge2 > myAge3)
{
    Console.WriteLine("niepelnoletni mezczyzna");

}
else if (myAge2 < myAge)
{
    Console.WriteLine("pelnoletni mezczyzna");
}