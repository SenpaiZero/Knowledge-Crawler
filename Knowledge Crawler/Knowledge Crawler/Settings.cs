using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Crawler
{
    class Settings
    {
        public static string server = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KnowledgeCrawlerDB.mdf;Integrated Security=True";
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public static bool music { get; set; }
        public static bool clickSfx { get; set; }
        public static bool gameSfx { get; set; }

        
        static bool isPlaying = false;
        static SoundPlayer bgMusic = new SoundPlayer(Properties.Resources.bgForm);

        static WaveOutEvent menuPlayer = new WaveOutEvent();
        static Stream menuMem = Properties.Resources.hitHurt;
        static WaveFileReader menuReader = new WaveFileReader(menuMem);
        static WaveChannel32 hitChannel = new WaveChannel32(menuReader);

        public static bool isFirst = true;
        public Settings()
        {
            Width = 24;
            Height = 24;
            directions = "left";
        }
        public static void playBg()
        {
            try
            {
                if (isPlaying)
                    return;

                isPlaying = true;
                bgMusic.PlayLooping();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void stopBg()
        {
            try
            {
                if (!isPlaying)
                    return;
                isPlaying = false;
                bgMusic.Stop();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool init = false;
        public static void playMenuSelect()
        {
            if (!clickSfx)
                return;
            try
            {
                Task.Run(() => {
                    if (!init)
                        menuPlayer.Init(hitChannel); init = true;
                    menuReader.Position = 0;
                    menuPlayer.Play();
                });
                
                Thread.Sleep(60);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
