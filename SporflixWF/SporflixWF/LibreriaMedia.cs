using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega2;
using System.IO;
using WMPLib;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Drawing.Printing;
using System.Drawing.Text;
using Spotflix;

namespace SporflixWF
{
    [Serializable]
    class LibreriaMedia
    {
        List<Cancion> library = Form1.Reproductor.Library();
    }
}
