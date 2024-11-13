// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;
using Dapper;
using HelloWorld.models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using HelloWorld.data;
Console.WriteLine("Hello, World!");
Console.Write("NO new space lol");

// PRINT FIRST ARGUMENT PASSED TO THE PROGRAM
// Console.WriteLine(args[0]);
// Varaible Types :
//// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
// //// Each bit can be worth 0 or 1 of the value it is placed in
// ////// From the right we start with a value of 1 and double for each digit to the left
// //// 00000000 = 0
// //// 00000001 = 1
// //// 00000010 = 2
// //// 00000011 = 3
// //// 00000100 = 4
// //// 00000101 = 5
// //// 00000110 = 6
// //// 00000111 = 7
// //// 00001000 = 8

// 1 byte (8 bit) unsigned, where signed means it can be negative
byte myByte = 255;
byte mySecondByte = 0;

// 1 byte (8 bit) signed, where signed means it can be negative
sbyte mySbyte = 127;
sbyte mySecondSbyte = -128;

// 2 byte (16 bit) unsigned, where signed means it can be negative
ushort myUshort = 65535;

// 2 byte (16 bit) signed, where signed means it can be negative
short myShort = -32768;

// 4 byte (32 bit) signed, where signed means it can be negative
int myInt = 2147483647;
int mySecondInt = -2147483648;

// 8 byte (64 bit) signed, where signed means it can be negative
long myLong = -9223372036854775808;

// 4 byte (32 bit) floating point number
float myFloat = 0.751f;
float mySecondFloat = 0.75f;

// 8 byte (64 bit) floating point number
// default type for floating point numbers in C#
double myDouble = 0.751;
double mySecondDouble = 0.75d;

//f for float, d for double, m for decimal

// 16 byte (128 bit) floating point number
decimal myDecimal = 0.751m;
decimal mySecondDecimal = 0.75m;

// least preices
Console.WriteLine(myFloat - mySecondFloat);

// more than the rwsult of the above
Console.WriteLine(myDouble - mySecondDouble);

// most precies
Console.WriteLine(myDecimal - mySecondDecimal);

string myString = "Hello, World";

// Console.WriteLine(myString);
string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";

// Console.WriteLine(myStringWithSymbols);

// singke quote for single characters
// double quote for strings ""

bool myBool = true;

// array - setting  max length of 5 items
string[] groceries = new string[5];
groceries[0] = "Milk";
groceries[1] = "Eggs";
groceries[2] = "Bread";
groceries[3] = "Butter";
groceries[4] = "Cheese";

// Array fixed length initialization
string[] gymEquipmeny = { "skiping rope" };

// Note you can't add more items to the array

// A list is a class rather than a data type
// Dynamic list that can grow and shrink
List<string> mytoDoList = new List<string>() { "Sleep" };

// You can initialize the list
List<int> myInteger = new List<int>() { 1, 2, 3 };

// List methods
// - Add()

// List is more for adding and removing elements

// IEnumerable : faster for looping through elements but can't access individaul data except loop (no addition or subtraction) .
//               it also needs a list or an array for initialisation

IEnumerable<string> TODO = mytoDoList;

// to access the first element you will use the first function
Console.WriteLine(TODO.First());

// staticly typed language C sharp dynnamic is python
// values of the varaivle in the code cannot change Type once decelared
// like type string cannot be changed to int


// 2D Array
string[,] twoD =
{
    { "baba", "ew" },
    { "ww", "yo" },
};

// accessing the array is [num1,num2]
Console.WriteLine(twoD[0, 0]);

// Dictionary
Dictionary<string, int> mydic = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 } };

Dictionary<string, int[,]> mdck = new Dictionary<string, int[,]>
{
    {
        "one",
        new int[,]
        {
            { 1, 1 },
            { 1, 2 },
        }
    },
    {
        "two",
        new int[,]
        {
            { 2, 2 },
            { 2, 3 },
        }
    },
};

Console.WriteLine(mdck["one"][0, 1]);

// Operators 
// ++,--,+=,-=,*=
// Using Power
Console.WriteLine(Math.Pow(3,3));
// sqrt
Console.WriteLine(Math.Sqrt(3));


// // string concatination +

// Console.WriteLine(myString.Split(",")[0]);
// .ToLower()
// .ToUpper()
// buildlt in comparision : 
//     Equal like myString.Equal(mystring1)
string test = "bbs sbs";
   List<int> myNumberList = new List<int>(){
                2, 3, 5, 6, 7, 9, 10, 123, 324, 54
            };
            //Write Your Code Here
            for(int i=0; i<myNumberList.Count; i++){
                if(myNumberList[i] % 2 == 0){
                    Console.WriteLine(myNumberList[i]);
                }
            }
/////////////////////////////////////////////////////////////
Computer linux = new Computer(){};
linux.MemorySpace = 4.5m;
linux.Os = "Linux";
linux.ComputerId =102;
linux.CPUCores=3;
linux.HasWifi=true;
linux.ReleaseDate= DateTime.Now;

DataQuery dataQuery = new DataQuery(){};


string query = "Select GETDATE()";

Console.WriteLine("The current time is "+dataQuery.QuerySingleData<string>(query));

string add = @"
Insert into TutorialAppSchema.Computer(      
        Os,
        CPUCores,
        ReleaseDate,
        HasWifi,
        MemorySpace 

) Values(
    '"+linux.Os+"','"+linux.CPUCores+"','"+ linux.ReleaseDate+"','"+linux.HasWifi+"','"+linux.MemorySpace+"')";

dataQuery.ExecSql(add);

string getData="Select * From TutorialAppSchema.Computer";

// Get the data from Database -- Default

IEnumerable <Computer> results = dataQuery.QueryData<Computer>(getData);

// List<Computer> resultLists = dbConnection.Query<Computer>(getData).ToList();

foreach(Computer result in results){
    Console.WriteLine("Computer Id : "+ result.ComputerId+" Os : "+result.Os);
}


