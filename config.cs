using CounterStrikeSharp.API.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace varkit_kaccm
{
    public class KaccmConfig : BasePluginConfig
    {
        [JsonPropertyName("RenkKodlari")]
        public string RenkKodlari { get; set; } = "Renk kodlarina ulasmak icin discord sunucumdaki #renkler kanalindan bakiniz";

        [JsonPropertyName("Prefix")]
        public string Prefix { get; set; } = "⌈varkit⌋";

        [JsonPropertyName("PrefixRenk")]
        public string PrefixRenk { get; set; } = "Kırmızı";
    }
}
