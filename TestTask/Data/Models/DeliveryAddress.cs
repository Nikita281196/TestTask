using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Data.Models
{
    /// <summary>
    /// Адрес доставки
    /// </summary>
    public class DeliveryAddress
    {
        /// <summary>
        /// Индекс
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Адрес 1
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Адрес 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
    }
}
