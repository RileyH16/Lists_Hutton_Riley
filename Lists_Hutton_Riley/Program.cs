// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.IO.Pipes;
//string list called games and has some game titles.
List<string> games = new List<string>
{
    "Fortnite",
    "Minecraft", 
    "Mario Kart 8",
    "Super Smash Bros.",
    "Halo 4"
};

//a couple more game titles
string[] otherGames = new string[]
{
    "GTA 5",
    "Overwatch"
};

//Prints each game in the games list
foreach (string game in games)
{
    Console.WriteLine(game);
}

//Prints how many games are in the list
Console.WriteLine($"Games in list: {games.Count}");

games.AddRange(otherGames);

//Prints how many games are in the list again
Console.WriteLine($"Games in list: {games.Count}");

//If the list contains "Halo", then print to console, "MASTER CHIEF is in the house!".
if (games.Contains("Halo"))
{
    Console.WriteLine("MASTER CHIEF IS IN THE HOUSE!");
}
//If not it adds Halo
else
{
    games.Add("Halo");
}

//An int with the value of 6
int myInt = 6;

//If the int value is less than the number of games in the games list, then remove the game at index 6 of the games list.
if (myInt < games.Count)
{
    games.RemoveAt(myInt);
}
//Else, print out, "Game not found!".
else
{
    Console.WriteLine("Game not found!");
}

//Prints "All games in the list:"
Console.WriteLine("All games in the list:");
//Prints each game in the games list
foreach (string game in games)
{
    Console.WriteLine(game);
}

//Sorts the list
games.Sort();

//Prints the sorted list
Console.WriteLine("Sorted games list:");
//Prints each game in the games list
foreach (string game in games)
{
    Console.WriteLine(game);
}

string[] newList = new string[games.Count];

//Copies the games list to the string array newList
games.CopyTo(newList);

//Clears the games list
games.Clear();

//Prints the strings in the new list
Console.WriteLine("New List:");
foreach (string game in newList)
{
    Console.WriteLine(game);
}

