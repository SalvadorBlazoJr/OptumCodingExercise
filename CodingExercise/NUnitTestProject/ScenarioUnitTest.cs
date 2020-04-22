using CodingExercise;
using NUnit.Framework;

namespace Tests
{
   public class Tests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      public void SampleTestCase1()
      {
         //Arrange
         string weight = "10";
         string height = "10";
         string width = "10";
         string length = "20";

         //Act
         Package package = new Package(weight, height, width, length);
         PackageModel packageModel = package.InitPackage();

         //Assert
         Assert.AreEqual(packageModel.Category, RulesEnum.MediumPackage);
         Assert.AreEqual(packageModel.Cost, "80");
      }
      
      [Test]
      public void SampleTestCase2()
      {
         //Arrange
         string weight = "22";
         string height = "5";
         string width = "5";
         string length = "5";

         //Act
         Package package = new Package(weight, height, width, length);
         PackageModel packageModel = package.InitPackage();

         //Assert
         Assert.AreEqual(packageModel.Category, RulesEnum.HeavyPackage);
         Assert.AreEqual(packageModel.Cost, "330");
      }

      [Test]
      public void SampleTestCase3()
      {
         //Arrange
         string weight = "2";
         string height = "3";
         string width = "10";
         string length = "12";

         //Act
         Package package = new Package(weight, height, width, length);
         PackageModel packageModel = package.InitPackage();

         //Assert
         Assert.AreEqual(packageModel.Category, RulesEnum.SmallPackage);
         Assert.AreEqual(packageModel.Cost, "18");
      }

      [Test]
      public void SampleTestCase4()
      {
         //Arrange
         string weight = "110";
         string height = "20";
         string width = "55";
         string length = "120";

         //Act
         Package package = new Package(weight, height, width, length);
         PackageModel packageModel = package.InitPackage();

         //Assert
         Assert.AreEqual(packageModel.Category, RulesEnum.Rejected);
         Assert.AreEqual(packageModel.Cost, "N/A");
      }

      [Test]
      public void InvalidInputs()
      {
         //Arrange
         string weight = "a";
         string height = "b";
         string width = "c";
         string length = "d";

         //Act
         Package package = new Package(weight, height, width, length);
         PackageModel packageModel = package.InitPackage();

         //Assert
         Assert.AreEqual(packageModel, null);
         Assert.IsTrue(Log._logs.Count > 0);
      }
   }
}