using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Data.Models
{
    /// <summary>
    /// Резулльтат запроса информации о заказах
    /// </summary>
    public class OrdersRequestResult
    {
        /// <summary>
        /// Версия API
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Список заказов
        /// </summary>
        public List<OrdersInformation> Result { get; set; }

        /// <summary>
        /// Код результата
        /// </summary>
        public int ResponseCode { get; set; }
    }
}
