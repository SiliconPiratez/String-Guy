  using System;

  namespace String_Guy
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------------------");
            Console.WriteLine(" String Guy Version 0.0.1A ");
            Console.WriteLine(" --------------------------\n");
            Console.WriteLine(" This simple app helps you to undrestand oop programming and some the of useful string methods in c#\n");
            // Developed By SiliconPirate
            Body();

        }
        public static void Body()
        {
            switch (fout())
            {
                case 1:
                    strtemp();

                    break;

                case 2:
                    instring();

                    break;
                case 0:
                    break;
                case 9:
                    about();
                    break;
            }
        }
        public static int fout()
        {
            bool flag = true;
            int UserChoise = 0;
            int counter = 0;
            Console.WriteLine("\n You Can Start Using The Program By Typing Your Own String Or Use Templets : \n");
            Console.WriteLine(" 1 . Use Templets \n");
            Console.WriteLine(" 2 . Type My Own String \n");
            Console.WriteLine(" 0 . Exit \n");
            Console.WriteLine(" 9 . About Us \n");
            while (flag)
            {
                try
                {

                    Console.Write(" I Want To (1,2,0) : ");
                    UserChoise = Convert.ToInt32(Console.ReadLine());
                    if (!(UserChoise == 0 || UserChoise == 1 || UserChoise == 2 || UserChoise == 9))
                    {
                        Console.WriteLine(" \n Try Again ! \n");
                        counter++;
                    }
                    else
                    {
                        flag = false;
                        if (counter > 0)
                            Console.WriteLine(" ------------------------------");
                    }
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("\n Just Enter Numbers ! \n");
                }
            }

            return UserChoise;
        }

        #region Templets
        public static void strtemp()
        {
            Console.WriteLine("\n Here You Can Choose Templets :\n");
            string[] templets = { "Hello World", "Coded By SiliconPirate", "Petit And Mighty", "I Saw a Horse !", "How Delightful It IS To Fall In Love For The First Time!" };
            int tempChoise = 0;
            for (int i = 0; i < templets.Length; i++)
            {
                Console.WriteLine(" {0} . {1}\n", i + 1, templets[i]);
                if (i == templets.Length - 1)
                {
                    bool flag = true;
                    int counter = 0;
                    while (flag)
                    {
                        try
                        {
                            Console.Write(" Your Choise : ");
                            tempChoise = Convert.ToInt32(Console.ReadLine()) - 1;
                            if (!(tempChoise >= 0 && tempChoise < 5))
                            {
                                Console.WriteLine(" \n Try Again ! \n");
                                counter++;
                            }
                            else
                            {
                                flag = false;
                                if (counter > 0)
                                    Console.WriteLine("-----------------------");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n Just Enter Numbers ! \n");

                        }

                    }
                }

            }
            if (tempChoise == 65)
                Environment.Exit(0);
            Console.WriteLine("\n Availble Methods : \n");
            string[] method = { "ToUpper", "ToLower", "Replace", "Remove", "Trim", "TrimEnd" };
            int methodChoise = 0;
            for (int i = 0; i < method.Length; i++)
            {
                Console.WriteLine(" {0} . {1}\n", i + 1, method[i]);
                if (i == method.Length - 1)
                {
                    bool flag = true;
                    int counter = 0;
                    while (flag)
                    {
                        try
                        {
                            Console.Write(" Your Choise : ");
                            methodChoise = Convert.ToInt32(Console.ReadLine());
                            if (!(methodChoise >= 0 && methodChoise < 7))
                            {
                                Console.WriteLine(" \n Try Again ! \n");
                                counter++;
                            }
                            else
                            {
                                flag = false;
                                if (counter > 0)
                                    Console.WriteLine("-----------------------");
                            }

                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n Just Enter Numbers ! \n");
                        }

                    }
                    if (methodChoise == 66)
                        Environment.Exit(0);
                }
            }
            switch (methodChoise)
            {
                case 1:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toUpper(templets[tempChoise] + "\n"));
                    TryAgain();
                    break;
                case 2:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toLower(templets[tempChoise] + "\n"));
                    TryAgain();

                    break;
                case 3:
                    foreach (char item in templets[tempChoise])
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine(templets[tempChoise]);
                    foreach (char item in templets[tempChoise])
                    {
                        Console.Write("-");
                    }
                    Console.Write("\n Enter The Word You want to replace : ");
                    char oldwrd = Convert.ToChar(Console.ReadLine());
                    Console.Write("\n Enter New Word : ");
                    char newwrd = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toReplace(templets[tempChoise], oldwrd, newwrd) + "\n");
                    TryAgain();
                    break;

                case 4:
                    foreach (char item in templets[tempChoise])
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine("\n" + templets[tempChoise]);

                    foreach (char item in templets[tempChoise])
                    {

                        Console.Write("-");
                    }
                    Console.Write("\nEnter The Start Index To Remove : ");
                    int strtindex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter The Number Of Charecters To Remove From Start : ");
                    int cntindex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toRemove(templets[tempChoise], strtindex, cntindex) + "\n");
                    TryAgain();

                    break;
                case 5:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toTrim(templets[tempChoise]) + "\n");
                    TryAgain();
                    break;
                case 6:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toTrimEnd(templets[tempChoise]) + "\n");
                    TryAgain();

                    break;

            }
        }
        #endregion

        public static void instring()
        {
            Console.Write("\n Here You Sould Enter Your Own String To Work With :) : ");
            string instr = Console.ReadLine();
            Console.WriteLine("\n Availble Methods : \n");
            string[] method = { "ToUpper", "ToLower", "Replace", "Remove", "Trim", "TrimEnd" };
            int methodChoise = 0;
            for (int i = 0; i < method.Length; i++)
            {
                Console.WriteLine(" {0} . {1}\n", i + 1, method[i]);
                if (i == method.Length - 1)
                {
                    Console.Write(" Your Choise : ");
                    methodChoise = Convert.ToInt32(Console.ReadLine());
                }

            }
            switch (methodChoise)
            {
                case 1:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toUpper(instr) + "\n");
                    TryAgain();
                    break;
                case 2:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toLower(instr) + "\n");
                    TryAgain();
                    break;
                case 3:
                    foreach (char item in instr)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine(instr);
                    foreach (char item in instr)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\n Enter The Word You want to replace : ");
                    char oldwrd = Convert.ToChar(Console.ReadLine());
                    Console.Write("\n Enter New Word : ");
                    char newwrd = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toReplace(instr, oldwrd, newwrd) + "\n");
                    TryAgain();
                    break;
                case 4:
                    foreach (char item in instr)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine("\n" + instr);

                    foreach (char item in instr)
                    {

                        Console.Write("-");
                    }
                    Console.Write("\nEnter The Start Index To Remove : ");
                    int strtindex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter The Number Of Charecters To Remove From Start : ");
                    int cntindex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toRemove(instr, strtindex, cntindex) + "\n");
                    TryAgain();
                    break;
                case 5:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toTrim(instr) + "\n");
                    TryAgain();
                    break;
                case 6:
                    Console.WriteLine("\n Result : \n");
                    Console.WriteLine(" " + toTrimEnd(instr) + "\n");
                    TryAgain();
                    break;

            }


        }

        public static void TryAgain()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write(" Do You Want To Try Again (Yes/No): ");
                String Try = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");
                if (!(Try.StartsWith("Y") || Try.StartsWith("N")))
                {
                    Console.WriteLine(" Try Again ! \n");
                }
                else if (Try.Equals("YES"))
                {
                    Body();
                    flag = false;
                }
                else if (Try.Equals("NO"))
                    flag = false;

            }

        }
        public static void about()
        {
            string about = "Developed By: ***SiliconPirate ***";
            foreach (char item in about)
            {
                Console.Write("-");
            }
            Console.Write("\n{0} \n", about);

            foreach (char item in about)
            {
                Console.Write("-");
            }
            back();
        }
        public static void back()
        {

            Console.WriteLine("\n Do You Want To Continue Or Quit :\n");
            Console.WriteLine(" 0 . Qiut \n");
            Console.WriteLine(" 1 . Continue ");

            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("\n Your Choise : ");
                    int AboutChoise = Convert.ToInt32(Console.ReadLine());
                    if (AboutChoise == 0)
                    {
                        Environment.Exit(0);
                        flag = false;
                    }
                    else if (AboutChoise == 1)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Body();
                        flag = false;
                    }
                    else if (!(AboutChoise == 0 || AboutChoise == 1))
                    {
                        Console.WriteLine("\n Try Again !");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n Wrong Enery , Just Numbers ! ");

                }

            }

        }

        #region Methods
        public static string toUpper(string inToUpper)
        {
            inToUpper = inToUpper.ToUpper();
            return inToUpper;
        }
        public static string toLower(string inTolower)
        {
            inTolower = inTolower.ToLower();
            return inTolower;
        }
        public static string toReplace(string inToReplace, char inToReplaceOldChar, char inToReplaceNew)
        {
            inToReplace = inToReplace.Replace(inToReplaceOldChar, inToReplaceNew);
            return inToReplace;
        }
        public static string toRemove(string inToRemoveString, int inToRemoveStartIndex, int inToRemoveCount)
        {
            inToRemoveString = inToRemoveString.Remove(inToRemoveStartIndex, inToRemoveCount);
            return inToRemoveString;

        }
        public static string toTrim(string inToTRim)
        {
            inToTRim = inToTRim.Trim();
            return inToTRim;
        }
        public static string toTrimEnd(string inToTrimEnd)
        {
            inToTrimEnd = inToTrimEnd.TrimEnd();
            return inToTrimEnd;
        }
        #endregion

    }
  }
