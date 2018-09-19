using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.Proxies
{
    public interface ISortable
    {
        int Position { get; set; }
    }
}
