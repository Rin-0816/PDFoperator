using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System.Diagnostics.Tracing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PDFoperator
{
    internal class Slicer
    {
        public void pdf_slicer(IReadOnlyCollection<string> data)
        {
            //引数がnullの場合、ファイルを開く
            if (data == null)
            {
                OpenFileDialog dialog = Dialog.Open();
                if (dialog != null) Slice(dialog.FileName);
                else {
                    return;
                }
            }
            else
            {
                foreach (string filename in data)
                {
                    Slice(filename);
                }
            }
            MessageBox.Show("処理が完了しました。");
            return;
        }
        private void Slice(string filename)
        {
            PdfDocument inputDocument;
            try
            {
                //PDFファイルを開く
                inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);
            }
            catch
            {
                MessageBox.Show("PDFファイルを開けませんでした。");
                return;
            }
            SelectPageDialog selectPageDialog = new SelectPageDialog();
            var (start, end) = selectPageDialog.getPageNum(1, inputDocument.PageCount);
            //PDF及び、指定されているページ番号が存在するかを確認する。
            if (inputDocument != null && 0 <= start && end < inputDocument.PageCount)
            {
                SaveFileDialog saveDialog = Dialog.Save();
                saveDialog.FileName = Path.GetFileNameWithoutExtension(filename) + "_" + (start + 1) + "-" + (end + 1) + ".pdf";
                DialogResult result = saveDialog.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("キャンセルされました。");
                    return;
                }
                if (saveDialog.FileName != "")
                {
                    //出力ファイルを開く
                    PdfDocument outputDocument = new PdfDocument();
                    //出力ファイルにページを追加
                    for (int i = start; i <= end; i++)
                    {
                        outputDocument.AddPage(inputDocument.Pages[i]);
                    }
                    //出力ファイルを保存
                    outputDocument.Save(saveDialog.FileName);
                    outputDocument.Close();
                }
            }
            else
            {
                //エラーメッセージを表示
                MessageBox.Show("PDFファイルを開けないか、もしくはページ数が不正です。");
                return;
            }
        }
    }
}
