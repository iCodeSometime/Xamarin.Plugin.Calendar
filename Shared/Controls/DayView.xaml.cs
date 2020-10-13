using Xamarin.Plugin.Calendar.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Xamarin.Plugin.Calendar.Controls
{
    /// <summary>
    /// Internal class used by Xamarin.Plugin.Calendar
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayView : ContentView
    {        
        internal DayView()
        {
            InitializeComponent();
        }

        private void OnTapped(object sender, EventArgs e)
        {
            if (BindingContext is DayModel dayModel && !dayModel.IsDisabled)
            {
                dayModel.IsSelected = true;
                dayModel.DayTappedCommand?.Execute(dayModel.Date);
            }
        }

        private void Frame_SizeChanged(object sender, EventArgs e)
        {
            var frame = (Frame)sender;
            var newWidth = frame.Width;
            frame.HeightRequest = newWidth;
            frame.CornerRadius = (float)newWidth / 2;
        }
    }
}