using Memory;

namespace SnipeMask
{
    public partial class MainPanel : Form
    {
        public Mem m = new Mem();
        public MainPanel()
        {
            InitializeComponent();
        }
        //Menu
        Point lastPoint;
        //Player
        bool bHealth = false;
        bool bArmor = false;
        bool bNoclip = false;
        //Weapons
        bool bRecoil = false;
        bool bAmmo = false;
        bool bNades = false;
        bool bRapidAtk = false;
        //Name
        string NewName = "Name";

        private void BgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                int pID = m.GetProcIdFromName("ac_client");

                bool ProcOpen = false;

                if (pID > 0)
                {

                    ProcOpen = m.OpenProcess("ac_client");
                    ProcLabel.Invoke((MethodInvoker)delegate
                    {
                        ProcLabel.Text = "Found";
                        ProcLabel.ForeColor = System.Drawing.Color.Cyan;
                    });

                    Thread.Sleep(1000);
                }

                if (pID == 0)
                   {

                    ProcLabel.Invoke((MethodInvoker)delegate
                    {
                        ProcLabel.Text = "Not Found";
                        ProcLabel.ForeColor = System.Drawing.Color.Red;
                    });

                    Thread.Sleep(1000);

                }

                Thread.Sleep(1000);

            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }


        private void BgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SubHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SubHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CheatName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CheatName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ProcLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void ProcLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ProcIntro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void ProcIntro_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfiniteHealth_CheckedChanged(object sender, EventArgs e)
        {
            bHealth = !bHealth;

                if (bHealth == true)
            {
                m.FreezeValue("ac_client.exe+0x50f4f4,0xF8", "2bytes", "100");
            }
                else
            {
                m.UnfreezeValue("ac_client.exe+0x50f4f4,0xF8");
            }
        }

        private void NoRecoil_CheckedChanged(object sender, EventArgs e)
        {
            bRecoil = !bRecoil;

            if (bRecoil == true)
            {
                m.FreezeValue("ac_client.exe+0x10F4F4,0x374,0C,120", "2bytes", "0");
            }
            else
            {
                m.UnfreezeValue("ac_client.exe+0x10F4F4,0x374,0C,120");
            }
        }

        private void InfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            bAmmo = !bAmmo;

            if (bAmmo == true)
            {
                m.FreezeValue("ac_client.exe+0x50f4f4,0x374,14,0", "2bytes", "20");
            }
            else
            {
                m.UnfreezeValue("ac_client.exe+0x50f4f4,0x374,14,0");
            }
        }

        private void NoClip_CheckedChanged(object sender, EventArgs e)
        {
            bNoclip = !bNoclip;

            if (bNoclip == true)
            {
                m.FreezeValue("ac_client.exe+0x50f4f4,0x338", "4bytes", "5");
                m.FreezeValue("ac_client.exe+0x50f4f4,0x82", "4bytes", "11");
            }
            else
            {
                m.UnfreezeValue("ac_client.exe+0x50f4f4,0x338");
                m.UnfreezeValue("ac_client.exe+0x50f4f4,0x82");
            }
        }

        private void InfiniteArmor_CheckedChanged(object sender, EventArgs e)
        {
            bArmor = !bArmor;

            if (bArmor == true)
            {
                m.FreezeValue("ac_client.exe+0x50f4f4,0xFC", "2bytes", "100");
            }
            else
            {
                m.UnfreezeValue("ac_client.exe+0x50f4f4,0xFC");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            m.WriteMemory("ac_client.exe+0x0010F4F4,0x225", "string", NewName);
        }

        private void NName_TextChanged(object sender, EventArgs e)
        {
            NewName = NName.Text;
        }

        private void Rapid_CheckedChanged(object sender, EventArgs e)
        {
            bRapidAtk = !bRapidAtk;

            if (bRapidAtk == true)
            {
                m.WriteMemory("ac_client.exe+0x04637E4", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("ac_client.exe+0x04637E4", "bytes", "89 0A");
            }
        }

        private void InfiniteGrenades_CheckedChanged(object sender, EventArgs e)
        {

            bNades = !bNades;

            if (bNades == true)
            {
                m.FreezeValue("ac_client.exe+00109B74,0x158", "bytes", "1");
            }
            else
            {
                m.UnfreezeValue("ac_client.exe+00109B74,0x158");
            }
        }
    }
}