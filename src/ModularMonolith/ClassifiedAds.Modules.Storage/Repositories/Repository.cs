﻿using ClassifiedAds.CrossCuttingConcerns.OS;
using ClassifiedAds.Domain.Entities;
using ClassifiedAds.Infrastructure.Persistence;

namespace ClassifiedAds.Modules.Storage.Repositories
{
    public class Repository<T, TKey> : DbContextRepository<StorageDbContext, T, TKey>
    where T : Entity<TKey>, IAggregateRoot
    {
        public Repository(StorageDbContext dbContext, IDateTimeProvider dateTimeProvider)
            : base(dbContext, dateTimeProvider)
        {
        }
    }
}
