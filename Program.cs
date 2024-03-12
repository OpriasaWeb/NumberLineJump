// See https://aka.ms/new-console-template for more information

class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {

        while(v1 > 0 && v2 > 0){
            x1 += v1;
            x2 += v2;
            if(x1 == x2)
            {
                return "YES";
            }

            // x1 = 0
            // v1 = 2
            // x2 = 5
            // v2 = 3

            // If one kangaroo is ahead and moving faster, they can't meet
            if ((x1 > x2 && v1 > v2) || (x2 > x1 && v2 > v1))
            {
                break;
            }
        }
        return "NO";
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        // NO
        // x1 = 0
        // v1 = 2
        // x2 = 5
        // v2 = 3

        // YES
        int x1 = 0;
        int v1 = 3;
        int x2 = 4;
        int v2 = 2;

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
