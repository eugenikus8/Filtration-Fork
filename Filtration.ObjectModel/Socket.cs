using System;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel
{
    [Serializable]
    public class Socket
    {
        private Socket()
        {
        }

        public Socket(SocketColor color)
        {
            Color = color;
        }

        public SocketColor Color { get; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Socket s = (Socket)obj;
            return Color == s.Color;
        }
    }
}