using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intranet
{
    class SessionVariable
    {
        public int userId { get; set; }
        public string username { get; set; }

        public void SetSession(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
        }

        public void ClearSession()
        {
            userId = 0;
            username = "";
        }
    }
}
