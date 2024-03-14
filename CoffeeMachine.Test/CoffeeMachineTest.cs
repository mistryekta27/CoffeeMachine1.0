using CoffeeMachine.API.Interface;
using CoffeeMachine.API.Service;
using System;
using Xunit;

namespace CoffeeMachine.Test
{
    public class CoffeeMachineTest
    {
        private readonly ICoffeeService _iCoffeeService;
        public CoffeeMachineTest()
        {
            _iCoffeeService = new CoffeeService();
        }

        [Fact]
        public void Get_APICount_LessThan5()
        {
            //Arrange
            int apiCount = 2;

            //Act
            var result = _iCoffeeService.CheckAPICount(apiCount);

            //Assert
            Assert.False(result);
        }
        [Fact]
        public void Get_APICount_EqualsTo5()
        {
            //Arrange
            int apiCount = 5;

            //Act
            var result = _iCoffeeService.CheckAPICount(apiCount);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void Get_CurrentDate_EqualsToApril1()
        {
            //Arrange
            DateTime today = DateTime.Now;

            //Act
            var result = _iCoffeeService.CompareDate(today);

            //Assert
            Assert.False(result);
        }
        [Fact]
        public void Get_April1_EqualsToApril1()
        {
            //Arrange
            DateTime today = new DateTime(DateTime.Now.Year, 4, 1);

            //Act
            var result = _iCoffeeService.CompareDate(today);

            //Assert
            Assert.True(result);
        }
    }
}
