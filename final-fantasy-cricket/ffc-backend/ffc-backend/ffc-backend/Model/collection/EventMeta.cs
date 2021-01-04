namespace ffc_backend.Model.collection
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Captain
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class ViceCaptain
    {
        public string label { get; set; }
        public double value { get; set; }
        public int points_earned { get; set; }
    }

    public class Starting11
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Runs
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Fours
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Sixes
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Thirty
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Fifty
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Century
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Duck
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Wkts
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Maiden
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Wkts4
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Wkts5
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Bonus
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Catch
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class Stumping
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class RunOutThrower
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class RunOutCatcher
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class StrikeRate6070
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class StrikeRate5060
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class StrikeRate150
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate04
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate45
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate56
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate910
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate1011
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EconRate11100
    {
        public string label { get; set; }
        public int value { get; set; }
        public int points_earned { get; set; }
    }

    public class EventMeta
    {
        public Captain captain { get; set; }
        public ViceCaptain vice_captain { get; set; }
        public Starting11 starting_11 { get; set; }
        public Runs runs { get; set; }
        public Fours fours { get; set; }
        public Sixes sixes { get; set; }
        public Thirty thirty { get; set; }
        public Fifty fifty { get; set; }
        public Century century { get; set; }
        public Duck duck { get; set; }
        public Wkts wkts { get; set; }
        public Maiden maiden { get; set; }
        public Wkts4 wkts4 { get; set; }
        public Wkts5 wkts5 { get; set; }
        public Bonus bonus { get; set; }
        public Catch @catch { get; set; }
        public Stumping stumping { get; set; }
        public RunOutThrower run_out_thrower { get; set; }
        public RunOutCatcher run_out_catcher { get; set; }
        public StrikeRate6070 strike_rate_60_70 { get; set; }
        public StrikeRate5060 strike_rate_50_60 { get; set; }
        public StrikeRate150 strike_rate_1_50 { get; set; }
        public EconRate04 econ_rate_0_4 { get; set; }
        public EconRate45 econ_rate_4_5 { get; set; }
        public EconRate56 econ_rate_5_6 { get; set; }
        public EconRate910 econ_rate_9_10 { get; set; }
        public EconRate1011 econ_rate_10_11 { get; set; }
        public EconRate11100 econ_rate_11_100 { get; set; }
    }

    //public class EventMeta
    //{
    //    [BsonId]
    //    [BsonRepresentation(BsonType.ObjectId)]
    //    public string _id { get; set; }
    //    public string meta_type { get; set; }
    //    public Meta meta { get; set; }
    //}
}
