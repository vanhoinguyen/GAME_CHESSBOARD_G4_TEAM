using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO_G4_TEAM
{   [Serializable]
    public class DataTransfer
    {
        private Point point;
        private int _commandType;
        string message;
        private bool isServer;

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }
       
        public int CommandType { get => _commandType; set => _commandType = value; }
        public string Message { get => message; set => message = value; }
        public bool IsServer { get => isServer; set => isServer = value; }

        public DataTransfer(Point point, int type, string message, bool isServer)
        {
            this.IsServer = isServer;
            Point = point;
            this._commandType = type;
            this.Message = message;

        }


    }
    public enum CommandType
    {
        POINT,
        UNDO,
        NEW_GAME,
        QUIT,
        CONNECT,
        MESSAGE,
        NAME,
        TURN_PASSED,
        REDO
    }
}
