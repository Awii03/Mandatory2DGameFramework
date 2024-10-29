public class AttackItem : WorldObject
{
    public string Name { get; set; }
    public int HitPoint { get; set; }
    public int Range { get; set; }

    public AttackItem(string name, int hitPoint, int range, int x, int y, bool isRemovable)
        : base(x, y, isRemovable)
    {
        Name = name;
        HitPoint = hitPoint;
        Range = range;
    }
}
