namespace MatchingPattern
{
    public partial class ScreenView : Form
    {
        //Initial positions of the GameObject
        private int x = 100;
        private int y = 100;
        //Size of the GameObject
        private int objectSize = 50;

        public ScreenView()
        {
            InitializeComponent();
        }

        //Draw object at cuttent position
        private void OnPaint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.Green))
            {
                e.Graphics.FillEllipse(brush, x, y, objectSize, objectSize);
            }
        }

        private void OnKeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    x -= 10;
                    break;
                case Keys.Right:
                    x += 10;
                    break;
                case Keys.Up:
                    y -= 10;
                    break;
                case Keys.Down:
                    y += 10;
                    break;
            }

            //Redraw the object after moving
            this.Invalidate();
        }

        //This method is called periodically to repaint the object, this is used to animate the object
        private void OnTimeClick(Object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
