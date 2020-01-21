using System;
using System.Collections.Generic;
using PhPopovich.Models;

namespace PhPopovich.StaticHelpers
{
    public static class DataHelper
    {
        public static IEnumerable<IEntity> GetList(Context context, Type type)
        {
            dynamic instance = Activator.CreateInstance(type);
            return context.GetDbSet(instance);
        }
    }
}
