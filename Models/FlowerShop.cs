using System;
using System.Collections.Generic;

namespace flower_shop {
    public class FlowerShop {
        public List<Rose> Roses = new List<Rose> ();
        public List<Tulip> Tulips = new List<Tulip> ();
        public List<Daffodils> Daffodils = new List<Daffodils> ();
        public List<Daisy> Daisies = new List<Daisy> ();

        public List<IMyMothersDay> MakeMothersDayArrangement () {
            List<IMyMothersDay> Arrangement = new List<IMyMothersDay> ();
            Arrangement.Add (new Rose ());
            Arrangement.Add (new Daisy ());
            return Arrangement;

        }
        public List<Ibirthday> MakeBirthdayArrangement () {
            List<Ibirthday> Arrangement = new List<Ibirthday> ();
            Tulip Yellow = new Tulip ();
            Arrangement.Add (Yellow);
            Arrangement.Add (new Daffodils ());
            return Arrangement;

        }
        public List<Igetwell> MakeGetWellArrangment () {
            List<Igetwell> Arrangement = new List<Igetwell> ();
            Arrangement.Add (new Mildew ());
            return Arrangement;
        }
    }
}