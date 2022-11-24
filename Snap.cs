using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    using System;
    using System.Collections.Generic;

    public class Snapshot
    {
        private List<int> data;

        public Snapshot(List<int> data)
        {
            this.data = new List<int> (data);
        }

        public List<int> Restore()
        {
            return new List<int>(this.data);
        }

    }
}
