using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Sobreloader
{
    class Strings
    {
        public string obtenerVersion()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            return s;
        }
        public DialogResult mensajeInicio()
        {
            return MessageBox.Show("Dieses einfache Tool wurde für Bildungszwecke und für alle, die die Überlastungsmethode ausprobieren wollten, entwickelt. Es wird empfohlen, es in virtualisierten Umgebungen wie virtuelle Maschinen zu verwenden.\n\nDer Autor dieses Programms ist nicht verantwortlich für die Auswirkungen, die seine Ausführung mit sich bringen kann. Verwenden Sie es micht Vorsicht.", "elstef41 Sobreloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
