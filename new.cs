
using System;
                   
public class Program
{
    void sum(){
        Console.WriteLine("Iam empty");
    }
    void sum(int a, int b){
        Console.WriteLine(a+b);
    }
    void sum(float a,float b,float c){
        Console.WriteLine(a+b+c);
    }
    void sum(string a,string b){
        Console.WriteLine(a+b);
    }
    public static void Main()
    {
        Program program1= new Program();
        Console.WriteLine("Enter a and b:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        program1.sum(float.Parse(a),float.Parse(b),float.Parse(c));
        program1.sum(a.ToString(),b.ToString());
    }
}