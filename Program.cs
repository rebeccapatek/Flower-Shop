using System;
using System.Collections.Generic;

namespace flower_shop {
    class Program {
        static void Main (string[] args) {
            Rose myRedRose = new Rose {
                Color = "Red",
                Name = "Big Red",
                Type = "Garden Rose",
                Cost = 0.99,
                WaterSchedule = "Once a week",
                Thorny = true,
                Fragrant = true,
                StemLength = 34,
            };
            Tulip myTully = new Tulip {
                Color = "Yellow",
                Name = "Tully",
                Type = "Special",
                Cost = 1.45,
                WaterSchedule = "Once a day"
            };
            Daisy myDaisy = new Daisy {
                Color = "White",
                Name = "Day",
                Type = "Gerber",
                Cost = 1.5,
                WaterSchedule = "Every day",
                StemLength = 16,

            };
            Daffodils myDaff = new Daffodils {
                Color = "Yellow",
                Name = "Daffy",
                Type = "SpringBloomer",
                Cost = .50,
                WaterSchedule = "Every 3 days",

            };

            FlowerShop MacsFlowershop = new FlowerShop ();
            List<Ibirthday> Arrangement = MacsFlowershop.MakeBirthdayArrangement ();
        }
    }
}