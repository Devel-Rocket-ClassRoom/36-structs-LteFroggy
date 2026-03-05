using InventoryItem;
using System;
using System.Threading.Channels;

Item[] items = new Item[] {
    new Item("검", 3.5, 1500),
    new Item("방패", 5.0, 1200),
    new Item("포션", 0.3, 50),
    new Item("활", 1.8, 1300),
    new Item("투구", 2.0, 800),
};

Console.WriteLine($"=== 인벤토리 목록 ===");
int count = 0;
double weightSum = 0;
int priceSum = 0;

int highestPrice = int.MinValue;
string maxPriceName = null;

double minWeight = double.MaxValue;
string minWeightName = null;

foreach (Item item in items) {
    Console.WriteLine($"{item.Name} - 무게 : {item.Weight}kg, 가격 : {item.Price}골드");
    count++;
    weightSum += item.Weight;
    priceSum += item.Price;

    if (minWeight > item.Weight) {
        minWeightName = item.Name;
        minWeight = item.Weight;
    }

    if (highestPrice <  item.Price) {
        maxPriceName = item.Name;
        highestPrice = item.Price;
    }
}
Console.WriteLine();
Console.WriteLine($"=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게 : {weightSum:F1}kg");
Console.WriteLine($"전체 가격 : {priceSum:N0}골드");
Console.WriteLine($"평균 가격 : {priceSum / count:N0}골드");
Console.WriteLine($"가장 비싼 아이템 : {maxPriceName}");
Console.WriteLine($"가장 가벼운 아아템 : {minWeightName}");
Console.WriteLine();
Console.WriteLine();