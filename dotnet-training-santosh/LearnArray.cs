public class LearnArray
{
    public void LearnArrays()
    {
        //One Dimensional Array
        byte[] ages = { 2, 25, 16, 14, 8, 14 };
        ages[5] = 55;
        Console.WriteLine(ages.Length);
        int[] numbers = new int[100]; //Array that hold numbers upto length 100

        //Multi-Dimensional Array
        double[,] matrix = new Double[3, 4];//Two Dimensional - one comma, three Dimensional- two comma and so on
                                            //first 3 is row
                                            // Second 4 is column
        double[,] matrix1 = new Double[2, 2];
        // 45  89
        // 33  55
        matrix[0, 0] = 45;
        matrix[0, 1] = 89;
        matrix[1, 0] = 33;
        matrix[1, 1] = 55;

        //Jagged Array
        var jaggedArray = new decimal[20][];
        jaggedArray[0] = new decimal[] { 0, 5, 16, 44, 78 };
        jaggedArray[1] = new decimal[] { 14, 12, 47 };
    }
}