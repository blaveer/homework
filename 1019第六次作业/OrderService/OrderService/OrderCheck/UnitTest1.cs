using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using orderManagement;

namespace OrderCheck
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
           // OrderService.AddOrder(10);
            Assert.AreEqual(OrderService.AddOrder(10), true);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //OrderService.XmlWrite();
            Assert.AreEqual(OrderService.XmlWrite(),true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //OrderService.XmlRead();
            Assert.AreEqual(OrderService.XmlRead(), true);

        }
        [TestMethod]
        public void TestMethod4()
        {
            //OrderService.OutputOrder(Order.list);
            Assert.AreEqual(OrderService.OutputOrder(Order.list), true);

        }
        [TestMethod]
        public void TestMethod5()
        {

            for (int i = 1; i <  11; i++)
            {
                OrderService.AddOrder(i);     //添加订单
            }
            Assert.AreEqual(OrderService.FindByOrderName(2), true);    //这个是有的
           // Assert.AreEqual(OrderService.FindByOrderName(12), true);     //这个没有
            //因为后面的属性是用随机函数生成的，所以就正确的测试就直接调用里面的了，，错误的测试就随便写了
            Assert.AreEqual(OrderService.FindByOrderQuantity(Order.list[5].OrderQuantity), true);//这个有，
            //Assert.AreEqual(OrderService.FindByOrderQuantity(2), true);    //这个应该没有
            Assert.AreEqual(OrderService.FindByProductName(Order.list[5].ProductName), true);  //这个有
            //Assert.AreEqual(OrderService.FindByProductName("sjdkks"), true); //这个应该没有
            Assert.AreEqual(OrderService.FindByClientName(Order.list[5].Client), true); //这个有
            //Assert.AreEqual(OrderService.FindByClientName("eiffbc"), true);//这个应该没有
        }
    }
}
