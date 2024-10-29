public class DefenceObject : WorldObject
{
    public string Name { get; set; }
    public int ReduceHitPoint { get; set; }

    public DefenceObject(string name, int reduceHitPoint, int x, int y, bool isRemovable)
        : base(x, y, isRemovable)
    {
        Name = name;
        ReduceHitPoint = reduceHitPoint;
    }
}
