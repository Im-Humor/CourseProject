using GTANetworkAPI;
using System.Collections.Generic;

namespace ServerSide
{
    public static class SpawnLocGetSet
    {
        private static Dictionary<string, Vector3> locGetSetDict = new Dictionary<string, Vector3>();
        public static Dictionary<string, Vector3> LocGetSetDict
        {
            get
            {
                if (locGetSetDict.Count == 0)
                {
                    locGetSetDict.Add("skyscraperSpawn", new Vector3(-77.65159, -821.1064, 328.0709));
                    locGetSetDict.Add("nearPoolSpawn", new Vector3(-1197.391, -251.6665, 43.78189));
                }
                    return locGetSetDict;

            }
            set
            {
                foreach (var pair in value)
                {
                    locGetSetDict[pair.Key] = pair.Value;
                }
            }
        }

    }
}