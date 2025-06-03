using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{
    public class Player
    {
        Socket clientSocket;
        public Player(Socket socket)
        {
            clientSocket = socket;
        }
    }
}
