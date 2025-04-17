using DotNetDrinksWebUI.Models;
namespace DotNetDrinksWebUI.Tests;

public class UnitTest1
{
    [Fact]

    public void Product_PropertiesSetCorrectly()

    {

        // Arrange

        var product = new Product

        {

            Id = 1,

            Name = "Test Product",

            Price = 9.99m,

            Description = "Test product description"

        };

        // Act

        // (No action needed for this test.)

        // Assert

        Assert.Equal(1, product.Id);

        Assert.Equal("Test Product", product.Name);

        Assert.Equal(9.99m, product.Price);

        Assert.Equal("Test product description", product.Description);

    }

    [Fact]

    public void Product_StringTest()
    {

        //arrange
        var product = new Product
        {
            Id = 1,
            Name = "Menu_1",
            Price = 4.50m,
            Description = "Description_1"
        };

        //Act

        //Assert
        Assert.Contains(product.Id.ToString(), product.Name);
        Assert.Contains(product.Id.ToString(), product.Description);
    }
}
