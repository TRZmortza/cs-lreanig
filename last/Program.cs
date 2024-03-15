// String name="morteza ";
// int age=22;
// Console.Write("name is :"+name+"\n");
// Console.Write($"name is:{name}\n");//some things
// Console.Write("name is :{0}age is:{1}",name,age);
/*
string name=string.Empty;int age=0;
Console.Write("enter your name:");
name=Console.ReadLine();//input out put
Console.Write("enter your age:");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(name+age);
*/

//this prat i am going to write a progrem a simpel one for taking a age 
// and then its going ti tell Retirement age in iran //(its going to tell how meny years left untill Retirement)
/*
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