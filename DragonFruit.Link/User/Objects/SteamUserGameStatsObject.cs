﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserGameStatsObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
