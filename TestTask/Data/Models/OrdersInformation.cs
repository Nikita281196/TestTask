using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Data.Models
{
    /// <summary>
    /// Информация о заказе
    /// </summary>
    public class OrdersInformation
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PhotolabId { get; set; }

        /// <summary>
        /// Пользовательский идентификатор
        /// </summary>
        public int CustomId { get; set; }

        /// <summary>
        /// Идентификатор исходного заказа
        /// </summary>
        public string SourceOrderId { get; set; }

        /// <summary>
        /// Идентификатор менеджера
        /// </summary>
        public string ManagerId { get; set; }

        /// <summary>
        /// Назначенный идентификатор
        /// </summary>
        public string AssignedToId { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// URL отслеживания
        /// </summary>
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Идентификационный номер
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Статус исполнения
        /// </summary>
        public string RenderStatus { get; set; }

        /// <summary>
        /// Статус платежа
        /// </summary>
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public DeliveryAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Перевозка
        /// </summary>
        public Shipping Shipping { get; set; }

        /// <summary>
        /// Количество комментариев
        /// </summary>
        public int CommentsCount { get; set; }

        /// <summary>
        /// Ссылка для скачивания
        /// </summary>
        public string DownloadLink { get; set; }

        /// <summary>
        /// URL изображения для предварительного просмотра
        /// </summary>
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Цена со скидкой
        /// </summary>
        public float DiscountPrice { get; set; }

        /// <summary>
        /// Цена доставки
        /// </summary>
        public float DeliveryPrice { get; set; }

        /// <summary>
        /// Окончательная цена
        /// </summary>
        public float TotalPrice { get; set; }

        /// <summary>
        /// Уплаченная цена
        /// </summary>
        public float PaidPrice { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Идентификатор учетной записи компании пользователя
        /// </summary>
        public string UserCompanyAccountId { get; set; }

        /// <summary>
        /// Название скидки
        /// </summary>
        public string DiscountTitle { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public string DateModified { get; set; }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        public string DatePaid { get; set; }

        /// <summary>
        /// Дата готовности
        /// </summary>
        public string DateReady { get; set; }

        /// <summary>
        /// Последний загруженный платежный документ
        /// </summary>
        public string LastDownloadedPaymentDocument { get; set; }

        /// <summary>
        /// Уникальный идентификатор платежной системы
        /// </summary>
        public string PaymentSystemUniqueId { get; set; }

        /// <summary>
        /// Идентификатор клиента Google
        /// </summary>
        public string GoogleClientId { get; set; }

        /// <summary>
        /// Заказы подрядчика
        /// </summary>
        public string ContractorOrders { get; set; }
    }
}
