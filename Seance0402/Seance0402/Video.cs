using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Seance0402
{
    [Serializable]
    class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Video(int id, string title, string description, DateTime date)
        {
            Id = id;
            Title = title;
            Description = description;
            Date = date;
        }

        public static void Serialize(string fileName, Video v)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, v);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Serialization finished");
            }
        }

        public static Video Deserialize(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                var v = bf.Deserialize(fs);
                fs.Close();
                return v as Video;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tId = {Id};\n\tTitle = {Title};\n\tDescription = {Description};\n\tDate = {Date};\n}}";
        }
    }
}
