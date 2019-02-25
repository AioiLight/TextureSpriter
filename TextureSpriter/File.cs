using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureSpriter
{
    public class File
    {
        public static string OpenDialog(string beforePath)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "*.png, *.bmp, *.jpg, *.gif|*.png;*.bmp;*.jpg;*.gif";
            if (!string.IsNullOrWhiteSpace(beforePath)) dialog.InitialDirectory = Path.GetDirectoryName(beforePath);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return beforePath;
        }

        public static string SaveDialog(string beforePath)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "*.png, *.bmp, *.jpg, *.gif|*.png;*.bmp;*.jpg;*.gif";
            if (!string.IsNullOrWhiteSpace(beforePath)) dialog.InitialDirectory = Path.GetDirectoryName(beforePath);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return beforePath;
        }

        public static string FolderDialog(string beforePath)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return beforePath;
        }
    }
}
