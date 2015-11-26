using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace HelloRestServices
{
    /// <summary>
    /// Retrievs data from REST service and provides it for binding.
    /// </summary>
    static class DataProvider
    {
        // The web page is http://www.panoramio.com/api/data/api.html

        const string ServerUrl = @"http://www.panoramio.com/map/get_panoramas.php";

        public static PanoramioData Get(int picturesCount)
        {
            RestClient client = new RestClient(ServerUrl);

            // Specify the get method
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("set", "public");
            request.AddParameter("from", 0);
            request.AddParameter("to", picturesCount);
            request.AddParameter("minx", -180);
            request.AddParameter("miny", -90);
            request.AddParameter("maxx", 180);
            request.AddParameter("maxy", 180);
            request.AddParameter("size", "medium");
            request.AddParameter("mapfilter", "true");

            // The request looks like http://www.panoramio.com/map/get_panoramas.php?set=public&from=0&to=20&minx=-180&miny=-90&maxx=180&maxy=90&size=medium&mapfilter=true

            var result = client.Execute<PanoramioData>(request);

            return result.Data;
        }
    }

    // Generate classes using json2csharp.com
    public class MapLocation
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public int panoramio_zoom { get; set; }
    }

    public class Photo
    {
        public int height { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int owner_id { get; set; }
        public string owner_name { get; set; }
        public string owner_url { get; set; }
        public string photo_file_url { get; set; }
        public int photo_id { get; set; }
        public string photo_title { get; set; }
        public string photo_url { get; set; }
        public string upload_date { get; set; }
        public int width { get; set; }
        public string place_id { get; set; }
    }

    public class PanoramioData
    {
        public int count { get; set; }
        public bool has_more { get; set; }
        public MapLocation map_location { get; set; }
        public List<Photo> photos { get; set; }
    }

}
