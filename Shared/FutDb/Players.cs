using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Soccer.Shared.FutDb
{
    //"name": "string",
    //"rating_min": 0,
    //"rating_max": 0,
    //"rating": 0,
    //"rarity": 0,
    //"position": "string",
    //"club": 0,
    //"league": 0,
    //"nation": 0,
    //"weak_foot": 0,
    //"skill_moves": 0
    public class PlayersRequest
    {
        [JsonPropertyName("league")]
        public int League { get; set; }     
    }

    public class Players : PageFutModel
    {
        [JsonPropertyName("items")]
        public List<Player> PlayerList { get; set; }
    }

    public partial class Player
    {
        public byte[] Image { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("resource_id")]
        public long ResourceId { get; set; }

        [JsonPropertyName("name")]
        public object Name { get; set; }

        [JsonPropertyName("age")]
        public long Age { get; set; }

        //[JsonPropertyName("resource_base_id")]
        //public long ResourceBaseId { get; set; }

        //[JsonPropertyName("fut_bin_id")]
        //public int? FutBinId { get; set; }

        //[JsonPropertyName("fut_wiz_id")]
        //public int? FutWizId { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("common_name")]
        public string CommonName { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }

        [JsonPropertyName("birth_date")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonPropertyName("league")]
        public long League { get; set; }

        [JsonPropertyName("nation")]
        public long Nation { get; set; }

        [JsonPropertyName("club")]
        public long Club { get; set; }

        [JsonPropertyName("rarity")]
        public long? Rarity { get; set; }

        [JsonPropertyName("traits")]
        public List<object> Traits { get; set; }

        [JsonPropertyName("specialities")]
        public List<object> Specialities { get; set; }

        [JsonPropertyName("tradeable")]
        public bool Tradeable { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("skill_moves")]
        public long SkillMoves { get; set; }

        [JsonPropertyName("weak_foot")]
        public long WeakFoot { get; set; }

        [JsonPropertyName("foot")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Foot Foot { get; set; }

        //[JsonPropertyName("attack_work_rate")]
        //public WorkRate AttackWorkRate { get; set; }

        //[JsonPropertyName("defense_work_rate")]
        //public WorkRate DefenseWorkRate { get; set; }

        //[JsonPropertyName("total_stats")]
        //public object TotalStats { get; set; }

        //[JsonPropertyName("total_stats_in_game")]
        //public object TotalStatsInGame { get; set; }

        [JsonPropertyName("rating")]
        public long Rating { get; set; }

        [JsonPropertyName("rating_average")]
        public long RatingAverage { get; set; }

        [JsonPropertyName("pace")]
        public long Pace { get; set; }

        [JsonPropertyName("shooting")]
        public long Shooting { get; set; }

        [JsonPropertyName("passing")]
        public long Passing { get; set; }

        [JsonPropertyName("dribbling")]
        public long Dribbling { get; set; }

        [JsonPropertyName("defending")]
        public long Defending { get; set; }

        [JsonPropertyName("physicality")]
        public long Physicality { get; set; }

        //[JsonPropertyName("pace_attributes")]
        //public PaceAttributes PaceAttributes { get; set; }

        //[JsonPropertyName("shooting_attributes")]
        //public ShootingAttributes ShootingAttributes { get; set; }

        //[JsonPropertyName("passing_attributes")]
        //public PassingAttributes PassingAttributes { get; set; }

        //[JsonPropertyName("dribbling_attributes")]
        //public DribblingAttributes DribblingAttributes { get; set; }

        //[JsonPropertyName("defending_attributes")]
        //public DefendingAttributes DefendingAttributes { get; set; }

        //[JsonPropertyName("physicality_attributes")]
        //public PhysicalityAttributes PhysicalityAttributes { get; set; }

        //[JsonPropertyName("goalkeeper_attributes")]
        //public GoalkeeperAttributes GoalkeeperAttributes { get; set; }
    }

    public enum WorkRate { High, Low, Med };

    public enum Foot { Left, Right };
    //public partial class DefendingAttributes
    //{
    //    [JsonPropertyName("interceptions")]
    //    public long Interceptions { get; set; }

    //    [JsonPropertyName("heading_accuracy")]
    //    public long HeadingAccuracy { get; set; }

    //    [JsonPropertyName("standing_tackle")]
    //    public long StandingTackle { get; set; }

    //    [JsonPropertyName("sliding_tackle")]
    //    public long SlidingTackle { get; set; }
    //}

    //public partial class DribblingAttributes
    //{
    //    [JsonPropertyName("agility")]
    //    public long Agility { get; set; }

    //    [JsonPropertyName("balance")]
    //    public long Balance { get; set; }

    //    [JsonPropertyName("reactions")]
    //    public long Reactions { get; set; }

    //    [JsonPropertyName("ball_control")]
    //    public long BallControl { get; set; }

    //    [JsonPropertyName("dribbling")]
    //    public long Dribbling { get; set; }

    //    [JsonPropertyName("composure")]
    //    public long Composure { get; set; }
    //}

    //public partial class GoalkeeperAttributes
    //{
    //    [JsonPropertyName("diving")]
    //    public long Diving { get; set; }

    //    [JsonPropertyName("handling")]
    //    public long Handling { get; set; }

    //    [JsonPropertyName("kicking")]
    //    public long Kicking { get; set; }

    //    [JsonPropertyName("positioning")]
    //    public long Positioning { get; set; }

    //    [JsonPropertyName("reflexes")]
    //    public long Reflexes { get; set; }
    //}

    //public partial class PaceAttributes
    //{
    //    [JsonPropertyName("acceleration")]
    //    public long Acceleration { get; set; }

    //    [JsonPropertyName("sprint_speed")]
    //    public long SprintSpeed { get; set; }
    //}

    //public partial class PassingAttributes
    //{
    //    [JsonPropertyName("vision")]
    //    public long Vision { get; set; }

    //    [JsonPropertyName("crossing")]
    //    public long Crossing { get; set; }

    //    [JsonPropertyName("free_kick_accuracy")]
    //    public long FreeKickAccuracy { get; set; }

    //    [JsonPropertyName("short_passing")]
    //    public long ShortPassing { get; set; }

    //    [JsonPropertyName("long_passing")]
    //    public long LongPassing { get; set; }

    //    [JsonPropertyName("curve")]
    //    public long Curve { get; set; }
    //}

    //public partial class PhysicalityAttributes
    //{
    //    [JsonPropertyName("jumping")]
    //    public long Jumping { get; set; }

    //    [JsonPropertyName("stamina")]
    //    public long Stamina { get; set; }

    //    [JsonPropertyName("strength")]
    //    public long Strength { get; set; }

    //    [JsonPropertyName("aggression")]
    //    public long Aggression { get; set; }
    //}

    //public partial class ShootingAttributes
    //{
    //    [JsonPropertyName("positioning")]
    //    public long Positioning { get; set; }

    //    [JsonPropertyName("finishing")]
    //    public long Finishing { get; set; }

    //    [JsonPropertyName("shot_power")]
    //    public long ShotPower { get; set; }

    //    [JsonPropertyName("long_shots")]
    //    public long LongShots { get; set; }

    //    [JsonPropertyName("volleys")]
    //    public long Volleys { get; set; }

    //    [JsonPropertyName("penalties")]
    //    public long Penalties { get; set; }
    //}
}
