using System;
using System.Linq;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] placementOfBugs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] playground = new int[fieldSize];

            foreach (int bugIndex in placementOfBugs)
            {
                if (bugIndex >= 0 && bugIndex <= fieldSize - 1)
                {
                    if (playground[bugIndex] == 0)
                    {
                        playground[bugIndex] = 1;
                    }

                }
            }

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] orders = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int indexBugPos = int.Parse(orders[0]);
                string directionToMove = orders[1];
                int indexMovePos = int.Parse(orders[2]);

                if (indexMovePos == 0)
                {
                    continue;
                }
                if (indexBugPos < 0 || indexBugPos >= fieldSize)
                {
                    continue;
                }
                //if the direction is left
                if (directionToMove == "left")
                {
                    if (playground[indexBugPos] > 0)
                    {
                        for (int i = indexBugPos - indexMovePos; i >= 0; i -= indexMovePos)
                        {
                            if (playground[i] == 0)
                            {
                                playground[i] = 1;
                                playground[indexBugPos] = 0;
                                break;
                            }
                        }
                        if (playground[indexBugPos] > 0)
                        {
                            playground[indexBugPos] = 0;
                            continue;
                        }
                    }
                }
                //if the direction is right
                else if (directionToMove == "right")
                {
                    if (playground[indexBugPos] > 0)
                    {
                        if (indexBugPos + indexMovePos >= playground.Length)
                        {
                            playground[indexBugPos] = 0;
                            continue;
                        }

                        for (int l = indexBugPos + indexMovePos; l < playground.Length; l += indexMovePos)
                        {
                            if (playground[l] == 0)
                            {
                                playground[l] = 1;
                                playground[indexBugPos] = 0;
                                break;
                            }
                        }

                        if (playground[indexBugPos] > 0)
                        {
                            playground[indexBugPos] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", playground));
        }
    }
}

