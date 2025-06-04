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
        string playerName;
        int playerID;

        public Player(Socket socket, string playerName, int playerID)
        {
            clientSocket = socket;
            this.playerName = playerName;
            this.playerID = playerID;
        }
    }
}
