using System;
using System.IO;
using System.Collections.Generic;

namespace src
{
    public class BFS
    {
        public static Queue<string> antrian = new Queue<string>();
        public static List<string> pengecekan = new List<string>();

        public static void Solve(string path, string filename)
        {
            string res = Process(path, filename);
            if (res == "")
            {
                Console.WriteLine("Tidak Ditemukan");
            }
            else
            {
                Console.Write("Ditemukan: ");
                Console.WriteLine(res);
            }
        }

        public static string Process(string pathfile, string filename)
        {
            Console.WriteLine("Root   : " + pathfile);
            Console.WriteLine("Target : " + filename + "\n");
            antrian.Enqueue(pathfile);
            string first;
            string[] dirs, files;
            string result = "";

            while (antrian.Count > 0)
            {
                first = antrian.Dequeue();
                files = Directory.GetFiles(first);

                foreach (string file in files)
                {
                    string[] splitFile = file.Split("\\");
                    pengecekan.Add(file);
                    if (splitFile[splitFile.Length - 1] == filename)
                    {
                        result = file;
                    }
                }

                dirs = Directory.GetDirectories(first);
                foreach (string dir in dirs)
                {
                    pengecekan.Add(dir);
                    antrian.Enqueue(dir);
                }

                if (result != "")
                {
                    return result;
                }
            }

            return result;
        }
    }

}
