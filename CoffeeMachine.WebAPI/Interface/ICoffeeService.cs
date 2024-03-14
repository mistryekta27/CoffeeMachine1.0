using System;
using System.Threading.Tasks;

namespace CoffeeMachine.API.Interface
{
    public interface ICoffeeService
    {
        public bool CheckAPICount(int apiCount);
        public bool CompareDate(DateTime today);
        public Task<bool> CheckTemperature();
    }
}
