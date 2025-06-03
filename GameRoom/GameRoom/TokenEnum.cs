using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{
    public enum Token
    {
        //토큰은 게임 룸에서 발생하는 이벤트를 나타내는 열거형으로, 각 이벤트에 대한 식별자로 사용됩니다.
        CreateRoom,
        JoinRoom,
        LeaveRoom,
        StartGame,
        EndGame,
        RoomList,
        PlayerList,
        RoomDelete,

    }
}
