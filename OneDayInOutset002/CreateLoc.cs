using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayInOutset002
{
    public class CreateLoc
    {
        public World world;
        public Loc Loc0 { get; set; }
        public Loc Loc1 { get; set; }
        public Loc Loc2 { get; set; }
        public Loc Loc3 { get; set; }
        public Loc Loc4 { get; set; }
        public Loc Loc5 { get; set; }
        public Loc Loc6 { get; set; }
        public Loc Loc7 { get; set; }
        public Loc Loc8 { get; set; }
        public Loc Loc9 { get; set; }
        public Loc Loc10 { get; set; }
        public Loc Loc11 { get; set; }
        public void LocConnect(Loc loc, Loc con)
        {
            loc.locconnect.Add(con);
        }
        public void LocLink(Loc loc, Loc loc2)
        {
            loc.locconnect.Add(loc2);
            loc2.locconnect.Add(loc);
        }
        public void Startup()
        {
            Loc0 = new Loc(LocInfo.Loc0Name, LocInfo.Loc0Desc);
            Loc1 = new Loc(LocInfo.Loc1Name, LocInfo.Loc1Desc);
            Loc2 = new Loc(LocInfo.Loc2Name, LocInfo.Loc2Desc);
            Loc3 = new Loc(LocInfo.Loc3Name, LocInfo.Loc3Desc);
            Loc4 = new Loc(LocInfo.Loc4Name, LocInfo.Loc4Desc);
            Loc5 = new Loc(LocInfo.Loc5Name, LocInfo.Loc5Desc);
            Loc6 = new Loc(LocInfo.Loc6Name, LocInfo.Loc6Desc);
            Loc7 = new Loc(LocInfo.Loc7Name, LocInfo.Loc7Desc);
            Loc8 = new Loc(LocInfo.Loc8Name, LocInfo.Loc8Desc);
            Loc9 = new Loc(LocInfo.Loc9Name, LocInfo.Loc9Desc);
            Loc10 = new Loc(LocInfo.Loc10Name, LocInfo.Loc10Desc);
            Loc11 = new Loc(LocInfo.Loc11Name, LocInfo.Loc11Desc);
            //
            LocConnect(Loc1, Loc2);
            //
            LocLink(Loc2, Loc3);
            LocLink(Loc2, Loc4);
            //
            LocLink(Loc4, Loc5);
            LocLink(Loc4, Loc6);
            LocLink(Loc4, Loc7);
            //
            LocLink(Loc5, Loc6);
            //
            LocLink(Loc7, Loc8);
            //
            LocLink(Loc8, Loc9);
            //
            LocLink(Loc9, Loc10);
            //
            LocLink(Loc10, Loc11);
            //
            //

            //
            world = new World(Loc0);
        }
    }
}
