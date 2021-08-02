using System;
using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groups")]
    public class GroupJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("membersCount")]
        public int MembersCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("privacy")]
        public GroupPrivacy Privacy { get; set; }

        [JsonProperty("rules")]
        public string Rules { get; set; }

        [JsonProperty("rulesFormatted")]
        public string RulesFormatted { get; set; }

        [JsonProperty("leadersCount")]
        public int LeadersCount { get; set; }

        [JsonProperty("neighborsCount")]
        public int NeighborsCount { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("lastActivityAt")]
        public DateTimeOffset LastActivityAt { get; set; }

        [JsonProperty("avatar")]
        public ImageJsonModel Avatar { get; set; }

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage { get; set; }
    }
}