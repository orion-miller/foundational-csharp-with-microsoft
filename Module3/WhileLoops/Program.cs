
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1,11);
//     Console.WriteLine(current);
// } while (current != 7);

//========================================

// Random random = new Random();
// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

//========================================

// int heroHealth = 10;
// int monsterHealth = 10;
// string attacker = "Hero";
// Random attackGenerator = new Random();
// int attackValue;

// while (heroHealth > 0 && monsterHealth > 0)
// {
//     attackValue = attackGenerator.Next(1,11); //get attack value

//     switch (attacker)
//     {
//         case "Hero":
//             monsterHealth -= attackValue; //apply change to health
//             monsterHealth = Math.Max(monsterHealth,0); //don't allow negative health values
//             Console.WriteLine($"Monster lost {attackValue} health - {monsterHealth} remaining"); //display attack summary            
//             attacker = "Monster"; //change attacker for next round
//             break;
//         case "Monster":
//             heroHealth -= attackValue; //apply change to health
//             heroHealth = Math.Max(heroHealth,0); //don't allow negative health values
//             Console.WriteLine($"Hero lost {attackValue} health - {heroHealth} remaining"); //display attack summary            
//             attacker = "Hero"; //change attacker for next round    
//             break;        
//     }
// }

// //display final message
// Console.WriteLine("GAME OVER");
// Console.WriteLine(heroHealth > monsterHealth ? "WINNER: Hero" : "WINNER: Monster");

//========================================

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

//========================================

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}