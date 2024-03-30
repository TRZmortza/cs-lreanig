// String name="morteza ";
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