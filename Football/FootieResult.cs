using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootieResult
    {
        public string HomeTeam = null;
        public string AwayTeam = null;

        public int HomeScore;
        public int AwayScore;

        public int HomePoints
        {
            get
            {
                if (HomeScore > AwayScore)
                {
                    return 3;
                }
                else
                {
                    if (HomeScore == AwayScore)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }

            }
        }
        public int AwayPoints
        {
            get
            {
                switch (HomePoints)
                {
                    case 3:

                        return 0;

                    case 1:

                        return 1;

                    default:

                        return 3;
                }

            }
        }

    }
}