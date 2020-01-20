using System;
using System.Collections.Generic;
using EnglishApp.Models;

namespace EnglishApp.StaticHelpers
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
