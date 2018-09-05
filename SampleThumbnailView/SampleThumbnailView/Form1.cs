using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using Microsoft.WindowsAPICodePack.Shell;

namespace SampleThumbnailView
{
    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 画面表示時の処理
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 参照ボタンクリックイベント.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ref_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                txb_file.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 表示ボタンクリックイベント.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_read_Click(object sender, EventArgs e)
        {
            pcb_preview.Image = CreateThumbnail(txb_file.Text, 1);
        }

        /// <summary>
        /// サムネイル画像を生成します.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        private Bitmap CreateThumbnail(string path, int scale)
        {
            // ファイルが存在した場合
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                ShellFile shellFile = ShellFile.FromFilePath(path);
                Bitmap bmp = shellFile.Thumbnail.Bitmap;
                int w = (int)(bmp.Width * scale);
                int h = (int)(bmp.Height * scale);
                return bmp;
            }

            // ファイルが存在しない場合はデフォルト表示
            return SampleThumbnailView.Properties.Resources.Message;
        }

    }
}
