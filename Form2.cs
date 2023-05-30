using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests_Planetas
{
    public partial class Form2 : Form
    {
        string[] jautajumi = new string[] {
            "Kura planēta ir lielākā Saules sistēmā?",
            "Kurai planētai ir visvairāk pavadoņu?",
            "Kura planēta ir mazākā Saules sistēmā?",
            "Uz kuras planētas vienmēr ir ļoti karsts?",
            "Kurai planētai ir visvairāk gredzenu?",
            "Kura planēta ir mūsu Zemes dvīņis?",
            "Kurai planētai ir visblīvākā atmosfēra?",
            "Kurai planētai ir lielākā orbīta ap Sauli?",
            "Kura planēta ir aukstākā Saules sistēmā?",
            "Kuru planētu sauc arī par sarkano planētu?",
            "Kurai no šīm planētām ir cieta virsma?",
            "Kura planēta sastāv no gāzēs un tai nav cietas virsmas?",
            "Kurai planētai nav neviena pavadoņa?",
            "Kura planēta atrodas vistālāk no Saules?",
            "Kurai planētai pavisam nav atmosfēras?",
            "Kura no planētām ir trešā no Saules?",
            "Kura no planētām atrodas vistuvāk Saulei?",
            "Kura planēta apkārt Saulei griežas ātrāk nekā apkārt savai asij?",
            "Kurai planētai vajag 165 gadus lai apriņķotu apkārt Saulei?",
            "Kura planēta apriņķo apkārt Saulei pa 3 mēnešiem?"
        };
        string[] atbildes1 = new string[] {
            "Neptūns",
            "Jupiters",
            "Zeme",
            "Marss",
            "Saturns",
            "Venēra",
            "Venēra",
            "Saturns",
            "Urāns",
            "Merkurs",
            "Marss",
            "Neptūns",
            "Zeme",
            "Neptūns",
            "Merkurs",
            "Marss",
            "Venēra",
            "Venēra",
            "Saturns",
            "Marss"
        };
        string[] atbildes2 = new string[] {
            "Jupiters",
            "Neptūns",
            "Venēra",
            "Merkurs",
            "Urāns",
            "Marss",
            "Zeme", 
            "Urāns", 
            "Neptūns",
            "Venēra",
            "Jupiters",
            "Venēra",
            "Venēra",
            "Saturns",
            "Venēra",
            "Zeme",
            "Zeme",
            "Urāns",
            "Neptūns",
            "Merkurs"
        };
        string[] atbildes3 = new string[] {
            "Urāns",
            "Saturns",
            "Merkurs",
            "Venēra",
            "Neptūns",
            "Neptūns",
            "Marss",
            "Neptūns",
            "Jupiters",
            "Marss",
            "Urāns",
            "Marss",
            "Saturns",
            "Urāns",
            "Jupiters",
            "Merkurs",
            "Merkurs",
            "Jupiters",
            "Urāns",
            "Venēra"
        };
        string[] atbildes = new string[] {
            "Jupiters",
            "Jupiters",
            "Merkurs",
            "Venēra",
            "Saturns",
            "Venēra",
            "Zeme",
            "Neptūns",
            "Neptūns",
            "Marss",
            "Marss",
            "Neptūns",
            "Venēra",
            "Urāns",
            "Merkurs",
            "Zeme",
            "Merkurs",
            "Venēra",
            "Neptūns",
            "Merkurs"
        };
        int piemeri = 0;
        public static int punkti = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labJautajums.Text = jautajumi[piemeri];
            butAtbilde1.Text = atbildes1[piemeri];
            butAtbilde2.Text = atbildes2[piemeri];
            butAtbilde3.Text = atbildes3[piemeri];
        }

        private void butAtbilde1_Click(object sender, EventArgs e)
        {
            if (butAtbilde1.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti + 0;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + " no 10.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
            
        }

        private void butAtbilde2_Click(object sender, EventArgs e)
        {
            if (butAtbilde2.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti + 0;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + " no 10.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde3_Click(object sender, EventArgs e)
        {
            if (butAtbilde3.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti + 0;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + " no 10.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }
    }
}
