using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureSpriter
{
    public partial class Cutter : Form
    {
        public Cutter()
        {
            InitializeComponent();
        }

        enum Direction
        {
            Vertical,
            Horizontal
        }

        private static string OpenDialog(string beforePath)
        {
            var dialog = new OpenFileDialog();
            if(!string.IsNullOrWhiteSpace(beforePath)) dialog.InitialDirectory = Path.GetDirectoryName(beforePath);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return beforePath;
        }

        private static string SaveDialog(string beforePath)
        {
            var dialog = new SaveFileDialog();
            if (!string.IsNullOrWhiteSpace(beforePath)) dialog.InitialDirectory = Path.GetDirectoryName(beforePath);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return beforePath;
        }

        private static string FolderDialog(string beforePath)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return beforePath;
        }

        private static void Processing(string fileName, string extractFolder, Direction direction, Size size, ProgressBar progressBar)
        {
            try
            {
                // Bitmapの生成
                var origin = new Bitmap(fileName);

                // 指定サイズで分割
                var number = direction == Direction.Vertical ? origin.Height / size.Height : origin.Width / size.Width;

                // プログレスバーの初期化
                progressBar.Maximum = number;
                progressBar.Value = 0;

                for (int i = 0; i < number; i++)
                {
                    var rectangle = new Rectangle();
                    if(direction == Direction.Vertical)
                    {
                        rectangle = new Rectangle(0, size.Height * i, size.Width, size.Width);
                    }
                    else
                    {
                        rectangle = new Rectangle(size.Width * i, 0, size.Width, size.Width);
                    }
                    var working = origin.Clone(rectangle, origin.PixelFormat);
                    working.Save(extractFolder + @"/" + i + @".png");
                    working.Dispose();
                    progressBar.Value++;
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (OutOfMemoryException)
            {
                throw new OutOfMemoryException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            TextBox_Open.Text = OpenDialog(TextBox_Open.Text);
            var size = new Bitmap(TextBox_Open.Text);
            NumBox_Width.Maximum = size.Width;
            NumBox_Width.Value = NumBox_Width.Maximum;
            NumBox_Height.Maximum = size.Height;
            NumBox_Height.Value = NumBox_Height.Maximum;
            size.Dispose();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            TextBox_Save.Text = FolderDialog(TextBox_Save.Text);
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            var direction = RadioButton_Vertical.Checked ? Direction.Vertical : Direction.Horizontal;
            try
            {
                Processing(TextBox_Open.Text, TextBox_Save.Text, direction, new Size((int)NumBox_Width.Value, (int)NumBox_Height.Value), ProgressBar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Textrue Spriter - Cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
