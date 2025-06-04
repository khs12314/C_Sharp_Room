using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{


    public interface IHandlerClass
    {
        /// <summary>
        /// 인터페이스로 핸들러 클래스를 정의합니다.
        /// 
        /// </summary>
        Token TokenType { get; }
        public void Handle(GameRoom room, Packet packet);
    }
    public class CreateRoomHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.CreateRoom;

        public void Handle(GameRoom room, Packet packet)
        {
            room.CreateRoom();   
        }
    }
    public class JoinRoomHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.JoinRoom;

        public void Handle(GameRoom room, Packet packet)
        {
            // 예시로 플레이어를 추가하는 로직을 구현합니다.
            room.AddPlayer();
        }
    }
    public class LeaveRoomHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.LeaveRoom;

        public void Handle(GameRoom room, Packet packet)
        {
            room.RemovePlayer();
        }
    }
    public  class StartHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.StartGame;

        public void Handle(GameRoom room, Packet packet)
        {
            room.StartGame();
        }
    }
    public class EndHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.EndGame;

        public void Handle(GameRoom room, Packet packet)
        {
            room.EndGame();
        }
    }
    public class RoomListHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.RoomList;

        public void Handle(GameRoom room, Packet packet)
        {

            //룸 목록을 처리하는 로직을 구현합니다.
            
        }
    }
    public class PlayerListHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.PlayerList;

        public void Handle(GameRoom room, Packet packet)
        {
            // 플레이어 목록을 처리하는 로직을 구현합니다.

        }
    }
    public class RoomDeleteHandler : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.RoomDelete;

        public void Handle(GameRoom room, Packet packet)
        {
            room.RoomDelete(Token.RoomDelete);
        }
    }
}
