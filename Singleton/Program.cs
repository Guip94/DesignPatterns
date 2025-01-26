


using Singleton;

var cache1 = MemoryCache.Instance;
var cache2  = MemoryCache.Instance;






cache1.Add("test", DateTime.Now);
Console.WriteLine(cache2.Get("test"));

Console.WriteLine(object.ReferenceEquals(cache1, cache2));  // ==> même référence mémoire

