using System;

class Program{
    static void Main(){

        double x;
        Console.Write("Input : ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine(Cal(x));
    }

    static double Cal(double x){
        if(x > 1 && x <= 0){
            return Math.Sqrt(1-Math.Pow(x,2));
        }else if( x > 0 && x <=1){
            return -Math.Sqrt(1-Math.Pow(x,2));
        }else if( x <= -1){
            return Cal(x+2);
        }else{
            return Cal(x-2);
        }
    }
}