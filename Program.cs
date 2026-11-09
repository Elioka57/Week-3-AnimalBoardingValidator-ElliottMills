// Week 3: Animal Boarding Validator
// Validate animal boarding requests using control structures

// Ask user for basic animal info
Console.WriteLine("=== Animal Boarding System ===");
Console.WriteLine("Animal Name?");
string animalName = Console.ReadLine();
Console.WriteLine("Thank you");
Console.WriteLine("Animal Size (Small, Medium, or Large)");
string animalSize = Console.ReadLine().ToLower();
Console.WriteLine("Is this animal a carnivore? (yes/no)");
string answer = Console.ReadLine().ToLower();

// Carnivore?
bool carnivore = false;

if (answer == "yes")
{
  carnivore = true;
}

else if (answer == "no")
{
  carnivore = false;
}
else 
{
    Console.WriteLine("Invalid!");
}
Console.WriteLine("Number Boarding?");
int numberBoarding = Convert.ToInt32(Console.ReadLine());

string floorAssignment = "";

// Assigning floors
switch (animalSize)
{
    case "large":
        floorAssignment = "Floor 1";
        break;

    case "medium":
        floorAssignment = "Floor 2";
        break;

    case "small":
        floorAssignment = "Floor 3";
        break;

    default:
    floorAssignment = "Invalid animal size";
    break;
}

// Final Check
bool approved = true;
string reason = "";

if (floorAssignment == "Invalid animal size")
{
    approved = false;
    reason = "Invalid animal size.";
}

else if (animalSize == "large" && numberBoarding > 2)
{
    approved = false;
    reason = "Maximum 2 large animals allowed. You requested " + numberBoarding;
}

else if (animalSize == "medium" && numberBoarding > 10)
{
    approved = false;
    reason = "Maximum 10 medium animals allowed. You requested " + numberBoarding;
}

else if (animalSize == "small" && numberBoarding > 50)
{
    approved = false;
    reason = "Maximum 50 small animals allowed. You requested " + numberBoarding;
}


// Final output
Console.WriteLine(" === Boarding Decision === ");
Console.WriteLine("Animal: " + animalName);

if (approved == true)
{
    Console.WriteLine("Status: APPROVED");
    Console.WriteLine("Floor Assignment: " + floorAssignment);
}
else
{
    Console.WriteLine("Status: REJECTED");
    Console.WriteLine("Reason: " + reason);
}

if (carnivore == true)
{
    Console.WriteLine("WARNING: Animal is a Carnivore and thus requires separate housing acomidations from the prey animals");
}
