using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad5
{
   
        public class CollisionDetector
        {
        /// <summary>
        /// Calculates if rectangles describing two sprites
        /// are overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param>
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            var x1 = s1.Position.X - (s1.Size.Width /2);
            var y1 = s1.Position.Y - (s1.Size.Height /2);
            var w1 = s1.Size.Width;
            var h1 = s1.Size.Height;
            var x2 = s2.Position.X - (s2.Size.Width /2);
            var y2 = s2.Position.Y - (s2.Size.Height /2);
            var w2 = s2.Size.Width;
            var h2 = s2.Size.Height;

            if (x1 < x2+w2)
            {
                if(x1+ w1 > x2)
                {
                    if (h1 + y1 >y2)
                    {
                        if (y1 < y2 + h2)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
    }
}
