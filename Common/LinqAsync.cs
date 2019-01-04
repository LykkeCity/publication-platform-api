using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common
{
    public static class LinqAsync
    {
        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this Task<IEnumerable<TIn>> src, Func<TIn, TOut> callback)
        {
            var result = await src;
            return result.Select(callback);
        }
        
    }
}