using System;
namespace Day_3
{
interface I1
{
void myMethod();
}
interface I2
{
void myMethod();
}
class MultipleInheritace:I1,I2
{
public void I1.myMethod()
{
Console.WriteLine("Hello i am called");
}
public void I2.myMethod()
{
Console.WriteLine("Hello i am interface 2 method");
}
}
public class Client
{
public static void Main()
{
MultipleInheritance Obj1 = new MultipleInheritance();
Obj1.myMethod();
Console.ReadLine();
}