using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC424_ScoreCard
{
    internal class Stats
    {
        private const string FileName = "plhistory.txt";

        public static void SaveUserScores(Dictionary<string, List<HistoryEntry>> userHistory)
        {
            SaveToFile(userHistory);
        }

        private static void SaveToFile(Dictionary<string, List<HistoryEntry>> userHistory)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (var entry in userHistory)
                {
                    string playerName = entry.Key;
                    foreach (var historyEntry in entry.Value)
                    {
                        writer.WriteLine($"{playerName}, {historyEntry.Points}, {historyEntry.Steals}, {historyEntry.Blocks}, {historyEntry.Assists}, {historyEntry.Rebound}, {historyEntry.Turnover}, {historyEntry.FieldGoal}, {historyEntry.MadeFieldGoals}, {historyEntry.AttemptFieldGoals}");
                    }
                }
            }
        }

        public static Dictionary<string, List<HistoryEntry>> LoadUserScores()
        {
            Dictionary<string, List<HistoryEntry>> userHistory = new Dictionary<string, List<HistoryEntry>>();

            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 10)
                        {
                            string playerName = parts[0].Trim(); 
                            int points = int.Parse(parts[1].Trim());
                            int steals = int.Parse(parts[2].Trim());
                            int blocks = int.Parse(parts[3].Trim());
                            int assists = int.Parse(parts[4].Trim());
                            int rebound = int.Parse(parts[5].Trim());
                            int turnover = int.Parse(parts[6].Trim());
                            double fieldgoal = double.Parse(parts[7].Trim());
                            int madeFieldGoals = int.Parse(parts[8].Trim());
                            int attemptedFieldGoals = int.Parse((parts[9].Trim()).Trim());

                            if (!userHistory.ContainsKey(playerName))
                            {
                                userHistory[playerName] = new List<HistoryEntry>();
                            }

                            userHistory[playerName].Add(new HistoryEntry { Points = points, Steals = steals, Blocks = blocks, Assists = assists, Rebound = rebound, Turnover = turnover, FieldGoal = fieldgoal, MadeFieldGoals = madeFieldGoals, AttemptFieldGoals = attemptedFieldGoals });
                        }
                    }
                }
            }

            return userHistory;
        }
    }



    public class HistoryEntry
    {
        public int Points { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Assists { get; set; }
        public int Rebound { get; set; }
        public int Turnover { get; set; }
        public double FieldGoal { get; set; }
        public int MadeFieldGoals { get; set; }
        public int AttemptFieldGoals { get; set; }
    }
}
