


using Singleton;

var cache1 = MemoryCache.Instance;
var cache2  = MemoryCache.Instance;






cache1.Add("test", DateTime.Now);
Console.WriteLine(cache2.Get("test"));

Console.WriteLine(object.ReferenceEquals(cache1, cache2));  // ==> même référence mémoire

// A noter que l'implémentation du singleton comme ici viole l'un des principes SOLID
// le S : single respinsibility car ici,
//Memory cache a 2 responsabilités. La première est de gérer le cache
// la deuxième est de gérer sa propre durée de vie, son cycle.

// => pas recommandé  à la mano