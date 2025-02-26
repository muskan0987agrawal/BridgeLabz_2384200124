using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using CsvHelper;


using System.Globalization;
using System.Formats.Asn1;

class IPLCensorshipAnalyzer
{
    static void Main()
    {
        string jsonInputPath = "ipl_matches.json";
        string jsonOutputPath = "ipl_matches_censored.json";
        string csvInputPath = "ipl_matches.csv";
        string csvOutputPath = "ipl_matches_censored.csv";

        // Process JSON File
        List<Match> matches = ReadJson(jsonInputPath);
        ApplyCensorship(matches);
        WriteJson(jsonOutputPath, matches);

        // Process CSV File
        List<Match> csvMatches = ReadCsv(csvInputPath);
        ApplyCensorship(csvMatches);
        WriteCsv(csvOutputPath, csvMatches);

        Console.WriteLine("Censorship Applied & Files Saved Successfully!");
    }

    // Read JSON File
    static List<Match> ReadJson(string path)
    {
        string jsonString = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<Match>>(jsonString);
    }

    // Write JSON File
    static void WriteJson(string path, List<Match> matches)
    {
        string jsonString = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText(path, jsonString);
    }

    // Read CSV File
    static List<Match> ReadCsv(string path)
    {
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Match>().ToList();
        }
    }

    // Write CSV File
    static void WriteCsv(string path, List<Match> matches)
    {
        using (var writer = new StreamWriter(path))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(matches);
        }
    }

    // Apply Censorship
    static void ApplyCensorship(List<Match> matches)
    {
        foreach (var match in matches)
        {
            match.team1 = MaskTeamName(match.team1);
            match.team2 = MaskTeamName(match.team2);
            match.winner = MaskTeamName(match.winner);
            match.player_of_match = "REDACTED";

            // Update scores dictionary with masked names
            Dictionary<string, int> newScores = new Dictionary<string, int>();
            foreach (var key in match.score.Keys)
            {
                newScores[MaskTeamName(key)] = match.score[key];
            }
            match.score = newScores;
        }
    }

    // Mask Team Name (Replace last word with "***")
    static string MaskTeamName(string teamName)
    {
        var words = teamName.Split(' ');
        if (words.Length > 1)
            words[words.Length - 1] = "***";
        return string.Join(" ", words);
    }
}

// Class to represent Match Data
class Match
{
    public int match_id { get; set; }
    public string team1 { get; set; }
    public string team2 { get; set; }
    public Dictionary<string, int> score { get; set; }
    public string winner { get; set; }
    public string player_of_match { get; set; }
}

