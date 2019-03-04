using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Cache
{
    public class RedisCache
    {
        //缓存创建
        private static PooledRedisClientManager CreateManager(long dbId)
        {
            AppConfiguration config = new AppConfiguration();
            string[] WriteList = config.WriteServerList.Split(",");
            string[] ReadList = config.ReadSeverList.Split(",");
            return new PooledRedisClientManager(WriteList, ReadList, new RedisClientManagerConfig
            {
                MaxWritePoolSize = config.MaxWritePoolSize,
                MaxReadPoolSize=config.MaxReadPoolSize,
                AutoStart = true,
                DefaultDb = dbId
            });
        }
        //缓存实例获取
        private static PooledRedisClientManager GetClientManager(long dbId)
        {
             return CreateManager(dbId);
        }
        //设置缓存
        public static bool Set<T>(string key, T value, long dbId = 0)
        {
            var clientManager = GetClientManager(dbId);
            IRedisClient redis = clientManager.GetClient();
            var res = redis.Set<T>(key, value);
            clientManager.DisposeClient((RedisNativeClient)redis);
            redis.Dispose();
            clientManager.Dispose();
            return res;
        }

        public static bool Set<T>(string key, T value, DateTime dateTime, long dbId = 0)
        {
            var clientManager = GetClientManager(dbId);
            IRedisClient redis = clientManager.GetClient();
            var res = redis.Set<T>(key, value, dateTime);
            clientManager.DisposeClient((RedisNativeClient)redis);
            redis.Dispose();
            clientManager.Dispose();
            return res;
        }


        public static T Get<T>(string key, long dbId = 0) where T : class
        {
            var clientManager = GetClientManager(dbId);
            IRedisClient redis = clientManager.GetClient();
            var res = redis.Get<T>(key);
            clientManager.DisposeClient((RedisNativeClient)redis);
            redis.Dispose();
            clientManager.Dispose();
            return res;
        }

        public static bool Remove(string key, long dbId = 0)
        {
            var clientManager = GetClientManager(dbId);
            IRedisClient redis = clientManager.GetClient();
            var res = redis.Remove(key);
            clientManager.DisposeClient((RedisNativeClient)redis);
            redis.Dispose();
            clientManager.Dispose();
            return res;
        }

        public static void RemoveAll(long dbId = 0)
        {
            var clientManager = GetClientManager(dbId);
            IRedisClient redis = clientManager.GetClient();
            redis.FlushDb();
            clientManager.DisposeClient((RedisNativeClient)redis);
            redis.Dispose();
            clientManager.Dispose();
        }

        //添加列表
        public static void List_Add<T>(string key, T value, long dbId = 0)
        {
            using (IRedisClient redis = CreateManager(dbId).GetClient())
            {
                var redisTypedClient = redis.As<T>();
                redisTypedClient.AddItemToList(redisTypedClient.Lists[key], value);
            }
        }
        //移除列表中的某个值
        public static bool List_Remove<T>(string key, T value, long dbId = 0)
        {
            using (IRedisClient redis = CreateManager(dbId).GetClient())
            {
                var redisTypedClient = redis.As<T>();
                return redisTypedClient.RemoveItemFromList(redisTypedClient.Lists[key], value) > 0;
            }
        }
        //移除列表中所有值
        public static void List_RemoveAll<T>(string key, long dbId = 0)
        {
            using (IRedisClient redis = CreateManager(dbId).GetClient())
            {
                var redisTypedClient = redis.As<T>();
                redisTypedClient.Lists[key].RemoveAll();
            }
        }

        //获取列表数据的条数
        public static long list_Count(string key, long dbId = 0)
        {
            using (IRedisClient redis = CreateManager(dbId).GetClient())
            {
                return redis.GetListCount(key);
            }
        }

        //获取列表所有数据
        public static List<T> GetList<T>(string key, long dbId = 0)
        {
            using (IRedisClient redis = CreateManager(dbId).GetClient())
            {
                var c = redis.As<T>();
                return c.Lists[key].GetRange(0, c.Lists[key].Count);
            }
        }

        public static List<T> List_GetRange<T>(string key,int start,int count,long dbId=0) {
            using (IRedisClient redis=CreateManager(dbId).GetClient()) {
                var res=redis.As<T>();
                return res.Lists[key].GetRange(start,start+count-1);
            }

        }

        public static List<T> List_GetList<T>(string key, int pageIndex, int pageSize, long dbId = 0) {
            int start = pageSize * (pageIndex - 1);
            return List_GetRange<T>(key,start,pageSize,dbId);
        }

    }
}
