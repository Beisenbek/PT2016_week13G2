using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example1
{
    class Program
    {

        static Dictionary<string, string[]> data = new Dictionary<string, string[]>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                string name = Console.ReadLine().ToLower();

                if (!data.ContainsKey(name))
                {
                    Console.WriteLine("online:");

                    string url = string.Format("http://www.kazhydromet.kz/rss-pogoda.php?id={0}", name);

                    XmlReader reader = XmlReader.Create(url);

                    SyndicationFeed feed = SyndicationFeed.Load(reader);

                    reader.Close();

                    if (feed.Items.Count() > 0)
                    {
                        string text = feed.Items.ElementAt(0).Summary.Text;

                        string[] arr = text.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries);

                        if (arr.Length >= 4)
                        {
                            for (int i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = arr[i].Trim();
                            }

                            data[name] = arr;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data not found!");
                    }
                }
                else
                {
                    Console.WriteLine("offline:");
                }

                Console.WriteLine(data[name][0]);
            }
        }
    }
}
