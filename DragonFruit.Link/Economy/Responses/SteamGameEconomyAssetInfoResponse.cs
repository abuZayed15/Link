﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamGameEconomyAssetInfoResponse : ISteamApiResponse
    {
        public IEnumerable<SteamGameEconomyAsset> Assets { get; set; }

        [JsonProperty("result")]
        private JObject AssetObject
        {
            set
            {
                //not part of the end result - it's a bool
                if (!(bool)value["success"])
                {
                    throw new SteamRequestFailedException();
                }

                value.Remove("success");

                var list = new List<SteamGameEconomyAsset>(value.Count);

                foreach (var item in value)
                {
                    list.Add(item.Value.ToObject<SteamGameEconomyAsset>());
                }

                Assets = list;
            }
            get => throw new NotSupportedException("Use Assets IEnumerable");
        }
    }
}
