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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEffectivePolicy operation.
    /// Returns the contents of the effective tag policy for the account. The effective tag
    /// policy is the aggregation of any tag policies the account inherits, plus any policy
    /// directly that is attached to the account. 
    /// 
    ///  
    /// <para>
    /// This action returns information on tag policies only.
    /// </para>
    ///  
    /// <para>
    /// For more information on policy inheritance, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies-inheritance.html">How
    /// Policy Inheritance Works</a> in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account or by a member
    /// account that is a delegated administrator for an AWS service.
    /// </para>
    /// </summary>
    public partial class DescribeEffectivePolicyRequest : AmazonOrganizationsRequest
    {
        private EffectivePolicyType _policyType;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EffectivePolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// When you're signed in as the master account, specify the ID of the account that you
        /// want details about. Specifying an organization root or OU as the target is not supported.
        /// 
        /// </para>
        /// </summary>
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}