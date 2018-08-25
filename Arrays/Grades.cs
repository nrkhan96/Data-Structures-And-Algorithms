using System;

namespace Arrays
{
    public class Grades
    {
         static string[,] studenGrades = new string [,]
        {
            {"Student1", "A", "B", "B", "C" },
            {"Student2", "C", "A", "A", "A*" },
            {"Student3", "B", "C", "A", "A" },
            {"Student4", "A", "A", "B", "C" },
            {"Student5", "A*", "A", "B", "B" }
        };

        //Calculate Total A*, A, B, C Grades, return each grade with total number
        static string[,] CalculateTotal()
        {
            string[,] TotalCounts = new string[5, 2];
            int totalAStar= 0;
            int totalA = 0;
            int totalB = 0;
            int totalC = 0;

            for (int i = 0; i <= studenGrades.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= studenGrades.GetUpperBound(1); j++)
                {
                    switch (studenGrades[i,j])
                    {
                        case "A*":
                            totalAStar++;
                            break;
                        case "A":
                            totalA++;
                            break;
                        case "B":
                            totalB++;
                            break;
                        case "C":
                            totalC++;
                            break;
                        default:
                            break;
                    }
                }
            }

            TotalCounts[0, 0] = "A*";
            TotalCounts[0, 1] = totalAStar.ToString();

            TotalCounts[1, 0] = "A";
            TotalCounts[1, 1] = totalA.ToString();

            TotalCounts[2, 0] = "B";
            TotalCounts[2, 1] = totalB.ToString();

            TotalCounts[3, 0] = "C";
            TotalCounts[3, 1] = totalC.ToString();

            return TotalCounts;
        }

        public static void Display()
        {
            var totals = CalculateTotal();
            for (int i = 0; i <= totals.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= totals.GetUpperBound(1); j++)
                {
                    Console.Write(totals[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
