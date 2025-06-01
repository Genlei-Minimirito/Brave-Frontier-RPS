using System.Collections.Generic;
using System.Drawing;

namespace Brave_Frontier_CG
{
    public static class Library
    {
        // Populate these lists at startup (e.g. in a static constructor)
        // Each UnitInfo(name, portrait) must match the strings used in SetPlayerAnimations.
        public static readonly List<UnitInfo> ThreeStarUnits = new List<UnitInfo>
        {
            new UnitInfo("Kaito\n3☆☆☆",   Properties.Resources.KAITO),
            new UnitInfo("Kagamine Rin\n3☆☆☆",      Properties.Resources.RIN),
            new UnitInfo("Kagamine Len\n3☆☆☆",     Properties.Resources.LEN),
            new UnitInfo("Juzo Suzuya\n3☆☆☆",     Properties.Resources.JUZO_SUZUYA),
            new UnitInfo("Touka Kirishima\n3☆☆☆",     Properties.Resources.TOUKA_KIRISHIMA),
            // ... add all your 3★ character portraits here ...
        };

        public static readonly List<UnitInfo> FourStarUnits = new List<UnitInfo>
        {
            new UnitInfo("All Might\n4☆☆☆☆",   Properties.Resources.ALL_MIGHT),
            new UnitInfo("Toki\n4☆☆☆☆",    Properties.Resources.TOKI),
            new UnitInfo("Dark Deemo and the Girl\n4☆☆☆☆",     Properties.Resources.DEEMO_DARK),
            new UnitInfo("Deemo and the Girl\n4☆☆☆☆",     Properties.Resources.DEEMO_LIGHT),
            new UnitInfo("Katsuki Bakugo\n4☆☆☆☆",     Properties.Resources.KATSUKI_BAKUGO),

            // ... all your 4★ units ...
        };

        public static readonly List<UnitInfo> FiveStarUnits = new List<UnitInfo>
        {
            new UnitInfo("Kaneki\n5☆☆☆☆☆",  Properties.Resources.KANEKI),
            new UnitInfo("Miku\n5☆☆☆☆☆",     Properties.Resources.MIKU),
            new UnitInfo("Natsu\n5☆☆☆☆☆",     Properties.Resources.NATSU),
            new UnitInfo("Lasswell\n5☆☆☆☆☆",     Properties.Resources.LASSWELL),
            new UnitInfo("Deku\n5☆☆☆☆☆",     Properties.Resources.DEKU),
            new UnitInfo("Iori Yagami\n5☆☆☆☆☆",     Properties.Resources.IORI),
            // ... all your 5★ units ...
        };
    }
}
