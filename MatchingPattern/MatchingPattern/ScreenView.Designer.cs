namespace MatchingPattern
{
    partial class ScreenView
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
            this.DoubleBuffered = true; //Smother Graphics
            this.Paint += new PaintEventHandler(OnPaint);
            this.KeyDown += new KeyEventHandler(OnKeyDown);


            //Set up form
            this.Size = new Size(800, 560);
            this.StartPosition = FormStartPosition.CenterScreen;

            SuspendLayout();
            // 
            // ScrrenView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Name = "ScrrenView";
            Text = "PatternMatching";
            ResumeLayout(false);
        }

        #endregion
    }
}
