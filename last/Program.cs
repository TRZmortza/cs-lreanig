﻿// String name="morteza ";
// int age=22;
// Console.Write("name is :"+name+"\n");
// Console.Write($"name is:{name}\n");//some things
// Console.Write("name is :{0}age is:{1}",name,age);
/*//new test
string name=string.Empty;int age=0;
Console.Write("enter your name:");
name=Console.ReadLine();//input out put
Console.Write("enter your age:");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(name+age);
*/

//this prat i am going to write a progrem a simpel one for taking a age 
// and then its going ti tell Retirement age in iran //(its going to tell how meny years left untill Retirement)
/*//test
int RetirementAge=0,totalYearsLeft=0;
Console.WriteLine("enter your age: ");
int userAge=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your name: ");
RetirementAge=60;
string userName=Console.ReadLine();
totalYearsLeft=RetirementAge-userAge;
if (totalYearsLeft>0)
{
    Console.WriteLine("{0} years of safring left {1}",totalYearsLeft,userName);
}
else{
    Console.WriteLine("you been retired this many year {0} mr/ms:{1}",(totalYearsLeft*-1),userName);
}
*/
//lreaniug how to de bug in c# and vs code
/*
string? name=string.Empty;
int age=0;
decimal salary=0;
char gender='\0';
bool job=false;//for me its false
Console.Write("pls Enter Your Name: ");
name=Console.ReadLine();

Console.Write("pls Enter Your Age: ");
age=Convert.ToInt32(Console.ReadLine());

Console.Write("pls Enter Your salary: ");
salary=Convert.ToDecimal(Console.ReadLine());

Console.Write("Are You Male our Femele(m/f): ");
gender=Convert.ToChar(Console.ReadLine());

Console.Write("DO You Have Job(true/false)? ");
job=Convert.ToBoolean(Console.ReadLine());
string gen=string.Empty;//short of gender
if (gender=='M'||gender=='m')
{
    gen="male";
}else
{
    gen="female";
}
string jobStats=string.Empty;
if (job)
{
    jobStats="working";
}else
{
    jobStats="not working";
}
Console.WriteLine("{0} youre a {1}\nyour income is {2}$\nyoure currently {3} ",name,gen,salary,jobStats);*/
/*
//math operations and operators
int num,num1=10,num2=1;
//add
num=num1+num2;
//multiply
num=num1*num2;
//devision
num=num1/num2;
//subtraction
num=num1-num2;
//modulus
num=num1%num2;
*/
//logic operations and opetrators
/* // >= / <= / == / !=
var isGreaterThen= 2<3;//this are same i think
bool isSmalerThen= 2>3;
*/
/*//ternary operator
Console.Write("pls Enter your grade: ")
int grade=Convert.ToInt32(Console.ReadLine());
string isHePassed= grade<10?"NO":"YES";
Console.WriteLine(isHePassed);
*/
//switch
/*
int num=45;
switch (num)
{
    case 1:
    //code
     break;
    case 2:
    //code
     break;
    case 3:
     //code
     break;
    default:
    break;
}
*/
//simple calculator
/*
Console.WriteLine("-=-=-=-=-=-=-welcome-=-=-=-=-=-=-");
decimal num1=0,num2=0;
Console.Write("pls enetr the first number:");
num1=Convert.ToDecimal(Console.ReadLine());

Console.Write("pls enetr the sec number:");
num2=Convert.ToDecimal(Console.ReadLine());

Console.Write("pls enetr operator simbel:");
char ch=Convert.ToChar(Console.ReadLine());
switch (ch)
{
    case '+' :
        Console.WriteLine($"you chose addition:{num1}+{num2}="+(num1+num2));
        break;
    case '-' :
        Console.WriteLine($"you chose subtraction:{num1}-{num2}="+(num1-num2));
        break;
    case '*' :
        Console.WriteLine($"you chose multiplication:{num1}X{num2}="+(num1*num2));
        break;
    case '/' :
        Console.WriteLine($"you chose Division:{num1}%{num2}="+(num1/num2));
     break;
    default:
        Console.WriteLine("invalid choice bu i will give you all i can do");
        Console.WriteLine($"you chose some thing:{num1}%{num2}="+(num1/num2));
        Console.WriteLine($"you chose some thing:{num1}X{num2}="+(num1*num2));
        Console.WriteLine($"you chose some thing:{num1}-{num2}="+(num1-num2));
        Console.WriteLine($"you chose some thing:{num1}+{num2}="+(num1+num2));
        break;
}
*/
//for loop
/*
int manyTimes=0;
Console.WriteLine("how many hello wrld do you want?");
manyTimes=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < manyTimes; i++)
{
    Console.WriteLine((i+1)+")Hello World!!");
}
*/
//while loop
/*
int sum=0,newNum;
while (true)
{
    Console.Write("pls enter a number for adding our enter (-1):");
    newNum=Convert.ToInt32(Console.ReadLine());
    //nested if statement
    if (newNum==-1)
    {
        break;
    }
    sum+=newNum;
}
    Console.WriteLine("total of entered numbers are:"+sum);
*/
// try and catch
/*
try{
Console.Write("Enter your Age: ");
int Age=Convert.ToInt32(Console.ReadLine());
Console.Write($"your age is {Age}");


} catch(Exception){
   Console.WriteLine("invalid input only number input allowed");
    //throw;
}
*/
//try catch exercise 1
//finle try catch exercise 1
/*
Console.WriteLine("-=-=-=-=-=-=-welcome-=-=-=-=-=-=-");
decimal num1 = 0, num2 = 0;
while (true)
{
    try
    {
        Console.Clear();
        Console.Write("operator + press 1");
        Console.Write("\noperator - press 2");
        Console.Write("\noperator X press 3");
        Console.Write("\noperator % press 4");
        Console.Write("\n  And exit press 5\n");
        int choice = Convert.ToInt32(Console.ReadLine());


        if (choice == 5)
            break;
        else
        {
            Console.Write("pls enetr the first number:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("pls enetr the sec number:");
            num2 = Convert.ToDecimal(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"you chose addition:{num1}+{num2}=" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine($"you chose subtraction:{num1}-{num2}=" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine($"you chose multiplication:{num1}X{num2}=" + (num1 * num2));
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"you chose Division:{num1}%{num2}=" + (num1 / num2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("invalid input can not do {0} % {1}", num1, num2);
                        Console.WriteLine("press any key to contino");
                        Console.Read();

                    }

                    break;

                default:
                    break;
            }
            Console.WriteLine("press any key to contino");
            Console.Read();
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("invalid input only number input allowed");
        //throw;
    }
    Console.Write("tnk for using me :-)");
}
*/
/*
//try catch practice 
bool infinite = true;
int num;
string er = "thankYou";
while (infinite)
{

    try
    {
        while (infinite)
        {
            Console.Clear();
            Console.Write("give me string for handling error ;-): ");
            num = Convert.ToInt32(Console.ReadLine());
            num = 0;
            while (infinite)
            {
                Console.Clear();
                Console.WriteLine("type 3");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 3)
                    throw new Exception(er);
                else if (num == 85)
                    infinite = false;
            }
        }
    }
    catch (System.Exception m)
    {   
        Console.Clear();
        Console.WriteLine(er + "2");
        Console.WriteLine(m.Message);
        Console.ReadKey();
        Console.Clear();

        continue;
    }
    finally{

        Console.WriteLine("try again");
        Console.ReadKey();
    }
}
*/
//strings
/* 
//initialize with regular string literal 
string s1="this is a literal string";
Console.WriteLine("\ninitialize with regular string literal="+s1);
String s2="this is a literal string";
Console.WriteLine("\ninitialize with regular string literal="+s2);
//Declare without initializin (possible null exception)
string s3;
//Console.WriteLine("Declare without initializin (possible null exception)="+s3);
// initialize to null (possible null exception)
string? s4=null;
Console.WriteLine("\ninitialize to null (possible null exception)="+s4);

//initialize to empty string 
string s5=string.Empty;
Console.WriteLine("\ninitialize to empty string="+s5);

string s6="";
Console.WriteLine("\ninitialize to empty string="+s6);

//Escape sequences and characters
string sequences="she said,\"by me a phone\"\r\nthis is the next line";
Console.WriteLine("\nEscape sequences and characters="+sequences);

//verbatim string literal
string oldpath="E:\\newflodeer\\myfiles";
Console.WriteLine("\nverbatim string literal="+oldpath);

string newpath=@"E:\newflodeer\myfiles";
Console.WriteLine("\nverbatim string literal="+newpath);

//using a counst to prevent modification to string
const string path="E:\\newflodeer\\myfiles";
Console.WriteLine("\nusing a counst"+path);

//path=null//you can`t do this
//rew string literals
string rawLiterals="""\n \t \r '""' """;
Console.WriteLine("\nrew string literals="+rawLiterals);

string rawLiteral=
""" 

first line
secound
""";
Console.WriteLine("\nrew string literals="+rawLiteral);

//string math
//s1+=s2;
string meow=$"{s1} +{s2}={s1}{s2}";
Console.WriteLine("\nstring math="+meow);

string newMeow=s1+$"{s1} +{s2}={s1}{s2}";
Console.WriteLine("\nstring math="+newMeow);

string newMeow1=String.Format("\nliteral string {0} and {1}",s1,s2);
Console.WriteLine("\nstring math="+newMeow1);
*/
//String Manipulation Methods
//date and time declearing empty
DateTime date= new DateTime();
//date and time with value
DateTime dateWithValue= new DateTime(2000,6,9);
DateTime exactDateWithValue= new DateTime(2000,6,9,6,49,58,DateTimeKind.Local);
Console.Clear();
Console.WriteLine("my brt is {0}",dateWithValue);

