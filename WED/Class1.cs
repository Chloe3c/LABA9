using System;

public class Coin
{
    private int nominal;
    private int quantity;

    public Coin(int nominal, int quantity)
    {
        this.nominal = nominal;
        this.quantity = quantity;
    }

    public string GetInformation()
    {
        return $"Номинал: {nominal}, Количество: {quantity}, Ответ: {CalculateTotal()}";
    }

    public int CalculateTotal()
    {
        return nominal * quantity;
    }
}