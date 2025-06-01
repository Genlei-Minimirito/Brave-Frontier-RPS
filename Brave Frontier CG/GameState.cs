using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Brave_Frontier_CG
{
    public static class GameState
    {
        static GameState()
        {
            Gems = 5;
        }

        public static int Gems { get; set; }

        // Backing list for collected starters
        private static readonly List<UnitInfo> _collectedStarters = new List<UnitInfo>();

        /// <summary>
        /// Read-only view of all collected starters.
        /// </summary>
        public static IReadOnlyList<UnitInfo> CollectedStarters => _collectedStarters;

        /// <summary>
        /// Adds a new UnitInfo only if there is not already one with the same Name.
        /// </summary>
        public static void AddStarter(UnitInfo unit)
        {
            if (unit == null) return;

            // Only add if no existing unit has the same Name
            if (!_collectedStarters.Any(u => u.Name == unit.Name))
            {
                _collectedStarters.Add(unit);
            }
        }
    }

    /// <summary>
    /// A small class to hold a unit’s name and portrait image together.
    /// </summary>
    public class UnitInfo
    {
        public string Name { get; }
        public Image Image { get; }

        public UnitInfo(string name, Image image)
        {
            Name = name;
            Image = image;
        }
    }
}
