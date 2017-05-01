using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMI
{
    public partial class mainForm : Form
    {
        string idGoogl;
        string idFacebook;
        string facebookToken;
        string idMission;
        string missionResults;
        string ENleft;
        string ENcost = "0";
        int statutProcess = 0; // 0 = not started;  1 = on process and waiting to finish; 2 = finished; 4 = on loop process; 5 = loop finished
        int counter = 0;
        int minLeft = 0;
        int timer_counter = 0;
        int nbrMissionDone = 0;
        int repeater = 0;
        int nbrOfRepeat = 0;


        public mainForm()
        {
            InitializeComponent();
        }

        /***************************************************************************************/
        /********************************** Event Handled **************************************/
        /***************************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSavedData("conf");
            goToHome();

        }

        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                loadSavedData("conf2");
            }

        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            DialogResult confirmSendAction = MessageBox.Show("Are you sure to start the bot with current informations", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmSendAction== DialogResult.Yes){

                //sendPost();
                waitCursorFunction(1);
                goToHome();
                refreshValue();
                nbrOfRepeat = int.Parse(txtB_NbrRepeat.Text);
                timer_loop.Start();

            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            string dataToSave = "google_id&" + txtB_IdGoogl.Text + "$facebook_id&" + txtB_IdFacebook.Text + "$facebook_token&" + rTxtB_FacebookToken.Text + "$mission&" + txtB_IdMission.Text
                + "$ENcost&" + txtB_ENConsume.Text;
            File.WriteAllText("conf", dataToSave);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                repeater = 1;
            }
            else
            {
                repeater = 0;
            }
        }

        private void chkB_loop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_loop.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                repeater = 0;
                txtB_NbrRepeat.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                txtB_NbrRepeat.Enabled = true;
            }
        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            if (statutProcess == 4 && timer_counter < minLeft)
            {
                timer_counter++;
                label_timeleft.Text = (minLeft - timer_counter).ToString()+" Minutes left";
            }
            else if (statutProcess == 4 && timer_counter == minLeft)
            {
                statutProcess = 5;
                timer_count.Stop();
                timer_count.Interval = 30000;
                timer_count.Start();
            }
            else if (statutProcess == 5)
            {
                initializeApp();
                timer_count.Interval = 65000;
                waitCursorFunction(1);
                refreshValue();
                timer_loop.Start();
            }
        }

        private void timer_loop_Tick(object sender, EventArgs e)
        {
            if (statutProcess == 0)
            {
                if (webBrowser1.Document.GetElementsByTagName("input").Count > 0)
                {
                    HtmlElementCollection elms = webBrowser1.Document.GetElementsByTagName("input");
                    foreach (HtmlElement elm in elms){
                        if (elm.GetAttribute("name").Equals("lid"))
                        {
                            statutProcess = 1;
                        }
                    }
                    
                }
            }
            else if (statutProcess == 1)
            {
                
                fillFormPost();


                HtmlElementCollection elms = webBrowser1.Document.GetElementsByTagName("button");
                foreach (HtmlElement elm in elms)
                {
                    if (elm.GetAttribute("type").Equals("submit"))
                    {
                        elm.InvokeMember("click");
                        statutProcess = 2;
                    }
                }
                
                counter++;
                progressBar1.Visible = true;
                progressBar1.Value = counter;
            }
            else if(statutProcess == 2)
            {
                if (webBrowser1.Document.GetElementsByTagName("pre").Count > 0)
                {
                    statutProcess = 3;
                }
                counter++;
                progressBar1.Value = counter;
            }
            else if (statutProcess == 3)
            {
                initializeApp();
                lastTreatment();
            }

            if(counter>= 60)
            {
                counter = 0;
                initializeApp();
                MessageBox.Show("Something went wrong !!");
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            initializeApp();
            
        }
       
        /***************************************************************************************/
        /************************************ Functions ****************************************/
        /***************************************************************************************/

        private void get_EN_Left(String response)
        {
            if (response.Contains("wrong")==false)
            {
                response = response.Replace("[+]", "&");
                ENleft = response.Split('&')[5].Split(' ')[3];
            }
            
        }

        private void loadSavedData(String fil)
        {
            if (File.Exists(fil))
            {
                string dataToRead = File.ReadAllText(fil);
                string[] dataSpl = dataToRead.Split('$');
                idGoogl = dataSpl[0].Split('&')[1];
                idFacebook = dataSpl[1].Split('&')[1];
                facebookToken = dataSpl[2].Split('&')[1];
                idMission = dataSpl[3].Split('&')[1];
                ENcost = dataSpl[4].Split('&')[1];
                fillData();
            }
            
        }

        private void fillData()
        {
            rTxtB_FacebookToken.Text = facebookToken;
            txtB_IdFacebook.Text = idFacebook;
            txtB_IdGoogl.Text = idGoogl;
            txtB_IdMission.Text = idMission;
            txtB_ENConsume.Text = ENcost;

        }

        private void refreshValue()
        {
           facebookToken = rTxtB_FacebookToken.Text ;
           idFacebook = txtB_IdFacebook.Text ;
           idGoogl = txtB_IdGoogl.Text ;
           idMission = txtB_IdMission.Text ;
           ENcost = txtB_ENConsume.Text  ;
        }

        private void fillFormPost()
        {
            HtmlElementCollection elms = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elm in elms)
            {
                if (elm.GetAttribute("name").Equals("lid")){ elm.SetAttribute("value", idGoogl); }
                if (elm.GetAttribute("name").Equals("fid")){ elm.SetAttribute("value", idFacebook); }
                if (elm.GetAttribute("name").Equals("mid")){ elm.SetAttribute("value", idMission); }
                if (elm.GetAttribute("name").Equals("ftk")){ elm.SetAttribute("value", facebookToken); }
            }
        }

        private void goToHome()
        {
            webBrowser1.Navigate("http://ffbe.pw/login");

        }

        private void lastTreatment()
        {
            statutProcess = 0;
            waitCursorFunction(0);
            missionResults = webBrowser1.Document.GetElementsByTagName("code")[0].InnerText;
            rTxtB_MissionResult.Text = missionResults;
            goToHome();
            if (missionResults.Contains("wrong") == false) { 
            get_EN_Left(missionResults);
            nbrMissionDone++;
            label_MissionDone.Text = nbrMissionDone.ToString();

            if (repeater == 1 && nbrOfRepeat > 0)
            {
                if ((int.Parse(ENleft) - int.Parse(txtB_ENConsume.Text) >= 0))
                {
                    waitCursorFunction(1);
                    refreshValue();
                    timer_loop.Start();
                    nbrOfRepeat--;
                }
                else {
                    nbrOfRepeat = 0;
                    txtB_NbrRepeat.Text = "0";
                    checkBox1.Checked = false;
                } 
            }
            else if (chkB_loop.Checked)
            {
                if ((int.Parse(ENleft) - int.Parse(txtB_ENConsume.Text) >= 0)){
                    refreshValue();
                    timer_loop.Start();
                }
                else
                {
                    minLeft = ((int.Parse(txtB_ENConsume.Text) - int.Parse(ENleft)) * 5);
                    label_timeleft.Text = minLeft.ToString() + " Minutes left";
                    statutProcess = 4;
                    timer_count.Start();
                }
                
            }
            }else
            {
                initializeApp();
            }

        }

        private void waitCursorFunction(int i)
        {
            if (i == 0)
            {
                this.Cursor = Cursors.Default;
                txtB_ENConsume.Cursor = Cursors.Default;
                rTxtB_FacebookToken.Cursor = Cursors.Default;
                rTxtB_MissionResult.Cursor = Cursors.Default;
                txtB_IdFacebook.Cursor = Cursors.Default;
                txtB_IdGoogl.Cursor = Cursors.Default;
                txtB_IdMission.Cursor = Cursors.Default;
                chkB_loop.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                txtB_ENConsume.Cursor = Cursors.WaitCursor;
                rTxtB_FacebookToken.Cursor = Cursors.WaitCursor;
                rTxtB_MissionResult.Cursor = Cursors.WaitCursor;
                txtB_IdFacebook.Cursor = Cursors.WaitCursor;
                txtB_IdGoogl.Cursor = Cursors.WaitCursor;
                txtB_IdMission.Cursor = Cursors.WaitCursor;
                chkB_loop.Cursor = Cursors.WaitCursor;
            }
            
        }

        private void initializeApp()
        {
            timer_loop.Stop();
            timer_count.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            statutProcess = 0;
            timer_counter = 0;
        }


    }
}
