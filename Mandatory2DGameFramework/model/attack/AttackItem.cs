public class AttackItem
{
    public string Name { get; private set; }
    public int HitPoint { get; private set; }
    public int Weight { get; private set; }
    public int Range { get; private set; }
    public int Durability { get; private set; }
    public bool IsEquipped { get; private set; }

    public AttackItem(string name, int hitPoint, int weight, int range, int durability, bool isEquipped)
    {
        Name = name;
        HitPoint = hitPoint;
        Weight = weight;
        Range = range;
        Durability = durability;
        IsEquipped = isEquipped;
    }
}