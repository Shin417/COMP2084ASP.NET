using DotNetDrinksWebUI.Controllers;
using DotNetDrinksWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDrinksWebUI.Tests
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void EditReturnResult()
        {
            ProductsController controller = new ProductsController(null);
            var results = controller.Edit(1);
            Assert.AreEqual("Edit", results.ToString());
        }

        [TestMethod]
        public void DeleteConfirmedResult()
        {
            ProductsController controller = new ProductsController(null);
            Product product = new Product
            {
                Name = "TestName",
                Id = 1
            };
            var results = controller.DeleteConfirmed(product);
        }
    }
}