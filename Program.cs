// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Heljlo, Wohrld!");

using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //talking about inside the parenthisis here it recieves the parameters or arguments whic is the input of this main function, though in some functions parameters are optional.
            //talking about void it defines the return type as it's the main it does not need to return anything that's why void is used here.
            //c# is a case sensitive language that's why it's Main not main and if it's written as main then CLR will not be able to find the entry point of the application.
            //a black of code is always surronded by curly braces {}.
            // Console.WriteLine("Rahul Ghosh");//a statement is always terminated by a semi colon. 
            // byte number;
            // Console.WriteLine(number);//it will give a compilation error as it is not initialized
            // number = 5;
            // int Number = 10;
            // float pi=3.14;//it will give a compilation error as it is like assigning a double value in a float type variable
            // float pi = 3.14f;//so for assigning a float value we have to add f as suffix
            // char character = 'A';
            // char chara="A";//a char can only be assigned by ''.
            // string charac = "Rahul";
            // bool isWorking = true;
            // Console.WriteLine(Number + " " + pi + " " + character + " " + charac + " " + isWorking);
            // Console.WriteLine(number);//5
            // cw+ TAB is used for Console.WriteLine
            // instead of using different datatypes we can just use var keyword


            // const float pi=3.14f;
            // pi=5f;// it will give compilation error


            // System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);//0 255

            // byte b=1;
            // int i=b;
            // System.Console.WriteLine(i);//1

            // int i=1;
            // byte b=i;//won't compile
            // System.Console.WriteLine(b);//compilation error

            // int i=1;
            // byte b=(byte)i;
            // System.Console.WriteLine(b);//1

            // int i = 1234;
            // byte b = (byte)i;
            // System.Console.WriteLine(b);//210

            // string num = "1234";
            // int number = int.Parse(num);
            // int numb = Convert.ToInt32(num);
            // System.Console.WriteLine(number + " " + numb);//1234 1234

            // try
            // {
            //     var number = "1234";
            //     byte b = Convert.ToByte(number);
            //     Console.WriteLine(b);
            // }
            // catch (System.Exception)
            // {
            //     System.Console.WriteLine("The number can't be converted into byte");
            //     // throw;
            // }
            // var a = 10;
            // var b = 3;
            // var add=a+b;
            // var sub=a-b;
            // var mul=a*b;
            // var div=a/b;
            // System.Console.WriteLine(!(a != b));//false



        }
    }
}