using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFoperator
{
    internal class Dialog
    {
        public static OpenFileDialog Open()
        {
            //ファイルを開く
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {
                dialog.Filter = "PDFファイル(*.pdf)|*.pdf";
                dialog.Title = "PDFファイルを開く";
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("キャンセルされました。");
                    return null;
                }
            }
            catch
            {
                return null;
            }
            return dialog;
        }
        public static SaveFileDialog Save()
        {
            //出力ファイル名を指定
            SaveFileDialog saveDialog = new SaveFileDialog();
            try
            {
                saveDialog.Filter = "PDFファイル(*.pdf)|*.pdf";
                saveDialog.Title = "PDFファイルを保存する";
            }
            catch
            {
                return null;
            }
            return saveDialog;
        }
    }
}
