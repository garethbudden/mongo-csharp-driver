﻿/* Copyright 2010-2013 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Net;
using MongoDB.Driver.Core.Protocol.Messages;

namespace MongoDB.Driver.Core.Connections
{
    /// <summary>
    /// A connection.
    /// </summary>
    internal interface IConnection : IDisposable
    {
        /// <summary>
        /// Gets the DNS end point.
        /// </summary>
        DnsEndPoint DnsEndPoint { get; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets a value indicating whether this transport is open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Opens the connection.
        /// </summary>
        void Open();

        /// <summary>
        /// Receives a message.
        /// </summary>
        /// <returns>The reply.</returns>
        ReplyMessage Receive();

        /// <summary>
        /// Sends the packet.
        /// </summary>
        /// <param name="packet">The packet.</param>
        void Send(IRequestPacket packet);
    }
}