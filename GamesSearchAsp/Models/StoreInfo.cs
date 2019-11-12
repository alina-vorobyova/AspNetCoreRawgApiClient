using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{


    public class StoreInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string domain { get; set; }
        public string slug { get; set; }
        public int games_count { get; set; }
        public string image_background { get; set; }
        public string description { get; set; }
    }


    //public class AllStoresListApiResponse
    //{
    //    public int count { get; set; }
    //    public object next { get; set; }
    //    public object previous { get; set; }
    //    public IEnumerable<StoreInfo> results { get; set; }
    //    public string description { get; set; }
    //    public string seo_title { get; set; }
    //    public string seo_description { get; set; }
    //    public string seo_h1 { get; set; }
    //}

    //public class StoreInfo
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string domain { get; set; }
    //    public string slug { get; set; }
    //    public int games_count { get; set; }
    //    public string image_background { get; set; }
    //    //public Game[] games { get; set; }
    //    public bool following { get; set; }
    //}

    //    public class Game
    //    {
    //        public int id { get; set; }
    //        public string slug { get; set; }
    //        public string name { get; set; }
    //        public int added { get; set; }
    //    }

    //}

}