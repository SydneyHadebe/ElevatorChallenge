using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorChallenge;
using Microsoft.VisualBasic;

namespace ElevatorChallengeTest
{
    [TestClass]
    public class ElevatorChallengeCheckTheNumbers
    {
        [TestMethod]
        public static void CheckTheFloor_InWhich_The_Elevator_IsCalled()
        {
            //Arrange
            var noOfPeople = 0;
            var weightLimit = 0;
            var initialFloorNumber = 0;

            var building = new Building(noOfPeople, weightLimit);

            //Act 
            building.CallElevator(building.NoOfFloors, noOfPeople, initialFloorNumber);

        }
    }
}
