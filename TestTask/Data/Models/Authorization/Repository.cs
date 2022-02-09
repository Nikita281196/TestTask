using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Data.Models.Authorization
{
    public class Repository
    {
        static WebClient client;
        public static string Authorization(string publicKey, string privateKey)
        {
            client = new WebClient() { Encoding = Encoding.UTF8, BaseAddress = @"http://api.pixlpark.com" };
            string AccessTokenResult = AccessToken.GetAccessToken(publicKey, privateKey, client);
            return AccessTokenResult;
        }

        public static OrdersRequestResult SendARequestForAListOfOrders(string accessToken, int userId)
        {
            string urlOrders = $"orders?oauth_token={accessToken}&userId={userId}";
            string jsonOrders = client.DownloadString(urlOrders);

            var orders = JsonConvert.DeserializeObject<OrdersRequestResult>(jsonOrders);
            return orders;
        }
    }
}
