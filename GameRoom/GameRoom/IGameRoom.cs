using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoom
{
    public interface IGameRoom : IRoom
    {
        //게임 룸의 인터페이스 추상화 기존의 룸만으로 추상화를 하였지만 게임 룸도 다양한 형태가 있어 조금 더 추상화를 시도함
        public void StartGame();
        public void EndGame();
    }
}
