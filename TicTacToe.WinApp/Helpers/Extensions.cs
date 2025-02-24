using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.WinApp.Helpers
{
    public static class Extensions
    {


        public static byte[] toByteArray(this Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms,ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] byteArray) 
        {
            return Image.FromStream(new MemoryStream(byteArray)); 
        
        }


    }
}
