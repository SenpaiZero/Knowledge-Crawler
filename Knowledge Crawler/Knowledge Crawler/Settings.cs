using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Crawler
{
    class Settings
    {
        public static string server = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KnowledgeCrawlerDB.mdf;Integrated Security=True";
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
