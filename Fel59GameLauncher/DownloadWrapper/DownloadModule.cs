using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEngine.Core.ModuleSystems;

namespace Downloader
{
    public static class DownloadModule : 
    {
        public static Dictionary<uint, GameStatus> Games = new Dictionary<uint, GameStatus>();
        public static List<uint> GameIds = new List<uint>();
        
        public static bool IgnoreNet;

        public static void Iniztelize()
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
        public string backgroundImage = "";
    }
}
