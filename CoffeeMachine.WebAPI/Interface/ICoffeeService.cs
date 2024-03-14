using System;

namespace CoffeeMachine.API.Interface
{
    public interface ICoffeeService
    {
        public bool CheckAPICount(int apiCount);
        public bool CompareDate(DateTime today);
    }
}
