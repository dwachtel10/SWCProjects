using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSystemDotIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWindowsDirectoryInfo();
            ModifyDirectory();
            //RemoveDirectory();
            ListDrives();
            ListDriveInfo();
            SimpleFileIO();
            FileStreamMethod();
            StreamReaderWriter();
            MoveFile();

            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            Console.WriteLine("<= Directory Info");

            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\System32");

            Console.WriteLine($"FullName = {dir.FullName}");
            Console.WriteLine($"Name = {dir.Name}");
            Console.WriteLine($"Parent = {dir.Parent}");
            Console.WriteLine($"Creation = {dir.CreationTime}");
            Console.WriteLine($"Attributes = {dir.Attributes}");
            Console.WriteLine($"Root = {dir.Root}");

            Console.WriteLine();
        }

        static void ModifyDirectory()
        {
            Console.WriteLine("<= Modify Directory");

            DirectoryInfo dir = new DirectoryInfo(".");

            Console.WriteLine($"Current Directory is {dir.FullName}");

            DirectoryInfo subDir = dir.CreateSubdirectory("MyFolder");

            Console.WriteLine($"Sub Directory is {subDir.FullName}");

            Console.WriteLine();
        }

        static void RemoveDirectory()
        {
            Console.WriteLine("<= Remove Directory");

            try
            {
                DirectoryInfo dir = new DirectoryInfo(@".\MyFolder");
                dir.Delete();
            }
            catch (DirectoryNotFoundException dnfex)
            {
                Console.WriteLine($"Directory not there - {dnfex.Message}");
            }

            Console.WriteLine();
        }

        static void ListDrives()
        {
            Console.WriteLine("<= List Drives");

            var drives = Directory.GetLogicalDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine();
        }

        static void ListDriveInfo()
        {
            Console.WriteLine("<= Drive Info");

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(var drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Free Space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Format: {drive.DriveFormat}");
                    Console.WriteLine($"Label: {drive.VolumeLabel}");
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void SimpleFileIO()
        {
            Console.WriteLine("<= Simple File I/O");

            string[] myTasks =
            {
                "Finish Battleship",
                "Rock, Paper Scissors",
                "Design Banking",
                "Do Talk Techs",
                "Take Quizzes",
                "LINQ Exercises"
            };

            File.WriteAllLines(@".\tasks.txt", myTasks);

            foreach (var task in File.ReadAllLines(@".\tasks.txt"))
            {
                Console.WriteLine($"TODO: {task}");
            }

            Console.WriteLine();
        }

        static void FileStreamMethod()
        {
            Console.WriteLine("<= File Stream Method");

            using (FileStream fs = File.Open(@"mymessages.dat", FileMode.Create))
            {
                // this is what I want to write
                // file stream makes me write the bytes
                string msg = "Hello!";
                byte[] msgAsBytes = Encoding.Default.GetBytes(msg);

                // write file output
                fs.Write(msgAsBytes, 0, msgAsBytes.Length);

                // move the file cursor back to the start
                // this way we can read...
                fs.Position = 0;

                // read the file one byte at a time
                byte[] bytesFromFile = new byte[msgAsBytes.Length];
                for (int i = 0; i < msgAsBytes.Length; i++)
                {
                    bytesFromFile[i] = (byte)fs.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }

                Console.WriteLine();

                // write the whole file
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }

            Console.WriteLine();
        }

        static void StreamReaderWriter()
        {
            Console.WriteLine("<= Stream Reader/Writer");

            using (StreamWriter sw = File.CreateText("reminders.txt"))
            {
                sw.WriteLine("Don't forget your anniversary");
                sw.WriteLine("Don't forget you Birthday!");
                sw.WriteLine("Don't forget these numbers");
                for(int i = 0; i< 10; i++)
                {
                    sw.Write(i + " ");
                }

                sw.Write(sw.NewLine);
            }

            using(StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine();
        }

        static void MoveFile()
        {
            Console.WriteLine("<= Move File");

            string fileName = "reminders.txt";
            File.Move(fileName, "MyFolder//" + fileName);

            Console.WriteLine();
        }
    }
}
