using HungryNinjaAssign;

Buffet buffet = new Buffet();
Ninja me = new Ninja();
Console.WriteLine(buffet.Serve().Name);
me.Eat(buffet.Serve());
Console.WriteLine(buffet.Serve().Name);
me.Eat(buffet.Serve());
Console.WriteLine(buffet.Serve().Name);
me.Eat(buffet.Serve());
Console.WriteLine(buffet.Serve().Name);
me.Eat(buffet.Serve());
Console.WriteLine(buffet.Serve().Name);
me.Eat(buffet.Serve());