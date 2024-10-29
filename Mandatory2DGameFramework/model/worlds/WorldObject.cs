public abstract class WorldObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsRemovable { get; set; }

    public WorldObject(int x, int y, bool isRemovable)
    {
        X = x;
        Y = y;
        IsRemovable = isRemovable;
    }
}
