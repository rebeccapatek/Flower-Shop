using System;

namespace flower_shop {
    public class Rose : IMyMothersDay {
        public string Color { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string WaterSchedule { get; set; }
        public bool Thorny { get; set; }
        public bool Fragrant { get; set; }

        public int StemLength { get; set; }

        // public Rose (string color, string name, string type, double cost, string waterSchedule, bool thorny, bool fragrant, int stemLength) {
        //     Color = color;
        //     Name = name;
        //     Type = type;
        //     Cost = cost;
        //     WaterSchedule = waterSchedule;
        //     Thorny = thorny;
        //     Fragrant = fragrant;
        //     StemLength = stemLength;
        // }
    }
}