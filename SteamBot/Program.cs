using System;
using System.IO;
using System.Runtime.InteropServices;
using NDesk.Options;
using System.Windows.Forms;

namespace SteamBot
{
    public class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {

            if (!File.Exists("settings.json"))
            {
                Console.WriteLine("No settings.json file found.");
                return;
            }

            Configuration configObject;
            try
            {
                configObject = Configuration.LoadConfiguration("settings.json");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                // handle basic json formatting screwups
                Console.WriteLine("settings.json file is currupt or improperly formatted.");
                return;
            }

            if (configObject.Bots.Length > 0)
            {
                //Bot b = new Bot(configObject.Bots[botIndex], configObject.ApiKey, BotManager.UserHandlerCreator, true);
                BotControlForm frm = new BotControlForm(configObject.Bots[0], configObject.ApiKey, true);
                frm.ShowDialog();
                Application.Exit();
                
                //frm.StartBot();
                //Console.Title = configObject.Bots[botIndex].DisplayName;
                //b.StartBot(); // never returns from this.
            }
        }

    }
}
