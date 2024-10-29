using System.Collections.Generic;
using System.Linq;

public class World
{
    private List<Creature> _creatures;

    public World(int width, int height)
    {
        _creatures = new List<Creature>();
        // Initialize the world with width and height
    }

    public void AddCreature(Creature creature)
    {
        _creatures.Add(creature);
    }

    public Creature GetCreatureByName(string name)
    {
        return _creatures.FirstOrDefault(c => c.Name == name);
    }
}