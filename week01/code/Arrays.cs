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

        // Solution:
        // 1. Create an "double array `multiples`" with "size `length`"
        // 2. Create a "for loop" where "int i = 1" and must continue to execute as long as "i <= length"
        // 3. Inside the loop, create a "double variable `product`" which holds the value of "number * i"
        // 4. Append "product" to "multiples" using the index "i - 1 
        //      4.a. so if i = 1 then the first iteration of "product" is in index 0"
        // 5. "Return multiple" at the end of the function

        double[] multiples = new double[length];
        for (int i = 1; i <= length; i++)
        {
            double product = number * i;
            multiples[i - 1] = product;
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

        // Solution:
        // 1. Create an "int variable `shift`" which would hold the value of "amount mod data.Count"
        //      1.a. "data.Count" counts all the items inside the "List<int> data"
        //      1.b. The `shift` value tells us how much we need to shift right in case the `amount` value is at least the `data.Count` value
        // 2. Create an "if block" which executes if `shift` value is NOT equal to 0
        //      2.a. This would allow the function to return the "original List" when no changes are made 
        // 3. Create an "int variable `index`" which would hold the value of "data.Count - shift"
        // 4. Create a new "List<int> `copy`" using "data.GetRange(index, shift)"
        //      4.a. `index` tells us at which index of the List we are to get
        //      4.b. `shift` tells us how many elements we are going to get
        //      4.c. This ensures that we are always going to get the last "`shift` value" elements in the List
        // 5. Delete the copied elements on the original List using "data.RemoveRange(index, shift)"
        // 6. Insert the copied elements to the original List using "data.InsertRange(0, copy)"

        int shift = amount % data.Count;

        if (shift != 0)
        {
            int index = data.Count - shift;
            List<int> copy = data.GetRange(index, shift);
            data.RemoveRange(index, shift);
            data.InsertRange(0, copy);
        }
    }
}
