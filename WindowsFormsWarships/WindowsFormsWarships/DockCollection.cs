using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWarships
{
    class DockCollection
    {
        readonly Dictionary<string, Dock<Vehicle, TrapezeGunForm>> dockStages;

        public List<string> Keys => dockStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public DockCollection(int pictureWidth, int pictureHeight)
        {
            dockStages = new Dictionary<string, Dock<Vehicle, TrapezeGunForm>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddDock(string name)
        {
            if (dockStages.ContainsKey(name))
            {
                return;
            }
            dockStages.Add(name, new Dock<Vehicle, TrapezeGunForm>(pictureWidth, pictureHeight));
        }

        public void DelDock(string name)
        {
            if (dockStages.ContainsKey(name))
            {
                dockStages.Remove(name);
            }
        }

        public Dock<Vehicle, TrapezeGunForm> this[string ind]
        {
            get
            {
                if (dockStages.ContainsKey(ind))
                {
                    return dockStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public Vehicle this[string key, int ind]
        {
            get
            {
                if (dockStages.ContainsKey(key) && ind >= 0)
                {
                    return dockStages[key]._places[ind];
                }
                return null;
            }
        }
    }
}
