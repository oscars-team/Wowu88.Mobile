using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Cache
{
    public class CacheByRedis : ICache
    {
        public T Read<T>(string key, long dbId = 0) where T : class
        {
            return RedisCache.Get<T>(key,dbId);
        }

        public void Remove(string key, long dbId = 0)
        {
            RedisCache.Remove(key,dbId);
        }

        public void RemoveAll(long dbId = 0)
        {
            RedisCache.RemoveAll(dbId);
        }

        public void Write<T>(string key, T value, long dbId = 0) where T : class
        {
            RedisCache.Set<T>(key,value,dbId);
        }

        public void Write<T>(string key, T value, DateTime expireTime, long dbId = 0) where T : class
        {
            RedisCache.Set<T>(key,value,expireTime,dbId);
        }
    }
}
