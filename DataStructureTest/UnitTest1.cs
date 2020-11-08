using NUnit.Framework;
using DataStructure;

namespace DataStructureTest
{
  public class Tests
  {
    [Test]
    public void AddByIndexTest()
    {
      ArrayList arrayList1 = new ArrayList();
      arrayList1.AddByIndex(1, 1);

      ArrayList arrayList2 = new ArrayList();
      arrayList2.AddByIndex(1, 1);

      Assert.IsTrue(arrayList1.Equals(arrayList2));

    }
  }
}