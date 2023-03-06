# Class 01 - Introduction 😊

## C# as a programming language

C# is one of many programming languages with which we can build back-end web applications. This means that with this language we will build an application that will run and be stationed on a server machine. The language was built by Microsoft in 2002 and can be used for all kinds of applications, from desktop to mobile and web. For this language to be running it has to be compiled. Compiling is the process of turning a source code written in one language into another language that can run that code ( assembly code for some languages or some intermediate language for languages such as C# )

## .NET and .NET Core

.NET is a framework that provides many features for building applications with Microsoft languages such as C#. It is the platform that provides building and compiling C# code. It also acts as a management tool for all libraries that are built for C# so that they can be included and used easily. This framework also holds some important features such as managing memory or monitoring performance. There are multiple types of the .NET framework:

* .NET Full Framework - The first version of the .NET framework that works only on Windows machines
* .NET Core - Different version that is built to run code on different platforms
* .NET 5 and above - The next version of .NET succeeding .NET Core ( More similar to Core than Full Framework )
  * The "Core" was dropped from the name to represent a single future version of the framework

## Visual Studio

Visual Studio is Microsoft's main tool for building applications using their languages and frameworks. This IDE provides all the things a developer can need and more. It is one of the best tools for building applications with C#. It has templates for different projects, which are already built start-up projects. It helps out by underlining code that will not work or giving suggestions on what might solve some issues. It has a full debugging tool-set which means that finding bugs and problems is much easier. It also makes building, compiling, and running code very easy and fast

## Console Application

Console applications are applications that run in the console of the machine. They can be executed on the native console in Command Prompt or Power Shell if you are using windows. This is the perfect type of application to start with learning C# because it isolates the language in a very simple environment and the focus is always on the language. In later subjects when we are familiar with C#, we will definitely use different types of applications. The basic structure of the console app is this:

```csharp
// .NET console app pre .NET6
using System; 

namespace  Calculator 
{ 
  class  Program 
  { 
    static void Main(string[] args) 
    { 
      // Your code goes here
    } 
  } 
}
```

The Console App template has been simplified massively in the .NET 6 version and it basically ditched all the boilerplate and is just left with the space that previously was in the static void Main block. This does not mean that there is nothing in the background, but it is greatly simplified for us developers

```csharp
// .NET 6+ Console App
using System; 

// Your code goes here
```

## Writing in the console

Writing in the console is very simple. It is very similar to writing in the console in JavaScript. There are a few commands that we can use to do this:

```csharp
// Will write text and then add a new line after it
Console.WriteLine("Hello World!");
// Will write text and not add a new line after it
Console.Write("Hello World!");
// Will stop to let the user enter something
Console.ReadLine();
// For this class we will use ReadLine just to stop the console
```

## Extra Materials 📘

* [Difference between C# and .NET](https://www.educba.com/c-sharp-vs-net/)
* [Official Microsoft Introduction](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/)
* [C# Console App templates](https://learn.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates)
