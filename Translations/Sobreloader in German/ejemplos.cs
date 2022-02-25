using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sobreloader
{
    public partial class ejemplos : Form
    {
        public ejemplos()
        {
            InitializeComponent();
        }

        private void ejemplos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(249, 219);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Size.Width != 554 || this.Size.Height != 219)
            {
                this.Size = new Size(554, 219);
            }
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    labelNom.Text = "Paint";
                    labelDesc.Text = "Der klassische Bildeditor ist auf Windows vorinstalliert.";
                    labelWW.Text = "Alle";
                    break;
                case 1:
                    labelNom.Text = "Notepad";
                    labelDesc.Text = "Einfacher und unkomplizierter Klartext-Editor.";
                    labelWW.Text = "Alle";
                    break;
                case 2:
                    labelNom.Text = "WordPad";
                    labelDesc.Text = "Rich-Format-Texteditor, sehr einfach im Vergleich zu Word, aber vollständiger als Notepad. Was will man mehr?";
                    labelWW.Text = "Alle";
                    break;
                case 3:
                    labelNom.Text = "Internet Explorer";
                    labelDesc.Text = "Von den Internetbrowsern, die in die Geschichte eingegangen sind. Zu dieser Zeit wurde es das am häufigsten verwendete und übertraf Netscape. Heutzutage können Sie andere wie es herunterladen.";
                    labelWW.Text = "Bist Windows 10";
                    break;
                case 4:
                    labelNom.Text = "Windows-Explorer";
                    labelDesc.Text = "Das am häufigsten verwendete Werkzeug von Microsoft Windows.";
                    labelWW.Text = "Alle";
                    break;
                case 5:
                    labelNom.Text = "Karakter-Map";
                    labelDesc.Text = "Wenn Sie seltsame Symbole suchen und einfügen müssen oder wenn Sie eine E-Mail senden möchten und Ihre gesegnete Tastatur es Ihnen nicht erlaubt, das at einzüfugen, diehnt Ihnen diese vorinstallierte Dienstprogramm wunderbar.";
                    labelWW.Text = "Alle";
                    break;
                case 6:
                    labelNom.Text = "Anwendung-Manager";
                    labelDesc.Text = "Dieses Erfindung von David Plummer funktioniert, um diese lästigen Anwendungen zu schließen, die an uns hängen, Wow!";
                    labelWW.Text = "Alle";
                    break;
                case 7:
                    labelNom.Text = "Systemsteurung";
                    labelDesc.Text = "Das Zentrum der Microsoft-Hauptbetriebssystemkonfigurationen. Für immer präsent.";
                    labelWW.Text = "Alle";
                    break;
                default:
                    labelNom.Text = "Unbenannte Program";
                    labelDesc.Text = "";
                    labelWW.Text = "??";
                    break;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = listBox1.SelectedItem.ToString(),
                    RedirectStandardOutput = false,
                    CreateNoWindow = true,
                }
            };
            try
            {
                proceso.Start();
            }
            catch (SystemException err)
            {
                MessageBox.Show("Beim Öffnen der Datei ist ein Fehler aufgetreten. Versuchen Sie, das es kompatibiliert mit der Windows-Version.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
