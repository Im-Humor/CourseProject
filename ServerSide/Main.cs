using GTANetworkAPI;
using System.Collections.Generic;

namespace ServerSide
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            NAPI.Util.ConsoleOutput("Server started!");
        }
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnect(Player player)
        {
            player.SendChatMessage("Hello!" + player.Name);
        }

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Player player)
        {

            player.Position = SpawnLocGetSet.LocGetSetDict["skyscraperSpawn"];
            player.GiveWeapon(WeaponHash.Pumpshotgun, 14);
            //player.SetClothes(5, 1, 0);
            player.GiveWeapon(WeaponHash.Parachute, 0);
        }
    }
}
