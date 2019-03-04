using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Cache
{
    public interface ICache
    {
        //读取缓存
        T Read<T>(string key,long dbId=0) where T : class;
        //写入缓存
        void Write<T>(string key, T value, long dbId=0) where T : class;
        //能是指缓存到期时间
        void Write<T>(string key, T value, DateTime expireTime, long dbId=0) where T : class;

        void Remove(string key, long dbId=0);

        void RemoveAll(long dbId=0);
    }
}
