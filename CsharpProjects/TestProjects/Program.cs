int monster = 10;
int hero = 10;
Random value = new Random();

do
{
    int attack = value.Next(1, 11);
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

    if (monster <= 0) continue;

    attack = value.Next(1, 11);
    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

if (hero < 0)
{
    Console.WriteLine("Monster wins!");
}
else if (monster < 0)
{
    Console.WriteLine("Hero wins!");
}