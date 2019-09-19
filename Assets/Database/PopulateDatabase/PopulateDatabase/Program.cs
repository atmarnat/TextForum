using System;
using System.IO;
using System.Text;

namespace PopulateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPosts = 1000;
            string[] posts = new string[numPosts];
            string path = @"C:\Users\wwstudent\Documents\posts.txt";

            for (int i = 0; i < numPosts; i++)
            {
                posts[i] = PostBuilder();
            }

            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllLines(path, posts, Encoding.UTF8);
            }

            foreach (var x in posts)
            {
                Console.WriteLine(x);
            }
        }

        static string PostBuilder()
        {
            Random topic = new Random();
            string message ="INSERT INTO Posts ( topicID, userID, created, content )\n";
            message +=     $"VALUES( {topic.Next(1,13)}, 1, GETDATE(), '{MessageBuilder()}');\n";
                       
            return message;
        }

        static string MessageBuilder()
        {
            Random messageSize = new Random();
            var chars = "AaBbCcDdEeFfGgHhIiJjKkHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz ,.'!";
            var message = new char[messageSize.Next(1, 254)];

            for (int i = 0; i < message.Length; i++)
            {
                message[i] = chars[messageSize.Next(chars.Length)];
            }

            return new String(message);
        }
    }
}
