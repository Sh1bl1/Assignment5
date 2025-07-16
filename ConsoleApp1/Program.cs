namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vid 1 
            // Boxing And UnBoxing
            // Boxing : Casting From ValueType To ReferenceType
            // UnBoxing : Casting From ReferenceType To Value Type
            object Q1;
            // Q1 => Can Refer To Instance Of "Object" Or Any Instance of Any Type

            Q1 = "Ahmed";
            Q1 = 3;       // Cast From ValueType[int] To ReferenceType[object]= Boxing
            Q1 = 1.5;     // Cast From ValueType[double] To ReferenceType [object] => Boxing
            Q1 = 'A';     // Cast From ValueType[char] To ReferenceType[object] | > Boxing
            Q1 = true;    // Cast From ValueType[bool] To ReferenceType[object] => Boxing
            Q1 = new DateTime(); // Cast From ValueType[DateTime] To ReferenceType [object] => Boxing

            // video 2

            // Value Type
            // Reference Type
            //int X = 6;
            //x = null; // Not Valid

            // Nullable<int> : Allow Int Value or Null as Valid Value
            //int? Age = 20;
            //Age = null;
            // Nullable<double> : Allow double value or Null As Valid Value
            double? Salary = 4000.5;
            Salary = null;

            // Nullable Reference Type [C# 10.0 .NET 6.0]
            string Message01 = null; // Required
            string? Message02 = null; // Nullable
            Console.WriteLine(Message01.Length);
            Console.WriteLine(Message02);
            int[] Arr = { 1, 2, 3, 4, 5, 3 }; // null
                                              // Best Practice
            if (Arr is not null)
                for (int i = 0; i < Arr.Length; i++)
                    Console.WriteLine(Arr[i]);
            //for(int i = 0; (Arr is not null* && i < Arr. Length; i++)

            // Console.WriteLine(Arr[i]);

            // Vid 3

            //for (int i = 0; i < Arr?.Length; i++)
            //Console WriteLine(ArrLil);
            // E?. Department?. DeptName
            //int Len = Arr is not null ? Arr.Length : 0;
            //int? Len = Arr?. Length;
            //int Len = Arr?.Length is not null ? Arr.Length : 0 ;
            //int Len = Arr?.Length ?? -1;
            //Console.WriteLine(Len);

            // Vid 5

            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Arr1 = { 1, 4, 2, 3, 3 };
                Arr[99] = 10;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (IndexOutOfRangeException E)
            {
                Console.WriteLine(E.Message);
            }




            // Vid 6 

            // Access Modifiers Inside The Namespace:
            // 1. internal : Inside The Same Project
            // 2. public : Everywhere
            // Default Access Modifier Inside The Namespace "Internal"
            // What Can Write Inside The Class Or Struct?
            // 1. Attributes [Filed - Member Variable]
            // 2. Properties [Full Property - Automatic Property - Special Property
            // 3. Methods - Functions
            // 4. Event

            // Access Modifiers Inside The Struct:
            // 1. private : Inside The Same Class Only
            // 2. internal: Inside The Same Project
            // 3. public : Everywhere
            // Default Access Modifier Inside The Class Or Struct "private"

            //------------------------------Q1---------------------------- -

            /*  enum WeekDays
             {
                  Monday,
                  Tuesday,
                  Wednesday,
                  Thursday,
                  Friday,
                  Saturday,
                  Sunday
             }
               Console.WriteLine("Days of the week:");

              foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
              {
                  Console.WriteLine(day);

            ------------------------------Q2-----------------------------

            enum Season
            {
                Spring,
                Summer,
                Autumn,
                Winter
            }


            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(typeof(Season), input, true, out object result))
            {
                Season selectedSeason = (Season)result;

                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered ");
            }

              }

            // ------------------------------Q4-----------------------------------

             enum Colors
             {
                  Red,
                  Green,
                  Blue
             }
               Console.WriteLine("Enter a color name:");
                string input = Console.ReadLine();


                if (Enum.TryParse(typeof(Colors), input, true, out object result))
                {
                    Colors color = (Colors)result;
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a primary color.");


        */

        }
    }
}
