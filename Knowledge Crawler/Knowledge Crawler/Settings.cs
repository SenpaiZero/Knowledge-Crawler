using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Crawler
{
    class Settings
    {
        public static string server = "Data Source=(localdb)\\MSSQLLocalDB;Initial " +
            "Catalog=KnowledgeCrawlerDB;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 24;
            Height = 24;
            directions = "left";
        }


    }
}
