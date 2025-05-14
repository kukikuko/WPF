using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorer.Support.Local.Models
{
    public enum ActionType
    {
        Up,         // 상위 폴더로 이동
        Undo,       // 뒤로 이동
        Redo        // 앞으로 이동
    }
}
