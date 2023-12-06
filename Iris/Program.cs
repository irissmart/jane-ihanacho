
namespace Iris2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array1 = new int[] { 0, 1 };
            int[] array2 = new int[] { 1, 2 };
            string optimizedResult = Test.InvasionResult(array1, array2);
            Console.WriteLine(optimizedResult);
        }


    }

    public static class Test
    {
        //      A[0] = 0;    B[0] = 1; 

        //A[1] = 1;    B[1] = 2;

        //A[2] = 1;    B[2] = 3;

        //A[3] = 3;    B[3] = 4;

        //A[4] = 3;    B[4] = 5;

        //A[5] = 6;    B[5] = 3;

        //A[6] = 7;    B[6] = 5;
        public static string? InvasionResult(int[] A, int[] B)
        {
            int result = 0;
            int standalonebridge1 = 0;
            if (A.Length != B.Length) { return "array length does not match"; }

            Dictionary<int, int> map = new Dictionary<int, int>();
            List<string> list = new List<string>();
            int length = A.Length;
            for (int i = 0; i < length; i++)
            {
                standalonebridge1++;
                //if (map.Count > 0)
                //{
                //    //check last location 
                //    int lastLocation = i - 1;
                //    var mappedArray = map.ToArray();
                //    var lastPair = mappedArray[lastLocation];

                //    if (A[i] == lastPair.Value) // a connection
                //    {
                //        standalonebridge1++;
                //    }
                //    else if (map.ContainsKey(B[i]) || map.ContainsValue(B[i])
                //    || map.ContainsValue(A[i]) || map.ContainsValue(A[i]))
                //    {
                //        //a connection
                //        standalonebridge1++;
                //    }
                //}
                //map.Add(A[i], B[i]);



                if (list.Count > 0)
                {
                    //check last location 
                    int lastLocation = i - 1;
                    var lastPair = list[lastLocation];
                    lastPair.Split('-');
                    var key = lastPair[0].ToString();
                    var value = lastPair[2].ToString();
                    if (A[i].ToString() == value) // a connection
                    {
                        standalonebridge1++;
                    }
                }
                list.Add($"{A[i]}-{B[i]}");

            }

            return standalonebridge1.ToString();
        }
    }
}