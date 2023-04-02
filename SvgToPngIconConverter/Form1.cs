using Svg;
using SvgToPngIconConverter.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvgToPngIconConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CbIconSize.SelectedIndex = 0;
            LblFilesCount.Text = null;
        }

        private void LbFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void LbFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null)
            {
                AddFiles(files);

            }
        }

        private void AddFiles(string[] files)
        {
            string directory = null;

            foreach (string file in files)
            {
                string fileExt = System.IO.Path.GetExtension(file);
                if (fileExt.ToLower() == ".svg")
                {
                    if (!LbFiles.Items.Contains(file))
                        LbFiles.Items.Add(file);
                }

                if (directory == null)
                {
                    directory = Path.GetDirectoryName(file);
                }
            }

            if (String.IsNullOrEmpty(TbxOutputFolder.Text))
            {
                TbxOutputFolder.Text = directory;
            }

            LblFilesCount.Text = $"({LbFiles.Items.Count})";
        }

        private void LbFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LbFiles.SelectedItems.Count != 0)
            {
                for (int x = LbFiles.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = LbFiles.SelectedIndices[x];
                    LbFiles.Items.RemoveAt(idx);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LbFiles.Items.Clear();
            TbxOutputFolder.Text = null;
            LblFilesCount.Text = null;
        }

        private void BtnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "SVG Files (*.svg)|*.svg";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Choose SVG files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AddFiles(openFileDialog1.FileNames);
            }
        }

        private void BtnSetOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            if (String.IsNullOrEmpty(TbxOutputFolder.Text))
                Fld.SelectedPath = Application.ExecutablePath;
            else
                Fld.SelectedPath = TbxOutputFolder.Text;

            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                TbxOutputFolder.Text = Fld.SelectedPath;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            ConvertSVGs();
        }

        private void ConvertSVGs()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (!Directory.Exists(TbxOutputFolder.Text))
                {
                    Directory.CreateDirectory(TbxOutputFolder.Text);
                }

                Bitmap bitmap = null;
                ProgressBarConvert.Value = 0;
                ProgressBarConvert.Maximum = LbFiles.Items.Count;

                foreach (string item in LbFiles.Items)
                {
                    if (File.Exists(item))
                    {
                        var filename = Path.GetFileName(item);
                        var directory = TbxOutputFolder.Text;
                        var svg = SvgDocument.Open(item);

                        if (CbIconSize.SelectedItem.ToString() == "Original")
                        {
                            bitmap = svg.Draw();
                        }
                        else
                        {
                            var sizes = CbIconSize.SelectedItem.ToString().Split(new[] { " x " }, StringSplitOptions.None);

                            var width = int.Parse(sizes[0]);
                            var height = int.Parse(sizes[1]);

                            bitmap = svg.Draw(width, height);
                        }

                        bitmap.Save(directory + "\\" + filename.Replace(".svg", ".png"), ImageFormat.Png);

                        ProgressBarConvert.SetProgressNoAnimation(++ProgressBarConvert.Value);
                    }

                }
                MessageBox.Show(
                    "Conversion successfully finished." + Environment.NewLine + LbFiles.Items.Count + " files created.",
                    "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProgressBarConvert.Value = 0;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }


    }
}
