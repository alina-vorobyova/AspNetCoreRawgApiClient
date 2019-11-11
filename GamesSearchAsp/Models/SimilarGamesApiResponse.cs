using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{

    public class SimilarGamesApiResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public IEnumerable<Result> results { get; set; }
        public DateTime updated { get; set; }
        public string seo_text { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string released { get; set; }
        public bool tba { get; set; }
        public string background_image { get; set; }
        public float rating { get; set; }
        public int rating_top { get; set; }
        public Rating[] ratings { get; set; }
        public int ratings_count { get; set; }
        public int reviews_text_count { get; set; }
        public int added { get; set; }
        public Added_By_Status added_by_status { get; set; }
        public int metacritic { get; set; }
        public int playtime { get; set; }
        public int suggestions_count { get; set; }
        public object user_game { get; set; }
        public int reviews_count { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public Platform[] platforms { get; set; }
        public Parent_Platforms[] parent_platforms { get; set; }
        public Genre[] genres { get; set; }
        public Store[] stores { get; set; }
        public Clip clip { get; set; }
        public Short_Screenshots[] short_screenshots { get; set; }
        public string short_description { get; set; }
    }

   

    public class Requirements_En
    {
        public string minimum { get; set; }
        public string recommended { get; set; }
    }

    public class Requirements_Ru
    {
        public string minimum { get; set; }
        public string recommended { get; set; }
    }

   
}
