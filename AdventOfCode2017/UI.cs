using System;
using System.Windows.Forms;
using Challenges;

namespace AdventOfCode2017
{
    public partial class UI : Form
    {
        public UI()
        {
            this.InitializeComponent();
            this.Load += this.UI_Load;
        }

        public enum ChallengesCoded
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }

        public void StartProcess(object sender, EventArgs e)
        {
            var modifier = this.rbtnChallenge1.Checked ? 1 : 2;
            var result = string.Empty;

            switch (this.challengeSelect.SelectedItem.ToString())
            {
                case "One":
                    result = ChallengeOne.ChallengeOneResult(modifier);
                    break;
                case "Two":
                    result = ChallengeTwo.ChallengeTwoResult(modifier);
                    break;
                case "Three":
                    result = "I didn't do this one! :(";
                    break;
                case "Four":
                    result = ChallengeFour.ChallengeFourResult(modifier);
                    break;
                case "Five":
                    result = ChallengeFive.ChallengeFiveResult(modifier);
                    break;
                default:
                    break;
            }

            string messageText = result.ToString();
            string messageCaption = string.Format("Challenge {0} output", this.challengeSelect.SelectedItem);
            MessageBoxButtons response = MessageBoxButtons.OK;
            
            MessageBox.Show(messageText, messageCaption, response);
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.challengeSelect.DataSource = Enum.GetValues(typeof(ChallengesCoded));
        }
    }
}
