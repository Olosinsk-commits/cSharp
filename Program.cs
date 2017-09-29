using System;



namespace ConsoleApp2

{

    class MainClass

    {

        public static void Main(string[] args)

        {

            int numberOfMethod;//number of methods

            int value2Method = 4; //this value we use in the 2nd method

            int value3Method = 52400;//this value we use in the 3rd method

            int lowerBound = 20;// this value represents the lower bound for 6,7,8 method

            int upperBound = 43;// this value represents the upper bound for 6,7,8 method

            int value9Method = 90;

            int value10Method = 90;

            bool flag = true;

            while (flag)
            {

                Console.WriteLine("Please, enter the number of method 1-10 or 11 to exit: ");





                numberOfMethod = Convert.ToInt16(Console.ReadLine());

                //check if user enters correct number of method

                while (numberOfMethod < 1 || numberOfMethod > 11)
                {

                    Console.WriteLine("Number must be between 1-10. Try again! ");

                    numberOfMethod = Convert.ToInt16(Console.ReadLine());

                    break;

                }

                //get number of method from user

                switch (numberOfMethod)
                {

                    case 1:

                        Console.WriteLine("Sum is: " + FirstMethod());

                        Console.WriteLine();

                        break;

                        ;

                    case 2:

                        Console.WriteLine("Value of the polynomial 2x^3 +4x– 3 for number 4: ");

                        Console.WriteLine("Method calls first time:   " + SecondMethod(value2Method));

                        Console.WriteLine("Method calls second time:  " + SecondMethod(value2Method));

                        Console.WriteLine();

                        break;

                    case 3:

                        ThirdMethod(value3Method);

                        Console.WriteLine();

                        break;

                    case 4:

                        FourthMethod();

                        Console.WriteLine();

                        break;

                    case 5:

                        FifthMethod();

                        Console.WriteLine();

                        break;

                    case 6:

                        SixthMethod(lowerBound, upperBound);

                        Console.WriteLine();

                        break;

                    case 7:

                        SeventhMethod(lowerBound, upperBound);

                        Console.WriteLine();

                        break;

                    case 8:

                        EighthMethod(lowerBound, upperBound);

                        Console.WriteLine();

                        break;

                    case 9:

                        Console.WriteLine("compound if statement. The grade is: " + NinthMethod(value9Method));

                        Console.WriteLine();

                        break;

                    case 10:

                        Console.WriteLine("switch statement. The grade is : " + TenthMethod(value10Method));

                        Console.WriteLine();

                        break;

                    case 11:

                        Console.WriteLine("Buy! Buy!");

                        flag = false;

                        break;

                }

            }

        }



        //FirstMethod method reads three	integers	from	the	keyboard, passes these	integers	just	read

        // to	a	method	which	adds them	together, returns	the	 sum and prints	the	sum to	the	console.



        static int FirstMethod()

        {

            Console.WriteLine("Please, enter 3 integers: ");

            int numberOne = Convert.ToInt16(Console.ReadLine());

            int numberTwo = Convert.ToInt16(Console.ReadLine());

            int numberThree = Convert.ToInt16(Console.ReadLine());

            int answer = numberOne + numberTwo + numberThree;

            return answer;

        }



        //SecondMethod	method	takes	a	single	integer	parameter named x,	and returns	the	value	of	the	polynomial

        //2x^3 +	4x	– 3. This	method is called	twice	from	Main,	each	time	reading	in	a value	for x,	

        //printing	it,	and	displaying	the	result.



        static int SecondMethod(int valueX)

        {

            int answer = (int)(2 * (Math.Pow(valueX, 3)) + 4 * valueX - 3);

            return answer;

        }

        //ThirdMethod	method	accepts	an	integer	number	of	seconds, and	prints	out	the	equivalent	

        //number	of	hours,	minutes,	and	seconds.	

        //For	example,	52400	seconds	should	yield	a	result	of	14	hours,	33	minutes,	20	seconds.



        static void ThirdMethod(int x)

        {

            int hours = x / 3600;

            int minutes = (x - hours * 3600) / 60;

            int seconds = x - hours * 3600 - minutes * 60;

            Console.WriteLine(x + " seconds should yield a result of: {0} hours, {1} minutes, {2} seconds", hours, minutes, seconds);



        }

        //The fourthMethod	method	prints	out	the	maximum	and	minimum	values	from	a	sequence	of	

        //non-negative	numbers	entered	by	a	user.	Before	reading	the	numbers,	ask	the	user	to	input	

        //how	many	numbers	will	be	input.

        static void FourthMethod()

        {

            int userNumb;



            Console.WriteLine("How many numbers would you like to enter: ");

            userNumb = Convert.ToInt16(Console.ReadLine());

            int[] userInput = new int[userNumb];

            Console.WriteLine("Please, enter {0} non-negative numbers: ", userNumb);

            for (int i = 0; i < userNumb; i++)
            {

                userInput[i] = Convert.ToInt16(Console.ReadLine());



            }

            int minV = userInput[0];

            int maxV = userInput[0];

            for (int j = 0; j < userNumb; j++)

            {

                if (userInput[j] < minV)

                    minV = userInput[j];

                else

                    if (userInput[j] > maxV)

                    maxV = userInput[j];

            }

            Console.WriteLine("The maximum value is: {0}", maxV);

            Console.WriteLine("The minimum value is: {0}", minV);

        }

