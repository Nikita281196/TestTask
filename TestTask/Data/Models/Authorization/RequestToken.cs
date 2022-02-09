using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TestTask.Data.Models.Authorization
{
    /// <summary>
    /// Токен запроса
    /// </summary>
    public class RequestToken:Token
    {
        /// <summary>
        /// Получение токена запроса
        /// </summary>
        /// <param name="client">Web клиент</param>
        /// <returns>Токен запроса</returns>
        public string GetRequestToken(WebClient client)
        {
            string urlRequestToken = $"oauth/requesttoken";
            string jsonRequestToken = client.DownloadString(urlRequestToken);

            string receivedRequestToken = JsonConvert.DeserializeObject<RequestToken>(jsonRequestToken).RequestToken;
            return receivedRequestToken;
        }
    }
}
