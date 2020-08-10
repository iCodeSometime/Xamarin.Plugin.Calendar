using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Interfaces;

namespace Xamarin.Plugin.Calendar.Models
{
    /// <summary>
    /// Wrapper to allow change the dot color
    /// </summary>
    public class DayEventCollection<T> : List<T>, IPersonalizableDayEvent
    {
        /// <summary>
        /// Empty contructor extends from base()
        /// </summary>
        public DayEventCollection() : base()
        {

        }

        /// <summary>
        /// Color contructor extends from base()
        /// </summary>
        /// <param name="eventIndicatorColor"></param>
        public DayEventCollection(Color? eventIndicatorColor) : base()
        {
            EventIndicatorColor = eventIndicatorColor;
        }

        /// <summary>
        /// IEnumerable contructor extends from base(IEnumerable collection)
        /// </summary>
        /// <param name="collection"></param>
        public DayEventCollection(IEnumerable<T> collection) : base(collection)
        {

        }

        /// <summary>
        /// Capacity contructor extends from base(int capacity)
        /// </summary>
        /// <param name="capacity"></param>
        public DayEventCollection(int capacity) : base(capacity)
        {

        }

        #region PersonalizableProperties
        public Color? EventIndicatorColor { get; set; }
        #endregion

    }
}