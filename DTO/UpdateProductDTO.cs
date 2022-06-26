using System;
using System.ComponentModel.DataAnnotations;

namespace PdiwtA.DTO
{
      public class UpdateProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
    }
}
