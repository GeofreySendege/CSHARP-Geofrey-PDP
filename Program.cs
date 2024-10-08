using System;
using System.Collections.Generic;

namespace Exercise_Array_list__Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EnterUserName();
            Console.WriteLine("exercise 2 below ");
             ReverseName();
            // SortListOfNumbers(); 
            //TypeExitProgram();
            // SeparatedNumbersWithCommas();

        }
        // stores  names into a list 
        public static void EnterUserName()
        {
            var names = new List<string>(); // create a list of names to store all names entered by the user 

            while (true)
            {
                Console.WriteLine(" Enter  different names or press enter to exit ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))   //  check and handle for invalid input
                    break;
                names.Add(input);   // otherwise add the name to the list 

            }
            Console.WriteLine("Total Number of names in List is : " + names.Count);  //  check  how many names enetered
                                                                                     //  in the list 

            if (names.Count > 2)
                Console.WriteLine("{0},{1} and {2} others like your post", names[0], names[1], names.Count - 2); // check the end of the list
            else if (names.Count == 2)
                Console.WriteLine("{0},{1} like your post : ", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} like  Your Post ", names[0]);
            else Console.WriteLine();
        }


        //  method  that reverse the name entered 
        public static void ReverseName()
        {
            Console.WriteLine("what is your Name :");
            var name = Console.ReadLine();   //  input string of characaters

            var arrayOFCharacters = new char[name.Length]; // created array of characters  of size  of the input string
                                                           //  where to store the characters

            for (var i = name.Length; i > 0; i--)
            {
                arrayOFCharacters[name.Length - 1] = name[i - 1];  //getting the character in the last index of the input array
                                                                   //and storing it in the last index of arrayOfCharacter
                var Reversed = new string(arrayOFCharacters);   // stored all reversed arrayófcharacters into string array.
                Console.WriteLine(" Reveresed Name is :" + Reversed);
            }

            /*
             * oscar feedback
             * 
             * Console.WriteLine(name.ToArray().Reverse());
		for (var i = name.Length; i > 0; i--)
		{
			arrayOFCharacters[name.Length - i] = name[i - 1];  //getting the character in the last
		}
		Console.WriteLine(" Reveresed Name is :" + arrayOFCharacters);
             * */

        }





        // method that prompts user to enter 5 different numbers  , sorts them 
        public static void SortListOfNumbers()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)   // checks not to add more than 5 numbers 
            {
                Console.WriteLine(" Please enter a number : ");
                var sl = Console.ReadLine();
                var number = int.Parse(sl);   //  check if the list contains the number before adding it to the list 

                if (numbers.Contains(number))  // checks if number exists in the list 
                {
                    Console.WriteLine(" Number already  exists :" + number);
                    continue;  // if number exists programe does not continue , it breaks and goes back to start while loop
                               // but if didnt have continue , programe  warns user but still adds  existing number to the container
                }
                numbers.Add(number);
            }
            Console.WriteLine("Display the numbers in container First");
            foreach (var number in numbers)  // display the numbers in the container 
                Console.WriteLine(number);

            Console.WriteLine("Show the sorted numbers :");
            numbers.Sort();  // sort the numbers 
            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        //  programe that allows one to input a text word example "exit"  to exist the programe
        public static void TypeExitProgram()
        {
            var listOfNumbers = new List<int>();  // create a list  where numbers shall be stored 

            while (true)  // while true keep adding numbers unless press exit to quit programme
            {
                Console.WriteLine(" Enter number of wish or type `Quit´ to exit:");
                var sl = Console.ReadLine();  // get hold of  the number and convert it to integer 
                if (string.IsNullOrEmpty(sl))  // check if  there is empty input  
                {
                    break;
                }
                else if (sl.ToLower() == "quit")  //  
                {
                    break;
                }
                // else   @Oscar  if i  leave an else statement get warnings on the lines below 
                var randomInput = int.Parse(sl);
                listOfNumbers.Add(randomInput);

            }

            Console.WriteLine("Display all Random numbers Including repeated numbers ");
            foreach (var number in listOfNumbers)
                Console.WriteLine(number);


            //   should look for unique numbers and display them
            var uniqueNumbers = new List<int>();
            foreach (var number in listOfNumbers)   //  go through the list  , identify the unique numbers and save 
            {
                if (!uniqueNumbers.Contains(number))   // think little more about this line
                    uniqueNumbers.Add(number);
            }

            Console.WriteLine("Unique Numbers ");
            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);

            }

        }

        public static void SeparatedNumbersWithCommas()
        {
            string[] elements; //  declare  string array of elements 

            while (true)   // use a while loop because we dont know  how many  numbers will be input    
            {
                Console.WriteLine("Enter a list of more than 5 Numbers separated with commas : ");
                var sl = Console.ReadLine();

                if (!string.IsNullOrEmpty(sl)) // we  check if the input string is empty 
                {
                    elements = sl.Split(',');   // split method returns an array of separated members
                    if (elements.Length >= 5)  // 
                        break;
                }

                Console.WriteLine("Invalid list");
            }

            // get hold of all the numbers from string and store them in a general list  called numbers 

            var numbers = new List<int>();

            foreach (var number in elements)  //  loop iterartes through the string element array and converts one element at a time 
            {
                numbers.Add(int.Parse(number));  //  have a list  converted integers 
            }

            Console.WriteLine("Display all list of general numbers :");
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("OriginalSize " + numbers.Count);


            //   create  a list to store all the small numbers less than 3 

            var smallest = new List<int>();  // list to store the smallest 

            while (smallest.Count < 3)  //
            {
                // assume the first index of number is the min 
                var min = numbers[0];

                foreach (var number in numbers)   //  iterates starting with the first index of numbers ,checks if its less than min 
                {
                    if (number < min)
                        min = number;  //  if the current value of  index is lower than the
                                       //  original min value then reset min value to become new min
                }
                smallest.Add(min);      // adds the lowest value found  to smallest list 
                numbers.Remove(min);    // deleates the lowest value  from the general list 

                // check or Test if the size of  the original list has reduced  
                Console.WriteLine(" Check if New Size of Original List Reduced ? New Size is  : " + numbers.Count);

            }

            // The smallest numbers are 
            Console.WriteLine(" The first  3 smallest numbers are :");
            foreach (var item in smallest)
                Console.WriteLine(item); // prints out the smallest numbers stored in the smallest list 


        }


    }
}
