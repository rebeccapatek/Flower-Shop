using System;

namespace flower_shop {
    public class Daisy : IMyMothersDay {
        public string Color { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string WaterSchedule { get; set; }
        public int StemLength { get; set; }

        // public Daisy (string color, string name, string type, double cost, string waterSchedule, int stemLength) {
        //     Color = color;
        //     Name = name;
        //     Type = type;
        //     Cost = cost;
        //     WaterSchedule = waterSchedule;
        //     StemLength = stemLength;
        // }
    }
}