//03 Object-Oriented Programming

/*
Test your knowledge

1.What are the six combinations of access modifier keywords and what do they do?
Public, Private, Protected, Internal, Protected Internal, and Private Protected. They specify the declare accessibility of a member or a type. 

2.What is the difference between the static, const, and readonly keywords when applied  to a type member?
Constant and ReadOnly keyword are used to make a field constant which value cannot be modified. 
The static keyword is used to make members static that can be shared by all the class objects.

3.What does a constructor do?
A constructor is a special method of a class or structure in OOP that initializes a newly created object of that type. 

4.Why is the partial keyword useful?
The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.

5.What is a tuple?
A tuple is a data structure that contains a sequence of elements of different data types.

6.What does the C# record keyword do?
Define a reference type that provides built-in functionality for encapsulating data. 

7.What does overloading and overriding mean?
Overloading occurs when two or more methods in one class have the same method name but different parameters. 
Overriding occurs when two methods have the same method name and parameters.

8.What is the difference between a field and a property?
A field is a variable of any type that is declared directly in a class. 
A property is a member that provides a flexible mechanism to read, write or compute the value of a private field. 
A field can be used to explain the characteristics of an object or a class.

9.How do you make a method parameter optional?
By Params Keyword.

10.What is an interface and how is it different fromabstract class?
An interface only allows user to define functionality, not implement it.

11.What accessibility level are members of an interface?
Public declared accessibility.

12.True/False. Polymorphism allows derived classesto provide different implementationsof the same method.
True.

13.True/False. The override keyword is used to indicatethat a method in a derived class isproviding its own implementation of a method.
True.

14.True/False. The new keyword is used to indicatethat a method in a derived class isproviding its own implementation of a method.
False.

15.True/False. Abstract methods can be used in anormal (non-abstract) class.
False.

16.True/False. Normal (non-abstract) methods can be used in an abstract class.
True.

17.True/False.Derived classes can override methods that were virtual in the base class.
True.

18.True/False.Derived classes can override methods that were abstract in the base class.
True. 

19.True/False.In a derived class, you can override a method that was neither virtual non  abstract in thebase class.
False. 

20.True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
True. 

21.True/False. A class that implements an interfaceis allowed to have other members that aren’t defined in the interface.
True. 

22.True/False. A class can have more than one baseclass.
True. 

23.True/False. A class can implement more than one interface.
True. 

*/


static int[] GenerateNumbers(int Num)
{
    int[] Arr=new int[Num];
    for (int i=0; i<Num; i++)
    {
        Arr[i]=i+1;
    }
    return Arr;
}


static int[] Reverse(int[] args)
{   int length=args.Length;
    int[] Arr = new int[length];
    for(int i=0; i<length; i++)
    {
        Arr[length-1-i]=args[i];
    }
    return Arr;

}


static void PrintNumbers(int[] args)
{
    foreach(var item in args)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine("");
}


static int Fibonacci(int Num)
{
    List<int> list1 = new List<int>();
    list1.Add(1);
    list1.Add(1);


    for (int i = 2; i < Num; i++)
    {
        list1.Add(list1[i - 2] + list1[i - 1]);
    }
    return list1[Num - 1];
}



static void Main1(int Num) 
{ 
    int[] numbers = GenerateNumbers(Num); 
    int[] Numbers = Reverse(numbers);
    Console.WriteLine("Original Array: ");
    Console.WriteLine("");
    PrintNumbers(numbers);
    Console.WriteLine("");
    Console.WriteLine("Reversed Array: ");
    Console.WriteLine("");
    PrintNumbers(Numbers); 
}



static void Main2() 
{
    for(int i = 1; i < 11; i++)
    {
        Console.WriteLine("Fibonacc number {0} = {1}", i, Fibonacci(i));
    }
}



Console.WriteLine("Question 1: Reverse Array");
Console.WriteLine("");

Main1(17);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Question 2: The Fibonacci sequence");
Console.WriteLine("");

Main2();

Console.WriteLine("");
Console.WriteLine("");