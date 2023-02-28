using Microsoft.AspNetCore.Identity;

namespace webapiCall_HttpClient.Models
{
    public class PostData
    {

        public int userId { get; set; }
        public int Id { get; set; }
        public string title { get; set; } = "";
        public string body { get; set; } = "";


        List<PostData> data = new List<PostData>();
        public List<PostData> GetPostData()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //every calling environment, has a default data format for data, eg. chrome has default xml, ie6 has xml, edge has json, 

            client.DefaultRequestHeaders.Accept.Clear(); //clear the default
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            
            //make a call
            var call = client.GetAsync(url).Result;

            //check if the call is successful
            if (call.IsSuccessStatusCode)
            {
                var postDetails = call.Content.ReadAsAsync<List<PostData>>();
                postDetails.Wait();
                data = postDetails.Result;
                
            }
            else
            {
                throw new Exception("Call failed, please contact admin");
            }
            return data;
        }


    }
}
