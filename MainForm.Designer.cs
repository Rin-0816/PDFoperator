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
            SuspendLayout();
            // 
            // slicer_button
            // 
            slicer_button.Location = new Point(32, 29);
            slicer_button.Name = "slicer_button";
            slicer_button.Size = new Size(127, 80);
            slicer_button.TabIndex = 0;
            slicer_button.Text = "slice";
            slicer_button.UseVisualStyleBackColor = true;
            slicer_button.Click += slicer_button_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(slicer_button);
            Name = "MainWindow";
            Text = "PDFoperator";
            ResumeLayout(false);
        }

        #endregion

        private Button slicer_button;
    }
}