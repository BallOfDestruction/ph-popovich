﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EnglishApp.Controllers.cms;
using EntityFrameworkPaginateCore;

namespace EnglishApp.Models
{
    public class Entity<T> : ISortFilterEntity<T>
        where T : IEntity
    {
        [Show(false, false, false, false)]
        public Guid Id { get; set; }

        [DisplayName("Дата создания")]
        [DataType(DataType.DateTime)]
        [Show(true, true, false, false)]
        public virtual DateTime DateCreated { get; set; } = DateTime.Now;

        [Show(false, false, false, false)]
        public virtual string Title { get; set; }

        public virtual string GetValueFromNameProperty(string nameProperty)
        {
            return null;
        }

        public virtual string GetLinkFromNameProperty(string nameProperty)
        {
            return null;
        }

        public virtual string GetTitleFromNameProperty(string nameProperty)
        {
            return null;
        }

        public virtual Filters<T> GetDefaultFilters(params string[] filters)
        {
            var filter = new Filters<T>();
            return filter;
        }

        public virtual Sorts<T> GetDefaultSorted()
        {
            var sorted = new Sorts<T>();
            return sorted;
        }
    }
}
