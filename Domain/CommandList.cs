using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTyper.Domain
{
    public static class CommandList
    {
        public static string Hunt = "rpg hunt";
        public static string Chop = "rpg chop";
        public static string Fish = "rpg fish";


        public static IEnumerable<string> GetListCommands()
        {
            return new[] { Hunt, Chop, Fish };
        }
    }
}
