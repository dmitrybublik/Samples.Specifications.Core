﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Attest.Fake.Builders;
using JetBrains.Annotations;
using Samples.Specifications.Data.Contracts.Dto;
using Samples.Specifications.Data.Contracts.Providers;
using Samples.Specifications.Data.Fake.Containers;
using Samples.Specifications.Data.Fake.ProviderBuilders;

namespace Samples.Specifications.Data.Fake.Providers
{
    [UsedImplicitly]
    internal sealed class FakeWarehouseProvider : FakeProviderBase<WarehouseProviderBuilder, IWarehouseProvider>,
        IWarehouseProvider
    {
        private readonly Random _random = new Random();

        public FakeWarehouseProvider(
            WarehouseProviderBuilder warehouseProviderBuilder,
            IWarehouseContainer warehouseContainer)
            : base(warehouseProviderBuilder) => warehouseProviderBuilder.WithWarehouseItems(warehouseContainer.WarehouseItems);

        IEnumerable<WarehouseItemDto> IWarehouseProvider.GetWarehouseItems() => GetService(r =>
        {
            Task.Delay(_random.Next(2000)).Wait();
            return r;
        }).GetWarehouseItems();

        bool IWarehouseProvider.DeleteWarehouseItem(Guid id) => GetService(r =>
        {
            Task.Delay(_random.Next(2000)).Wait();
            return r;
        }).DeleteWarehouseItem(id);

        bool IWarehouseProvider.UpdateWarehouseItem(WarehouseItemDto dto) => GetService(r =>
        {
            Task.Delay(_random.Next(2000)).Wait();
            return r;
        }).UpdateWarehouseItem(dto);

        void IWarehouseProvider.CreateWarehouseItem(WarehouseItemDto dto) => GetService(r =>
        {
            Task.Delay(_random.Next(2000)).Wait();
            return r;
        }).CreateWarehouseItem(dto);
    }
}