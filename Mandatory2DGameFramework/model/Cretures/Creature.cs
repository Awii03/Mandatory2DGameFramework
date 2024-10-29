public class Creature
{
    public string Name { get; set; }
    public int HitPoints { get; set; }
    public List<AttackItem> AttackItems { get; set; }
    public List<DefenceObject> DefenceItems { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Creature(string name, int hitPoints, int x, int y)
    {
        Name = name;
        HitPoints = hitPoints;
        X = x;
        Y = y;
        AttackItems = new List<AttackItem>();
        DefenceItems = new List<DefenceObject>();
    }

    public void Hit(Creature target, int damage)
    {
        target.ReceiveHit(damage);
    }

    public void ReceiveHit(int damage)
    {
        int totalDamage = damage;
        foreach (var defence in DefenceItems)
        {
            totalDamage -= defence.ReduceHitPoint;
        }
        HitPoints -= Math.Max(0, totalDamage);
        if (HitPoints <= 0)
        {
            // Creature dies
        }
    }

    public void Loot(WorldObject obj)
    {
        // Code to pick up objects, e.g., add to inventory
    }
}
