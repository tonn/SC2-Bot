using System;
using System.IO;
using SC2APIProtocol;

namespace Bot
{
    internal class Program
    {
        // Settings for your bot.
        private static readonly Bot bot = new RaxBot();
        private const Race race = Race.Terran;

        // Settings for single player mode.
        private static readonly string mapName = Path.Combine("Ladder2019Season3", "AcropolisLE.SC2Map");

        private static readonly Race opponentRace = Race.Random;
        private static readonly Difficulty opponentDifficulty = Difficulty.Easy;

        public static GameConnection gc;

        private static void Main(string[] args)
        {
            try
            {
                gc = new GameConnection();
                if (args.Length == 0)
                {
                    gc.readSettings();
                    gc.RunSinglePlayer(bot, mapName, race, opponentRace, opponentDifficulty).Wait();
                }
                else
                    gc.RunLadder(bot, race, args).Wait();
            }
            catch (Exception ex)
            {
                Logger.Info(ex.ToString());
            }

            Logger.Info("Terminated.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}