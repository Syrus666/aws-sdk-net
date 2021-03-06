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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribePortal operation
    /// </summary>  
    public class DescribePortalResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribePortalResponse response = new DescribePortalResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("portalArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalClientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalContactEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalContactEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.PortalCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalLastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.PortalLastUpdateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalLogoImage", targetDepth))
                {
                    var unmarshaller = ImageUnmarshaller.Instance;
                    response.PortalLogoImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalStartUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PortalStartUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalStatus", targetDepth))
                {
                    var unmarshaller = PortalStatusUnmarshaller.Instance;
                    response.PortalStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribePortalResponseUnmarshaller _instance = new DescribePortalResponseUnmarshaller();        

        internal static DescribePortalResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribePortalResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}