﻿using EDADBContext.Models;
using EDAInventory.Models;

namespace EDAInventory.Repository.Interface
{
    public interface IInventoryRepository
    {
        Task<List<Product>> GetProductsList();
        Task<string> UpsertProduct(Product? product, bool IsUpdate = false);
        Task<Product?> GetProductById(Guid productId);
    }
}
