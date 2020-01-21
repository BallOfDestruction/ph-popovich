using System;
using System.Linq.Expressions;

namespace PhPopovich.EntityFrameworkPaginateCore
{
    internal class Filter<T>
    {
        public bool Condition { get; set; }
        public Expression<Func<T, bool>> Expression { get; set; }
    }
}