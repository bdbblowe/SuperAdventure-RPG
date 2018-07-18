using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventArgs
{
    class GameMessageEventArgs : System.EventArgs
    {
        public string Message { get; set; }

        GameMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}