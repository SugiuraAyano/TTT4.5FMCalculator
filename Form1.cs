using static System.Formats.Asn1.AsnWriter;
using System.Net.Http.Json;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        List<Map> maps;
        HttpClient client = new HttpClient();
        Regex reg = new Regex(@"\d+$");

        public async Task<string> readUsername(int userid)
        {
            var response = await client.GetStringAsync($"https://osu.ppy.sh/api/get_user?k={"NOPE"}&u={userid}");
            JsonNode data = JsonNode.Parse(response)!;
            return data[0]["username"].GetValue<string>();
        }

        public int scoreConvert(int beatmapId, int score, int? mods)
        {
            double adjustScore;
            var target = maps.Where(m => m.beatmap_id == beatmapId);
            if (target.Any())
            {
                var matchdata = target.First();
                if ((mods & 8) != 0)
                {
                    switch (matchdata.mods)
                    {
                        case "NM":
                            adjustScore = score / 1.06;
                            return (int)adjustScore;
                        case "HR":
                        case "DT":
                            adjustScore = score / 1.07;
                            return (int)adjustScore;

                        default:
                            break;
                    }

                }
            }

            return score;
        }

        public Form1()
        {
            InitializeComponent();
            var f = File.ReadAllText("maps.json");
            // MessageBox.Show(f);
            maps = JsonSerializer.Deserialize<List<Map>>(File.ReadAllText("./maps.json"), new JsonSerializerOptions { NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict });

            // MessageBox.Show(String.Join("\n", maps.Select(map=>$"{map.mods} {map.beatmap_id}")));

        }

        private async void getMatchDataBtn_ClickAsync(object sender, EventArgs e)
        {
            // payload = { 'k': 'NOPE', 'mp': }
            var mpid = reg.Match(matchIdTextbox.Text).Value;
            var response = await client.GetFromJsonAsync<Root>($"https://osu.ppy.sh/api/get_match?k={"NOPE"}&mp={mpid}", new JsonSerializerOptions { NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString });
            var lastMatch = response.games[response.games.Count - 1];

            foreach (var m in lastMatch.scores)
            {
                switch (m.slot)
                {
                    case 0:
                        redPlayer1.Text = await readUsername(m.user_id);
                        redPlayer1ScoreOriginal.Text = m.score.ToString();
                        redPlayer1ScoreReviced.Text = scoreConvert(lastMatch.beatmap_id, m.score, m.enabled_mods).ToString();
                        break;
                    case 1:
                        redPlayer2.Text = await readUsername(m.user_id);
                        redPlayer2ScoreOriginal.Text = m.score.ToString();
                        redPlayer2ScoreReviced.Text = scoreConvert(lastMatch.beatmap_id, m.score, m.enabled_mods).ToString();
                        break;
                    case 2:
                        bluePlayer1.Text = await readUsername(m.user_id);
                        bluePlayer1ScoreOriginal.Text = m.score.ToString();
                        bluePlayer1ScoreReviced.Text = scoreConvert(lastMatch.beatmap_id, m.score, m.enabled_mods).ToString();
                        break;
                    case 3:
                        bluePlayer2.Text = await readUsername(m.user_id);
                        bluePlayer2ScoreOriginal.Text = m.score.ToString();
                        bluePlayer2ScoreReviced.Text = scoreConvert(lastMatch.beatmap_id, m.score, m.enabled_mods).ToString();
                        break;
                    default:
                        break;
                }
            }

            redTotalScoreOriginal.Text = (int.Parse(redPlayer1ScoreOriginal.Text) + int.Parse(redPlayer2ScoreOriginal.Text)).ToString();
            redTotalScoreReviced.Text = (int.Parse(redPlayer1ScoreReviced.Text) + int.Parse(redPlayer2ScoreReviced.Text)).ToString();
            blueTotalScoreOriginal.Text = (int.Parse(bluePlayer1ScoreOriginal.Text) + int.Parse(bluePlayer2ScoreOriginal.Text)).ToString();
            blueTotalScoreReviced.Text = (int.Parse(bluePlayer1ScoreReviced.Text) + int.Parse(bluePlayer2ScoreReviced.Text)).ToString();

            if (int.Parse(redTotalScoreReviced.Text) > int.Parse(blueTotalScoreReviced.Text))
            {
                winner.Text = "紅方勝利!!";
            }
            else if (int.Parse(redTotalScoreReviced.Text) < int.Parse(blueTotalScoreReviced.Text))
            {
                winner.Text = "藍方勝利!!";
            }
            else
            {
                winner.Text = "平手!!";
            }
        }
    }
    public class Match {
        public int match_id { get; set; }
        public string name { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
    public class Games
    {
        public int game_id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public int beatmap_id { get; set; }
        public int play_mode { get; set; }
        public int match_type { get; set; }
        public int scoring_type { get; set; }
        public int team_type { get; set; }
        public int mods { get; set; }
        public List<Scores> scores { get; set; }
    }

    public class Scores
    {
        public int slot { get; set; }
        public int team { get; set; }
        public int user_id { get; set; }
        public int score { get; set; }
        public int maxcombo { get; set; }
        public int count50 { get; set; }
        public int count100 { get; set; }
        public int count300 { get; set; }
        public int countmiss { get; set; }
        public int countgeki { get; set; }
        public int countkatu { get; set; }
        public int perfect { get; set; }
        public int pass { get; set; }
        public int? enabled_mods { get; set; }
    }

    public class Root {
        public Match match { get; set; }
        public List<Games> games { get; set; }
    }

    public class Map {
        public string mods { get; set; }
        public int beatmap_id { get; set; }
    }

    
}