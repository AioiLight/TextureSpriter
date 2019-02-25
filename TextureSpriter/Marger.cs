using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureSpriter
{
    public partial class Marger : Form
    {
        public Marger()
        {
            InitializeComponent();
        }

        private static void Processing(string fileFolder, string extractPath, Direction direction, Size size, ProgressBar progressBar)
        {
            try
            {
                // Bitmapの生成
                var origin = new List<Bitmap>();
                foreach (var item in Directory.GetFiles(fileFolder))
                {
                    origin.Add(new Bitmap(item));
                }

                // サイズの推定
                var extractSize = direction == Direction.Vertical ? new Size(size.Width, size.Height * origin.Count) : new Size(size.Width * origin.Count, size.Height);

                // 出力用Bitmapの生成
                var result = new Bitmap(extractSize.Width, extractSize.Height);
                var graphic = Graphics.FromImage(result);

                // プログレスバーの初期化
                progressBar.Maximum = origin.Count;
                progressBar.Value = 0;

                for (int i = 0; i < origin.Count; i++)
                {
                    if (direction == Direction.Vertical)
                    {
                        graphic.DrawImage(origin[i], new Point(0, size.Height * i));
                    }
                    else
                    {
                        graphic.DrawImage(origin[i], new Point(size.Width * i, 0));
                    }
                    origin[i].Dispose();
                    progressBar.Value++;
                }

                // 保存
                result.Save(extractPath);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(string.Format(Properties.Common.FileNotFound, fileFolder));
            }
            catch (OutOfMemoryException)
            {
                throw new OutOfMemoryException(string.Format(Properties.Common.OutOfMemory));
            }
            catch (Exception)
            {
                throw new Exception(string.Format(Properties.Common.Exception));
            }
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            TextBox_Open.Text = File.FolderDialog(TextBox_Open.Text);
            //var size = new Bitmap(TextBox_Open.Text);
            //NumBox_Width.Maximum = size.Width;
            //NumBox_Width.Value = NumBox_Width.Maximum;
            //NumBox_Height.Maximum = size.Height;
            //NumBox_Height.Value = NumBox_Height.Maximum;
            //size.Dispose();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            TextBox_Save.Text = File.SaveDialog(TextBox_Save.Text);
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            var direction = RadioButton_Vertical.Checked ? Direction.Vertical : Direction.Horizontal;
            try
            {
                Processing(TextBox_Open.Text, TextBox_Save.Text, direction, new Size((int)NumBox_Width.Value, (int)NumBox_Height.Value), ProgressBar);
                MessageBox.Show(string.Format(Properties.Common.Finish));
                Process.Start(Path.GetDirectoryName(TextBox_Save.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Textrue Spriter - Cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