        //Write	a static method	that finds the mean of a sequence of nonnegative numbers entered by	a	

        //user.	Stop reading input when	the	user enters	a negative number.

        static void FifthMethod()

        {

            double usersInput;

            double sum = 0;

            int count = 0;



            Console.WriteLine("Please enter a sequence of non-negative numbers.");

            Console.WriteLine("To stop you need to enter a negative number.");



            usersInput = double.Parse(Console.ReadLine());



            while (usersInput > 0)
            {

                count++;

                sum = sum + usersInput;

                usersInput = Convert.ToInt16(Console.ReadLine());

            }



            double average = sum / count;

            Console.WriteLine("The average value of {0} elements is {1}", count, average);

        }

        //The sixthMethod method contains a for-loop that displays	

        //the odd numbers between 42 and 20	in that	order.

        static void SixthMethod(int lowerBound, int upperBound)

        {



            Random rnd1 = new Random();



            int numberOfNumbers = 10;

            int[] arrayOfNumbers = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {

                int number = rnd1.Next(lowerBound, upperBound);

                arrayOfNumbers[i] = number;

            }

            Console.WriteLine("for-loop. The odd numbers between 42 and 20 are: ");

            Array.Sort(arrayOfNumbers);

            Array.Reverse(arrayOfNumbers);

            for (int j = 0; j < numberOfNumbers; j++)
            {

                if (arrayOfNumbers[j] % 2 != 0)



                    Console.WriteLine(arrayOfNumbers[j]);

            }





        }

        //Write	a static method	that contains a	while-loop that	displays the even numbers between

        //42 and 20	in that	order.	

        static void SeventhMethod(int lowerBound, int upperBound)

        {



            Random rnd1 = new Random();



            int numberOfNumbers = 10;

            int[] arrayOfNumbers = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {

                int number = rnd1.Next(lowerBound, upperBound);

                arrayOfNumbers[i] = number;

            }

            Console.WriteLine("while-loop. The even numbers between 42 and 20 are: ");

            Array.Sort(arrayOfNumbers);

            Array.Reverse(arrayOfNumbers);

            int count = 0;

            while (count < numberOfNumbers - 1)

            {

                if (arrayOfNumbers[count] % 2 == 0)

                    Console.WriteLine(arrayOfNumbers[count]);

                count++;



            }

        }



        //Write	a static method	that contains a	do-loop	that displays the even numbers between 42 and	

        //20 in	that order.		

        static void EighthMethod(int lowerBound, int upperBound)

        {



            Random rnd1 = new Random();



            int numberOfNumbers = 10;

            int[] arrayOfNumbers = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {

                int number = rnd1.Next(lowerBound, upperBound);

                arrayOfNumbers[i] = number;

            }

            Console.WriteLine("do-while loop. The even numbers between 42 and 20 are: ");

            Array.Sort(arrayOfNumbers);

            Array.Reverse(arrayOfNumbers);

            int count = 0;

            do
            {

                if (arrayOfNumbers[count] % 2 != 0)

                    Console.WriteLine(arrayOfNumbers[count]);

                count++;

            } while (count < numberOfNumbers - 1);

        }



        //if statement. The ninthMethod method takes a single int parameter specifying a test score between 0	and	

        //100, and returns the corresponding letter	grade. The grade scale below:	

        //91 to	100	A	

        //81 to	90	B	

        //71 to	80	C	

        //61 to	70	D	

        //60 and below F



        static char NinthMethod(int parameter)

        {

            char letterGrade;

            if (parameter <= 60)

                letterGrade = 'F';

            else if (parameter > 60 && parameter <= 70)

                letterGrade = 'D';

            else if (parameter > 70 && parameter <= 80)

                letterGrade = 'C';

            else if (parameter > 80 && parameter <= 90)

                letterGrade = 'B';

            else

                letterGrade = 'A';

            return letterGrade;

        }

        //switch statement. The tenthMethod method takes a single int parameter specifying a test score between 0	and	

        //100, and returns the corresponding letter	grade. The grade scale below:	

        //91 to	100	A	

        //81 to	90	B	

        //71 to	80	C	

        //61 to	70	D	

        //60 and below F

        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch 

        static char TenthMethod(int parameter)

        {

            char letterGrade;

            switch (parameter)

            {

                case int n when parameter <= 60:

                    letterGrade = 'F';

                    break;

                case int n when parameter <= 70:

                    letterGrade = 'D';

                    break;

                case int n when parameter <= 80:

                    letterGrade = 'C';

                    break;

                case int n when parameter <= 90:

                    letterGrade = 'B';

                    break;

                default:

                    letterGrade = 'A';

                    break;



            }

            return letterGrade;

        }



    }

}