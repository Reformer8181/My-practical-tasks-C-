namespace Array___Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
            }

            // Create an array with 5 of your best friends
            // Create a foreach loop which greets all of them

            string[] myBestFriendsArray = new string[5];

            myBestFriendsArray[0] = "Alice";
            myBestFriendsArray[1] = "Bob";
            myBestFriendsArray[2] = "Carlos";
            myBestFriendsArray[3] = "Diana";
            myBestFriendsArray[4] = "Ethan";

            foreach (string friendName in myBestFriendsArray) 
            {
                Console.WriteLine(friendName);
            }

            Console.ReadKey();
        }
    }
}