using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous
{
    /// <summary>
    /// least recently used cache implementation
    /// </summary>
    public class LRUCache
    {
        private int _capacity; // capacity
        private Dictionary<int, (LinkedListNode<int> node, int value, int priority)> _cache; // cache
        private LinkedList<int> _list; // list of least recently used cache nodes

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _cache = new Dictionary<int, (LinkedListNode<int> node, int value, int priority)>(capacity);
            _list = new LinkedList<int>();
        }

        public int Get(int key)
        {
            if (!_cache.ContainsKey(key))
                return -1;

            var node = _cache[key];
            _list.Remove(node.node);
            _list.AddFirst(node.node);

            return node.value;
        }

        public void Put(int key, int value, int priority)
        {
            if (_cache.ContainsKey(key))
            {
                var node = _cache[key];

                _list.Remove(node.node);
                _list.AddFirst(node.node);

                _cache[key] = (node.node, value, priority);
            }
            else
            {
                if(_cache.Count >= _capacity)
                {
                    var removeKey = _list.Last!.Value;
                    _cache.Remove(removeKey);
                    _list.RemoveLast();
                }

                _cache.Add(key, (_list.AddFirst(key), value, priority));
            }
        }
    }
}
