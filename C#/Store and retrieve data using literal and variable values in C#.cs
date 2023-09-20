// notes here
string firstName;
firstName = "bob";
Console.WriteLine(firstName);
// then 
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

//initialize as soon as possible to get it right; you can even initalize it right on one line like
string firstName = "Bob";
Console.WriteLine(firstName);

//Complete the challenge
var name = "bob";
int messagesCount = 3;
double temp = 34.4;
Console.WriteLine("Hello " + name +" you have "+ messagesCount + " messages in your inbox. The tempreture is "+ temp +" Celsius.");

//the correct way they wanted is below:
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

//Check your knowledge
//1. Which of the following variable names should or must be avoided?

// -> $DATA
//registrationComplete
//flag

//2. What is the problem with this line of code: var message;

//var isn't a data type.
//Use of var keyword without initializing the variable
//A variable named message should always be a string.

//3. Which of the following is the output of Console.WriteLine(34.40M);?

//34.40M
//34.4
// -> 34.40

//4. Which of the following lines of code creates a variable correctly?

//int x = 12.3m;
// -> decimal x = 12.3m;
//bool x = 'False';
