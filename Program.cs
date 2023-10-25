// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Linq.Expressions;

for (int i = 1; i <= 255; i++ ){
    Console.WriteLine(i);
}

for(int j = 1; j <= 100 ; j++){
    if((j % 3 == 0 || j % 5 == 0 ) && !(j % 3 == 0 && j % 5 == 0)){
        Console.WriteLine(j);
    }
}


for (int k = 1; k <= 100; k++)
{
    if (k % 3 == 0 && k % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (k % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if (k % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(k);
    }
}

int l = 1;
while (l <= 100)
{
    if (l % 3 == 0 && l % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (l % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if (l % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(l);
    }
    l++;
}