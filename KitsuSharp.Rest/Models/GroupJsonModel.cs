using System;
using KitsuSharp.Enums;
using KitsuSharp.Models;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("slug")]
        public string Slug;

        [JsonProperty("about")]
        public string About;

        [JsonProperty("locale")]
        public string Locale;

        [JsonProperty("membersCount")]
        public int MembersCount;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("nsfw")]
        public bool Nsfw;

        [JsonProperty("privacy")]
        public GroupPrivacy Privacy;

        [JsonProperty("rules")]
        public string Rules;

        [JsonProperty("rulesFormatted")]
        public string RulesFormatted;

        [JsonProperty("leadersCount")]
        public int LeadersCount;

        [JsonProperty("neighborsCount")]
        public int NeighborsCount;

        [JsonProperty("featured")]
        public bool Featured;

        [JsonProperty("tagline")]
        public string Tagline;

        [JsonProperty("lastActivityAt")]
        public DateTimeOffset LastActivityAt;

        [JsonProperty("avatar")]
        public ImageJsonModel Avatar;

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage;
    }
}