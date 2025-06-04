using System.Net.Sockets;

namespace GameRoom
{
    //프로퍼티로 만들고 메소드에 토큰 기반 이벤트 실행



  
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
