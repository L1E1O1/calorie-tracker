using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calorie_tracker.main
{
    public class ProgressTracker
    {
        //hämta info
        public UserProfile User { get; set; }


        // en konsruktor som tar in user data some history och mål
        public ProgressTracker(UserProfile user)
        {
            User = user;
        }

    }

}
