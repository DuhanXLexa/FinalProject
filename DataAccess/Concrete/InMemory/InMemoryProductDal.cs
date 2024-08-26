using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        
        public InMemoryProductDal() 
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, CategoryId=1,ProductName="Kamera",UnitPrice=2000,UnitsInStock=2},
            new Product { ProductId = 2, CategoryId = 2, ProductName = "Telefon", UnitPrice = 2000, UnitsInStock = 2 },
            new Product { ProductId = 3, CategoryId = 3, ProductName = "Bilgisayar", UnitPrice = 2000, UnitsInStock = 2 },
            new Product { ProductId = 4, CategoryId = 4, ProductName = "Monitor", UnitPrice = 2000, UnitsInStock = 2 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product ProductToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);
            ProductToUpdate.ProductId = product.ProductId;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
