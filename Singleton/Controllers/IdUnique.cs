using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton.Controllers
{
    public class IdUnique
    {
        private static IdUnique sing = null;

        private IdUnique()
        {

        }

        public static IdUnique getSingleton()
        {
            if (sing == null)
            {
                sing = new IdUnique();
            }
            return sing;
        }
        private int current = 0;
        public int getNewId()
        {
            current += 1;
            return current;
        }
    }
}
