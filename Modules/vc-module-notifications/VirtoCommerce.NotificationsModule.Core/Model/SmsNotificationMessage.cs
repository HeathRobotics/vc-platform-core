namespace VirtoCommerce.NotificationsModule.Core.Model
{
    /// <summary>
    /// Sms - Kind of message notification
    /// </summary>
    public class SmsNotificationMessage : NotificationMessage
    {
        /// <summary>
        /// Number of recipient Sms notification
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Message of Sms Notification
        /// </summary>
        public string Message { get; set; }
    }
}
