using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFramework;
using GFramework.Network;
using Share.Protocols;

namespace GameServer
{
    public class TickDispatcher : ADispatcher
    {
        GLogger logger = new GLogger("TickDispatcher");

        public override void DecodeForm(ProtoDefine define, byte[] data)
        {
            logger.P($"反序列化{define}类型消息");
            switch (define)
            {
                case ProtoDefine.C2S_Tick_Input: DealWithTickInput(ProtoBufNetSerializer.Decode<TickUpdateData>(data)); break;
                default:
                    logger.E($"没有找到协议--{define}--的定义！！！");
                    break;
            }
        }

        public override void RegisterMsg(RpcCallBack response)
        {

        }

        private void DealWithTickInput(TickUpdateData data)
        {
            TickAgent.Instance.TickUpdate(data.roomID, data);
        }
    }
}