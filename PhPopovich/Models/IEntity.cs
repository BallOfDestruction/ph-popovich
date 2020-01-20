using System;

namespace EnglishApp.Models
{
    public interface IEntity
    {
        Guid Id { get; }

        string Title { get; }

        DateTime DateCreated { get; }

        string GetValueFromNameProperty(string nameProperty);

        string GetLinkFromNameProperty(string nameProperty);

        string GetTitleFromNameProperty(string nameProperty);
    }
}