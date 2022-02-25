using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace Sobreloader
{
    public partial class sobreloader : Form
    {
        Strings SC = new Strings();
        public string consejosFrases()
        {
            string[] ejemplos = {"mspaint", "notepad", "winver", "calc"};
            var ejaltr = new Random();
            int cntej = ejaltr.Next(ejemplos.Length);
            return ejemplos[cntej];
        }
        public sobreloader()
        {
            InitializeComponent();
            this.MinimumSize = new Size(430, 420);
            this.Text = "Sobreloader ";
            this.Text += SC.obtenerVersion();
            this.Text += " durch elstef41";
            label3.Text = "z.B.: " + consejosFrases();
        }
        string ultexto;
        bool ultextoUso = false;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 1000)
            {
                panel2.Visible = true;
                int tsHeightM = this.Size.Height + 10;
                this.Size = new Size(this.Size.Width, tsHeightM);
            }
            else
            {
                panel2.Visible = false;
                this.Size = new Size(this.Size.Width, 396);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sl = 1;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Sie haben keinen Prozess geschreiben.\n\nIm Menü Sobreloader sehen Sie einige Beispiele mit Factory-Programmen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBox2.Checked == false && numericUpDown1.Value < 1)
                {
                    MessageBox.Show("Der Betrag muss größer als 0 sein.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkBox2.Checked == true)
                {
                    var sinlimconfirm = MessageBox.Show("Sie haben die Option Kein Limit ausgewählt, was bedeutet, dass das eingestellte Programm ständig und ohne Beendigung ausgeführt wird. Wenn Sie sich nicht in einer virtualisierten Umgebung befinden, ist es sehr wahrscheinlich, dass dieses Verfahren die Leistung Ihres Computers beeinträchtigt und Folgeerscheinungen hinterlässt.\n\n\nSind Sie wirklich sicher, dass Sie weitermachen werden? Wenn Sie sich nicht in einer virtuellen Maschine befinden, wählen Sie Nein aus.", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (sinlimconfirm)
                    {
                        case DialogResult.Yes:
                            sl = 1;
                            break;
                        case DialogResult.No:
                            sl = 0;
                            break;
                    }
                } if (sl == 1)
                {
                    int eCant = Convert.ToInt32(numericUpDown1.Value);
                    int eAb = 0;
                    ProcessWindowStyle SelVent;
                    string args = argsTB.Text;
                    ProcessWindowStyle wst = ProcessWindowStyle.Normal;
                    var procesos = Process.GetProcessesByName(textBox1.Text);
                    if (!checkBox1.Checked)
                    {
                        args = "";
                    }
                    ultexto = textBox1.Text;
                    ultextoUso = true;
                    desText.Visible = false;
                    while (eAb < eCant)
                    {
                        var proceso = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = textBox1.Text,
                                WindowStyle = wst,
                                RedirectStandardOutput = false,
                                CreateNoWindow = true,
                                Arguments = args
                            }
                        };
                        try
                        {
                            proceso.Start();
                            if (checkBox2.Checked == false) { eAb++; }
                        }
                        catch (SystemException err)
                        {
                            MessageBox.Show("Beim Öffnen der Datei ist ein Fehler aufgetreten.\n\Wenn Sie den Namen der ausführbaren Datei trocken eingegeben haben, versuchen Sie, den ursprünglichen Speicherort zu platzieren.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            eAb = eCant;
                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    argsTB.Visible = true;
                    break;
                default:
                    argsTB.Visible = false;
                    break;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visitarRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://twitter.com/elstef41");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcercaDe().ShowDialog();
        }


        private void advertenciaDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SC.mensajeInicio();
        }


        private void nombresDeEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobreloader.ejemplos().Show();
        }

        private void visitarRepositorioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/elstef41/sobreloader");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirEXE = new OpenFileDialog();
            abrirEXE.Title = "Wählen eine Datei";
            abrirEXE.Filter = "Ausführbare Datei|*.exe";
            Stream archivoEXE = null;
            if (abrirEXE.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!abrirEXE.FileName.EndsWith(".EXE") && !abrirEXE.FileName.EndsWith(".exe")) {
                        MessageBox.Show("Wählen Sie eine ausführbare Datei aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((archivoEXE = abrirEXE.OpenFile()) != null)
                    {
                        using (archivoEXE) 
                        {
                            textBox1.Text = abrirEXE.FileName;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Beim Öffnen der Datei ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.apache.org/licenses/LICENSE-2.0.html");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label3.Visible = false;
                cancText.Visible = true;
                if (ultextoUso)
                {
                    desText.Visible = true;
                }
                else
                {
                    desText.Visible = false;
                }
            }
            else
            {
                if (!cancText.Visible)
                {
                    label3.Visible = true;
                }
                cancText.Visible = false;
            }
            if (ultextoUso == true && ultexto == textBox1.Text)
            {
                desText.Visible = false;
            }
        }

        private void restaurarTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(450, 430);
            restaurarTamañoToolStripMenuItem.Enabled = false;
        }

        private void sobreloader_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                restaurarTamañoToolStripMenuItem.Enabled = false;

            } else if (this.Size.Width != 450 || this.Size.Height != 430)
            {
                restaurarTamañoToolStripMenuItem.Enabled = true;
            }
            else
            {
                restaurarTamañoToolStripMenuItem.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancText_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (ultextoUso)
            {
                desText.Visible = true;
            }
        }

        private void desText_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = ultexto;
        }

        private void sobreloader_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void sobreloader_Load(object sender, EventArgs e)
        {

        }



    }
}

namespace Sobreloader
{
    class Form1
    {
    }
}
