
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

//====================================================

// string[] names = {"Alex","Eddie","David","Michael"};

// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David")
//         names[i] = "Sammy";

// foreach (var name in names)
//     Console.WriteLine(name);

//====================================================

int remainder3;
int remainder5;
string remainder3Result;
string remainder5Result;

for (int i = 1; i <= 100; i++)
{
    //get remainders
    remainder3 = i % 3;
    remainder5 = i % 5; 

    //check remainders to determine extra strings
    if (remainder3 == 0) 
        remainder3Result = "Fizz";
    else
        remainder3Result = "";     
    if (remainder5 == 0) 
        remainder5Result = "Buzz";
    else
        remainder5Result = "";          

    //write out line    
    if (remainder3 == 0 || remainder5 == 0) 
        Console.WriteLine($"{i} - {remainder3Result}{remainder5Result}");
    else
        Console.WriteLine($"{i}");    
}