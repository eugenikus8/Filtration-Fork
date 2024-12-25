using System;
using System.Collections.Generic;

namespace Filtration.ObjectModel
{
    [Serializable]
    public class SocketGroup : List<Socket>
    {
        private SocketGroup()
        {
            
        }

        public SocketGroup(List<Socket> sockets, bool linked)
        {
            if (sockets.Count < 1 || sockets.Count > 6)
            {
                throw new InvalidOperationException("A socket group must have between 2 and 6 sockets");
            }


            if (linked && sockets.Count < 2)
            {
                throw new InvalidOperationException("A linked socket group must have at least 2 sockets");
            }

            if (linked && sockets.Contains(new Socket(Enums.SocketColor.Abyss)))
            {
                throw new InvalidOperationException("Abyssal sockets cannot be linked to other sockets");
            }

            if (linked && sockets.Contains(new Socket(Enums.SocketColor.Delve)))
            {
                throw new InvalidOperationException("Delve sockets are never linked together");
            }

            AddRange(sockets);
            Linked = linked;
        }

        public bool Linked { get; }
    }
}