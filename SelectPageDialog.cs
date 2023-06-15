using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFoperator
{
    internal class SelectPageDialog : Form
    {
        public SelectPageDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            start_page = new TextBox();
            end_page = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Cancel_button = new Button();
            Select_button = new Button();
            SuspendLayout();
            // 
            // start_page
            // 
            start_page.ImeMode = ImeMode.Disable;
            start_page.Location = new Point(12, 33);
            start_page.Margin = new Padding(3, 4, 3, 4);
            start_page.Name = "start_page";
            start_page.PlaceholderText = "startPage";
            start_page.ShortcutsEnabled = false;
            start_page.Size = new Size(114, 27);
            start_page.TabIndex = 2;
            start_page.KeyPress += texNumOnly_KeyPress;
            // 
            // end_page
            // 
            end_page.ImeMode = ImeMode.Disable;
            end_page.Location = new Point(166, 33);
            end_page.Margin = new Padding(3, 4, 3, 4);
            end_page.Name = "end_page";
            end_page.PlaceholderText = "endPage";
            end_page.ShortcutsEnabled = false;
            end_page.Size = new Size(114, 27);
            end_page.TabIndex = 3;
            end_page.KeyPress += texNumOnly_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "開始ページ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "終了ページ";
            // 
            // Cancel_button
            // 
            Cancel_button.DialogResult = DialogResult.Cancel;
            Cancel_button.Location = new Point(152, 67);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(128, 29);
            Cancel_button.TabIndex = 6;
            Cancel_button.Text = "キャンセル";
            Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Select_button
            // 
            Select_button.DialogResult = DialogResult.OK;
            Select_button.Location = new Point(12, 67);
            Select_button.Name = "Select_button";
            Select_button.Size = new Size(123, 29);
            Select_button.TabIndex = 7;
            Select_button.Text = "決定";
            Select_button.UseVisualStyleBackColor = true;
            // 
            // SelectPageDialog
            // 
            ClientSize = new Size(292, 106);
            Controls.Add(Select_button);
            Controls.Add(Cancel_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(end_page);
            Controls.Add(start_page);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectPageDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ページ選択";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox start_page;
        private Label label1;
        private Label label2;
        private Button Cancel_button;
        private Button Select_button;
        private TextBox end_page;
        public (int, int) getPageNum(int x, int y)
        {
            SelectPageDialog dialog = new SelectPageDialog();
            dialog.start_page.PlaceholderText = x.ToString();
            dialog.end_page.PlaceholderText = y.ToString();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int start, end;
                try
                {
                    start = int.Parse(dialog.start_page.Text);
                    end = int.Parse(dialog.end_page.Text);
                }
                catch (Exception e)
                {
                    return (-1, -1);
                }
                return (start - 1, end - 1);
            }
            else
            {
                return (-1, -1);
            }
        }
        private void texNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }
    }
}
