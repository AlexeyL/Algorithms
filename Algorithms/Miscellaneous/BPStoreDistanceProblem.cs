using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous
{
    public class BPStoreDistanceProblem
    {
        // input int [] - locations
        //       n - number of stores
        //       d - distance between sotores
        // boolean - is it posible build number of stores with required distance in provided location
        // example
        // locations [1,4,2,8,9] | n - 3 | d - 2 | output true [1,4,8]
        public bool BuildStores(int[] locations, int n, int d)
        {
            var sortedLocations = locations.OrderBy(i => i).ToArray();
            var builtStores = 0;
            var lastLocation = 0;

            for (var i = 0; i < sortedLocations.Length; i++)
            {
                if (i == 0)
                {
                    builtStores++;
                    lastLocation = i;
                    continue;
                }

                if (sortedLocations[i] - sortedLocations[lastLocation] >= d)
                {
                    builtStores++;
                    lastLocation = i;
                }
            }

            if (builtStores == n)
                return true;

            return false;
        }

        // input int [] - locations
        //       n - number of stores
        // int - find the largest distance the stores could be build
        // example
        // locations [1,4,2,8,9] | n - 3 | output - 3
        public int BuildStores(int[] locations, int n)
        {
            var sortedLocations = locations.OrderBy(i => i).ToArray();
            //1,2,4,8,9

            var builtStores = 0;
            var lastLocation = 0;
            var largestDistance = 0;

            for (var i = 0; i < sortedLocations.Length; i++)
            {
                if (builtStores < n)
                {
                    builtStores++;

                    if (i == 1)
                    {
                        largestDistance = sortedLocations[i] - sortedLocations[i - 1];
                    }

                    lastLocation++;
                    continue;
                }

                var distance = sortedLocations[i] - sortedLocations[i - 1];

                if (this.BuildStores(locations, n, distance))
                {
                    largestDistance = distance;
                }
                else
                {
                    for (var j = i; j > largestDistance; j--)
                    {
                        var subLocations = sortedLocations.Take(j + 1).ToArray();
                        if (this.BuildStores(subLocations, n, j))
                        {
                            largestDistance = j;
                            break;
                        }
                    }
                }
            }

            
            return largestDistance;
        }
    }
}
