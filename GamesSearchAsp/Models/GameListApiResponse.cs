using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{

    public class GameListApiResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public IEnumerable<Game> results { get; set; }
        public bool user_platforms { get; set; }
    }

    public class Game
    {
        public string slug { get; set; }
        public string name { get; set; }
        public int playtime { get; set; }
        public IEnumerable<Platform> platforms { get; set; }
        public IEnumerable<Store> stores { get; set; }
        public string released { get; set; }
        public bool tba { get; set; }
        public string background_image { get; set; }
        public float rating { get; set; }
        public int rating_top { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
        public int ratings_count { get; set; }
        public int reviews_text_count { get; set; }
        public int added { get; set; }
        public Added_By_Status added_by_status { get; set; }
        public int? metacritic { get; set; }
        public int suggestions_count { get; set; }
        public int id { get; set; }
        public object score { get; set; }
        public Clip clip { get; set; }
        public object user_game { get; set; }
        public int reviews_count { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public IEnumerable<Short_Screenshots> short_screenshots { get; set; }
        public IEnumerable<Parent_Platforms> parent_platforms { get; set; }
        public Genre[] genres { get; set; }
    }

    public class Added_By_Status
    {
        public int yet { get; set; }
        public int owned { get; set; }
        public int beaten { get; set; }
        public int toplay { get; set; }
        public int dropped { get; set; }
        public int playing { get; set; }
    }

    public class Clip
    {
        public string clip { get; set; }
        public Clips clips { get; set; }
        public string preview { get; set; }
    }

    public class Clips
    {
        public string _320 { get; set; }
        public string _640 { get; set; }
        public string full { get; set; }
    }

    public class Platform
    {
        public Platform1 platform { get; set; }
    }

    public class Platform1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Store
    {
        public Store1 store { get; set; }
    }

    public class Store1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Rating
    {
        public int id { get; set; }
        public string title { get; set; }
        public int count { get; set; }
        public float percent { get; set; }
    }

    public class Short_Screenshots
    {
        public int id { get; set; }
        public string image { get; set; }
    }

    public class Parent_Platforms
    {
        public Platform2 platform { get; set; }
    }

    public class Platform2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

}
