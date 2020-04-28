using System;
using System.Collections.Generic;
using Samples.Specifications.Modules.Shell.Data.Contracts.Dto;

namespace Samples.Specifications.Modules.Shell.Data.Contracts.Providers
{
    public interface IWarehouseProvider
    {
        IEnumerable<WarehouseItemDto> GetWarehouseItems();
        bool DeleteWarehouseItem(Guid id);
        bool UpdateWarehouseItem(WarehouseItemDto dto);
        void CreateWarehouseItem(WarehouseItemDto dto);
    }
}
