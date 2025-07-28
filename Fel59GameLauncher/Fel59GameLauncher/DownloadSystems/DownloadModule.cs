using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEngine.Core.EngineCoreSystems;
using MEngine.Core.ModuleSystems;

namespace Downloader
{
    public class DownloadModule : Module
    {
        public Dictionary<uint, GameStatus> Games = new Dictionary<uint, GameStatus>();
        public List<uint> GameIds = new List<uint>();
        
        public bool IgnoreNet;

        public string curentVertion;
        public int curentImageVertion;

        public override void Initialize()
        {
            base.Initialize();

            GameInstance.EventBus.SubscribeEvent("download_information_for_download_information", Data => downloadInfo());

            GameInstance.EventBus.Publish("start_loading_screen_full", "Receving information");

            getInfo();

            GameInstance.EventBus.Publish("stop_loading_screen_full", "Reciveing information");
        }

        private void getInfo()
        {
            if (!File.Exists("Resorses\\Resorses.txt"))
                downloadInfo();
            string[] res = readFile("Resorses\\Resorses.txt");

            foreach (string s in res) {
                string[] format = s.Split();
                if (format[0] == "ImageVersion")
                {
                    if (curentImageVertion != 0)
                    {
                        if (int.TryParse(format[0], out int ImageVertion)) {
                            if (curentImageVertion != ImageVertion)
                                downloadImages();
                            curentImageVertion = ImageVertion;
                        }
                    }
                }
            }

            string[] gameResorces = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Resorses", "*.felres");

            foreach(string GameresFile in gameResorces)
            {
                if (File.Exists(GameresFile))
                {
                    GameStatus g = new GameStatus();
                    string[] resg = readFile(GameresFile);

                    foreach (string s in resg)
                    {
                        string[] format = s.Split();
                        if (format[0] == "name")
                        {
                            g.name = format[1];
                        }
                        if (format[0] == "latestVersion")
                        {
                            if(g.curentVersion == "")
                            {
                                g.curentVersion = format[1];
                            }
                            else
                            {
                                g.latestVersion = format[1];
                                if(g.latestVersion != g.curentVersion)
                                    g.avalebleUpdate = true;
                            }
                        }
                        if (format[0] == "backgroundImage")
                        {
                            g.latestVersion = format[1];
                        }
                        if (format[0] == "description")
                        {

                        }
                        if (format[0] == "author")
                        {

                        }
                        if (format[0] == "githubDownload")
                        {

                        }
                        if (format[0] == "execution")
                        {

                        }
                    }
                }
            }
        }

        private string[] readFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            return new string[0];
        }

        private void downloadInfo()
        {
            GameInstance.EventBus.Publish("popup_prompt_yes_no");
        }

        private void downloadImages()
        {

        }

        private void runGame()
        {

        }

        private void downloadGame()
        {

        }
    }

    public enum GameInstallStatus
    {
        Uninstaled,
        UpToDate,
        NeedsUpdate,
        Updating,
        Faild
    }

    public class GameStatus
    {
        public string name = "";
        public string version = "";
        public string[] description;
        public string[] author;
        public string latestVersion = "";
        public string curentVersion = "";
        public string backgroundImage = "";
        public bool avalebleUpdate;
    }
}
