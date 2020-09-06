using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OneDayInOutset002
{
    public class Construct
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
        public Cho Startup1 { get; set; }
        public Cho Startup2 { get; set; }
        public Cho Startup3 { get; set; }
        public Cho Startup4 { get; set; }
        public Cho neighborGood1 { get; set; }
        public Cho neighborGood2 { get; set; }
        public Cho neighborGood3 { get; set; }
        public void BuildButton1()
        {
        }
        public void LocConnect(Loc loc, Loc con)
        {
            loc.locconnect.Add(con);
        }
        public void LocLink(Loc loc, Loc loc2)
        {
            loc.locconnect.Add(loc2);
            loc2.locconnect.Add(loc);
        }
        public void LocArray(Loc loc, params Loc[] locs)
        {
            for (int i = 0; i < locs.Length; i++)
            {
                LocLink(loc, locs[i]);
            }
        }
        public void ChoiceChain(Cho cho, Cho cho2)
        {
            cho.choices.Add(cho2);
        }
        public void ChoiceArray(Cho cho, params Cho[] chos)
        {
            for (int i = 0; i < chos.Length; i++)
            {
                ChoiceChain(cho, chos[i]);
            }
        }
        public void Startup()
        {
            world = new World(Loc0);
            //
            Loc0 = new Loc(LocInfo.LocStart, LocInfo.Loc0Desc);
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
            LocArray(Loc2, Loc3, Loc4);
            //
            LocArray(Loc4, Loc5, Loc6, Loc7);
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
            Startup1 = new Cho("startup1", ChoInfo.Startup1);
            Startup2 = new Cho("startup2", ChoInfo.Startup2);
            Startup3 = new Cho("startup3", ChoInfo.Startup3);
            Startup4 = new Cho("startup3", ChoInfo.Startup4);
            neighborGood1 = new Cho(ChoInfo.neighborGood1Name, ChoInfo.neighborGood1Text);
            neighborGood2 = new Cho(ChoInfo.neighborGood2Name, ChoInfo.neighborGood2Text);
            //
            ChoiceChain(Startup1, Startup2);
            ChoiceChain(Startup2, Startup3);
            ChoiceChain(Startup3, Startup4);
            ChoiceArray(Startup4, neighborGood1, neighborGood2);
        }
    }
}
