using System;
namespace Day_3
{
//static keyword
//by default these are sealed clasees--cannot inherit and cannot create a object
static class Class12
{
public static string Topic = "static class";
}
class Client
{
public static void Main()
{
Console.WriteLine(Class12.Topic);

}
}
}