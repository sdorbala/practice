// See https://aka.ms/new-console-template for more information

using AlgosDS.LeetCode;

Console.WriteLine("Hello, World!");

string invalid = "-90.";

Console.WriteLine($"Is this valid? {float.Parse(invalid)}");

int[] xCoords = [2, 3, 2, 4, 2];
int[] yCoords = [2, 2, 6, 5, 8];

Console.WriteLine($"MaxPath = {FoodDrop.GetMaxLength(xCoords, yCoords)}.");

xCoords.Rotate(2);
xCoords.Print();
yCoords.Rotate(3);
yCoords.Print();

int[] partiallySorted = [9,-3,-2,-1,0,1,2,3,4,5,6,7,8,];
Console.Write("Partially Sorted Array: ");
Arrays.Print(partiallySorted);
Console.WriteLine($"Lowest in partially sorted array = {Arrays.FindMin(partiallySorted)}");
