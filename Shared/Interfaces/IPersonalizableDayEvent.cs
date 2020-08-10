using Xamarin.Forms;

namespace Xamarin.Plugin.Calendar.Interfaces
{
    public interface IPersonalizableDayEvent
    {
        #region PersonalizableProperties
        /// <summary>
        /// Color to use as indicator when there are events on the day
        /// if the EventIndicatorColor is null then the general EventIndicatorColor of the Calendar will be used
        /// </summary>
        Color? EventIndicatorColor { get; set; }
        #endregion
    }
}
