using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Interfaces;
using System.Linq;

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
            EventIndicatorColors = new List<Color>();
        }

        /// <summary>
        /// IEnumerable contructor extends from base(IEnumerable collection)
        /// </summary>
        /// <param name="collection"></param>
        public DayEventCollection(IEnumerable<T> collection) : base(collection)
        {
            EventIndicatorColors = new List<Color>();
        }

        /// <summary>
        /// Capacity contructor extends from base(int capacity)
        /// </summary>
        /// <param name="capacity"></param>
        public DayEventCollection(int capacity) : base(capacity)
        {
            EventIndicatorColors = new List<Color>();
        }

        public void Add(T item, Color color)
        {
            base.Add(item);

            if (!EventIndicatorColors.Contains(color))
            {
                EventIndicatorColors.Add(color);
                EventIndicatorColors.Sort((l, r) => l.ToString().CompareTo(r.ToString()));
            }
        }

        #region PersonalizableProperties
        private List<Color> eventIndicatorColors;
        public List<Color> EventIndicatorColors { get; set; }
        #endregion

    }
}