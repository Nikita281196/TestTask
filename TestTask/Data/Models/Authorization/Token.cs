using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Data.Models.Authorization
{
    /// <summary>
    /// Абстрактный класс токена
    /// </summary>
    public abstract class Token
    {
        /// <summary>
        /// Токена запроса
        /// </summary>
        public string RequestToken { get; set; }

        /// <summary>
        /// Токен доступа
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Количество запросов с данными токенами
        /// </summary>
        public int Expires { get; set; }

        /// <summary>
        /// Токен обновления
        /// </summary>
        public string RefreshToken { get; set; }

        public string Scope { get; set; }

        /// <summary>
        /// Ошибка
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Успех
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Требование протокола SSL
        /// </summary>
        public bool RequireSsl { get; set; }
    }
}
