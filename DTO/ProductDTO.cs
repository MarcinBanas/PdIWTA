using PdiwtA.Controllers;
using System;

namespace PdiwtA.DTO
{
    public class ProductDTO
    {
        public ProductDTO(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            IsAvailable = product.IsAvailable;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
    }
}
