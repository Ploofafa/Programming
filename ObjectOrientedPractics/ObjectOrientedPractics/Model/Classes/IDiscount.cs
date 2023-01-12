using System;
using ObjectOrientedPractics.Model.Classes;

/// <summary>
/// Интерфейс для общей работы со скидками.
/// </summary>
public interface IDiscount
{
    /// <summary>
    /// Возвращает информацию о виде и размере скидки.
    /// </summary>
    string Info { get; }

    /// <summary>
    /// Метод считающий размер скидки на конкретный заказ.
    /// </summary>
    /// <param name="items">Список товаров в заказе.</param>
    /// <returns>Сумма скидки.</returns>
    double Calculate(List<Item> items);

    /// <summary>
    /// Метод применяющий скидку к заказу.
    /// </summary>
    /// <param name="items">Список товаров в заказе.</param>
    /// <returns>Возвращает новую стоимость заказа.</returns>
    double Apply(List<Item> items);

    /// <summary>
    /// Метод обновляющий информацию о возможных скидках.
    /// </summary>
    /// <param name="items">Список товаров в заказе.</param>
    void Update(List<Item> items);
}
