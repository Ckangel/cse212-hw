public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)

    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan
        // 1. Input Parameters: The function takes two parameters:
        // number: A double that represents the base number.
        // length: An integer that specifies how many multiples to generate.

        // 2. Initialize an Array: Create a new array of doubles with the size specified by length.

        // 3. Fill the Array: Use a loop to populate the array:
        // - For each index i from 0 to length - 1, calculate the value as (i + 1) * number.
        // - Assign this value to the corresponding index in the array.

        // 4. Return the Array: After filling the array, return it.
    }

    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of doubles with the specified length
        double[] multiples = new double[length];

        // Step 2: Fill the array with multiples of 'number'
        for (int i = 0; i < length; i++)
        {
            multiples[i] = (i + 1) * number; // Calculate and assign each multiple
        }

        // Step 3: Return the filled array
        return multiples;
    }

        return multiples; // replace this return statement with your own
    }

/// <summary>
/// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
/// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
/// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
///
/// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
/// </summary>
public static void RotateListRight(List<int> data, int amount)
{
    // TODO Problem 2 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.
}


{   // Plan
    // 1. Input Parameters: The function takes two parameters:
    // - data: A list of integers that needs to be rotated.
    // - amount: An integer indicating how many positions to rotate.

    // 2. Handle Rotation Logic:
    // - Calculate the effective rotation amount using modulo operation to handle cases where amount is greater than the list size.
    // - Store elements that will wrap around in a temporary list or variable.
    // - Shift elements in the original list to their new positions.

    // 3. Update List: Modify the original list in place with the new order of elements.
}

public static void RotateListRight(List<int> data, int amount)
{
    // Step 1: Calculate effective rotation amount
    int count = data.Count;
    amount = amount % count; // In case amount is greater than count

    // Step 2: Create a copy of last 'amount' elements to rotate
    List<int> temp = data.Skip(count - amount).ToList();

    // Step 3: Shift existing elements in 'data'
    for (int i = count - 1; i >= amount; i--)
    {
        data[i] = data[i - amount]; // Shift elements right
    }

    // Step 4: Place temporary elements at the start of 'data'
    for (int i = 0; i < amount; i++)
    {
        data[i] = temp[i]; // Assign wrapped-around elements
    }
}

