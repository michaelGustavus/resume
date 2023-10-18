using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC.RESUME.CORE.Extensions
{
    public static class Contract
    {
        /// <summary>Converts Entities to Contracts and vise versa.</summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static TResult
            ConvertTo<TResult, TSource>(this TSource source)
        {
            if (source == null)
                return default;



            var contract = (TResult)Activator.CreateInstance(typeof(TResult), null);



            var sourceType = source.GetType();
            var targetType = contract.GetType();



            foreach (var eaProperty in sourceType.GetProperties().Where(p => p.CanRead))
            {
                var targetProperty = targetType.GetProperties().Where(p => p.Name.Equals(eaProperty.Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (targetProperty == null)
                    continue;



                targetProperty.SetValue(contract, eaProperty.GetValue(source));
            }



            return contract;
        }
    }
}
