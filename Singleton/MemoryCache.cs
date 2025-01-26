using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MemoryCache
    {
        private Dictionary<string, object> _cachedObjects;

        private static Lazy<MemoryCache> _cache = new(() => new MemoryCache());
        //private static Lazy<MemoryCache> _cache = new(() => new ());

        // Lazy fournit une Lazy initialisation 
        // CAD : permet de défibir la factory qui permet de créer une nouvelle instance de ce cache UNIQUEMENT
        // à partir du moment où j'en ai besoin
        public static MemoryCache Instance => _cache.Value;
        private  MemoryCache()
        {
        _cachedObjects = new();
            
        }

        public void Add(string key, object value) => _cachedObjects[key] = value;

        public object? Get (string key) 
        { 
            if (_cachedObjects.ContainsKey(key)) 
            { 
                return _cachedObjects[key];
            } 
            return null;
        }
    }
}
