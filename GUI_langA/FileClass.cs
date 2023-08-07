using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class FileClass
    {
        public static string path = Directory.GetCurrentDirectory();
        public string ToTranslate { get; set; } = "toTranslate.csv";
        public string Translated { get; set; } = "translated.csv";
        // Checks if a file exists
        public static bool FileExists(string file)
        {
            string filePath = Path.Combine(path, file);

            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Creates a file
        public static void CreateFile(string file)
        {
            bool toCreateFile = FileExists(file);
            if (!toCreateFile)
            {
                string filePath = Path.Combine(path, file);
                using (FileStream fs = File.Create(filePath)){ }

                Console.WriteLine($"Following file is created: {file}");
            }
        }

        public List<string> ReadListFromFile(string file)
        {
            string filePath = Path.Combine(path, file);
            List<string> existingData = new List<string>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();

                List<string> data = line?.Split(',').ToList() ?? new List<string>();

                existingData.AddRange(data);
            }

            return existingData;
        }

        public int findIndex(string file, string data)
        {
            int index = ReadListFromFile(file).FindIndex(a => a.Equals(data));

            return index;
        }

        public void AddDataFile(string newData, string file)
        {
            string filePath = Path.Combine(path, file);
            List<string> existingData = ReadListFromFile(file);

            existingData.Add(newData);

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                if (existingData.Count != 0)
                {
                    string line = string.Join(",", existingData);
                    writer.WriteLine(line);
                }
            }

        }
        public bool removeData(string data)
        {
            string existingDataToTranslate = Path.Combine(path, ToTranslate);
            string existingDataTranslated = Path.Combine(path, Translated);
            List<string> existingTranslatedData = ReadListFromFile(Translated);
            List<string> existingToTranslateData = ReadListFromFile(ToTranslate);

            int check = findIndex(existingDataToTranslate, data);
            if (check == -1)
            {
                check = findIndex(existingDataTranslated, data);
                if (check == -1)
                {
                    return false;
                }
                else
                {
                    existingTranslatedData.RemoveAt(check);
                    using (StreamWriter writer = new StreamWriter(existingDataTranslated, false))
                    {
                        if (existingTranslatedData.Count != 0)
                        {
                            string line = string.Join(",", existingTranslatedData);
                            writer.WriteLine(line);
                        }
                    }
                    existingToTranslateData.RemoveAt(check);
                    using (StreamWriter writer = new StreamWriter(existingDataToTranslate, false))
                    {
                        if (existingToTranslateData.Count != 0)
                        {
                            string line = string.Join(",", existingToTranslateData);
                            writer.WriteLine(line);
                        }
                    }

                    return true;
                }
            }
            existingToTranslateData.RemoveAt(check);
            using (StreamWriter writer = new StreamWriter(existingDataToTranslate, false))
            {
                if (existingToTranslateData.Count != 0)
                {
                    string line = string.Join(",", existingToTranslateData);
                    writer.WriteLine(line);
                }
            }
            existingTranslatedData.RemoveAt(check);
            using (StreamWriter writer = new StreamWriter(existingDataTranslated, false))
            {
                if (existingTranslatedData.Count != 0)
                {
                    string line = string.Join(",", existingTranslatedData);
                    writer.WriteLine(line);
                }
            }
            return true;
        }
    }
}
