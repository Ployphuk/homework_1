using System;
class Program{
    public static void Main(){
        double x;

        Console.Write("Input : ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine(function(x));
    }

    static double function(double x){

        if(x*x <= 4){
            return 2;
        }
        else {
            return 1 + function(x - ((4*Math.Abs(x))/x)); 
        }
    }
}