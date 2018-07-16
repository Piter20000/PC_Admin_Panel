using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PC_Admin_Panel.Classes
{
    class QR_Generator
    {
        /// <summary>
        /// Method generate QR code basing on text
        /// </summary>
        /// <param name="text"> Your text </param>
        /// <returns> Your text converted into QR code in image form </returns>
        public System.Drawing.Image Generate_QR(string text)
        {
            Zen.Barcode.CodeQrBarcodeDraw QR_Code = Zen.Barcode.BarcodeDrawFactory.CodeQr;

            return QR_Code.Draw(text, 50);
        }
    }
}
