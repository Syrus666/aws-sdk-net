/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterGameServer operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Removes the game server resource from the game server group. As a result of this action,
    /// the de-registered game server can no longer be claimed and will not returned in a
    /// list of active game servers. 
    /// </para>
    ///  
    /// <para>
    /// To de-register a game server, specify the game server group and game server ID. If
    /// successful, this action emits a CloudWatch event with termination time stamp and reason.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RegisterGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGameServers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ClaimGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeregisterGameServer</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeregisterGameServerRequest : AmazonGameLiftRequest
    {
        private string _gameServerGroupName;
        private string _gameServerId;

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// An identifier for the game server group where the game server to be de-registered
        /// is running. Use either the <a>GameServerGroup</a> name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GameServerGroupName
        {
            get { return this._gameServerGroupName; }
            set { this._gameServerGroupName = value; }
        }

        // Check to see if GameServerGroupName property is set
        internal bool IsSetGameServerGroupName()
        {
            return this._gameServerGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerId. 
        /// <para>
        /// The identifier for the game server to be de-registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
        public string GameServerId
        {
            get { return this._gameServerId; }
            set { this._gameServerId = value; }
        }

        // Check to see if GameServerId property is set
        internal bool IsSetGameServerId()
        {
            return this._gameServerId != null;
        }

    }
}