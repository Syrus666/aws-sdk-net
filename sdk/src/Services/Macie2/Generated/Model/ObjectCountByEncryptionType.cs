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
    /// The total number of objects that are in the bucket, grouped by server-side encryption
    /// type. This includes a grouping that reports the total number of objects that aren't
    /// encrypted.
    /// </summary>
    public partial class ObjectCountByEncryptionType
    {
        private long? _customerManaged;
        private long? _kmsManaged;
        private long? _s3Managed;
        private long? _unencrypted;

        /// <summary>
        /// Gets and sets the property CustomerManaged. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long CustomerManaged
        {
            get { return this._customerManaged.GetValueOrDefault(); }
            set { this._customerManaged = value; }
        }

        // Check to see if CustomerManaged property is set
        internal bool IsSetCustomerManaged()
        {
            return this._customerManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsManaged. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long KmsManaged
        {
            get { return this._kmsManaged.GetValueOrDefault(); }
            set { this._kmsManaged = value; }
        }

        // Check to see if KmsManaged property is set
        internal bool IsSetKmsManaged()
        {
            return this._kmsManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Managed. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long S3Managed
        {
            get { return this._s3Managed.GetValueOrDefault(); }
            set { this._s3Managed = value; }
        }

        // Check to see if S3Managed property is set
        internal bool IsSetS3Managed()
        {
            return this._s3Managed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unencrypted. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public long Unencrypted
        {
            get { return this._unencrypted.GetValueOrDefault(); }
            set { this._unencrypted = value; }
        }

        // Check to see if Unencrypted property is set
        internal bool IsSetUnencrypted()
        {
            return this._unencrypted.HasValue; 
        }

    }
}