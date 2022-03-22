using System;
using System.IO;
using System.Collections.Generic;

namespace src
{
    public class BFS
    {
        public static Queue<string> antrian = new Queue<string>();
        public static List<string> pengecekan = new List<string>();

        public static List<string> Solve(string pathfile, string filename, bool allOccur)
        {
            antrian.Enqueue(pathfile);
            string first;
            string[] dirs, files;
            List<string> result = new List<string>();

            // Iterasi pada antrian sesuai kaidah BFS
            while (antrian.Count > 0) {
                first = antrian.Dequeue();
                files = Directory.GetFiles(first);

                // Pengecekan file terlebih dahulu
                foreach (string file in files) {
                    string[] splitFile = file.Split("\\");
                    pengecekan.Add(file);
                    // File ditemukan
                    if (splitFile[splitFile.Length - 1] == filename)
                        result.Add(file);
                }

                // Pengecekan nama folder
                dirs = Directory.GetDirectories(first);
                foreach (string dir in dirs) {
                    pengecekan.Add(dir);
                    antrian.Enqueue(dir);
                }

                // Jika sudah ditemukan dan tidak mencari keseluruhan kemunculan
                if (result.Count > 0 && !allOccur) {
                    return result;
                }
            }

            return result;
        }
    }

}
