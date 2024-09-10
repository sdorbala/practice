//-----------------------------------------------------------------------------
// FoodDrop.cs
//-----------------------------------------------------------------------------

/**
A pilot was asked to drop food packets In a terrain. He must fly over the entire terrain only
once but cover a maximum number of drop points. The points are given as inputs in the form of
integer co-ordinates in a two-dimensional field. The flight path can be horizontal or vertical,
but not a mix of the two or diagonal. Please write java code to find the maximum number of
drop points that can be covered by flying over the terrain once.

Input
The first line of input consists of an integer- xCoordinate_size, representing the number of x coordinates (N).
The next line consists of N space-separated integers representing the x coordinates.
The third line consists of an integer-Coordinate_size, representing the number of y coordinates (M).
The next line consists of M space-separated integers representing the y coordinates.

Output
Print an integer representing the number of coordinates in the best path which covers the maximum number
of drop points by flying over the terrain once.

Constraints
1 < N, M = 700 (where N is always equal
to M)

Example
Input:
5
23242
5
22658
Output:
3
Explanation:
There are 5 coordinates- (12,2), (3,2).
(2,6), (4,5) and (2,8).
The best path is the horizontal one covering (2,2), (2,6) and (2,8).
So, the output is 3.

Can you please use java programming?
*/

public class FoodDrop {
    public static int GetMaxLength(int[] xCoordinates, int[] yCoordinates) {
        if (xCoordinates == null || yCoordinates == null) {
            return 0;
        }

        if (xCoordinates.Length < 2 || xCoordinates.Length < 2) {
            return 0;
        }

        int maxHorizontal = 0, maxVertical = 0;
        foreach (int num in xCoordinates) {
            int numCount = GetFrequency(num, xCoordinates);
            maxHorizontal = Math.Max(numCount, maxHorizontal);
        }

        foreach (int num in yCoordinates) {
            int numCount = GetFrequency(num, yCoordinates);
            maxVertical = Math.Max(numCount, maxVertical);
        }

        return Math.Max(maxHorizontal, maxVertical);
    }

    private static int GetFrequency(int num, int[] coordinates) {
        return coordinates.Where(x => x == num).Count();
    }
}