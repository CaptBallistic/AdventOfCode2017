using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Challenges;


namespace AdventOfCode2017
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            this.Load += UI_Load;

        }

        public enum ChallengesCoded
        {
            One = 1
        }

        private void UI_Load(object sender, EventArgs e)
        {
            challengeSelect.DataSource = Enum.GetValues(typeof(ChallengesCoded));
        }

        public void startProcess (object sender, EventArgs e)
        {
            var modifier = rbtnChallenge1.Checked ? 1 : 2;
            var result = ChallengeOne.challengeOne(modifier);

            string messageText = result.ToString();
            string messageCaption = String.Format("Challenge {0} output", challengeSelect.SelectedItem);
            MessageBoxButtons response = MessageBoxButtons.OK;
            
            MessageBox.Show(messageText, messageCaption, response);
                
        }
        
    }
}
