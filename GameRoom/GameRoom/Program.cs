using System.Net.Sockets;

namespace GameRoom
{
    //프로퍼티로 만들고 메소드에 토큰 기반 이벤트 실행

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

    public interface IGameRoom : IRoom
    {
        //게임 룸의 인터페이스 추상화 기존의 룸만으로 추상화를 하였지만 게임 룸도 다양한 형태가 있어 조금 더 추상화를 시도함
        public void StartGame();
        public void EndGame();
    }   
    public class GameRoom : IGameRoom
    {
        
        public string Name { get;  set; }

        public int RoomID { get; set; }

        public List<Player> Players { get; }

        public int MaxPlayers { get; set; }

        public GameRoom(Player player, string Name, int RoomID)
        {
            
            Players = new List<Player>();
            if (player == null) throw new ArgumentNullException(nameof(player), "Player cannot be null");
            if (string.IsNullOrEmpty(Name)) throw new ArgumentException("Name cannot be null or empty", nameof(Name));
            if (RoomID <= 0) throw new ArgumentOutOfRangeException(nameof(RoomID), "RoomID must be greater than zero");

            Players.Add(player);
            this.RoomID = RoomID;
            this.Name = Name;

        }

        public void CreateRoom(string name, int maxPlayers) {

               //룸 id와 이름 등등 조건 만족 시 생성 실질적으로 이 메소드를 통해 생성할것임

        }

        public void AddPlayer(Player player)
        {

            if(Players.Count >= MaxPlayers)
            {
                throw new InvalidOperationException("Cannot add player: room is full.");
            }
            else
            {
                Players.Add(player);
            }

        }

        public void BoradCast(string message)
        {
            //메시지를 모든 플레이어에게 전송하는 로직
            foreach (var player in Players)
            {
                //player.SendMessage(message); // 가상의 메소드로 메시지를 전송
            }
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

        public void StartGame()
        {
            //게임 시작 로직
        }

        public void EndGame()
        {
            //게임 종료 로직
        }

        public void RoomDelete(Token token)
        {

            if(token.Equals(Token.RoomDelete))
            {
                //룸 삭제 로직
                Players.Clear();
            }
        }

        public void RegisterHandler(IHandlerClass handler)
        {
            //핸들러 클래스를 등록하는 로직
            //예를 들어, 핸들러를 리스트에 추가하거나 이벤트에 연결할 수 있습니다.
        }

        public void HandleToken(Token token)
        {
            //token에 따라 적절한 핸들러를 호출하는 로직
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
