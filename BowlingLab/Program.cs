using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playerNames = new string[2];



            int[,] playerScores = new int[2, 11];

            Console.Write("Please enter your name: ");
            playerNames[0] = Console.ReadLine();

            Console.Write("Please enter your name: ");
            playerNames[1] = Console.ReadLine();

            Random randonNumGen = new Random();
            int pinsKnockedDown;
            int score = 0;
            int totalScore = 0;
            bool strike = false;
            bool spare = false;


            for (int frames = 0; frames < 11; frames++)//number of frames
            {


                for (int player = 0; player < 2; player++)//player 1 and 2
                {
                    Console.WriteLine($"\nIt's {playerNames[player]}'s turn! Hit ENTER to bowl!");
                    Console.ReadLine();
                    Console.WriteLine();

                    if(strike == true)
                    {
                        score = 10;

                        pinsKnockedDown = randonNumGen.Next(11);
                        Console.WriteLine($"You knocked down {pinsKnockedDown} pins, bowl again!");
                        Console.ReadLine();
                        score += pinsKnockedDown*2;


                        if (pinsKnockedDown < 10) //second turn
                        {
                            pinsKnockedDown = randonNumGen.Next(11 - pinsKnockedDown);
                            Console.WriteLine($"You knocked down {pinsKnockedDown} pins.");
                            Console.ReadLine();
                            score += pinsKnockedDown*2;

                            if (score == 10)
                            {
                                Console.WriteLine("You got a spare!");
                                //playerScores[player, frames + 1] = 10;
                                spare = true;
                            }
                        }
                        else if (pinsKnockedDown == 10)
                        {
                            Console.WriteLine("Congrats! You got a strike!");
                            //playerScores[player, frames + 1] = 10;
                            strike = true;
                        }

                        playerScores[player, frames] = score;

                        for (int i = frames; i >= 0; i--)
                        {
                            totalScore += playerScores[player, i];
                            //Console.WriteLine(totalScore);
                        }

                        Console.WriteLine($"{playerNames[player]} total frame {frames + 1} score is {playerScores[player, frames]} and your total score is {totalScore}");
                        score = 0;
                        //Console.WriteLine(totalScore);

                        totalScore = 0;
                    }
                    else if (spare == true)
                    {
                        score = 10;

                        pinsKnockedDown = randonNumGen.Next(11);
                        Console.WriteLine($"You knocked down {pinsKnockedDown} pins, bowl again!");
                        Console.ReadLine();
                        score += pinsKnockedDown*2;


                        if (pinsKnockedDown < 10)
                        {
                            pinsKnockedDown = randonNumGen.Next(11 - pinsKnockedDown);
                            Console.WriteLine($"You knocked down {pinsKnockedDown} pins.");
                            Console.ReadLine();
                            score += pinsKnockedDown;

                            if (score == 10)
                            {
                                Console.WriteLine("You got a spare!");
                                playerScores[player, frames + 1] = 10;
                                spare = true;
                            }
                        }
                        else if (pinsKnockedDown == 10)
                        {
                            Console.WriteLine("Congrats! You got a strike!");
                            //playerScores[player, frames + 1] = 10;
                            strike = true;
                        }

                        playerScores[player, frames] = score;

                        for (int i = frames; i >= 0; i--)
                        {
                            totalScore += playerScores[player, i];
                            //Console.WriteLine(totalScore);
                        }

                        Console.WriteLine($"{playerNames[player]} total frame {frames + 1} score is {playerScores[player, frames]} and your total score is {totalScore}");
                        score = 0;
                        //Console.WriteLine(totalScore);

                        totalScore = 0;
                    }
                    else
                    {
                        pinsKnockedDown = randonNumGen.Next(11);
                        Console.WriteLine($"You knocked down {pinsKnockedDown} pins, bowl again!");
                        Console.ReadLine();
                        score += pinsKnockedDown;


                        if (pinsKnockedDown < 10)
                        {
                            pinsKnockedDown = randonNumGen.Next(11 - pinsKnockedDown);
                            Console.WriteLine($"You knocked down {pinsKnockedDown} pins.");
                            Console.ReadLine();
                            score += pinsKnockedDown;

                            if (score == 10)
                            {
                                Console.WriteLine("You got a spare!");
                                playerScores[player, frames + 1] = 10;
                                spare = true;
                            }
                        }
                        else if (pinsKnockedDown == 10)
                        {
                            Console.WriteLine("Congrats! You got a strike!");
                            //playerScores[player, frames + 1] = 10;
                            strike = true;
                        }

                        playerScores[player, frames] = score;

                        for (int i = frames; i >= 0; i--)
                        {
                            totalScore += playerScores[player, i];
                            //Console.WriteLine(totalScore);
                        }

                        Console.WriteLine($"{playerNames[player]} total frame {frames + 1} score is {playerScores[player, frames]} and your total score is {totalScore}");
                        score = 0;
                        //Console.WriteLine(totalScore);

                        totalScore = 0;
                    }



                }
            }


        }
    }
}
