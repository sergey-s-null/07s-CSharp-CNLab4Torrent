﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNLab4.Messages.Peer.Responses
{
    public class BlockResponse : BasePeerResponse
    {
        public Block Block;

        public static implicit operator BlockResponse(Block block)
        {
            return new BlockResponse { Block = block };
        }
    }
}
