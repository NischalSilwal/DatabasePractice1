﻿using DatabasePractice1.DTO;
using DatabasePractice1.Models;

namespace DatabasePractice1.Mappers
{
    public class ProductMapper : IProductMapper
    {
        public ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                //imageId = product.imageId
            }; throw new NotImplementedException();
        }

        public Product MapToEntity(ProductDto productDto)
        {
            return new Product
            {

                Id = productDto.Id,
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
              //  imageId = productDto.imageId

            };
        }
    }
}
