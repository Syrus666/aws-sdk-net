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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// The total number of buckets that are publicly accessible, based on a combination of
    /// permissions settings for each bucket.
    /// </summary>
    public partial class BucketCountByEffectivePermission
    {
        private long? _publiclyAccessible;
        private long? _publiclyReadable;
        private long? _publiclyWritable;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyReadable. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long PubliclyReadable
        {
            get { return this._publiclyReadable.GetValueOrDefault(); }
            set { this._publiclyReadable = value; }
        }

        // Check to see if PubliclyReadable property is set
        internal bool IsSetPubliclyReadable()
        {
            return this._publiclyReadable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyWritable. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long PubliclyWritable
        {
            get { return this._publiclyWritable.GetValueOrDefault(); }
            set { this._publiclyWritable = value; }
        }

        // Check to see if PubliclyWritable property is set
        internal bool IsSetPubliclyWritable()
        {
            return this._publiclyWritable.HasValue; 
        }

    }
}