using Download_webpage_content_project;
using System;
namespace DownloadWebpageContent
{
    class main_class
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                user u =new user();
                Console.Write($"welcome MR {u.UserName} could you please paste the web page URL here to download the content:");
                string URL=string.Empty;
                try
                {
                     URL = Console.ReadLine();
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("invalid url");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("dividebyzeroexception");
                }
                catch (FormatException)
                {
                    Console.WriteLine("formatexeption");
                }
                List<char> content_of_chars = new List<char>();
                content_of_chars=convert_from_string_to_list(await ReadWebpageContentAsync(URL));
                content_of_chars.Sort();
                for (int i = 0; i <= 100; i++)
                {
                    if (i%10==0)
                    {
                        Console.WriteLine(i+"% ...");
                        Thread.Sleep(1000);
                    }
                }
                Console.WriteLine("the data has been downloaded successfully (:");
                Console.Write("\nfor exit press q on the keyboard\nto continue press any another key\n");
                var userinput = Console.ReadKey();
                if (userinput.Key == ConsoleKey.Q)
                    break;
            }
        }
        static List<char> convert_from_string_to_list(string str)
        {
            List<char> list = new List<char>(); 
            for (int i = 0; i < str.Length; i++)
            {
                list.Add(str[i]);
            }
            return list;
        }
        static async Task<string> ReadWebpageContentAsync(string url)
        {
            var clint = new HttpClient();
            var content = await clint.GetStringAsync(url);
            return content;
        }
    }
}