using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System.Diagnostics.Tracing;

namespace PDFoperator
{
    internal class Slicer
    {
        public void pdf_slicer(int start, int end)
        {   
            //ファイルを開く
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDFファイル(*.pdf)|*.pdf";
            dialog.Title = "PDFファイルを開く";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //PDFファイルを開く
                PdfDocument inputDocument = PdfReader.Open(dialog.FileName, PdfDocumentOpenMode.Import);
                //PDF及び、指定されているページ番号が存在するかを確認する。
                if (inputDocument != null && 0 <= start && end < inputDocument.PageCount)
                {
                    //出力ファイル名を指定
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "PDFファイル(*.pdf)|*.pdf";
                    saveFileDialog1.Title = "PDFファイルを保存する";
                    saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(dialog.FileName)+"_"+(start+1)+"-"+(end+1)+".pdf";
                    DialogResult result = saveFileDialog1.ShowDialog();
                    if(result == DialogResult.Cancel)
                    {
                        MessageBox.Show("キャンセルされました。");
                        return;
                    }
                    if (saveFileDialog1.FileName != "")
                    {
                        //出力ファイルを開く
                        PdfDocument outputDocument = new PdfDocument();
                        //出力ファイルにページを追加
                        for (int i = start; i <= end; i++)
                        {
                            outputDocument.AddPage(inputDocument.Pages[i]);
                        }
                        //出力ファイルを保存
                        outputDocument.Save(saveFileDialog1.FileName);
                        outputDocument.Close();
                        MessageBox.Show("処理が完了しました。");
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
}
