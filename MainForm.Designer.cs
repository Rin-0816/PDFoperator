namespace PDFoperator
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            slicer_button = new Button();
            start_page = new TextBox();
            end_page = new TextBox();
            SuspendLayout();
            // 
            // slicer_button
            // 
            slicer_button.Location = new Point(12, 12);
            slicer_button.Name = "slicer_button";
            slicer_button.Size = new Size(151, 104);
            slicer_button.TabIndex = 0;
            slicer_button.Text = "slice";
            slicer_button.UseVisualStyleBackColor = true;
            slicer_button.Click += slicer_button_Click;
            // 
            // start_page
            // 
            start_page.ImeMode = ImeMode.Disable;
            start_page.Location = new Point(195, 30);
            start_page.Name = "start_page";
            start_page.PlaceholderText = "startPage";
            start_page.ShortcutsEnabled = false;
            start_page.Size = new Size(100, 23);
            start_page.TabIndex = 1;
            start_page.KeyPress += texNumOnly_KeyPress;
            // 
            // end_page
            // 
            end_page.Location = new Point(195, 81);
            end_page.Name = "end_page";
            end_page.PlaceholderText = "endPage";
            end_page.Size = new Size(100, 23);
            end_page.TabIndex = 2;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 137);
            Controls.Add(end_page);
            Controls.Add(start_page);
            Controls.Add(slicer_button);
            Name = "MainWindow";
            Text = "PDFoperator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button slicer_button;
        private TextBox start_page;
        private TextBox end_page;
    }
}