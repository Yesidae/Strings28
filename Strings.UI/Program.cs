using Microsoft.VisualBasic;
using Strings.Logic;

var myStrings = new String28[]
{
    new String28("%===*="),
    new String28("&=======*=====*====="),
    new String28("#=======*=====*====="),
};

foreach (var myString in myStrings)
{
    Console.WriteLine(myString.Viga());
}
