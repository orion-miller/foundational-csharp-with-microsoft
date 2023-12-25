// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//======================================================================

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// int saleAmount = 980;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

//======================================================================

// Random coinFlipper = new Random();
// int FlipResult = coinFlipper.Next(0,2);
// Console.WriteLine($"Coin toss result: {(FlipResult > 0 ? "Heads" : "Tails")}");

//======================================================================

string permission = "Admin|Manager";
int level = 55;

if ((level >= 55) && (permission.Contains("Admin")))
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}
else if ((level >= 20) && (permission.Contains("Manager")))
{
    Console.WriteLine("Contact an Admin for access");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}




