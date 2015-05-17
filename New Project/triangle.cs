using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n\nStart of Program...\n\n");
        
        printTriangle(6);
        
        Console.WriteLine("\n\nEnd of Program!\n\n");
    }
    
    static void printTriangle(int num) {
        /*
             *     Make this...
            ***    
           *****   
          *******
         *********
        ***********
        */
        int breaker = 0;
        for(int i = 0; i < num; i++) {
            printSpaces(num, i);
            printStars(i);
            Console.WriteLine();
            breaker++;
            if(breaker == 10) {
                Console.WriteLine("Loop went too long!");
                break;
            }
        }
    }
    
    static void printSpaces(int num, int i) {
        i++;
        num -= i;
        int breaker = 0;
        for(int n = 0; n < num; n++) {
            Console.Write(" ");
            breaker++;
            if(breaker == 10) {
                Console.Write("printSpaces is looping too much!");
                break;
            }
        }
    }
    
    static void printStars(int n) {
        int stars = 0;
        int breaker = 0;
        if(n == 0) {stars = 1;}
        else {
            stars = 1 + (n * 2);
        }
        
        for(int i = 0; i < stars; i++) {
            Console.Write("*");
            breaker++;
            if(breaker == 20) {
                Console.Write("printStars is looping too much!");
                break;
            }
        }
    }
}

