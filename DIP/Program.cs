// See https://aka.ms/new-console-template for more information

using DIP;

//Console.WriteLine("Hello, World!");
IAutomobile automobile = new Jeep();
//IAutomobile automobile = new SUV();
AutomobileController automobileController = new AutomobileController(automobile);
automobile.Ignition();
automobile.Stop();

Console.Read();