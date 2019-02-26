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
    public partial class Cutter : Form
    {
        public Cutter()
        {
            InitializeComponent();
        }

        private static void Processing(string fileName, string extractFolder, Direction direction, Size size, ProgressBar progressBar)
        {
            try
            {
                // Bitmapの生成
                var origin = new Bitmap(fileName);
                var fileExtension = Path.GetExtension(fileName);

                // 指定サイズで分割
                var number = direction == Direction.Vertical ? origin.Height / size.Height : origin.Width / size.Width;

                // プログレスバーの初期化
                progressBar.Maximum = number;
                progressBar.Value = 0;

                for (int i = 0; i < number; i++)
                {
                    var rectangle = new Rectangle();
                    if (direction == Direction.Vertical)
                    {
                        rectangle = new Rectangle(0, size.Height * i, size.Width, size.Height);
                    }
                    else
                    {
                        rectangle = new Rectangle(size.Width * i, 0, size.Width, size.Height);
                    }
                    var working = origin.Clone(rectangle, origin.PixelFormat);
                    working.Save(extractFolder + @"/" + i + fileExtension);
                    working.Dispose();
                    progressBar.Value++;
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(string.Format(Properties.Common.FileNotFound, fileName));
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
            TextBox_Open.Text = File.OpenDialog(TextBox_Open.Text);
            SuggestSize();
        }

        private void SuggestSize()
        {
            if (!string.IsNullOrWhiteSpace(TextBox_Open.Text)
                && !System.IO.File.GetAttributes(TextBox_Open.Text).HasFlag(FileAttributes.Directory))
            {
                try
                {
                    var size = new Bitmap(TextBox_Open.Text);
                    NumBox_Width.Maximum = size.Width;
                    NumBox_Width.Value = NumBox_Width.Maximum;
                    NumBox_Height.Maximum = size.Height;
                    NumBox_Height.Value = NumBox_Height.Maximum;
                    size.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show(Properties.Common.InvaildFile, "Textrue Spriter - Cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            TextBox_Save.Text = File.FolderDialog(TextBox_Save.Text);
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            var direction = RadioButton_Vertical.Checked ? Direction.Vertical : Direction.Horizontal;
            try
            {
                Processing(TextBox_Open.Text, TextBox_Save.Text, direction, new Size((int)NumBox_Width.Value, (int)NumBox_Height.Value), ProgressBar);
                MessageBox.Show(string.Format(Properties.Common.Finish));
                Process.Start(TextBox_Save.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Textrue Spriter - Cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cutter_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if(!string.IsNullOrWhiteSpace(files[0])) TextBox_Open.Text = files[0];
            SuggestSize();
        }

        private void Cutter_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }
    }
}
