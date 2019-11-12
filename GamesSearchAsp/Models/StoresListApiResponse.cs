using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{

    public class StoresListApiResponse
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public IEnumerable<StoresResult> results { get; set; }
    }

    public class StoresResult
    {
        public int id { get; set; }
        public int game_id { get; set; }
        public int store_id { get; set; }
        public string url { get; set; }
    }

}
