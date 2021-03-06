﻿using System;
using System.Runtime.Remoting;

namespace Couchbase.Core
{
    /// <summary>
    /// Thrown if a node in the cluster is not online to service a pending request.
    /// </summary>
    public class NodeUnavailableException: ServerException
    {
        public NodeUnavailableException()
        {
        }

        public NodeUnavailableException(string message)
            : base(message)
        {
        }

        public NodeUnavailableException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
