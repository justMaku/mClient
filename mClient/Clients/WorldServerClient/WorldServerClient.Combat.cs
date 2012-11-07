using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using mClient.Shared;
using mClient.Network;
using mClient.Crypt;
using mClient.Constants;

namespace mClient.Clients
{
    public partial class WorldServerClient
    {
        public void Attack(Object target)
        {
            PacketOut packet = new PacketOut(WorldServerOpCode.CMSG_SET_SELECTION);
            if (objectMgr.getPlayerObject() != null)
            {
                packet.Write(target.Guid.GetNewGuid());
            }
            Send(packet);

            packet = new PacketOut(WorldServerOpCode.CMSG_ATTACKSWING);
            if (objectMgr.getPlayerObject() != null)
            {
                packet.Write(target.Guid.GetNewGuid());
            }
            Send(packet);
        }


    }
}
