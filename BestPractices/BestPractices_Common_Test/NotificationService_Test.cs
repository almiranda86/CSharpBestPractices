using BestPractices.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestPractices_Common_Test
{
    [TestClass]
    public class NotificationService_Test
    {
        [TestMethod]
        public void NotifyTalent_Test()
        {
            //Arrange
            var expect = $"Notifying talent: rey";

            //Act
            var actual = NotificationServices.NotifyTalent("rey");

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
