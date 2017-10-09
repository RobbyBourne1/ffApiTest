using System;
using System.Collections.Generic;
using System.IO;

namespace ffApiTest
{
    public class Player
    {
        public string id { get; set; }
        public string esbid { get; set; }
        public object gsisPlayerId { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string teamAbbr { get; set; }
        public double seasonPts { get; set; }
        public double seasonProjectedPts { get; set; }
        public double weekPts { get; set; }
        public double weekProjectedPts { get; set; }
    }

    public class RootObject
    {
        public string statType { get; set; }
        public string season { get; set; }
        public string week { get; set; }
        public List<Player> players { get; set; }
    }
}