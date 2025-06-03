using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{
   public interface IHandlerClass
    {
        // 인터페이스로 핸들러 클래스를 정의합니다.
        // 이 인터페이스는 핸들러 클래스가 구현해야 하는 메소드를 정의합니다.
        Token TokenType { get; }
        public void Handle(GameRoom room);
    }
    public  class HandlerClass : IHandlerClass
    {
        // 핸들러 클래스는 IHandlerClass 인터페이스를 구현합니다.
        public Token TokenType => Token.StartGame;

        public void Handle(GameRoom room)
        {
            room.StartGame();
        }
    }

}
