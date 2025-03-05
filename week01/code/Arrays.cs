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

        // variable for the result
        var results = new double[length];

        // so here I need to make this work as many times as the int length
        for (int i = 0; i < length; i++) {
            // here I multiplied the double number for the length adding one so the first result 
            // don't give 0, making the starting index 1
            results[i] = number * (i + 1);
            Console.WriteLine(results[i]);
        }
        Console.WriteLine(results);
        return results; // replace this return statement with your own
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
        
        // here is the loop that repeats the insertion for the int amount
        for (var i = 0; i < amount; i++) {
            // here, fristly the last index is inserted at the beginning
            data.Insert(0, data[data.Count - 1]);
            // and here the last index is removed
            data.RemoveAt(data.Count -1);
        }


    }
}
