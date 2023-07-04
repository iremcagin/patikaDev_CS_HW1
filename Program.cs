using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //_________________________________ QUESTION 1 _________________________________________
            /*
            List<int> nums = new List<int>();
            int n;

            do{
                Console.Write("Enter a positive number: ");
                n = int.Parse(Console.ReadLine());
            }while(n<=0);
            // get the numbers from the console 
            for(int i=1; i<=n; ++i){
                Console.Write(i+": ");
                nums.Add(int.Parse(Console.ReadLine()));
            }
            // print even numbers
            Console.Write("Even numbers : ");
            for(int i=0; i<nums.Count; ++i){
                if(nums[i]%2==0) Console.Write(nums[i]+ " ");
            }
            */

          
            //_________________________________ QUESTION 2 _________________________________________
            /*
            Console.WriteLine("Enter the first num : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num : ");
            int m = int.Parse(Console.ReadLine());
            if(n==m || n%m==0) Console.Write(n);
            */

            
            
            //_________________________________ QUESTION 3 _________________________________________

            /*
            List<string> words = new List<string>();

            Console.Write("Enter a positive num : ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the words : ");
            for(int i=1; i<=n; ++i){
                Console.Write(i+": ");
                words.Add(Console.ReadLine());
            }

            for(int i=n-1; i>=0; --i)Console.Write(words[i]+" ");
            */


            //_________________________________ QUESTION 4 ________________________________________
            /*
            Console.Write("Enter a sentence : ");
            string sent = "";
            sent = Console.ReadLine();
            string[] words = sent.Split(' ');
            int wordnum = words.Count();
            char[] chars = sent.Replace(" ", string.Empty).ToCharArray();
            int  charnum= chars.Count();
            Console.WriteLine("Word number: {0}, Char number: {1}", wordnum, charnum);
            */
        }
    }
}