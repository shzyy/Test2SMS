using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        internal class StreamReader
        {
            static void StreamReaderMeetod(string[] args)
            {
                Console.WriteLine("Kirjuta faili läbi konsooli");

                string filepath = @"C:/Users/opilane/Desktop/Tekst.txt";
                string inputText = Console.ReadLine();

                File.WriteAllText(filepath, inputText);
            }

        }

    }

