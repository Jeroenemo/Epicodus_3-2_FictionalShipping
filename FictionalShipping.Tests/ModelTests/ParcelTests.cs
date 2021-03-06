using Microsoft.VisualStudio.TestTools.UnitTesting;
using FictionalShipping.Models;

namespace FictionalShipping.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(0, 0, 0);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsParcelLength_Int()
    {
      int length = 6;
      Parcel newParcel = new Parcel(length, 0, 0);
      int result = newParcel.Length;
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void GetHeight_ReturnsParcelHeight_Int()
    {
      int height = 6;
      Parcel newParcel = new Parcel(0, height, 0);
      int result = newParcel.Height;
      Assert.AreEqual(height, result);
    }

    [TestMethod]
    public void GetWidth_ReturnsParcelWidth_Int()
    {
      int width = 6;
      Parcel newParcel = new Parcel(0, 0, width);
      int result = newParcel.Width;
      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void GetWeight_ReturnsParcelWeight_Int()
    {
      int weight = 6;
      Parcel newParcel = new Parcel(0, 0, 0, weight);
      int result = newParcel.Weight;
      Assert.AreEqual(weight, result);
    }

    [TestMethod]
    public void GetVolume_ReturnsParcelVolume_Int()
    {
      int volume = 60;
      Parcel newParcel = new Parcel(3, 4, 5);
      int result = newParcel.GetVolume();
      Assert.AreEqual(volume, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsShippingPrice_Int()
    {
      double price = 11.64;
      Parcel newParcel = new Parcel(12, 12, 12, 6);
      double result = newParcel.GetPrice();
      Assert.AreEqual(price, result);

    }
  }
}