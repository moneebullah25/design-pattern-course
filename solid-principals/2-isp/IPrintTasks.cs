using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principals._2_isp
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}
