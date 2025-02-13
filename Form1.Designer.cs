namespace ScoreCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            redTeamLabel = new Label();
            blueTeamLabel = new Label();
            red1OriginalScore = new TextBox();
            totalRevicedScoreLabel = new Label();
            vsLabel = new Label();
            redTotalScore = new Label();
            blueTotalScore = new Label();
            dashRevicedLabel = new Label();
            red2OriginalScore = new TextBox();
            red2Mods = new TextBox();
            red1Mods = new TextBox();
            redOriginalScoreLabel = new Label();
            redModLabel = new Label();
            redNormalizedScoreLabel = new Label();
            blueNormalizedScoreLabel = new Label();
            blueModLabel = new Label();
            blueOriginalScoreLabel = new Label();
            blue2Mods = new TextBox();
            blue1Mods = new TextBox();
            blue2OriginalScore = new TextBox();
            blue1OriginalScore = new TextBox();
            red1NormalizedScore = new Label();
            red2NormalizedScore = new Label();
            blue2NormalizedScore = new Label();
            blue1NormalizedScore = new Label();
            conditionLabel = new Label();
            calculateFMMod = new Button();
            calculateScore = new Button();
            currentMap = new ComboBox();
            redModCount = new Label();
            blueModCount = new Label();
            SuspendLayout();
            // 
            // redTeamLabel
            // 
            redTeamLabel.AutoSize = true;
            redTeamLabel.Location = new Point(12, 96);
            redTeamLabel.Name = "redTeamLabel";
            redTeamLabel.Size = new Size(31, 15);
            redTeamLabel.TabIndex = 0;
            redTeamLabel.Text = "紅隊";
            // 
            // blueTeamLabel
            // 
            blueTeamLabel.AutoSize = true;
            blueTeamLabel.Location = new Point(754, 96);
            blueTeamLabel.Name = "blueTeamLabel";
            blueTeamLabel.Size = new Size(31, 15);
            blueTeamLabel.TabIndex = 7;
            blueTeamLabel.Text = "藍隊";
            // 
            // red1OriginalScore
            // 
            red1OriginalScore.Location = new Point(60, 48);
            red1OriginalScore.Name = "red1OriginalScore";
            red1OriginalScore.Size = new Size(85, 23);
            red1OriginalScore.TabIndex = 34;
            // 
            // totalRevicedScoreLabel
            // 
            totalRevicedScoreLabel.AutoSize = true;
            totalRevicedScoreLabel.Location = new Point(94, 226);
            totalRevicedScoreLabel.Name = "totalRevicedScoreLabel";
            totalRevicedScoreLabel.Size = new Size(79, 15);
            totalRevicedScoreLabel.TabIndex = 18;
            totalRevicedScoreLabel.Text = "修正分數總和";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Location = new Point(391, 97);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(18, 15);
            vsLabel.TabIndex = 27;
            vsLabel.Text = "vs";
            // 
            // redTotalScore
            // 
            redTotalScore.AutoSize = true;
            redTotalScore.Location = new Point(252, 226);
            redTotalScore.Name = "redTotalScore";
            redTotalScore.Size = new Size(14, 15);
            redTotalScore.TabIndex = 29;
            redTotalScore.Text = "0";
            redTotalScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // blueTotalScore
            // 
            blueTotalScore.AutoSize = true;
            blueTotalScore.Location = new Point(367, 226);
            blueTotalScore.Name = "blueTotalScore";
            blueTotalScore.Size = new Size(14, 15);
            blueTotalScore.TabIndex = 31;
            blueTotalScore.Text = "0";
            blueTotalScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dashRevicedLabel
            // 
            dashRevicedLabel.AutoSize = true;
            dashRevicedLabel.Location = new Point(314, 226);
            dashRevicedLabel.Name = "dashRevicedLabel";
            dashRevicedLabel.Size = new Size(12, 15);
            dashRevicedLabel.TabIndex = 33;
            dashRevicedLabel.Text = "-";
            // 
            // red2OriginalScore
            // 
            red2OriginalScore.Location = new Point(60, 130);
            red2OriginalScore.Name = "red2OriginalScore";
            red2OriginalScore.Size = new Size(85, 23);
            red2OriginalScore.TabIndex = 35;
            // 
            // red2Mods
            // 
            red2Mods.Location = new Point(173, 130);
            red2Mods.Name = "red2Mods";
            red2Mods.Size = new Size(85, 23);
            red2Mods.TabIndex = 38;
            // 
            // red1Mods
            // 
            red1Mods.Location = new Point(173, 48);
            red1Mods.Name = "red1Mods";
            red1Mods.Size = new Size(85, 23);
            red1Mods.TabIndex = 37;
            // 
            // redOriginalScoreLabel
            // 
            redOriginalScoreLabel.AutoSize = true;
            redOriginalScoreLabel.Location = new Point(74, 19);
            redOriginalScoreLabel.Name = "redOriginalScoreLabel";
            redOriginalScoreLabel.Size = new Size(55, 15);
            redOriginalScoreLabel.TabIndex = 39;
            redOriginalScoreLabel.Text = "原始分數";
            // 
            // redModLabel
            // 
            redModLabel.AutoSize = true;
            redModLabel.Location = new Point(196, 19);
            redModLabel.Name = "redModLabel";
            redModLabel.Size = new Size(35, 15);
            redModLabel.TabIndex = 40;
            redModLabel.Text = "Mod";
            // 
            // redNormalizedScoreLabel
            // 
            redNormalizedScoreLabel.AutoSize = true;
            redNormalizedScoreLabel.Location = new Point(297, 19);
            redNormalizedScoreLabel.Name = "redNormalizedScoreLabel";
            redNormalizedScoreLabel.Size = new Size(67, 15);
            redNormalizedScoreLabel.TabIndex = 41;
            redNormalizedScoreLabel.Text = "標準化分數";
            // 
            // blueNormalizedScoreLabel
            // 
            blueNormalizedScoreLabel.AutoSize = true;
            blueNormalizedScoreLabel.Location = new Point(432, 19);
            blueNormalizedScoreLabel.Name = "blueNormalizedScoreLabel";
            blueNormalizedScoreLabel.Size = new Size(67, 15);
            blueNormalizedScoreLabel.TabIndex = 51;
            blueNormalizedScoreLabel.Text = "標準化分數";
            // 
            // blueModLabel
            // 
            blueModLabel.AutoSize = true;
            blueModLabel.Location = new Point(559, 19);
            blueModLabel.Name = "blueModLabel";
            blueModLabel.Size = new Size(35, 15);
            blueModLabel.TabIndex = 50;
            blueModLabel.Text = "Mod";
            // 
            // blueOriginalScoreLabel
            // 
            blueOriginalScoreLabel.AutoSize = true;
            blueOriginalScoreLabel.Location = new Point(662, 19);
            blueOriginalScoreLabel.Name = "blueOriginalScoreLabel";
            blueOriginalScoreLabel.Size = new Size(55, 15);
            blueOriginalScoreLabel.TabIndex = 49;
            blueOriginalScoreLabel.Text = "原始分數";
            // 
            // blue2Mods
            // 
            blue2Mods.Location = new Point(536, 130);
            blue2Mods.Name = "blue2Mods";
            blue2Mods.Size = new Size(85, 23);
            blue2Mods.TabIndex = 48;
            // 
            // blue1Mods
            // 
            blue1Mods.Location = new Point(536, 48);
            blue1Mods.Name = "blue1Mods";
            blue1Mods.Size = new Size(85, 23);
            blue1Mods.TabIndex = 47;
            // 
            // blue2OriginalScore
            // 
            blue2OriginalScore.Location = new Point(648, 130);
            blue2OriginalScore.Name = "blue2OriginalScore";
            blue2OriginalScore.Size = new Size(85, 23);
            blue2OriginalScore.TabIndex = 45;
            // 
            // blue1OriginalScore
            // 
            blue1OriginalScore.Location = new Point(648, 48);
            blue1OriginalScore.Name = "blue1OriginalScore";
            blue1OriginalScore.Size = new Size(85, 23);
            blue1OriginalScore.TabIndex = 44;
            // 
            // red1NormalizedScore
            // 
            red1NormalizedScore.AutoSize = true;
            red1NormalizedScore.Location = new Point(323, 51);
            red1NormalizedScore.Name = "red1NormalizedScore";
            red1NormalizedScore.Size = new Size(14, 15);
            red1NormalizedScore.TabIndex = 52;
            red1NormalizedScore.Text = "0";
            red1NormalizedScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // red2NormalizedScore
            // 
            red2NormalizedScore.AutoSize = true;
            red2NormalizedScore.Location = new Point(323, 133);
            red2NormalizedScore.Name = "red2NormalizedScore";
            red2NormalizedScore.Size = new Size(14, 15);
            red2NormalizedScore.TabIndex = 53;
            red2NormalizedScore.Text = "0";
            red2NormalizedScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blue2NormalizedScore
            // 
            blue2NormalizedScore.AutoSize = true;
            blue2NormalizedScore.Location = new Point(459, 133);
            blue2NormalizedScore.Name = "blue2NormalizedScore";
            blue2NormalizedScore.Size = new Size(14, 15);
            blue2NormalizedScore.TabIndex = 55;
            blue2NormalizedScore.Text = "0";
            blue2NormalizedScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blue1NormalizedScore
            // 
            blue1NormalizedScore.AutoSize = true;
            blue1NormalizedScore.Location = new Point(459, 51);
            blue1NormalizedScore.Name = "blue1NormalizedScore";
            blue1NormalizedScore.Size = new Size(14, 15);
            blue1NormalizedScore.TabIndex = 54;
            blue1NormalizedScore.Text = "0";
            blue1NormalizedScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(419, 249);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(0, 15);
            conditionLabel.TabIndex = 56;
            // 
            // calculateFMMod
            // 
            calculateFMMod.Location = new Point(664, 213);
            calculateFMMod.Name = "calculateFMMod";
            calculateFMMod.Size = new Size(121, 25);
            calculateFMMod.TabIndex = 57;
            calculateFMMod.Text = "計算Mod數量";
            calculateFMMod.UseVisualStyleBackColor = true;
            calculateFMMod.Click += calFMCount;
            // 
            // calculateScore
            // 
            calculateScore.Location = new Point(664, 244);
            calculateScore.Name = "calculateScore";
            calculateScore.Size = new Size(121, 25);
            calculateScore.TabIndex = 58;
            calculateScore.Text = "計算分數";
            calculateScore.UseVisualStyleBackColor = true;
            calculateScore.Click += calScore;
            // 
            // currentMap
            // 
            currentMap.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMap.FormattingEnabled = true;
            currentMap.Items.AddRange(new object[] { "FM1", "FM2", "FM3", "FM4", "FM5", "FM6", "FM7", "TB" });
            currentMap.Location = new Point(664, 184);
            currentMap.Name = "currentMap";
            currentMap.Size = new Size(121, 23);
            currentMap.TabIndex = 59;
            // 
            // redModCount
            // 
            redModCount.AutoSize = true;
            redModCount.Location = new Point(20, 132);
            redModCount.Name = "redModCount";
            redModCount.Size = new Size(14, 15);
            redModCount.TabIndex = 60;
            redModCount.Text = "0";
            redModCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blueModCount
            // 
            blueModCount.AutoSize = true;
            blueModCount.Location = new Point(762, 130);
            blueModCount.Name = "blueModCount";
            blueModCount.Size = new Size(14, 15);
            blueModCount.TabIndex = 61;
            blueModCount.Text = "0";
            blueModCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 281);
            Controls.Add(blueModCount);
            Controls.Add(redModCount);
            Controls.Add(currentMap);
            Controls.Add(calculateScore);
            Controls.Add(calculateFMMod);
            Controls.Add(conditionLabel);
            Controls.Add(blue2NormalizedScore);
            Controls.Add(blue1NormalizedScore);
            Controls.Add(red2NormalizedScore);
            Controls.Add(red1NormalizedScore);
            Controls.Add(blueNormalizedScoreLabel);
            Controls.Add(blueModLabel);
            Controls.Add(blueOriginalScoreLabel);
            Controls.Add(blue2Mods);
            Controls.Add(blue1Mods);
            Controls.Add(blue2OriginalScore);
            Controls.Add(blue1OriginalScore);
            Controls.Add(redNormalizedScoreLabel);
            Controls.Add(redModLabel);
            Controls.Add(redOriginalScoreLabel);
            Controls.Add(red2Mods);
            Controls.Add(red1Mods);
            Controls.Add(red2OriginalScore);
            Controls.Add(red1OriginalScore);
            Controls.Add(dashRevicedLabel);
            Controls.Add(blueTotalScore);
            Controls.Add(redTotalScore);
            Controls.Add(vsLabel);
            Controls.Add(totalRevicedScoreLabel);
            Controls.Add(blueTeamLabel);
            Controls.Add(redTeamLabel);
            Name = "Form1";
            Text = "TTT4.5 Freemod Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label redTeamLabel;
        private Label blueTeamLabel;
        private TextBox red1OriginalScore;
        private Label totalRevicedScoreLabel;
        private Label vsLabel;
        private Label redTotalScore;
        private Label blueTotalScore;
        private Label dashRevicedLabel;
        private TextBox red2OriginalScore;
        private TextBox red2Mods;
        private TextBox red1Mods;
        private Label redOriginalScoreLabel;
        private Label redModLabel;
        private Label redNormalizedScoreLabel;
        private Label blueNormalizedScoreLabel;
        private Label blueModLabel;
        private Label blueOriginalScoreLabel;
        private TextBox blue2Mods;
        private TextBox blue1Mods;
        private TextBox blue2OriginalScore;
        private TextBox blue1OriginalScore;
        private Label red1NormalizedScore;
        private Label red2NormalizedScore;
        private Label blue2NormalizedScore;
        private Label blue1NormalizedScore;
        private Label conditionLabel;
        private Button calculateFMMod;
        private Button calculateScore;
        private ComboBox currentMap;
        private Label redModCount;
        private Label blueModCount;
    }
}