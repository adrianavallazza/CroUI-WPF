using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CroUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // *** Connect Button
        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Start Client Object here and try connect to server (Raspi)
        }

        // *** Shape Buttons

        private void buttonRectangle_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.moveRectangle();
        }

        private void buttonCircle_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.moveCircle();
        }

        private void buttonTriangle_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.moveTriangle();
        }

        private void buttonStar_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.moveStar();
        }

        // Effect Buttons

        private void buttonLed_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.ledEffect();
        }

        private void buttonMusic_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            // Robot.playMusic();
        }

        // Arrow Buttons

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                textBoxStatus.Text = "Driving forward...";
                setBtnPressedDesign(buttonArrowUp);
                // ToDo
                // Robot.moveForward(sliderSpeed.value);
            }
            if (e.Key == Key.Left)
            {
                textBoxStatus.Text = "Driving to the left...";
                setBtnPressedDesign(buttonArrowLeft);
                // ToDo
                // Robot.moveLeft(sliderSpeed.value);
            }
            if (e.Key == Key.Right)
            {
                textBoxStatus.Text = "Driving to the right...";
                setBtnPressedDesign(buttonArrowRight);
                // ToDo
                // Robot.moveright(sliderSpeed.value);
            }
            if (e.Key == Key.Down)
            {
                textBoxStatus.Text = "Driving backwards...";
                setBtnPressedDesign(buttonArrowDown);
                // ToDo
                // Robot.moveBackwards(sliderSpeed.value);
            }
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            clearTextBoxStatus();

            if (e.Key == Key.Up)
            {
                resetBtnDesign(buttonArrowUp);
            }
            if (e.Key == Key.Left)
            {
                resetBtnDesign(buttonArrowLeft);
            }
            if (e.Key == Key.Right)
            {
                resetBtnDesign(buttonArrowRight);
            }
            if (e.Key == Key.Down)
            {
                resetBtnDesign(buttonArrowDown);
            }
        }

        private void buttonArrowUp_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBoxStatus.Text = "Driving forward...";
            setBtnPressedDesign(buttonArrowUp);
            // ToDo
            // Robot.moveForward(sliderSpeed.value);
        }


        private void buttonArrowLeft_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBoxStatus.Text = "Driving to the left...";
            setBtnPressedDesign(buttonArrowLeft);
            // ToDo
            // Robot.moveLeft(sliderSpeed.value);
        }

        private void buttonArrowRight_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBoxStatus.Text = "Driving to the right...";
            setBtnPressedDesign(buttonArrowRight);
            // ToDo
            // Robot.moveright(sliderSpeed.value);
        }

        private void buttonArrowDown_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textBoxStatus.Text = "Driving backwards...";
            setBtnPressedDesign(buttonArrowDown);
            // ToDo
            // Robot.moveBackwards(sliderSpeed.value);
        }

        private void buttonArrow_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            clearTextBoxStatus();
            resetBtnDesign((Button)sender);
        }

        private void buttonArrow_MouseEnter(object sender, MouseEventArgs e)
        {
            setBtnMouseoverDesign((Button)sender);
        }

        private void buttonArrow_MouseLeave(object sender, MouseEventArgs e)
        {
            resetBtnDesign((Button)sender);
        }

        private void clearTextBoxStatus()
        {
            textBoxStatus.Text = "";
        }

        private void sliderSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Determine if a button is currently pressed - if yes which one?
            // Adjust the speed of the movement
        }

        private void setBtnPressedDesign(Button btn)
        {
            var gradientStopCollection = new GradientStopCollection();
            gradientStopCollection.Add(new GradientStop(Colors.AliceBlue, 0.0));
            gradientStopCollection.Add(new GradientStop(Colors.CornflowerBlue, 0.5));
            gradientStopCollection.Add(new GradientStop(Colors.RoyalBlue, 1));
            btn.Background = new LinearGradientBrush(gradientStopCollection, new Point(0.5, 0), new Point(0.5, 1));
        }

        private void setBtnMouseoverDesign(Button btn)
        {
            var gradientStopCollection = new GradientStopCollection();
            gradientStopCollection.Add(new GradientStop(Colors.WhiteSmoke, 0.0));
            gradientStopCollection.Add(new GradientStop(Colors.LightGray, 0.5));
            gradientStopCollection.Add(new GradientStop(Colors.Silver, 1));
            btn.Background = new LinearGradientBrush(gradientStopCollection, new Point(0.5, 0), new Point(0.5, 1));
        }

        private void resetBtnDesign(Button btn)
        {
            var gradientStopCollection = new GradientStopCollection();
            gradientStopCollection.Add(new GradientStop(Colors.WhiteSmoke, 0.0));
            gradientStopCollection.Add(new GradientStop(Colors.LightGray, 0.25));
            gradientStopCollection.Add(new GradientStop(Colors.DimGray, 1));
            btn.Background = new LinearGradientBrush(gradientStopCollection, new Point(0.5, 0), new Point(0.5, 1));
        }



    }
}
