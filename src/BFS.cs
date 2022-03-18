using System;
using System.IO;
using System.Collections.Generic;

namespace src
{
    public class BFS
    {
        public static Queue<string> antrian = new Queue<string>();
        public static List<string> pengecekan = new List<string>();
        public static Dictionary<string, string> warnaPath = new Dictionary<string, string>();

        public static List<string> Solve(string pathfile, string filename, bool allOccur)
        {
            antrian.Enqueue(pathfile);
            string first;
            string[] dirs, files;
            List<string> result = new List<string>();

            while (antrian.Count > 0) {
                first = antrian.Dequeue();
                files = Directory.GetFiles(first);

                foreach (string file in files) {
                    string[] splitFile = file.Split("\\");
                    pengecekan.Add(file);
                    // File ditemukan
                    if (splitFile[splitFile.Length - 1] == filename) {
                        warnaPath.Add(file, "Blue");
                        splitFile = splitFile[..^1];
                        string folder = string.Join("\\", splitFile);
                        while (folder != pathfile)
                        {
                            if (warnaPath.ContainsKey(folder))
                                warnaPath[folder] = "Blue";
                            splitFile = splitFile[..^1];
                            folder = string.Join("\\", splitFile);
                        }
                        result.Add(file);
                    } else {
                        warnaPath.Add(file, "Red");
                    }
                }

                dirs = Directory.GetDirectories(first);
                foreach (string dir in dirs) {
                    pengecekan.Add(dir);
                    warnaPath.Add(dir, "Red");
                    antrian.Enqueue(dir);
                }

                if (result.Count > 0 && !allOccur) {
                    return result;
                }
            }

            return result;
        }
    }

}
