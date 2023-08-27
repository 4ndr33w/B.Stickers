using System;
using System.Text;

namespace B.Stickers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string sourceString = Console.ReadLine();
            string resultString = sourceString;

            int amountOfStickers = Convert.ToInt32(Console.ReadLine());
            string[] stickerList = new string[amountOfStickers];
            int[,] period = new int[amountOfStickers,2];

            string[] arrayToReplace = new string[amountOfStickers];

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(sourceString);

            for (int i = 0; i < amountOfStickers; i++) 
            {
                stickerList[i] = Console.ReadLine();
                var splitterString = stickerList[i].Split(' '); 
                period[i,0] = Convert.ToInt32(splitterString[0]);
                period[i, 1] = Convert.ToInt32(splitterString[1]);

                var lettersToReplace = stickerList[i].Substring(
               stickerList[i].LastIndexOf(
                   period[i, 1].ToString()
                   ) + period[i, 1].ToString().Length + 1).Replace(" ", "");
                resultString = resultString.Remove(period[i, 0] - 1, lettersToReplace.Length).
                    Insert(period[i, 0] - 1, lettersToReplace);
                arrayToReplace[i] = lettersToReplace;
            }
            Console.WriteLine(resultString);
        }
    }
}
