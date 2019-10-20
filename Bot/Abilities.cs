namespace Bot
{
    internal static class Abilities
    {
        //you can get all these values from the stableid.json file (just search for it on your PC)

        public const int RESEARCH_BANSHEE_CLOAK = 790;
        public const int RESEARCH_INFERNAL_PREIGNITER = 761;
        public const int RESEARCH_UPGRADE_MECH_AIR = 3699;
        public const int RESEARCH_UPGRADE_MECH_ARMOR = 3700;
        public const int RESEARCH_UPGRADE_MECH_GROUND = 3701;

        public const int CANCEL_CONSTRUCTION = 314;
        public const int CANCEL = 3659;
        public const int CANCEL_LAST = 3671;
        public const int LIFT = 3679;
        public const int LAND = 3678;

        public const int SMART = 1;
        public const int STOP = 4;
        public const int ATTACK = 23;
        public const int MOVE = 16;
        public const int PATROL = 17;
        public const int RALLY = 3673;
        public const int REPAIR = 316;

        public const int THOR_SWITCH_AP = 2362;
        public const int THOR_SWITCH_NORMAL = 2364;
        public const int SCANNER_SWEEP = 399;
        public const int YAMATO = 401;
        public const int CALL_DOWN_MULE = 171;
        public const int CLOAK = 3676;
        public const int REAPER_GRENADE = 2588;
        public const int DEPOT_RAISE = 558;
        public const int DEPOT_LOWER = 556;
        public const int SIEGE_TANK = 388;
        public const int UNSIEGE_TANK = 390;
        public const int TRANSFORM_TO_HELLBAT = 1998;
        public const int TRANSFORM_TO_HELLION = 1978;
        public const int UNLOAD_BUNKER = 408;
        public const int SALVAGE_BUNKER = 32;

        //gathering/returning minerals
        public const int GATHER_RESOURCES = 295;
        public const int RETURN_RESOURCES = 296;


        //gathering/returning minerals
        public const int GATHER_MINERALS = 295;
        public const int RETURN_MINERALS = 296;


        public static int GetID(uint unit)
        {
            return (int)Controller.gameData.Units[(int)unit].AbilityId;
        }

    }
}