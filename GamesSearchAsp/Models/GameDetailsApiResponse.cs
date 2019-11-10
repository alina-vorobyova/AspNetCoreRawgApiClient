using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{

    public class GameDetailsApiResponse
    {
        public int id { get; set; }
        public string detail { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public object metacritic { get; set; }
        public string released { get; set; }
        public bool tba { get; set; }
        public DateTime updated { get; set; }
        public string background_image { get; set; }
        public string background_image_additional { get; set; }
        public string website { get; set; }
        public double rating { get; set; }
        public double rating_top { get; set; }
        public object[] ratings { get; set; }
        public object reactions { get; set; }
        public int added { get; set; }
        public Added_By_Status added_by_status { get; set; }
        public int playtime { get; set; }
        public int screenshots_count { get; set; }
        public int movies_count { get; set; }
        public int creators_count { get; set; }
        public int achievements_count { get; set; }
        public int parent_achievements_count { get; set; }
        public string reddit_url { get; set; }
        public string reddit_name { get; set; }
        public string reddit_description { get; set; }
        public string reddit_logo { get; set; }
        public int reddit_count { get; set; }
        public int twitch_count { get; set; }
        public int youtube_count { get; set; }
        public int reviews_text_count { get; set; }
        public int ratings_count { get; set; }
        public int suggestions_count { get; set; }
        public object[] alternative_names { get; set; }
        public string metacritic_url { get; set; }
        public int parents_count { get; set; }
        public int additions_count { get; set; }
        public int game_series_count { get; set; }
        public object user_game { get; set; }
        public int reviews_count { get; set; }
        public int community_rating { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public Parent_Platforms[] parent_platforms { get; set; }
        public Platform1[] platforms { get; set; }
        public Store[] stores { get; set; }
        public Developer[] developers { get; set; }
        public Genre[] genres { get; set; }
        public Tag[] tags { get; set; }
        public Publisher[] publishers { get; set; }
        public Esrb_Rating esrb_rating { get; set; }
        public Clip clip { get; set; }
        public string description_raw { get; set; }
    }


    public class Esrb_Rating
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }


    public class Requirements
    {
        public string minimum { get; set; }
        public string recommended { get; set; }
    }



   
    public class Developer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int games_count { get; set; }
        public string image_background { get; set; }
    }


    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string language { get; set; }
        public int games_count { get; set; }
        public string image_background { get; set; }
    }

    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int games_count { get; set; }
        public string image_background { get; set; }
    }

}
