namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            var numbers = new List<int>() {1,3,5};
            int arrayresults = array.FindSum(numbers);

            //2d array
            var _2dArayList = new List<List<int>>() 
            {
                new List<int>() {1,3,4},
                new List<int>() {1,3,6},
                new List<int>() {1,3,7},
                new List<int>() {1,3,8},
            };
            var _2dArrayresults = _2dArray.FindSum(_2dArayList);
            

            //Print Results
            Console.WriteLine(arrayresults);
            Console.WriteLine(_2dArrayresults);
        }
    }
}