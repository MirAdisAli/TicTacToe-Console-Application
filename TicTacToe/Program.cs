using System;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = new char[200];
        static int player = 1;
        static int choice;
        static int ch1;
        static int ch2;
        static int di;
        static int p1;

        static int p1p = 0;
        static int p2p = 0;
        static int plc = 0;
        static int flag = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("\n||||| Welcome to the Tic Tac Toe |||||\n1.Play with Friend \n2.Play with Computer");
            ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 == 1)
            {
                int i = 0;
                while (i < 100)
                { 
                    Console.WriteLine("1.Play\n0.Exit");
                    ch2 = Convert.ToInt32(Console.ReadLine());
                    if (ch2 == 0)
                    {
                        if (p1p > p2p)
                        {
                            Console.WriteLine("|| Player1 has won The sries||\n||Player 1 total point: {0}||\n||Player2  total point: {1} ||", p1p, p2p);
                        }
                        else if (p1p < p2p)
                        {
                            Console.WriteLine("|| Player2 has won The sries || Player2 total point: {0} ||\n||Player1  total point: {1} ||", p2p, p1p);
                        }
                        else
                        {
                            Console.WriteLine("|| draw Seris ||");
                            Console.WriteLine("||Player1 Point: {0}\n  Player2 Point: {1}||", p1p, p2p);
                        }
                        break;
                    }
                    else
                    {
                        for (int ii = 0; ii < 11; ii++)
                        {
                            arr[ii] = ' ';
                        }
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("|| Player1:  X    Player2:  O ||");
                            Console.WriteLine("|| Press the Number || ");
                            demo_Board();

                            if (player % 2 == 0)
                            {
                                Console.WriteLine("|| Play>>>Player2 Chance ||");
                            }
                            else
                            {
                                Console.WriteLine("|| Play>>Player1 Chance ||");
                            }

                            Board();
                            Console.WriteLine("|| Enter :");

                            choice = Convert.ToInt32(Console.ReadLine());
                            if (arr[choice] != 'X' && arr[choice] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    arr[choice] = 'O';
                                    player++;
                                }
                                else
                                {
                                    arr[choice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                                Console.WriteLine("\n");
                            }

                            flag = CheckWin();

                        } while (flag != 1 && flag != -1);
                        if (flag == 1)
                        {
                            Console.WriteLine("|| Player{0} has won ||", (player % 2) + 1);
                            p1 = (player % 2) + 1;

                            if (p1 == 1)
                            {
                                p1p++;
                                Console.WriteLine("|| Player1 Point: {0}\n  Player2 Point: {1} ||", p1p, p2p);
                                Console.WriteLine("|| Player{0} has won {1} matches ||", p1, p1p);
                            }
                            else
                            {
                                p2p++;
                                Console.WriteLine("|| Player 1 Point: {0}\n   Player 2 Point: {1} ||", p1p, p2p);
                                Console.WriteLine("|| Player{0} has won {1} matches ||", p1, p2p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("|| Result is  Draw ||");
                            Console.WriteLine("|| Player1 Point: {0}\n  Player2 Point: {1} ||", p1p, p2p);
                        }
                        Board();
                        plc++;
                        Console.WriteLine("||| {0} match finsh |||", plc);
                    }
                    i++;
                    Array.Clear(arr, 0, 10);
                }
            }
            else
            {
                int x = 0;
                while (x < 100)
                {
                    Console.WriteLine("1.Play\n0.Exit");
                    ch2 = Convert.ToInt32(Console.ReadLine());
                    if (ch2 == 0)
                    {
                        if (p1p > p2p)
                        {
                            Console.WriteLine("|| Player1 has won The series & Total point: {0}||\n||Player2  Total point: {1} ||", p1p, p2p);
                        }
                        else if (p1p < p2p)
                        {
                            Console.WriteLine("|| Player2 has won The sries Total point: {0}||\n||Player1  total point: {1} ||", p2p, p1p);
                        }
                        else
                        {
                            Console.WriteLine("|| draw Seris ||");
                            Console.WriteLine("|| Player1 Point: {0}\n  Player2 Point: {1} ||", p1p, p2p);
                        }
                        break;
                    }
                    else
                    {
                        for (int ii = 0; ii < 11; ii++)
                        {
                            arr[ii] = ' ';
                        }
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("||Player 1 you : X |Player 2 Com: O ||");
                            Console.WriteLine("|| Press the Numbers ||");
                            demo_Board();

                            if (player % 2 == 0)
                            {
                                Console.WriteLine("|| Paly>> Computure Chance ||");
                            }
                            else
                            {
                                Console.WriteLine("|| Play>> Player1 Chance");
                            }

                            Board();
                            Console.WriteLine("|| Enter :");
                            Random rand = new Random();
                            if (player % 2 != 0)
                            {
                                choice = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                di = rand.Next(1, 10);
                                choice = di;
                            }
                            if (arr[choice] != 'X' && arr[choice] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    arr[choice] = 'O';
                                    player++;
                                }
                                else
                                {
                                    arr[choice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                                Console.WriteLine("\n");
                            }
                            flag = CheckWin();
                        } while (flag != 1 && flag != -1);
                        if (flag == 1)
                        {
                            Console.WriteLine("|| Player{0} has won ||", (player % 2) + 1);
                            p1 = (player % 2) + 1;
                            if (p1 == 1)
                            {
                                p1p++;
                                Console.WriteLine("|| Player{0} has won {1} matches ||", p1, p1p);
                                Console.WriteLine("|| Player1 Point: {0}\n   Player2 Point: {1} ||", p1p, p2p);
                            }
                            else
                            {
                                p2p++;
                                Console.WriteLine("|| Player{0} has won {1} matches ||", p1, p2p);
                                Console.WriteLine("|| Player1 Point: {0}\n   Player2 Point: {1} ||", p1p, p2p);

                            }
                        }
                        else
                        {
                            Console.WriteLine("|| Result is  Draw ||");
                            Console.WriteLine("|| Player1 Point: {0}\n   Player2 Point: {1} ||", p1p, p2p);
                        }
                        Board();
                        plc++;
                        Console.WriteLine("||| {0} match finsh |||", plc);
                    }
                    x++;
                    Array.Clear(arr, 0, 10);
                }
            }
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static void demo_Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  1  |  2  |   3 ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  4  |  5  |   6 ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  7  |  8  |   9 ");
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            if ((arr[1] == arr[2] && arr[2] == arr[3]) && (arr[1] == 'X' || arr[1] == 'O') && (arr[2] == 'X' || arr[2] == 'O') && (arr[3] == 'X' || arr[3] == 'O'))
            {
                return 1;
            }
            else if ((arr[4] == arr[5] && arr[5] == arr[6]) && (arr[4] == 'X' || arr[4] == 'O') && (arr[5] == 'X' || arr[5] == 'O') && (arr[6] == 'X' || arr[6] == 'O'))
            {
                return 1;
            }
            else if ((arr[6] == arr[7] && arr[7] == arr[8]) && (arr[6] == 'X' || arr[6] == 'O') && (arr[7] == 'X' || arr[7] == 'O') && (arr[8] == 'X' || arr[8] == 'O'))
            {
                return 1;
            }
            else if ((arr[1] == arr[4] && arr[4] == arr[7]) && (arr[1] == 'X' || arr[1] == 'O') && (arr[4] == 'X' || arr[4] == 'O') && (arr[7] == 'X' || arr[7] == 'O'))
            {
                return 1;
            }
            else if ((arr[2] == arr[5] && arr[5] == arr[8]) && (arr[2] == 'X' || arr[2] == 'O') && (arr[5] == 'X' || arr[5] == 'O') && (arr[8] == 'X' || arr[8] == 'O'))
            {
                return 1;
            }
            else if ((arr[3] == arr[6] && arr[6] == arr[9]) && (arr[3] == 'X' || arr[3] == 'O') && (arr[6] == 'X' || arr[6] == 'O') && (arr[9] == 'X' || arr[9] == 'O'))
            {
                return 1;
            }
            else if ((arr[1] == arr[5] && arr[5] == arr[9]) && (arr[1] == 'X' || arr[1] == 'O') && (arr[5] == 'X' || arr[5] == 'O') && (arr[9] == 'X' || arr[9] == 'O'))
            {
                return 1;
            }
            else if ((arr[3] == arr[5] && arr[5] == arr[7]) && (arr[3] == 'X' || arr[3] == 'O') && (arr[5] == 'X' || arr[5] == 'O') && (arr[7] == 'X' || arr[7] == 'O'))
            {
                return 1;
            }
            else if (arr[1] != ' ' && arr[2] != ' ' && arr[3] != ' ' && arr[4] != ' ' && arr[5] != ' ' && arr[6] != ' ' && arr[7] != ' ' && arr[8] != ' ' && arr[9] != ' ')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
