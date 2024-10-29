class Program
{
    static void Main(string[] args)
    {
        World world = new World(10, 10);

        Creature hero = new Creature("Hero", 100, 0, 0);
        world.AddCreature(hero);

        AttackItem sword = new AttackItem("Sword", 10, 1, 1, 1, true);
        DefenceObject shield = new DefenceObject("Shield", 5, 1, 1, true);

        hero.AttackItems.Add(sword);
        hero.DefenceItems.Add(shield);

        Creature enemy = new Creature("Enemy", 50, 2, 2);
        world.AddCreature(enemy);

        Console.WriteLine($"{enemy.Name} starts with {enemy.HitPoints} HP.");

        hero.Hit(enemy, sword.HitPoint);

        Console.WriteLine($"{enemy.Name} has {enemy.HitPoints} HP after being hit.");
    }
}
