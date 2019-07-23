﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace TicTacToe
{
   public class Start
   {
        char Firstplaersumbol;
        static void Main(string[] args)
        {
            InitialScreen();
            Console.ReadKey(true);
        }
        static void InitialScreen()
        {
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            int initialСhoice;
            // Console.WriteLine("Введите порядковый номер дня недели:");
            Console.WriteLine("1)Играть");
            Console.WriteLine("2)Войти");
            Console.WriteLine("3)Настройки");
            initialСhoice = Convert.ToInt32(Console.ReadLine());
            switch (initialСhoice)
            {
                case 1:
                    Play.CreatePlayingField();
                    break;
                //case 2:
                //    CheckIn();
                //    break;
                //case 3:
                //    Options();
                //    break;
            }
        }        
   }
   public class Play
   {
        public static void CreatePlayingField()
        {
            PlayingField.field = new char[4, 4];
            while (true)
            {
                FullMove();
                PlayingField.CounterWins();
                PlayingField.FieldCleaning(PlayingField.field);
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        static void FullMove()
        {

            while (true)
            {
                Console.WriteLine("ход 1 игрока");
                PlayingField.PrintField(PlayingField.field);
                PlayersStep(PlayingField.field, 'X');
                Console.Clear();
                if (PlayingField.CheckWin('X') == true)
                {
                    Console.WriteLine("ход 1 игрока");
                    PlayingField.PrintField(PlayingField.field);
                    Console.WriteLine("Победа 1 игрока");
                    Console.ReadKey(true);
                    Console.Clear();
                    PlayingField.firstPlayerToWin++;
                    //Console.ReadKey(true);
                    break;
                }
                //Console.WriteLine("ход 2 игрока");
                //PlayingField.PrintField(PlayingField.field);
                //PlayersStep(PlayingField.field, 'O');
                //Console.Clear();
                //if (PlayingField.CheckWin('O') == true)
                //{
                //    Console.WriteLine("Победа 2 игрока");
                //    PlayingField.secondPlayerToWin++;
                //    break;
                //}
            }
        }
        static void PlayersStep(char[,] field, char plaerSumbol)//Принимает числа через пробел и указывает кординату X
        {
            Console.WriteLine("укажите столбик и ряд через пробел:");
            string s = Console.ReadLine();
            string[] array = s.Split(' ');
            int move2 = (Int32.Parse(array[0])) - 1;
            int move = (Int32.Parse(array[1])) - 1;
            field[move, move2] = plaerSumbol;
        }

   }
   public class Players
    {
        static string Name;
        static int KauntWin;



    }
   public class PlayingField
   {
        public static char[,] field;
        public static int firstPlayerToWin;
        public static int secondPlayerToWin;
        public static int width = 4;
       static int length = 4;
       public static void PrintField(char[,] field)//Доработаю
        {
            for (int t = 0; t < width; t++)
            {
                Console.Write(" |");
                for (int y = 0; y < length; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
        }
       public static void FieldCleaning(char[,] field)//Доработаю
       {
            for (int t = 0; t < width; t++)
            {
                for (int y = 0; y < length; y++)
                {
                    field[t, y] = ' ';
                }
            }          
        }
        public static bool CheckWin(char plaerSumbol)
        {
            int pastMeaningI;
            int pastMeaningP;

            for (int i = 2; i < 4; i++)
            {
                for (int p = 0; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[p, i - 2] == plaerSumbol && field[p, i - 1] == plaerSumbol && field[p, i] == plaerSumbol) { return true;  }// 3 в ряд
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[i - 2, p] == plaerSumbol && field[i - 1, p] == plaerSumbol && field[i, p] == plaerSumbol) { return true; }// 3  по вертикали                   
                }
                for (int p = 2; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[i - 2, p - 2] == plaerSumbol && field[i - 1, p - 1] == plaerSumbol && field[i, p] == plaerSumbol) { return true; }// 3  по диаганали
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[p - 2, i] == plaerSumbol && field[p - 1, i - 1] == plaerSumbol && field[p, i - 2] == plaerSumbol) { return true; }
                }
            }
            return false;
        }
        public static void CounterWins()
        {
            Console.WriteLine(firstPlayerToWin + " / " + secondPlayerToWin);
        }
    }
    public class register
    { 
        static void CheckIn()
        {
        //    Console.WriteLine("Имя главного игрока:");
        //    string mainPlayerName = Console.ReadLine();
        //    Console.WriteLine("Имя второго игрока:");
        //    string playerNameSecond = Console.ReadLine();
        //    FileStream file1 = new FileStream("E:\\Name\\" + mainPlayerName + ".txt", FileMode.OpenOrCreate); //создаем файловый поток
        //    StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
        //    writer.Write(width /*fieldSize*/); //записываем в файл
        //    writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        //    Console.WriteLine("Для возвращения в меню нажмите любую клавишу..");
        //    Console.ReadKey(true);
        //    Console.Clear();
        //    InitialScreen();
        //}
        //static void Options()
        //{
        //    Console.WriteLine("Выберите размер поля");
        //    width = length = UserInput();
        //    Console.WriteLine("Для возвращения в меню нажмите любую клавишу...");
        //    Console.ReadKey(true);
        //    Console.Clear();
        //    InitialScreen();
        }
    }
}
