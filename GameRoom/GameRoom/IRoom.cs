using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{
    public interface IRoom
    {
        /// <summary>
        /// 룸의 ID를 나타내는 프로퍼티입니다.
        /// 룸을 식별하는 고유한 값입니다.
        /// </summary>
        int RoomID { set; }



        /// <summary>
        /// 게임 룸의 이름을 나타내는 프로퍼티입니다. 룸의 식별자로 사용됩니다.
        /// </summary>
        string Name { get; }



        /// <summary>
        /// 게임 룸의 이름을 나타내는 프로퍼티입니다. 룸의 식별자로 사용됩니다.
        /// </summary>
        public int MaxPlayers { get; set; }



        /// <summary>
        /// 게임 룸의 플레이어 목록을 나타내는 프로퍼티입니다. 룸에 참여 중인 플레이어들의 리스트를 포함합니다.
        /// </summary>
        public List<Player> Players { get; }



        /// <summary>
        /// 룸을 생성하는 메소드입니다. 룸의 이름과 최대 플레이어 수를 설정합니다. 룸 ID는 생성 시 자동으로 할당됩니다.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxPlayers"></param>
        public void CreateRoom(string name, int maxPlayers);



        /// <summary>
        /// 룸에 플레이어를 추가하는 메소드입니다. 플레이어가 룸에 참여할 때 호출됩니다.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player);



        /// <summary>
        /// 룸에서 플레이어를 제거하는 메소드입니다. 플레이어가 룸을 떠날 때 호출됩니다.
        /// </summary>
        /// <param name="player"></param>
        public void RemovePlayer(Player player);



        /// <summary>
        /// 룸에 메시지를 브로드캐스트하는 메소드입니다. 모든 플레이어에게 메시지를 전송합니다.
        /// </summary>
        /// <param name="message"></param>
        public void BoradCast(string message);



        /// <summary>
        /// 룸을 삭제하는 메소드입니다. 토큰을 통해 룸 삭제 이벤트를 처리합니다.
        /// </summary>
        /// <param name="token"></param>
        public void RoomDelete(Token token);



        /// <summary>
        /// 핸들러 클래스를 등록하는 메소드입니다. 핸들러 클래스는 게임 룸에서 발생하는 이벤트를 처리합니다.
        /// </summary>
        /// <param name="handler"></param>
        public void RegisterHandler(IHandlerClass handler);



        public void HandleToken(Token token);
    }
}
