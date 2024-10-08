﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProductTest();
             CategoryTest();
            //DTOs : Data Transformation Object
        }

        private static void CategoryTest()
        {
            EfCategoryDal x = new EfCategoryDal();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {



            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }



}