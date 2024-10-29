
public class World
{
    public int MaxX { get; set; }
    public int MaxY { get; set; }
    public List<Creature> Creatures { get; set; }
    public List<WorldObject> WorldObjects { get; set; }

    public World(int maxX, int maxY)
    {
        MaxX = maxX;
        MaxY = maxY;
        Creatures = new List<Creature>();
        WorldObjects = new List<WorldObject>();
    }

    // Add methods to manage creatures and objects
    public void AddCreature(Creature creature)
    {
        Creatures.Add(creature);
    }

    public void AddWorldObject(WorldObject worldObject)
    {
        WorldObjects.Add(worldObject);
    }
}
