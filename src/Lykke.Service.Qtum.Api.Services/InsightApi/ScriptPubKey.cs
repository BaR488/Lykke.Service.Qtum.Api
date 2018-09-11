﻿using Lykke.Service.Qtum.Api.Core.Domain.InsightApi;
using Newtonsoft.Json;

namespace Lykke.Service.Qtum.Api.Services.InsightApi
{
    public class ScriptPubKey : IScriptPubKey
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("asm")]
        public string Asm { get; set; }
    }
}
