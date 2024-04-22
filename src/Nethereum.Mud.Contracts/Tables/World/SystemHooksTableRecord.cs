﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using static Nethereum.Mud.Contracts.Tables.World.SystemHooksTableRecord;

namespace Nethereum.Mud.Contracts.Tables.World
{
    public class SystemHooksTableRecord : TableRecord<SystemHooksKey, SystemHooksValue>
    {
        public SystemHooksTableRecord() : base("world", "SystemHooks")
        {
        }

        public class SystemHooksKey
        {
            [Parameter("bytes32", "systemId", 1)]
            public byte[] SystemId { get; set; }
        }

        public class SystemHooksValue
        {
            [Parameter("bytes21[]", "value", 1)]
            public List<byte[]> Value { get; set; }
        }
    }

}

