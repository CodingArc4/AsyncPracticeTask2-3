namespace AsynchronusDemo2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //call async method
            Console.WriteLine("--Async Method Call");
            var myresul2 = await AsyncMethod(50);

            //call async method
            Console.WriteLine("--Async2 Method Call");
            var myresul1 = await AsyncMethod2(5);
            
            Console.WriteLine($"async2 method call result: {myresul1}");
            Console.WriteLine($"Async method call result: {myresul2}");

        }

        //asynchronus method
        private static async Task<int> AsyncMethod(int count)
        {
            int result = 0;

            for (int i = 0; i < count; i++)
            {               
                Console.WriteLine($"async number print : {i}");
                result += i;
            }
            return result;
        }

        // Asynchronus method 2
        private static async Task<int> AsyncMethod2(int count)
        {
            int result = 0;

            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"async2 number print : {i}");
                result += i;
            }
            return result;
        }

    }
}