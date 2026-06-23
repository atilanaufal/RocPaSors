using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RocPaSors
{
    internal class OpponentAction
    {        
        public static string opponentCurrentAction = "none";
        GameMatch win;
        public OpponentAction(GameMatch win)
        {
            this.win = win;
        }
        private byte RandomAction()
        {
            Random rnd = new Random();
            return Convert.ToByte(rnd.Next(1, 240));
        }
        public void ResetOpponent()
        {
            opponentCurrentAction = "none";
            if (opponentCurrentAction == "none")
            {
                win.Scissors2.Background = new SolidColorBrush(Colors.WhiteSmoke);
                win.Rock2.Background = new SolidColorBrush(Colors.WhiteSmoke);
                win.Paper2.Background = new SolidColorBrush(Colors.WhiteSmoke);
                win.opsci.Source = new BitmapImage(Assets.Image("scissors.png"));
                win.oprck.Source = new BitmapImage(Assets.Image("fist.png"));
                win.opppr.Source = new BitmapImage(Assets.Image("hand-paper.png"));
            }
        }

        public void OpponentLogic()
        {
            byte rngGenerator = RandomAction();           
            switch (rngGenerator)
            {
                case >= 1 and <= 60:
                    opponentCurrentAction = "scissor";
                    win.Scissors2.Background = new SolidColorBrush(Colors.Black);
                    win.opsci.Source = new BitmapImage(Assets.Image("scissors2.png"));
                    break;
                case >= 61 and <= 120:
                    opponentCurrentAction = "rock";
                    win.Rock2.Background = new SolidColorBrush(Colors.Black);
                    win.oprck.Source = new BitmapImage(Assets.Image("fist2.png"));
                    break;
                case >= 180 and <= 240:
                    opponentCurrentAction = "paper";
                    win.Paper2.Background = new SolidColorBrush(Colors.Black);
                    win.opppr.Source = new BitmapImage(Assets.Image("hand-paper2.png"));
                    break;
            }
        }
    }
}
