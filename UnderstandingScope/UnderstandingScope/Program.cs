using System;

namespace UnderstandingScope
{
    class Program
    {
        // Declare statics
        private static string k;

        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                k = i.ToString();
            } // End for


            // Console.WriteLine(i);    Error resides outside for loop
            MessageK();

            // Test our new class
            MoreMessages mm = new MoreMessages();
            mm.NewMessage();
            // Change private to public in order to access it outside of the class

            // Put this line in to pause the program
            Console.ReadLine();

        } // End main

        static void MessageK()
        {
            Console.WriteLine("Value of variable k is " + k);
        }

    } // End class


    // Create a new class
    class MoreMessages
    {
        public void NewMessage()
        {
            Console.WriteLine("New Message from MoreMessage Class");

        }

        private void AdditionalMessage()
        {
            Console.WriteLine("Additional Message");

        }

    } // End class MoreMessages


} // End namespace
