using System;

namespace Samples.Specifications.Modules.Shell.Data.Contracts.Dto
{    
    public sealed class WarehouseItemDto
    {
        public Guid Id { get; set; }
        public string Kind { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}