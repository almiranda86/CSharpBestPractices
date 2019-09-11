using BestPractices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractices_Test
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void ParameterizedConstructos_Test()
        {
            //Arrange
            var currentActor = new Actor("Jhonny");
            var expected = "Jhonny";

            //Act
            string result = currentActor.ActorName;

            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void GetOccupation_Test ()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            
            //Act
            string result = currentActor.GetOccupation();
            
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void BookActor_Test()
        {
            string details = $"Bookin can change if actor starts trouble";

            var currentActor = new Actor("Jhonny");
            var expected = $"Actor Jhonny is booked. {details}";

            string result = currentActor.BookActor();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BookActorOnSpecificDate_Test()
        {
            string details = $"Bookin can change if actor starts trouble";

            var currentActor = new Actor("Jhonny");
            var expected = $"Actor Jhonny is booked on {DateTime.Today.ToShortDateString()}. {details}";

            string result = currentActor.BookActor(DateTime.Today.ToShortDateString());

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void FormatingOnSetterForBookActor_Test()
        {
            string details = $"Bookin can change if actor starts trouble";

            var currentActor = new Actor("Jhonny       ");
            var expected = $"Actor Jhonny is booked. {details}";

            string result = currentActor.BookActor();

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AutoPropActorDescription_Test()
        {
            var currentActor = new Actor
            {
                ActorName = "Sandy Love"
            };

            var expected = $"Regular actor";

            string result = currentActor.ActorDescription;

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AutoPropActorAge_Test()
        {
            var currentActor = new Actor
            {
                ActorName = "Sandy Love",
                ActorAge = 46
            };

            var expected = 46;

            int result = currentActor.ActorAge;

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void GetAgency_Test()
        {
            var currentActor = new Actor();

            var expected = "Agency Name";

            var result = currentActor.GetAgency();

            Assert.AreEqual(expected, result);
        }
    }
}
