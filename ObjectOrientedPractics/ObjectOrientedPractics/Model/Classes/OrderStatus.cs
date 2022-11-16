namespace ObjectOrientedPractics.Model.Classes
{

    /// <summary>
    /// Содержит перечисление статуса заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}