using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS3_Comment_Loader
{
    public partial class mainFrm : MaterialForm
    {
        const string ipFormat = @"\b\d{1,4}\.\d{1,4}\.\d{1,4}\.\d{1,4}\b";
        const int maxSize = 354, defaultSize = 124;
        const string localIp = "Localip";

        void NewThread(Action act)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() => { act(); }).Start();
        }
        
        // All Codes In Designer Area :) ->
        public mainFrm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            if (File.Exists(Path.GetTempPath() + localIp))
                ipBox.Text = File.ReadAllText(Path.GetTempPath() + localIp);
            else ipBox.Text = "192.168.0.0";
            this.Size = new Size(389, defaultSize);
        }
    }
}
