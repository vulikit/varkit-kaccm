using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Logging;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API;

namespace varkit_kaccm
{
    public class varkit_kaccm : BasePlugin, IPluginConfig<KaccmConfig>
    {
        public override string ModuleName => "varkit-kaccm";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "varkit";
        private Random random = new Random();
        public KaccmConfig Config { get; set; }
        public string prefix { get; set; }

        public void OnConfigParsed(KaccmConfig config)
        {
            Config = config;
            string secilenRenk = config.PrefixRenk;
            char renkKodu = renkler.ContainsKey(secilenRenk) ? renkler[secilenRenk] : ChatColors.Red;
            prefix = $" {renkKodu}{config.Prefix} ";
        }

        public override void Load(bool hotReload)
        {
            AddCommand("css_kaccm", "", OnKaccmCommand);

            Console.WriteLine(" ");
            Console.WriteLine("                  _    _ _ ");
            Console.WriteLine("                 | |  (_) |");
            Console.WriteLine(" __   ____ _ _ __| | ___| |_");
            Console.WriteLine(" \\ \\ / / _` | '__| |/ / | __|");
            Console.WriteLine("  \\ V / (_| | |  |   <| | |_");
            Console.WriteLine("   \\_/ \\__,_|_|  |_|\\_\\_|\\__|");
            Console.WriteLine("		>> Version: " + ModuleVersion);
            Console.WriteLine(" ");
        }

        private void OnKaccmCommand(CCSPlayerController? player, CommandInfo command)
        {
            if (player == null || !player.IsValid)
            {
                return;
            }
            int santimetre = random.Next(0, 32);
            string message = $"{ChatColors.Red}{prefix} {ChatColors.Lime}{player.PlayerName} {ChatColors.White}adlı kişinin malafatı {ChatColors.Magenta}{santimetre} {ChatColors.White}cm!";
            Server.PrintToChatAll(message);
        }

        public Dictionary<string, char> renkler = new()
        {
            { "Mavi", ChatColors.Blue },
            { "Mavi Gri", ChatColors.BlueGrey },
            { "Koyu Mavi", ChatColors.DarkBlue },
            { "Koyu Kırmızı", ChatColors.DarkRed },
            { "Varsayılan", ChatColors.Default },
            { "Altın", ChatColors.Gold },
            { "Yeşil", ChatColors.Green },
            { "Gri", ChatColors.Grey },
            { "Açık Mavi", ChatColors.LightBlue },
            { "Açık Mor", ChatColors.LightPurple },
            { "Açık Kırmızı", ChatColors.LightRed },
            { "Açık Sarı", ChatColors.LightYellow },
            { "Lime", ChatColors.Lime },
            { "Macenta", ChatColors.Magenta },
            { "Zeytin", ChatColors.Olive },
            { "Turuncu", ChatColors.Orange },
            { "Mor", ChatColors.Purple },
            { "Kırmızı", ChatColors.Red },
            { "Gümüş", ChatColors.Silver },
            { "Beyaz", ChatColors.White },
            { "Sarı", ChatColors.Yellow }
        };
    }
}