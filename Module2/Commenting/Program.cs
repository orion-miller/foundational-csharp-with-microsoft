
string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] originalMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(originalMessage);

int oCount = 0;

// count the o's
foreach (char i in originalMessage) 
{ 
    if (i == 'o') 
    { 
        oCount++; 
    } 
}

// convert it back to a string
string newMessage = new String(originalMessage);

// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {oCount} times.");
