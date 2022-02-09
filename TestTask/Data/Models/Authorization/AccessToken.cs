using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Data.Models.Authorization
{
    /// <summary>
    /// Токен доступа
    /// </summary>
    public class AccessToken : Token
    {
        private static string password;

        /// <summary>
        /// Получение токена доступа
        /// </summary>
        /// <param name="publicKey">Публичный ключ</param>
        /// <param name="privateKey">Приватный ключ</param>
        /// <param name="client">Web клиент</param>
        /// <returns>Токен доступа</returns>
        public static string GetAccessToken(string publicKey, string privateKey, WebClient client)
        {
            RequestToken request = new();

            string reqToken = request.GetRequestToken(client);

            string concatRequestTokenAndSecretKey = reqToken + $"{privateKey}";

            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(concatRequestTokenAndSecretKey);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                password = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }

            string urlAccessToken = $"oauth/accesstoken?oauth_token={reqToken}&" +
                $"grant_type=api&" +
                $"username={publicKey}&" +
                $"password={password}";
            string jsonAccessToken = client.DownloadString(urlAccessToken);
            string receivedAccessToken = JsonConvert.DeserializeObject<AccessToken>(jsonAccessToken).AccessToken;
            return receivedAccessToken;
        }
    }
}
