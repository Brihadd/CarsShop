using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CarRegNumber { get; set; }
        public int CarYear { get; set; }
        public Fuel Fuel { get; set; }
        public double Kilometers { get; set; }
        public Condition Condition { get; set; }      
        public string EngineName { get; set; }
        public int EnginePower { get; set; }
        public int EngineVolume { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Profit
        {
            get
            {
                return SellPrice - BuyPrice;
            }
        }
        public bool IsLuxury
        {
            get
            {
                return SellPrice > 950000;
            }
        }
    }
    public enum Fuel
    {
        Petrol,
        Diesel,
        LPG,
        CNG,
        Electricity
    }
    public enum Condition
    {
        Excellent,
        Good,
        Bad,
        Pig
    }
}