Console.WriteLine($"day of week:{dateWithValue.DayOfWeek}");
Console.WriteLine($"day of year:{dateWithValue.DayOfYear}");
Console.WriteLine($"time of day:{exactDateWithValue.TimeOfDay}");
Console.WriteLine($"tick:{exactDateWithValue.Ticks}");//sec form tracikng of time
Console.WriteLine($"kind:{exactDateWithValue.Kind}");

//Create a DAteTime form current timetamp
DateTime now=DateTime.Now;
Console.WriteLine("time is now: {0}",now);
Console.WriteLine("what is your DDB(MM/DD/YYYY): ");
string dob=Console.ReadLine();
var userDob= DateTime.Parse(dob);

Console.WriteLine($"you entered :{userDob.DayOfWeek}");
Console.WriteLine($"day of week:{userDob.DayOfWeek}");
Console.WriteLine($"day of year:{userDob.DayOfYear}");
Console.WriteLine($"time of day:{userDob.TimeOfDay}");
Console.WriteLine($"tick:{userDob.Ticks}");//sec form tracikng of time
Console.WriteLine($"kind:{userDob.Kind}");


//change format DAteTime
Console.WriteLine($"formatted date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"formatted date: {userDob.ToString("MMM-dd-yyyy")}");
Console.WriteLine($"formatted date: {userDob.ToString("dddd,MMMM dd ,yyyy")}");
//add additional time
