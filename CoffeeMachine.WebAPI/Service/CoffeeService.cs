using CoffeeMachine.API.Helper;
using CoffeeMachine.API.Interface;
using CoffeeMachine.API.Model;
using System;

namespace CoffeeMachine.API.Service
{
    public class CoffeeService : ICoffeeService
    {
        //Check for every 5th call to this API.
        public bool CheckAPICount(int apiCount)
        {
            if (apiCount == Constant.DefaultAPICount)
            {
                APICounter.ResetAPICount();
                return true;
            }
            return false;
        }

        //Compare current date with 1st April.
        public bool CompareDate(DateTime today)
        {
            DateTime CompareToDate = Constant.DateToCompare;
            return today.Month == CompareToDate.Month && today.Day == CompareToDate.Day;
        }
    }
}
