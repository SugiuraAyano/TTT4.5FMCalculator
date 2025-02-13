using System.Linq;
using System.Text.Json;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public List<Mod>? mods;
        public List<Map>? maps;
        public int? redTotalModsCountGlobal;
        public int? blueTotalModsCountGlobal;
        public readonly List<string>? noOverlapModsList = new List<string> { "HD", "HR", "EZ", "MR", "AL", "SY" };

        public Form1()
        {
            InitializeComponent();
            // var f = File.ReadAllText("maps.json");
            // MessageBox.Show(f);
            mods = JsonSerializer.Deserialize<List<Mod>>(File.ReadAllText("./mods.json"), new JsonSerializerOptions { NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict });
            maps = JsonSerializer.Deserialize<List<Map>>(File.ReadAllText("./maps.json"), new JsonSerializerOptions { NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict });
            // MessageBox.Show(String.Join("\n", mods.Select(map=>$"{map.acronym} {map.magnification} {map.value}")));

        }

        private void calScore(object sender, EventArgs e)
        {
            calFMCount(this, EventArgs.Empty);
            float red1Score;
            float red2Score;
            float blue1Score;
            float blue2Score;

            if (currentMap.Text == null || currentMap.Text == "")
            {
                conditionLabel.Text = "未輸入圖! 請在右下角下拉式選單選擇圖!";
                return;
            }

            if (red1OriginalScore.Text != "")
            {
                red1Score = float.Parse(red1OriginalScore.Text);
            }
            else
            {
                conditionLabel.Text = "未輸入紅方選手的分數!";
                return;
            }

            if (red2OriginalScore.Text != "")
            {
                red2Score = float.Parse(red2OriginalScore.Text);
            }
            else
            {
                conditionLabel.Text = "未輸入紅方選手的分數!";
                return;
            }

            if (blue1OriginalScore.Text != "")
            {
                blue1Score = float.Parse(blue1OriginalScore.Text);
            }
            else
            {
                conditionLabel.Text = "未輸入藍方選手的分數!";
                return;
            }

            if (blue2OriginalScore.Text != "")
            {
                blue2Score = float.Parse(blue2OriginalScore.Text);
            }
            else
            {
                conditionLabel.Text = "未輸入藍方選手的分數!";
                return;
            }

            red1Score /= (float)maps.Find(map => map.mods == currentMap.Text).defaultMagnification;
            red2Score /= (float)maps.Find(map => map.mods == currentMap.Text).defaultMagnification;
            blue1Score /= (float)maps.Find(map => map.mods == currentMap.Text).defaultMagnification;
            blue2Score /= (float)maps.Find(map => map.mods == currentMap.Text).defaultMagnification;

            List<string> red1ModsList = red1Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> red2ModsList = red2Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());

            List<string> blue1ModsList = blue1Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> blue2ModsList = blue2Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());

            foreach (string m in red1ModsList)
            {
                Mod mod = mods.Find(target => target.acronym == m);
                
                if (mod.value < 0)
                {
                    conditionLabel.Text = "紅方開啟了不合法的Mod! 請注意!";
                    return;
                }
                else
                {
                    red1Score /= (float)mod.magnification;
                }
            }

            foreach (string m in red2ModsList)
            {
                Mod mod = mods.Find(target => target.acronym == m);

                if (mod.value < 0)
                {
                    conditionLabel.Text = "紅方開啟了不合法的Mod! 請注意!";
                    return;
                }
                else
                {
                    red2Score /= (float)mod.magnification;
                }
            }

            foreach (string m in blue1ModsList)
            {
                Mod mod = mods.Find(target => target.acronym == m);

                if (mod.value < 0)
                {
                    conditionLabel.Text = "藍方開啟了不合法的Mod! 請注意!";
                    return;
                }
                else
                {
                    blue1Score /= (float)mod.magnification;
                }
            }

            foreach (string m in blue2ModsList)
            {
                Mod mod = mods.Find(target => target.acronym == m);

                if (mod.value < 0)
                {
                    conditionLabel.Text = "藍方開啟了不合法的Mod! 請注意!";
                    return;
                }
                else
                {
                    blue2Score /= (float)mod.magnification;
                }
            }

            if (redTotalModsCountGlobal.HasValue && blueTotalModsCountGlobal.HasValue)
            {
                red1Score *= (float)(1.0 + 0.05 * (float)redTotalModsCountGlobal);
                red2Score *= (float)(1.0 + 0.05 * (float)redTotalModsCountGlobal);
                blue1Score *= (float)(1.0 + 0.05 * (float)blueTotalModsCountGlobal);
                blue2Score *= (float)(1.0 + 0.05 * (float)blueTotalModsCountGlobal);
            }
            else 
            {
                conditionLabel.Text = "尚未計算FM數量, 請按下\"計算Mod數量\"按鈕";
                return;
            }

            int tempRedTotalScore = Convert.ToInt32(red1Score) + Convert.ToInt32(red2Score);
            int tempBlueTotalScore = Convert.ToInt32(blue1Score) + Convert.ToInt32(blue2Score);


            redTotalScore.Text = tempRedTotalScore.ToString();
            blueTotalScore.Text = tempBlueTotalScore.ToString();

            if (tempRedTotalScore > tempBlueTotalScore) {
                conditionLabel.Text = $"紅方勝利! 贏了{tempRedTotalScore-tempBlueTotalScore}分!";
                return;
            }
            else if (tempRedTotalScore < tempBlueTotalScore)
            {
                conditionLabel.Text = $"藍方勝利! 贏了{tempBlueTotalScore - tempRedTotalScore}分!";
                return;

            }
            else {
                conditionLabel.Text = "平局! 真的假的!?";
                return;
            }


        }

        private void calFMCount(object sender, EventArgs e)
        {
            if (currentMap.Text == null || currentMap.Text == "")
            {
                conditionLabel.Text = "未輸入圖! 請在右下角下拉式選單選擇圖!";
                return;
            }

            List<string> red1ModsList = red1Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> red2ModsList = red2Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> redTotalModsList = red1ModsList.Concat(red2ModsList).ToList();

            List<string> blue1ModsList = blue1Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> blue2ModsList = blue2Mods.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper());
            List<string> blueTotalModsList = blue1ModsList.Concat(blue2ModsList).ToList();

            int targetCount = maps.Find(map => map.mods == currentMap.Text).requestValue;
            int redTotalModsCount = 0;
            int blueTotalModsCount = 0;

            List<string> redOverlapModsList = red1ModsList.Intersect(red2ModsList).Except(noOverlapModsList).ToList();
            List<string> blueOverlapModsList = blue1ModsList.Intersect(blue2ModsList).Except(noOverlapModsList).ToList();

            if (redOverlapModsList.Count != 0)
            {
                redTotalModsCount++;
            }
            if (blueOverlapModsList.Count != 0)
            {
                blueTotalModsCount++;
            }

            foreach (string redMod in redTotalModsList)
            {
                Mod mod = mods.Find(mod => mod.acronym == redMod);
                Map map = maps.Find(map => map.mods == currentMap.Text);
                List<string> bonusMods = map.bonusMods.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(w => w.ToUpper()); ;

                if (mod.value < 0)
                {
                    continue;
                }
                else if (bonusMods.Contains(mod.acronym))
                {
                    redTotalModsCount += mod.value;
                    redTotalModsCount += 2;
                }
                else
                {
                    redTotalModsCount += mod.value;
                }
            }

            foreach (string blueMod in blueTotalModsList)
            {
                Mod mod = mods.Find(mod => mod.acronym == blueMod);
                Map map = maps.Find(map => map.mods == currentMap.Text);
                List<string> bonusMods = map.bonusMods.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (mod.value < 0)
                {
                    continue;
                }
                else if (bonusMods.Count != 0 && bonusMods.Contains(mod.acronym))
                {
                    blueTotalModsCount += mod.value;
                    blueTotalModsCount += 2;
                }
                else
                {
                    blueTotalModsCount += mod.value;
                }
            }

            redModCount.Text = redTotalModsCount.ToString();
            blueModCount.Text = blueTotalModsCount.ToString();

            if (redTotalModsCount < targetCount)
            {
                conditionLabel.Text = "紅隊Mod數量不足!";
                return;
            }
            else if (blueTotalModsCount < targetCount)
            {
                conditionLabel.Text = "藍隊Mod數量不足!";
                return;
            }
            else
            {
                conditionLabel.Text = "雙方Mod數量足夠, 可以開始比賽!";
                redTotalModsCountGlobal = redTotalModsCount;
                blueTotalModsCountGlobal = blueTotalModsCount;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Mod
    {
        public required string acronym { get; set; }
        public required float magnification { get; set; }
        public required int value { get; set; }
    }

    public class Map
    {
        public required string mods { get; set; }
        public required float defaultMagnification { get; set; }
        public required int requestValue { get; set; }
        public required string bonusMods { get; set; }
    }

}
