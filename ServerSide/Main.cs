using GTANetworkAPI;

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
            player.GiveWeapon(WeaponHash.Pumpshotgun, 14);
        }

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Player player)
        {
            player.Position = new Vector3(0.0, 0.0, 72.0);
        }
    }
}
