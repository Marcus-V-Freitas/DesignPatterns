using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Outros
{
    public class ObjectPool<T> where T:new()
    {
        private static List<T> _available = new List<T>();
        private static List<T> _use = new List<T>();
        private static readonly int _max=3;

        private static readonly ObjectPool<T> _instance = new ObjectPool<T>();

        private ObjectPool() { }

        public static ObjectPool<T> Instance
        {
            get { return _instance; }
        }

        public T GetObject()
        {
            T obj;
            if (_available.Count > 0)
            {
                obj = _available[0];
                _available.Remove(obj);
                _use.Add(obj);
            }
            else
            {
                if (_use.Count<_max)
                {
                    obj = new T();
                    _use.Add(obj);
                }
                else
                {
                    throw new PoolException($"Limite máximo de {_max} instâncias atingido.");
                }

            }
            return obj;
        }

        public void Release(T obj)
        {
            Clear(obj);
            _use.Remove(obj);
            _available.Add(obj);
        }

        private void Clear(T obj)
        {
            obj = default(T);
        }
    }

    public class PoolException : Exception
    {
        public PoolException(string message) : base(message) { }
    }
}
