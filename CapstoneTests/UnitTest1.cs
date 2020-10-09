using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void DoesStreamReaderAccessPartsArray()
        //{
        //    //Arrange
        //    FileAccess access = new FileAccess();
        //    //Act
        //    string result = access.LoadCateringItems("B1|Soda|1.50|B");
        //    //Assert
        //    Assert.AreEqual(
        //    //Generate tests as we work through catering, catering item, and maybe file access
        //}

        [TestMethod]
        public void DoesAddItemActuallyIncreaseCountOfItems()
        {
            // Arrange
            Catering catering = new Catering();
            CateringItem newItem = new CateringItem("B1", "Soda", 1.50M, "B");
          
            // Act
            catering.Add(newItem);
            System.Collections.Generic.List<CateringItem> cateringItems = catering.AllCateringItems;
            //Assert
            Assert.AreEqual(1, cateringItems.Count);
        }

        [TestMethod]
        public void AddMoneyUpdatesCurrentBalance()
        {
            // Arrange
            Money money = new Money();

            // Act
            decimal result = money.AddMoney(10M);

            // Assert
            Assert.AreEqual(10M, result);
        }
    }
}
