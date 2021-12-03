using System;

namespace HashTablesAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Hash Tables and BST Programs");
                Console.WriteLine("Choose the program to be executed : \n 1. Sentence Frequency \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        hash.Add("0", "To");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash5 = hash.Get("5");
                        Console.WriteLine("5th index Value is : {0}" , hash5);
                        hash.Remove("1");
                        
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}