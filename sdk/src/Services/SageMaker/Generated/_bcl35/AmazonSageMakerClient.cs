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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMaker.Model;
using Amazon.SageMaker.Model.Internal.MarshallTransformations;
using Amazon.SageMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Implementation for accessing SageMaker
    ///
    /// Provides APIs for creating and managing Amazon SageMaker resources. 
    /// 
    ///  
    /// <para>
    /// Other Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/whatis.html#first-time-user">Amazon
    /// SageMaker Developer Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/augmented-ai/2019-11-07/APIReference/Welcome.html">Amazon
    /// Augmented AI Runtime API Reference</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSageMakerClient : AmazonServiceClient, IAmazonSageMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSageMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AmazonSageMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials and an
        /// AmazonSageMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AWSCredentials credentials, AmazonSageMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddTags

        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon SageMaker resource. You
        /// can add tags to notebook instances, training jobs, hyperparameter tuning jobs, batch
        /// transform jobs, models, labeling jobs, work teams, endpoint configurations, and endpoints.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// For more information about tags, see For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
        /// Tagging Strategies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tags that you add to a hyperparameter tuning job by calling this API are also added
        /// to any training jobs that the hyperparameter tuning job launches after you call this
        /// API, but not to training jobs that the hyperparameter tuning job launched before you
        /// called this API. To make sure that the tags associated with a hyperparameter tuning
        /// job are also added to all training jobs that the hyperparameter tuning job launches,
        /// add the tags when you first create the tuning job by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateHyperParameterTuningJob</a> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateTrialComponent

        /// <summary>
        /// Associates a trial component with a trial. A trial component can be associated with
        /// multiple trials. To disassociate a trial component from a trial, call the <a>DisassociateTrialComponent</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the AssociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        public virtual AssociateTrialComponentResponse AssociateTrialComponent(AssociateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<AssociateTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginAssociateTrialComponent(AssociateTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrialComponent.</param>
        /// 
        /// <returns>Returns a  AssociateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        public virtual AssociateTrialComponentResponse EndAssociateTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlgorithm

        /// <summary>
        /// Create a machine learning algorithm that you can use in Amazon SageMaker and list
        /// in the AWS Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm service method.</param>
        /// 
        /// <returns>The response from the CreateAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        public virtual CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return Invoke<CreateAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginCreateAlgorithm(CreateAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlgorithm.</param>
        /// 
        /// <returns>Returns a  CreateAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        public virtual CreateAlgorithmResponse EndCreateAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApp

        /// <summary>
        /// Creates a running App for the specified UserProfile. Supported Apps are <code>JupyterServer</code>,
        /// <code>KernelGateway</code>, and <code>TensorBoard</code>. This operation is automatically
        /// invoked by Amazon SageMaker Studio upon access to the associated Studio Domain, and
        /// when new kernel configurations are selected by the user. A user may have multiple
        /// Apps active simultaneously. Apps will automatically terminate and be deleted when
        /// stopped from within Studio, or when the DeleteApp API is manually called. UserProfiles
        /// are limited to 5 concurrently running Apps at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutoMLJob

        /// <summary>
        /// Creates an AutoPilot job.
        /// 
        ///  
        /// <para>
        /// After you run an AutoPilot job, you can find the best performing model by calling
        /// , and then deploy that model by following the steps described in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html">Step
        /// 6.1: Deploy the Model to Amazon SageMaker Hosting Services</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about how to use AutoPilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">Use
        /// AutoPilot to Automate Model Development</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the CreateAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        public virtual CreateAutoMLJobResponse CreateAutoMLJob(CreateAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<CreateAutoMLJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        public virtual IAsyncResult BeginCreateAutoMLJob(CreateAutoMLJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoMLJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoMLJob.</param>
        /// 
        /// <returns>Returns a  CreateAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        public virtual CreateAutoMLJobResponse EndCreateAutoMLJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutoMLJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCodeRepository

        /// <summary>
        /// Creates a Git repository as a resource in your Amazon SageMaker account. You can associate
        /// the repository with notebook instances so that you can use Git source control for
        /// the notebooks you create. The Git repository is a resource in your Amazon SageMaker
        /// account, so it can be associated with more than one notebook instance, and it persists
        /// independently from the lifecycle of any notebook instances it is associated with.
        /// 
        ///  
        /// <para>
        /// The repository can be hosted either in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository service method.</param>
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        public virtual CreateCodeRepositoryResponse CreateCodeRepository(CreateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateCodeRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        public virtual IAsyncResult BeginCreateCodeRepository(CreateCodeRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeRepository.</param>
        /// 
        /// <returns>Returns a  CreateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        public virtual CreateCodeRepositoryResponse EndCreateCodeRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCodeRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCompilationJob

        /// <summary>
        /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
        /// saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon S3)
        /// bucket that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// with AWS IoT Greengrass. In that case, deploy them as an ML resource.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name for the compilation job
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Information about the input model artifacts 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The output location for the compiled model and the device (target) that the model
        /// runs on 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes
        /// to perform the model compilation job</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide a <code>Tag</code> to track the model compilation job's resource
        /// use and costs. The response body contains the <code>CompilationJobArn</code> for the
        /// compiled job.
        /// </para>
        ///  
        /// <para>
        /// To stop a model compilation job, use <a>StopCompilationJob</a>. To get information
        /// about a particular model compilation job, use <a>DescribeCompilationJob</a>. To get
        /// information about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob service method.</param>
        /// 
        /// <returns>The response from the CreateCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        public virtual CreateCompilationJobResponse CreateCompilationJob(CreateCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return Invoke<CreateCompilationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateCompilationJob(CreateCompilationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCompilationJob.</param>
        /// 
        /// <returns>Returns a  CreateCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        public virtual CreateCompilationJobResponse EndCreateCompilationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCompilationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates a Domain for Amazon SageMaker Studio, which can be accessed by end-users in
        /// a web browser. A Domain has an associated directory, list of authorized users, and
        /// a variety of security, application, policies, and Amazon Virtual Private Cloud configurations.
        /// An AWS account is limited to one Domain, per region. Users within a domain can share
        /// notebook files and other artifacts with each other. When a Domain is created, an Amazon
        /// Elastic File System (EFS) is also created for use by all of the users within the Domain.
        /// Each user receives a private home directory within the EFS for notebooks, Git repositories,
        /// and data files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpoint

        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. Amazon
        /// SageMaker uses the endpoint to provision resources and deploy models. You create the
        /// endpoint configuration with the <a>CreateEndpointConfig</a> API. 
        /// 
        ///  
        /// <para>
        ///  Use this API to deploy models using Amazon SageMaker hosting services. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
        /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html#ex1-deploy-model-boto">Deploy
        /// the Model to Amazon SageMaker Hosting Services (AWS SDK for Python (Boto 3)).</a>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must not delete an <code>EndpointConfig</code> that is in use by an endpoint
        /// that is live or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code>
        /// operations are being performed on the endpoint. To update an endpoint, you must create
        /// a new <code>EndpointConfig</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The endpoint name must be unique within an AWS Region in your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// When it receives the request, Amazon SageMaker creates the endpoint, launches the
        /// resources (ML compute instances), and deploys the model(s) on them. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
        /// After it creates the endpoint, it sets the status to <code>InService</code>. Amazon
        /// SageMaker can then process incoming requests for inferences. To check the status of
        /// an endpoint, use the <a>DescribeEndpoint</a> API.
        /// </para>
        ///  
        /// <para>
        /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
        /// Amazon SageMaker uses AWS Security Token Service to download model artifacts from
        /// the S3 path you provided. AWS STS is activated in your IAM user account by default.
        /// If you previously deactivated AWS STS for a region, you need to reactivate AWS STS
        /// for that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpointConfig

        /// <summary>
        /// Creates an endpoint configuration that Amazon SageMaker hosting services uses to deploy
        /// models. In the configuration, you identify one or more models, created using the <code>CreateModel</code>
        /// API, to deploy and the resources that you want Amazon SageMaker to provision. Then
        /// you call the <a>CreateEndpoint</a> API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API if you want to use Amazon SageMaker hosting services to deploy models
        /// into production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define a <code>ProductionVariant</code>, for each model that you
        /// want to deploy. Each <code>ProductionVariant</code> parameter also describes the resources
        /// that you want Amazon SageMaker to provision. This includes the number and type of
        /// ML compute instances to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
        /// specify how much traffic you want to allocate to each model. For example, suppose
        /// that you want to host two models, A and B, and you assign traffic weight 2 for model
        /// A and 1 for model B. Amazon SageMaker distributes two-thirds of the traffic to Model
        /// A, and one-third to model B. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
        /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html#ex1-deploy-model-boto">Deploy
        /// the Model to Amazon SageMaker Hosting Services (AWS SDK for Python (Boto 3)).</a>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        public virtual CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpointConfig(CreateEndpointConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointConfig.</param>
        /// 
        /// <returns>Returns a  CreateEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        public virtual CreateEndpointConfigResponse EndCreateEndpointConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExperiment

        /// <summary>
        /// Creates an Amazon SageMaker <i>experiment</i>. An experiment is a collection of <i>trials</i>
        /// that are observed, compared and evaluated as a group. A trial is a set of steps, called
        /// <i>trial components</i>, that produce a machine learning model.
        /// 
        ///  
        /// <para>
        /// The goal of an experiment is to determine the components that produce the best model.
        /// Multiple trials are performed, each one isolating and measuring the impact of a change
        /// to one or more inputs, while keeping the remaining inputs constant.
        /// </para>
        ///  
        /// <para>
        /// When you use Amazon SageMaker Studio or the Amazon SageMaker Python SDK, all experiments,
        /// trials, and trial components are automatically tracked, logged, and indexed. When
        /// you use the AWS SDK for Python (Boto), you must use the logging APIs provided by the
        /// SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to experiments, trials, trial components and then use the <a>Search</a>
        /// API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To add a description to an experiment, specify the optional <code>Description</code>
        /// parameter. To add a description later, or to change the description, call the <a>UpdateExperiment</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your experiments, call the <a>ListExperiments</a> API. To view
        /// an experiment's properties, call the <a>DescribeExperiment</a> API. To get a list
        /// of all the trials associated with an experiment, call the <a>ListTrials</a> API. To
        /// create a trial call the <a>CreateTrial</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        public virtual CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;

            return Invoke<CreateExperimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        public virtual IAsyncResult BeginCreateExperiment(CreateExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperiment.</param>
        /// 
        /// <returns>Returns a  CreateExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        public virtual CreateExperimentResponse EndCreateExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExperimentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFlowDefinition

        /// <summary>
        /// Creates a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        public virtual CreateFlowDefinitionResponse CreateFlowDefinition(CreateFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateFlowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateFlowDefinition(CreateFlowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowDefinition.</param>
        /// 
        /// <returns>Returns a  CreateFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        public virtual CreateFlowDefinitionResponse EndCreateFlowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFlowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHumanTaskUi

        /// <summary>
        /// Defines the settings you will use for the human review workflow user interface. Reviewers
        /// will see a three-panel interface with an instruction area, the item to review, and
        /// an input area.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi service method.</param>
        /// 
        /// <returns>The response from the CreateHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        public virtual CreateHumanTaskUiResponse CreateHumanTaskUi(CreateHumanTaskUiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHumanTaskUiResponseUnmarshaller.Instance;

            return Invoke<CreateHumanTaskUiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHumanTaskUi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        public virtual IAsyncResult BeginCreateHumanTaskUi(CreateHumanTaskUiRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHumanTaskUiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHumanTaskUi.</param>
        /// 
        /// <returns>Returns a  CreateHumanTaskUiResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        public virtual CreateHumanTaskUiResponse EndCreateHumanTaskUi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHumanTaskUiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHyperParameterTuningJob

        /// <summary>
        /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
        /// of a model by running many training jobs on your dataset using the algorithm you choose
        /// and values for hyperparameters within ranges that you specify. It then chooses the
        /// hyperparameter values that result in a model that performs the best, as measured by
        /// an objective metric that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the CreateHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        public virtual CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<CreateHyperParameterTuningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        public virtual IAsyncResult BeginCreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  CreateHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        public virtual CreateHyperParameterTuningJobResponse EndCreateHyperParameterTuningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHyperParameterTuningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLabelingJob

        /// <summary>
        /// Creates a job that uses workers to label the data objects in your input dataset. You
        /// can use the labeled data to train machine learning models.
        /// 
        ///  
        /// <para>
        /// You can select your workforce from one of three providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A private workforce that you create. It can include employees, contractors, and outside
        /// experts. Use a private workforce when want the data to stay within your organization
        /// or when a specific set of skills is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more vendors that you select from the AWS Marketplace. Vendors provide expertise
        /// in specific areas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Mechanical Turk workforce. This is the largest workforce, but it should
        /// only be used for public data or data that has been stripped of any personally identifiable
        /// information.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use <i>automated data labeling</i> to reduce the number of data objects
        /// that need to be labeled by a human. Automated data labeling uses <i>active learning</i>
        /// to determine if a data object can be labeled by machine or if it needs to be sent
        /// to a human worker. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-automated-labeling.html">Using
        /// Automated Data Labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// The data objects to be labeled are contained in an Amazon S3 bucket. You create a
        /// <i>manifest file</i> that describes the location of each object. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-data.html">Using
        /// Input and Output Data</a>.
        /// </para>
        ///  
        /// <para>
        /// The output can be used as the manifest file for another labeling job or as training
        /// data for your machine learning models.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob service method.</param>
        /// 
        /// <returns>The response from the CreateLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        public virtual CreateLabelingJobResponse CreateLabelingJob(CreateLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return Invoke<CreateLabelingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        public virtual IAsyncResult BeginCreateLabelingJob(CreateLabelingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabelingJob.</param>
        /// 
        /// <returns>Returns a  CreateLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        public virtual CreateLabelingJobResponse EndCreateLabelingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLabelingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Creates a model in Amazon SageMaker. In the request, you name the model and describe
        /// a primary container. For the primary container, you specify the Docker image that
        /// contains inference code, artifacts (from prior training), and a custom environment
        /// map that the inference code uses when you deploy the model for predictions.
        /// 
        ///  
        /// <para>
        /// Use this API to create a model if you want to use Amazon SageMaker hosting services
        /// or run a batch transform job.
        /// </para>
        ///  
        /// <para>
        /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
        /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. Amazon
        /// SageMaker then deploys all of the containers that you defined for the model in the
        /// hosting environment. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
        /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html#ex1-deploy-model-boto">Deploy
        /// the Model to Amazon SageMaker Hosting Services (AWS SDK for Python (Boto 3)).</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To run a batch transform using your model, you start a job with the <code>CreateTransformJob</code>
        /// API. Amazon SageMaker uses your model and your dataset to get inferences which are
        /// then saved to a specified S3 location.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateModel</code> request, you must define a container with the <code>PrimaryContainer</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// In the request, you also provide an IAM role that Amazon SageMaker can assume to access
        /// model artifacts and docker image for deployment on ML compute hosting instances or
        /// for batch transform jobs. In addition, you also use the IAM role to manage permissions
        /// the inference code needs. For example, if the inference code access any other AWS
        /// resources, you grant necessary permissions via this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModelPackage

        /// <summary>
        /// Creates a model package that you can use to create Amazon SageMaker models or list
        /// on AWS Marketplace. Buyers can subscribe to model packages listed on AWS Marketplace
        /// to create models in Amazon SageMaker.
        /// 
        ///  
        /// <para>
        /// To create a model package by specifying a Docker container that contains your inference
        /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
        /// To create a model from an algorithm resource that you created or subscribed to in
        /// AWS Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage service method.</param>
        /// 
        /// <returns>The response from the CreateModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        public virtual CreateModelPackageResponse CreateModelPackage(CreateModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return Invoke<CreateModelPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        public virtual IAsyncResult BeginCreateModelPackage(CreateModelPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelPackage.</param>
        /// 
        /// <returns>Returns a  CreateModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        public virtual CreateModelPackageResponse EndCreateModelPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMonitoringSchedule

        /// <summary>
        /// Creates a schedule that regularly starts Amazon SageMaker Processing Jobs to monitor
        /// the data captured for an Amazon SageMaker Endoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        public virtual CreateMonitoringScheduleResponse CreateMonitoringSchedule(CreateMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginCreateMonitoringSchedule(CreateMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  CreateMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        public virtual CreateMonitoringScheduleResponse EndCreateMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNotebookInstance

        /// <summary>
        /// Creates an Amazon SageMaker notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
        /// that you want to run. Amazon SageMaker launches the instance, installs common libraries
        /// that you can use to explore datasets for model training, and attaches an ML storage
        /// volume to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker also provides a set of example notebooks. Each notebook demonstrates
        /// how to use Amazon SageMaker with a specific algorithm or with a machine learning framework.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, Amazon SageMaker does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the Amazon SageMaker VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <code>SubnetId</code>, Amazon SageMaker creates a network
        /// interface in your own VPC, which is inferred from the subnet ID that you provide in
        /// the input. When creating this network interface, Amazon SageMaker attaches the security
        /// group that you specified in the request to the network interface that it creates in
        /// your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the Amazon SageMaker
        /// VPC. If you specified <code>SubnetId</code> of your VPC, Amazon SageMaker specifies
        /// both network interfaces when launching this instance. This enables inbound traffic
        /// from your own VPC to the notebook instance, assuming that the security groups allow
        /// it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, Amazon SageMaker returns its Amazon Resource
        /// Name (ARN). You can't change the name of a notebook instance after you create it.
        /// </para>
        ///  
        /// <para>
        /// After Amazon SageMaker creates the notebook instance, you can connect to the Jupyter
        /// server and work in Jupyter notebooks. For example, you can write code to explore a
        /// dataset that you can use for model training, train a model, host models by creating
        /// Amazon SageMaker endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        public virtual CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateNotebookInstance(CreateNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        public virtual CreateNotebookInstanceResponse EndCreateNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNotebookInstanceLifecycleConfig

        /// <summary>
        /// Creates a lifecycle configuration that you can associate with a notebook instance.
        /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
        /// create or start a notebook instance.
        /// 
        ///  
        /// <para>
        /// Each lifecycle configuration script has a limit of 16384 characters.
        /// </para>
        ///  
        /// <para>
        /// The value of the <code>$PATH</code> environment variable that is available to both
        /// scripts is <code>/sbin:bin:/usr/sbin:/usr/bin</code>.
        /// </para>
        ///  
        /// <para>
        /// View CloudWatch Logs for notebook instance lifecycle configurations in log group <code>/aws/sagemaker/NotebookInstances</code>
        /// in log stream <code>[notebook-instance-name]/[LifecycleConfigHook]</code>.
        /// </para>
        ///  
        /// <para>
        /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
        /// runs for longer than 5 minutes, it fails and the notebook instance is not created
        /// or started.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceLifecycleConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual CreateNotebookInstanceLifecycleConfigResponse EndCreateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotebookInstanceLifecycleConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePresignedDomainUrl

        /// <summary>
        /// Creates a URL for a specified UserProfile in a Domain. When accessed in a web browser,
        /// the user will be automatically signed in to Amazon SageMaker Studio, and granted access
        /// to all of the Apps and files associated with that Amazon Elastic File System (EFS).
        /// This operation can only be called when AuthMode equals IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedDomainUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        public virtual CreatePresignedDomainUrlResponse CreatePresignedDomainUrl(CreatePresignedDomainUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedDomainUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedDomainUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedDomainUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedDomainUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedDomainUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        public virtual IAsyncResult BeginCreatePresignedDomainUrl(CreatePresignedDomainUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedDomainUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedDomainUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedDomainUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedDomainUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedDomainUrlResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        public virtual CreatePresignedDomainUrlResponse EndCreatePresignedDomainUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresignedDomainUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl

        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the Amazon SageMaker console, when you choose <code>Open</code> next to a notebook
        /// instance, Amazon SageMaker opens a new tab showing the Jupyter server home page from
        /// the notebook instance. The console uses this API to get the URL and show the page.
        /// 
        ///  
        /// <para>
        /// IAM authorization policies for this API are also enforced for every HTTP request and
        /// WebSocket frame that attempts to connect to the notebook instance.For example, you
        /// can restrict access to this API and to the URL that it returns to a list of IP addresses
        /// that you specify. Use the <code>NotIpAddress</code> condition operator and the <code>aws:SourceIP</code>
        /// condition context key to specify the list of IP addresses that you want to have access
        /// to the notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/security_iam_id-based-policy-examples.html#nbi-ip-filter">Limit
        /// Access to a Notebook Instance by IP Address</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <a>CreatePresignedNotebookInstanceUrl</a> is valid
        /// only for 5 minutes. If you try to use the URL after the 5-minute limit expires, you
        /// are directed to the AWS console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedNotebookInstanceUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedNotebookInstanceUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual IAsyncResult BeginCreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedNotebookInstanceUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedNotebookInstanceUrlResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual CreatePresignedNotebookInstanceUrlResponse EndCreatePresignedNotebookInstanceUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresignedNotebookInstanceUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProcessingJob

        /// <summary>
        /// Creates a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob service method.</param>
        /// 
        /// <returns>The response from the CreateProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        public virtual CreateProcessingJobResponse CreateProcessingJob(CreateProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProcessingJobResponseUnmarshaller.Instance;

            return Invoke<CreateProcessingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        public virtual IAsyncResult BeginCreateProcessingJob(CreateProcessingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProcessingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProcessingJob.</param>
        /// 
        /// <returns>Returns a  CreateProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        public virtual CreateProcessingJobResponse EndCreateProcessingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProcessingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrainingJob

        /// <summary>
        /// Starts a model training job. After training completes, Amazon SageMaker saves the
        /// resulting model artifacts to an Amazon S3 location that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// in a machine learning service other than Amazon SageMaker, provided that you know
        /// how to use them for inferences. 
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to enable
        /// the estimation of model parameters during training. Hyperparameters can be tuned to
        /// optimize this learning process. For a list of hyperparameters for each training algorithm
        /// provided by Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InputDataConfig</code> - Describes the training dataset and the Amazon S3,
        /// EFS, or FSx location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 bucket where you want Amazon
        /// SageMaker to save the results of model training. 
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
        /// ML storage volumes to deploy for model training. In distributed training, you specify
        /// more than one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EnableManagedSpotTraining</code> - Optimize the cost of training machine learning
        /// models by up to 80% by using Amazon EC2 Spot instances. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
        /// Spot Training</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoleARN</code> - The Amazon Resource Number (ARN) that Amazon SageMaker assumes
        /// to perform tasks on your behalf during model training. You must grant this role the
        /// necessary permissions so that Amazon SageMaker can successfully complete model training.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StoppingCondition</code> - To help cap training costs, use <code>MaxRuntimeInSeconds</code>
        /// to set a time limit for training. Use <code>MaxWaitTimeInSeconds</code> to specify
        /// how long you are willing to wait for a managed spot training job to complete. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob service method.</param>
        /// 
        /// <returns>The response from the CreateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        public virtual CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        public virtual IAsyncResult BeginCreateTrainingJob(CreateTrainingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainingJob.</param>
        /// 
        /// <returns>Returns a  CreateTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        public virtual CreateTrainingJobResponse EndCreateTrainingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrainingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTransformJob

        /// <summary>
        /// Starts a transform job. A transform job uses a trained model to get inferences on
        /// a dataset and saves these results to an Amazon S3 location that you specify.
        /// 
        ///  
        /// <para>
        /// To perform batch transformations, you create a transform job and use the data that
        /// you have readily available.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TransformJobName</code> - Identifies the transform job. The name must be unique
        /// within an AWS Region in an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ModelName</code> - Identifies the model to use. <code>ModelName</code> must
        /// be the name of an existing Amazon SageMaker model in the same AWS Region and AWS account.
        /// For information on creating a model, see <a>CreateModel</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformInput</code> - Describes the dataset to be transformed and the Amazon
        /// S3 location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformOutput</code> - Identifies the Amazon S3 location where you want Amazon
        /// SageMaker to save the results from the transform job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformResources</code> - Identifies the ML compute instances for the transform
        /// job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how batch transformation works, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Batch
        /// Transform</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob service method.</param>
        /// 
        /// <returns>The response from the CreateTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        public virtual CreateTransformJobResponse CreateTransformJob(CreateTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return Invoke<CreateTransformJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        public virtual IAsyncResult BeginCreateTransformJob(CreateTransformJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransformJob.</param>
        /// 
        /// <returns>Returns a  CreateTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        public virtual CreateTransformJobResponse EndCreateTransformJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTransformJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrial

        /// <summary>
        /// Creates an Amazon SageMaker <i>trial</i>. A trial is a set of steps called <i>trial
        /// components</i> that produce a machine learning model. A trial is part of a single
        /// Amazon SageMaker <i>experiment</i>.
        /// 
        ///  
        /// <para>
        /// When you use Amazon SageMaker Studio or the Amazon SageMaker Python SDK, all experiments,
        /// trials, and trial components are automatically tracked, logged, and indexed. When
        /// you use the AWS SDK for Python (Boto), you must use the logging APIs provided by the
        /// SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial and then use the <a>Search</a> API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your trials, call the <a>ListTrials</a> API. To view a trial's
        /// properties, call the <a>DescribeTrial</a> API. To create a trial component, call the
        /// <a>CreateTrialComponent</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial service method.</param>
        /// 
        /// <returns>The response from the CreateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        public virtual CreateTrialResponse CreateTrial(CreateTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialResponseUnmarshaller.Instance;

            return Invoke<CreateTrialResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        public virtual IAsyncResult BeginCreateTrial(CreateTrialRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrial.</param>
        /// 
        /// <returns>Returns a  CreateTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        public virtual CreateTrialResponse EndCreateTrial(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrialResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrialComponent

        /// <summary>
        /// Creates a <i>trial component</i>, which is a stage of a machine learning <i>trial</i>.
        /// A trial is composed of one or more trial components. A trial component can be used
        /// in multiple trials.
        /// 
        ///  
        /// <para>
        /// Trial components include pre-processing jobs, training jobs, and batch transform jobs.
        /// </para>
        ///  
        /// <para>
        /// When you use Amazon SageMaker Studio or the Amazon SageMaker Python SDK, all experiments,
        /// trials, and trial components are automatically tracked, logged, and indexed. When
        /// you use the AWS SDK for Python (Boto), you must use the logging APIs provided by the
        /// SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial component and then use the <a>Search</a> API to search
        /// for the tags.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>CreateTrialComponent</code> can only be invoked from within an Amazon SageMaker
        /// managed environment. This includes Amazon SageMaker training jobs, processing jobs,
        /// transform jobs, and Amazon SageMaker notebooks. A call to <code>CreateTrialComponent</code>
        /// from outside one of these environments results in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the CreateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        public virtual CreateTrialComponentResponse CreateTrialComponent(CreateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<CreateTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateTrialComponent(CreateTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrialComponent.</param>
        /// 
        /// <returns>Returns a  CreateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        public virtual CreateTrialComponentResponse EndCreateTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserProfile

        /// <summary>
        /// Creates a user profile. A user profile represents a single user within a Domain, and
        /// is the main way to reference a "person" for the purposes of sharing, reporting and
        /// other user-oriented features. This entity is created during on-boarding to Amazon
        /// SageMaker Studio. If an administrator invites a person by email or imports them from
        /// SSO, a UserProfile is automatically created. 
        /// 
        ///  
        /// <para>
        ///  This entity is the primary holder of settings for an individual user and, through
        /// the domain, has a reference to the user's private Amazon Elastic File System (EFS)
        /// home directory. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkteam

        /// <summary>
        /// Creates a new work team for labeling your data. A work team is defined by one or more
        /// Amazon Cognito user pools. You must first create the user pools before you can create
        /// a work team.
        /// 
        ///  
        /// <para>
        /// You cannot create more than 25 work teams in an account and region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam service method.</param>
        /// 
        /// <returns>The response from the CreateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        public virtual CreateWorkteamResponse CreateWorkteam(CreateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return Invoke<CreateWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkteam(CreateWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkteam.</param>
        /// 
        /// <returns>Returns a  CreateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        public virtual CreateWorkteamResponse EndCreateWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkteamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlgorithm

        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        public virtual DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DeleteAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlgorithm(DeleteAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlgorithm.</param>
        /// 
        /// <returns>Returns a  DeleteAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        public virtual DeleteAlgorithmResponse EndDeleteAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Used to stop and delete an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCodeRepository

        /// <summary>
        /// Deletes the specified Git repository from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        public virtual DeleteCodeRepositoryResponse DeleteCodeRepository(DeleteCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        public virtual IAsyncResult BeginDeleteCodeRepository(DeleteCodeRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeRepository.</param>
        /// 
        /// <returns>Returns a  DeleteCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        public virtual DeleteCodeRepositoryResponse EndDeleteCodeRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCodeRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Used to delete a domain. Use with caution. If <code>RetentionPolicy</code> is set
        /// to <code>Delete</code>, all of the members of the domain will lose access to their
        /// EFS volume, including data, notebooks, and other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes an endpoint. Amazon SageMaker frees up all of the resources that were deployed
        /// when the endpoint was created. 
        /// 
        ///  
        /// <para>
        /// Amazon SageMaker retires any custom KMS key grants associated with the endpoint, meaning
        /// you don't need to use the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
        /// API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpointConfig

        /// <summary>
        /// Deletes an endpoint configuration. The <code>DeleteEndpointConfig</code> API deletes
        /// only the specified configuration. It does not delete endpoints created using the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpointConfig(DeleteEndpointConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual DeleteEndpointConfigResponse EndDeleteEndpointConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExperiment

        /// <summary>
        /// Deletes an Amazon SageMaker experiment. All trials associated with the experiment
        /// must be deleted first. Use the <a>ListTrials</a> API to get a list of the trials associated
        /// with the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        public virtual DeleteExperimentResponse DeleteExperiment(DeleteExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;

            return Invoke<DeleteExperimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        public virtual IAsyncResult BeginDeleteExperiment(DeleteExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperiment.</param>
        /// 
        /// <returns>Returns a  DeleteExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        public virtual DeleteExperimentResponse EndDeleteExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExperimentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlowDefinition

        /// <summary>
        /// Deletes the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        public virtual DeleteFlowDefinitionResponse DeleteFlowDefinition(DeleteFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteFlowDefinition(DeleteFlowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        public virtual DeleteFlowDefinitionResponse EndDeleteFlowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFlowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModel

        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in Amazon SageMaker when you called the <a>CreateModel</a> API. It does
        /// not delete model artifacts, inference code, or the IAM role that you specified when
        /// creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModelPackage

        /// <summary>
        /// Deletes a model package.
        /// 
        ///  
        /// <para>
        /// A model package is used to create Amazon SageMaker models or list on AWS Marketplace.
        /// Buyers can subscribe to model packages listed on AWS Marketplace to create models
        /// in Amazon SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage service method.</param>
        /// 
        /// <returns>The response from the DeleteModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        public virtual DeleteModelPackageResponse DeleteModelPackage(DeleteModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteModelPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        public virtual IAsyncResult BeginDeleteModelPackage(DeleteModelPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelPackage.</param>
        /// 
        /// <returns>Returns a  DeleteModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        public virtual DeleteModelPackageResponse EndDeleteModelPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMonitoringSchedule

        /// <summary>
        /// Deletes a monitoring schedule. Also stops the schedule had not already been stopped.
        /// This does not delete the job execution history of the monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        public virtual DeleteMonitoringScheduleResponse DeleteMonitoringSchedule(DeleteMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginDeleteMonitoringSchedule(DeleteMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        public virtual DeleteMonitoringScheduleResponse EndDeleteMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNotebookInstance

        /// <summary>
        /// Deletes an Amazon SageMaker notebook instance. Before you can delete a notebook instance,
        /// you must call the <code>StopNotebookInstance</code> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. Amazon SageMaker removes
        /// the ML compute instance, and deletes the ML storage volume and the network interface
        /// associated with the notebook instance. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotebookInstance(DeleteNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual DeleteNotebookInstanceResponse EndDeleteNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNotebookInstanceLifecycleConfig

        /// <summary>
        /// Deletes a notebook instance lifecycle configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual DeleteNotebookInstanceLifecycleConfigResponse DeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceLifecycleConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual DeleteNotebookInstanceLifecycleConfigResponse EndDeleteNotebookInstanceLifecycleConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotebookInstanceLifecycleConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes the specified tags from an Amazon SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <code>ListTags</code> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call this API to delete tags from a hyperparameter tuning job, the deleted
        /// tags are not removed from training jobs that the hyperparameter tuning job launched
        /// before you called this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrial

        /// <summary>
        /// Deletes the specified trial. All trial components that make up the trial must be deleted
        /// first. Use the <a>DescribeTrialComponent</a> API to get the list of trial components.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial service method.</param>
        /// 
        /// <returns>The response from the DeleteTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        public virtual DeleteTrialResponse DeleteTrial(DeleteTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialResponseUnmarshaller.Instance;

            return Invoke<DeleteTrialResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrial(DeleteTrialRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrial.</param>
        /// 
        /// <returns>Returns a  DeleteTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        public virtual DeleteTrialResponse EndDeleteTrial(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrialResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrialComponent

        /// <summary>
        /// Deletes the specified trial component. A trial component must be disassociated from
        /// all trials before the trial component can be deleted. To disassociate a trial component
        /// from a trial, call the <a>DisassociateTrialComponent</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        public virtual DeleteTrialComponentResponse DeleteTrialComponent(DeleteTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrialComponent(DeleteTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrialComponent.</param>
        /// 
        /// <returns>Returns a  DeleteTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        public virtual DeleteTrialComponentResponse EndDeleteTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserProfile

        /// <summary>
        /// Deletes a user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkteam

        /// <summary>
        /// Deletes an existing work team. This operation can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        public virtual DeleteWorkteamResponse DeleteWorkteam(DeleteWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkteam(DeleteWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkteam.</param>
        /// 
        /// <returns>Returns a  DeleteWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        public virtual DeleteWorkteamResponse EndDeleteWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkteamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlgorithm

        /// <summary>
        /// Returns a description of the specified algorithm that is in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlgorithm(DescribeAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlgorithm.</param>
        /// 
        /// <returns>Returns a  DescribeAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual DescribeAlgorithmResponse EndDescribeAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApp

        /// <summary>
        /// Describes the app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutoMLJob

        /// <summary>
        /// Returns information about an Amazon SageMaker job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        public virtual DescribeAutoMLJobResponse DescribeAutoMLJob(DescribeAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoMLJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutoMLJob(DescribeAutoMLJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoMLJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoMLJob.</param>
        /// 
        /// <returns>Returns a  DescribeAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        public virtual DescribeAutoMLJobResponse EndDescribeAutoMLJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoMLJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCodeRepository

        /// <summary>
        /// Gets details about the specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        public virtual DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        public virtual IAsyncResult BeginDescribeCodeRepository(DescribeCodeRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeRepository.</param>
        /// 
        /// <returns>Returns a  DescribeCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        public virtual DescribeCodeRepositoryResponse EndDescribeCodeRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCodeRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCompilationJob

        /// <summary>
        /// Returns information about a model compilation job.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        public virtual DescribeCompilationJobResponse DescribeCompilationJob(DescribeCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeCompilationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeCompilationJob(DescribeCompilationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCompilationJob.</param>
        /// 
        /// <returns>Returns a  DescribeCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        public virtual DescribeCompilationJobResponse EndDescribeCompilationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCompilationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomain

        /// <summary>
        /// The desciption of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpoint

        /// <summary>
        /// Returns the description of an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointConfig

        /// <summary>
        /// Returns the description of an endpoint configuration created using the <code>CreateEndpointConfig</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointConfig(DescribeEndpointConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual DescribeEndpointConfigResponse EndDescribeEndpointConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExperiment

        /// <summary>
        /// Provides a list of an experiment's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment service method.</param>
        /// 
        /// <returns>The response from the DescribeExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        public virtual DescribeExperimentResponse DescribeExperiment(DescribeExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperimentResponseUnmarshaller.Instance;

            return Invoke<DescribeExperimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        public virtual IAsyncResult BeginDescribeExperiment(DescribeExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExperiment.</param>
        /// 
        /// <returns>Returns a  DescribeExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        public virtual DescribeExperimentResponse EndDescribeExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExperimentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowDefinition

        /// <summary>
        /// Returns information about the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        public virtual DescribeFlowDefinitionResponse DescribeFlowDefinition(DescribeFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlowDefinition(DescribeFlowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        public virtual DescribeFlowDefinitionResponse EndDescribeFlowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHumanTaskUi

        /// <summary>
        /// Returns information about the requested human task user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi service method.</param>
        /// 
        /// <returns>The response from the DescribeHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        public virtual DescribeHumanTaskUiResponse DescribeHumanTaskUi(DescribeHumanTaskUiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanTaskUiResponseUnmarshaller.Instance;

            return Invoke<DescribeHumanTaskUiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHumanTaskUi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        public virtual IAsyncResult BeginDescribeHumanTaskUi(DescribeHumanTaskUiRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanTaskUiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHumanTaskUi.</param>
        /// 
        /// <returns>Returns a  DescribeHumanTaskUiResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        public virtual DescribeHumanTaskUiResponse EndDescribeHumanTaskUi(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHumanTaskUiResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHyperParameterTuningJob

        /// <summary>
        /// Gets a description of a hyperparameter tuning job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        public virtual DescribeHyperParameterTuningJobResponse DescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeHyperParameterTuningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  DescribeHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        public virtual DescribeHyperParameterTuningJobResponse EndDescribeHyperParameterTuningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHyperParameterTuningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLabelingJob

        /// <summary>
        /// Gets information about a labeling job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        public virtual DescribeLabelingJobResponse DescribeLabelingJob(DescribeLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeLabelingJob(DescribeLabelingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabelingJob.</param>
        /// 
        /// <returns>Returns a  DescribeLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        public virtual DescribeLabelingJobResponse EndDescribeLabelingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLabelingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeModel

        /// <summary>
        /// Describes a model that you created using the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeModelPackage

        /// <summary>
        /// Returns a description of the specified model package, which is used to create Amazon
        /// SageMaker models or list them on AWS Marketplace.
        /// 
        ///  
        /// <para>
        /// To create models in Amazon SageMaker, buyers can subscribe to model packages listed
        /// on AWS Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage service method.</param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        public virtual DescribeModelPackageResponse DescribeModelPackage(DescribeModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return Invoke<DescribeModelPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        public virtual IAsyncResult BeginDescribeModelPackage(DescribeModelPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelPackage.</param>
        /// 
        /// <returns>Returns a  DescribeModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        public virtual DescribeModelPackageResponse EndDescribeModelPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeModelPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMonitoringSchedule

        /// <summary>
        /// Describes the schedule for a monitoring job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        public virtual DescribeMonitoringScheduleResponse DescribeMonitoringSchedule(DescribeMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginDescribeMonitoringSchedule(DescribeMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        public virtual DescribeMonitoringScheduleResponse EndDescribeMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotebookInstance

        /// <summary>
        /// Returns information about a notebook instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        public virtual DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotebookInstance(DescribeNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        public virtual DescribeNotebookInstanceResponse EndDescribeNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotebookInstanceLifecycleConfig

        /// <summary>
        /// Returns a description of a notebook instance lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceLifecycleConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual DescribeNotebookInstanceLifecycleConfigResponse EndDescribeNotebookInstanceLifecycleConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotebookInstanceLifecycleConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProcessingJob

        /// <summary>
        /// Returns a description of a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        public virtual DescribeProcessingJobResponse DescribeProcessingJob(DescribeProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProcessingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeProcessingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeProcessingJob(DescribeProcessingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProcessingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProcessingJob.</param>
        /// 
        /// <returns>Returns a  DescribeProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        public virtual DescribeProcessingJobResponse EndDescribeProcessingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProcessingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSubscribedWorkteam

        /// <summary>
        /// Gets information about a work team provided by a vendor. It returns details about
        /// the subscription with a vendor in the AWS Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribedWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        public virtual DescribeSubscribedWorkteamResponse DescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscribedWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscribedWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        public virtual IAsyncResult BeginDescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribedWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribedWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        public virtual DescribeSubscribedWorkteamResponse EndDescribeSubscribedWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubscribedWorkteamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrainingJob

        /// <summary>
        /// Returns information about a training job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTrainingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrainingJob(DescribeTrainingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrainingJob.</param>
        /// 
        /// <returns>Returns a  DescribeTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual DescribeTrainingJobResponse EndDescribeTrainingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrainingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTransformJob

        /// <summary>
        /// Returns information about a transform job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        public virtual DescribeTransformJobResponse DescribeTransformJob(DescribeTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTransformJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTransformJob(DescribeTransformJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTransformJob.</param>
        /// 
        /// <returns>Returns a  DescribeTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        public virtual DescribeTransformJobResponse EndDescribeTransformJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTransformJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrial

        /// <summary>
        /// Provides a list of a trial's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial service method.</param>
        /// 
        /// <returns>The response from the DescribeTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        public virtual DescribeTrialResponse DescribeTrial(DescribeTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialResponseUnmarshaller.Instance;

            return Invoke<DescribeTrialResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrial(DescribeTrialRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrial.</param>
        /// 
        /// <returns>Returns a  DescribeTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        public virtual DescribeTrialResponse EndDescribeTrial(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrialResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrialComponent

        /// <summary>
        /// Provides a list of a trials component's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        public virtual DescribeTrialComponentResponse DescribeTrialComponent(DescribeTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrialComponent(DescribeTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrialComponent.</param>
        /// 
        /// <returns>Returns a  DescribeTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        public virtual DescribeTrialComponentResponse EndDescribeTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserProfile

        /// <summary>
        /// Describes the user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public virtual DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserProfile(DescribeUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public virtual DescribeUserProfileResponse EndDescribeUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkforce

        /// <summary>
        /// Lists private workforce information, including workforce name, Amazon Resource Name
        /// (ARN), and, if applicable, allowed IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>).
        /// Allowable IP address ranges are the IP addresses that workers can use to access tasks.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// This operation applies only to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkforce service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        public virtual DescribeWorkforceResponse DescribeWorkforce(DescribeWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkforceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkforceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkforce(DescribeWorkforceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkforceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkforce.</param>
        /// 
        /// <returns>Returns a  DescribeWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        public virtual DescribeWorkforceResponse EndDescribeWorkforce(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkforceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkteam

        /// <summary>
        /// Gets information about a specific work team. You can see information such as the create
        /// date, the last updated date, membership information, and the work team's Amazon Resource
        /// Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        public virtual DescribeWorkteamResponse DescribeWorkteam(DescribeWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkteam(DescribeWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        public virtual DescribeWorkteamResponse EndDescribeWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkteamResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTrialComponent

        /// <summary>
        /// Disassociates a trial component from a trial. This doesn't effect other trials the
        /// component is associated with. Before you can delete a component, you must disassociate
        /// the component from all trials it is associated with. To associate a trial component
        /// with a trial, call the <a>AssociateTrialComponent</a> API.
        /// 
        ///  
        /// <para>
        /// To get a list of the trials a component is associated with, use the <a>Search</a>
        /// API. Specify <code>ExperimentTrialComponent</code> for the <code>Resource</code> parameter.
        /// The list appears in the response under <code>Results.TrialComponent.Parents</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        public virtual DisassociateTrialComponentResponse DisassociateTrialComponent(DisassociateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DisassociateTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTrialComponent(DisassociateTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrialComponent.</param>
        /// 
        /// <returns>Returns a  DisassociateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        public virtual DisassociateTrialComponentResponse EndDisassociateTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSearchSuggestions

        /// <summary>
        /// An auto-complete API for the search functionality in the Amazon SageMaker console.
        /// It returns suggestions of possible matches for the property name to use in <code>Search</code>
        /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
        /// and <code>Metrics</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        public virtual GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetSearchSuggestionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSearchSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        public virtual IAsyncResult BeginGetSearchSuggestions(GetSearchSuggestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSearchSuggestions.</param>
        /// 
        /// <returns>Returns a  GetSearchSuggestionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        public virtual GetSearchSuggestionsResponse EndGetSearchSuggestions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSearchSuggestionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlgorithms

        /// <summary>
        /// Lists the machine learning algorithms that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms service method.</param>
        /// 
        /// <returns>The response from the ListAlgorithms service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        public virtual ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return Invoke<ListAlgorithmsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlgorithms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        public virtual IAsyncResult BeginListAlgorithms(ListAlgorithmsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlgorithms.</param>
        /// 
        /// <returns>Returns a  ListAlgorithmsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        public virtual ListAlgorithmsResponse EndListAlgorithms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlgorithmsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApps

        /// <summary>
        /// Lists apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse EndListApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutoMLJobs

        /// <summary>
        /// Request a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs service method.</param>
        /// 
        /// <returns>The response from the ListAutoMLJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        public virtual ListAutoMLJobsResponse ListAutoMLJobs(ListAutoMLJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoMLJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoMLJobsResponseUnmarshaller.Instance;

            return Invoke<ListAutoMLJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutoMLJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutoMLJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        public virtual IAsyncResult BeginListAutoMLJobs(ListAutoMLJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoMLJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoMLJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutoMLJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutoMLJobs.</param>
        /// 
        /// <returns>Returns a  ListAutoMLJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        public virtual ListAutoMLJobsResponse EndListAutoMLJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutoMLJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCandidatesForAutoMLJob

        /// <summary>
        /// List the Candidates created for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the ListCandidatesForAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        public virtual ListCandidatesForAutoMLJobResponse ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCandidatesForAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCandidatesForAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<ListCandidatesForAutoMLJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCandidatesForAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCandidatesForAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        public virtual IAsyncResult BeginListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCandidatesForAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCandidatesForAutoMLJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCandidatesForAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCandidatesForAutoMLJob.</param>
        /// 
        /// <returns>Returns a  ListCandidatesForAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        public virtual ListCandidatesForAutoMLJobResponse EndListCandidatesForAutoMLJob(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCandidatesForAutoMLJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCodeRepositories

        /// <summary>
        /// Gets a list of the Git repositories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories service method.</param>
        /// 
        /// <returns>The response from the ListCodeRepositories service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        public virtual ListCodeRepositoriesResponse ListCodeRepositories(ListCodeRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListCodeRepositoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        public virtual IAsyncResult BeginListCodeRepositories(ListCodeRepositoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeRepositories.</param>
        /// 
        /// <returns>Returns a  ListCodeRepositoriesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        public virtual ListCodeRepositoriesResponse EndListCodeRepositories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCodeRepositoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCompilationJobs

        /// <summary>
        /// Lists model compilation jobs that satisfy various filters.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about a particular model compilation job you have created, use <a>DescribeCompilationJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs service method.</param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        public virtual ListCompilationJobsResponse ListCompilationJobs(ListCompilationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return Invoke<ListCompilationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCompilationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        public virtual IAsyncResult BeginListCompilationJobs(ListCompilationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCompilationJobs.</param>
        /// 
        /// <returns>Returns a  ListCompilationJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        public virtual ListCompilationJobsResponse EndListCompilationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCompilationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Lists the domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEndpointConfigs

        /// <summary>
        /// Lists endpoint configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs service method.</param>
        /// 
        /// <returns>The response from the ListEndpointConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        public virtual ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        public virtual IAsyncResult BeginListEndpointConfigs(ListEndpointConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointConfigs.</param>
        /// 
        /// <returns>Returns a  ListEndpointConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        public virtual ListEndpointConfigsResponse EndListEndpointConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEndpointConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEndpoints

        /// <summary>
        /// Lists endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExperiments

        /// <summary>
        /// Lists all the experiments in your account. The list can be filtered to show only experiments
        /// that were created in a specific time range. The list can be sorted by experiment name
        /// or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual IAsyncResult BeginListExperiments(ListExperimentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiments.</param>
        /// 
        /// <returns>Returns a  ListExperimentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual ListExperimentsResponse EndListExperiments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperimentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlowDefinitions

        /// <summary>
        /// Returns information about the flow definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListFlowDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        public virtual ListFlowDefinitionsResponse ListFlowDefinitions(ListFlowDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListFlowDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlowDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListFlowDefinitions(ListFlowDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlowDefinitions.</param>
        /// 
        /// <returns>Returns a  ListFlowDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        public virtual ListFlowDefinitionsResponse EndListFlowDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHumanTaskUis

        /// <summary>
        /// Returns information about the human task user interfaces in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis service method.</param>
        /// 
        /// <returns>The response from the ListHumanTaskUis service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        public virtual ListHumanTaskUisResponse ListHumanTaskUis(ListHumanTaskUisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanTaskUisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanTaskUisResponseUnmarshaller.Instance;

            return Invoke<ListHumanTaskUisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHumanTaskUis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHumanTaskUis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        public virtual IAsyncResult BeginListHumanTaskUis(ListHumanTaskUisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanTaskUisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanTaskUisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHumanTaskUis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHumanTaskUis.</param>
        /// 
        /// <returns>Returns a  ListHumanTaskUisResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        public virtual ListHumanTaskUisResponse EndListHumanTaskUis(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHumanTaskUisResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHyperParameterTuningJobs

        /// <summary>
        /// Gets a list of <a>HyperParameterTuningJobSummary</a> objects that describe the hyperparameter
        /// tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        public virtual ListHyperParameterTuningJobsResponse ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return Invoke<ListHyperParameterTuningJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHyperParameterTuningJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        public virtual IAsyncResult BeginListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHyperParameterTuningJobs.</param>
        /// 
        /// <returns>Returns a  ListHyperParameterTuningJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        public virtual ListHyperParameterTuningJobsResponse EndListHyperParameterTuningJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHyperParameterTuningJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLabelingJobs

        /// <summary>
        /// Gets a list of labeling jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        public virtual ListLabelingJobsResponse ListLabelingJobs(ListLabelingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        public virtual IAsyncResult BeginListLabelingJobs(ListLabelingJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobs.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        public virtual ListLabelingJobsResponse EndListLabelingJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLabelingJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLabelingJobsForWorkteam

        /// <summary>
        /// Gets a list of labeling jobs assigned to a specified work team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobsForWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        public virtual ListLabelingJobsForWorkteamResponse ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsForWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobsForWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        public virtual IAsyncResult BeginListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobsForWorkteam.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsForWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        public virtual ListLabelingJobsForWorkteamResponse EndListLabelingJobsForWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLabelingJobsForWorkteamResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelPackages

        /// <summary>
        /// Lists the model packages that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages service method.</param>
        /// 
        /// <returns>The response from the ListModelPackages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        public virtual ListModelPackagesResponse ListModelPackages(ListModelPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return Invoke<ListModelPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        public virtual IAsyncResult BeginListModelPackages(ListModelPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelPackages.</param>
        /// 
        /// <returns>Returns a  ListModelPackagesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        public virtual ListModelPackagesResponse EndListModelPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModels

        /// <summary>
        /// Lists models created with the <a>CreateModel</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse EndListModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMonitoringExecutions

        /// <summary>
        /// Returns list of all monitoring job executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringExecutions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        public virtual ListMonitoringExecutionsResponse ListMonitoringExecutions(ListMonitoringExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        public virtual IAsyncResult BeginListMonitoringExecutions(ListMonitoringExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringExecutions.</param>
        /// 
        /// <returns>Returns a  ListMonitoringExecutionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        public virtual ListMonitoringExecutionsResponse EndListMonitoringExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMonitoringExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMonitoringSchedules

        /// <summary>
        /// Returns list of all monitoring schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringSchedules service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        public virtual ListMonitoringSchedulesResponse ListMonitoringSchedules(ListMonitoringSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringSchedulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        public virtual IAsyncResult BeginListMonitoringSchedules(ListMonitoringSchedulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringSchedulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringSchedules.</param>
        /// 
        /// <returns>Returns a  ListMonitoringSchedulesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        public virtual ListMonitoringSchedulesResponse EndListMonitoringSchedules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMonitoringSchedulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs

        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        public virtual ListNotebookInstanceLifecycleConfigsResponse ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstanceLifecycleConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstanceLifecycleConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        public virtual IAsyncResult BeginListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstanceLifecycleConfigs.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstanceLifecycleConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        public virtual ListNotebookInstanceLifecycleConfigsResponse EndListNotebookInstanceLifecycleConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotebookInstanceLifecycleConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotebookInstances

        /// <summary>
        /// Returns a list of the Amazon SageMaker notebook instances in the requester's account
        /// in an AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual IAsyncResult BeginListNotebookInstances(ListNotebookInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstances.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstancesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual ListNotebookInstancesResponse EndListNotebookInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotebookInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProcessingJobs

        /// <summary>
        /// Lists processing jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs service method.</param>
        /// 
        /// <returns>The response from the ListProcessingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        public virtual ListProcessingJobsResponse ListProcessingJobs(ListProcessingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProcessingJobsResponseUnmarshaller.Instance;

            return Invoke<ListProcessingJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProcessingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        public virtual IAsyncResult BeginListProcessingJobs(ListProcessingJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProcessingJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProcessingJobs.</param>
        /// 
        /// <returns>Returns a  ListProcessingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        public virtual ListProcessingJobsResponse EndListProcessingJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProcessingJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscribedWorkteams

        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the AWS Marketplace. The
        /// list may be empty if no work team satisfies the filter specified in the <code>NameContains</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        public virtual ListSubscribedWorkteamsResponse ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListSubscribedWorkteamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscribedWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        public virtual IAsyncResult BeginListSubscribedWorkteams(ListSubscribedWorkteamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscribedWorkteams.</param>
        /// 
        /// <returns>Returns a  ListSubscribedWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        public virtual ListSubscribedWorkteamsResponse EndListSubscribedWorkteams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscribedWorkteamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns the tags for the specified Amazon SageMaker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainingJobs

        /// <summary>
        /// Lists training jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual IAsyncResult BeginListTrainingJobs(ListTrainingJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobs.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual ListTrainingJobsResponse EndListTrainingJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainingJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob

        /// <summary>
        /// Gets a list of <a>TrainingJobSummary</a> objects that describe the training jobs that
        /// a hyperparameter tuning job launched.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobsForHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        public virtual ListTrainingJobsForHyperParameterTuningJobResponse ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsForHyperParameterTuningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobsForHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        public virtual IAsyncResult BeginListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobsForHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsForHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        public virtual ListTrainingJobsForHyperParameterTuningJobResponse EndListTrainingJobsForHyperParameterTuningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainingJobsForHyperParameterTuningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTransformJobs

        /// <summary>
        /// Lists transform jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs service method.</param>
        /// 
        /// <returns>The response from the ListTransformJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        public virtual ListTransformJobsResponse ListTransformJobs(ListTransformJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return Invoke<ListTransformJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransformJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        public virtual IAsyncResult BeginListTransformJobs(ListTransformJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransformJobs.</param>
        /// 
        /// <returns>Returns a  ListTransformJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        public virtual ListTransformJobsResponse EndListTransformJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTransformJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrialComponents

        /// <summary>
        /// Lists the trial components in your account. You can sort the list by trial component
        /// name or creation time. You can filter the list to show only components that were created
        /// in a specific time range. You can also filter on one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExperimentName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialName</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents service method.</param>
        /// 
        /// <returns>The response from the ListTrialComponents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        public virtual ListTrialComponentsResponse ListTrialComponents(ListTrialComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialComponentsResponseUnmarshaller.Instance;

            return Invoke<ListTrialComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrialComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrialComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        public virtual IAsyncResult BeginListTrialComponents(ListTrialComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrialComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrialComponents.</param>
        /// 
        /// <returns>Returns a  ListTrialComponentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        public virtual ListTrialComponentsResponse EndListTrialComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrialComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrials

        /// <summary>
        /// Lists the trials in your account. Specify an experiment name to limit the list to
        /// the trials that are part of that experiment. Specify a trial component name to limit
        /// the list to the trials that associated with that trial component. The list can be
        /// filtered to show only trials that were created in a specific time range. The list
        /// can be sorted by trial name or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrials service method.</param>
        /// 
        /// <returns>The response from the ListTrials service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        public virtual ListTrialsResponse ListTrials(ListTrialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialsResponseUnmarshaller.Instance;

            return Invoke<ListTrialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrials operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        public virtual IAsyncResult BeginListTrials(ListTrialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrials.</param>
        /// 
        /// <returns>Returns a  ListTrialsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        public virtual ListTrialsResponse EndListTrials(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrialsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserProfiles

        /// <summary>
        /// Lists user profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public virtual ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return Invoke<ListUserProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public virtual IAsyncResult BeginListUserProfiles(ListUserProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserProfiles.</param>
        /// 
        /// <returns>Returns a  ListUserProfilesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public virtual ListUserProfilesResponse EndListUserProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkteams

        /// <summary>
        /// Gets a list of work teams that you have defined in a region. The list may be empty
        /// if no work team satisfies the filter specified in the <code>NameContains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        public virtual ListWorkteamsResponse ListWorkteams(ListWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListWorkteamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        public virtual IAsyncResult BeginListWorkteams(ListWorkteamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkteams.</param>
        /// 
        /// <returns>Returns a  ListWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        public virtual ListWorkteamsResponse EndListWorkteams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkteamsResponse>(asyncResult);
        }

        #endregion
        
        #region  RenderUiTemplate

        /// <summary>
        /// Renders the UI template so that you can preview the worker's experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate service method.</param>
        /// 
        /// <returns>The response from the RenderUiTemplate service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        public virtual RenderUiTemplateResponse RenderUiTemplate(RenderUiTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return Invoke<RenderUiTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenderUiTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        public virtual IAsyncResult BeginRenderUiTemplate(RenderUiTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenderUiTemplate.</param>
        /// 
        /// <returns>Returns a  RenderUiTemplateResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        public virtual RenderUiTemplateResponse EndRenderUiTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<RenderUiTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  Search

        /// <summary>
        /// Finds Amazon SageMaker resources that match a search query. Matching resources are
        /// returned as a list of <code>SearchRecord</code> objects in the response. You can sort
        /// the search results by any resource property in a ascending or descending order.
        /// 
        ///  
        /// <para>
        /// You can query against the following value types: numeric, text, Boolean, and timestamp.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse Search(SearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        public virtual IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse EndSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMonitoringSchedule

        /// <summary>
        /// Starts a previously stopped monitoring schedule.
        /// 
        ///  <note> 
        /// <para>
        /// New monitoring schedules are immediately started after creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        public virtual StartMonitoringScheduleResponse StartMonitoringSchedule(StartMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginStartMonitoringSchedule(StartMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  StartMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        public virtual StartMonitoringScheduleResponse EndStartMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  StartNotebookInstance

        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, Amazon SageMaker
        /// sets the notebook instance status to <code>InService</code>. A notebook instance's
        /// status must be <code>InService</code> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        public virtual StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StartNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginStartNotebookInstance(StartNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StartNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        public virtual StartNotebookInstanceResponse EndStartNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StartNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  StopAutoMLJob

        /// <summary>
        /// A method for forcing the termination of a running job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the StopAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        public virtual StopAutoMLJobResponse StopAutoMLJob(StopAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<StopAutoMLJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        public virtual IAsyncResult BeginStopAutoMLJob(StopAutoMLJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutoMLJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAutoMLJob.</param>
        /// 
        /// <returns>Returns a  StopAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        public virtual StopAutoMLJobResponse EndStopAutoMLJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAutoMLJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCompilationJob

        /// <summary>
        /// Stops a model compilation job.
        /// 
        ///  
        /// <para>
        ///  To stop a job, Amazon SageMaker sends the algorithm the SIGTERM signal. This gracefully
        /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopCompilationJob</code> request, Amazon SageMaker changes
        /// the <a>CompilationJobSummary$CompilationJobStatus</a> of the job to <code>Stopping</code>.
        /// After Amazon SageMaker stops the job, it sets the <a>CompilationJobSummary$CompilationJobStatus</a>
        /// to <code>Stopped</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob service method.</param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        public virtual StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return Invoke<StopCompilationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        public virtual IAsyncResult BeginStopCompilationJob(StopCompilationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCompilationJob.</param>
        /// 
        /// <returns>Returns a  StopCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        public virtual StopCompilationJobResponse EndStopCompilationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCompilationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopHyperParameterTuningJob

        /// <summary>
        /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
        /// job launched.
        /// 
        ///  
        /// <para>
        /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
        /// Service (Amazon S3). All data that the training jobs write to Amazon CloudWatch Logs
        /// are still available in CloudWatch. After the tuning job moves to the <code>Stopped</code>
        /// state, it releases all reserved resources for the tuning job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        public virtual StopHyperParameterTuningJobResponse StopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<StopHyperParameterTuningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        public virtual IAsyncResult BeginStopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  StopHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        public virtual StopHyperParameterTuningJobResponse EndStopHyperParameterTuningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopHyperParameterTuningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopLabelingJob

        /// <summary>
        /// Stops a running labeling job. A job that is stopped cannot be restarted. Any results
        /// obtained before the job is stopped are placed in the Amazon S3 output bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob service method.</param>
        /// 
        /// <returns>The response from the StopLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        public virtual StopLabelingJobResponse StopLabelingJob(StopLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return Invoke<StopLabelingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        public virtual IAsyncResult BeginStopLabelingJob(StopLabelingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLabelingJob.</param>
        /// 
        /// <returns>Returns a  StopLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        public virtual StopLabelingJobResponse EndStopLabelingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopLabelingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopMonitoringSchedule

        /// <summary>
        /// Stops a previously started monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        public virtual StopMonitoringScheduleResponse StopMonitoringSchedule(StopMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<StopMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginStopMonitoringSchedule(StopMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  StopMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        public virtual StopMonitoringScheduleResponse EndStopMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StopMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  StopNotebookInstance

        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, Amazon SageMaker
        /// disconnects the ML storage volume from it. Amazon SageMaker preserves the ML storage
        /// volume. Amazon SageMaker stops charging you for the ML compute instance when you call
        /// <code>StopNotebookInstance</code>.
        /// 
        ///  
        /// <para>
        /// To access data on the ML storage volume for a notebook instance that has been terminated,
        /// call the <code>StartNotebookInstance</code> API. <code>StartNotebookInstance</code>
        /// launches another ML compute instance, configures it, and attaches the preserved ML
        /// storage volume so you can continue your work. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StopNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginStopNotebookInstance(StopNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StopNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual StopNotebookInstanceResponse EndStopNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StopNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  StopProcessingJob

        /// <summary>
        /// Stops a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob service method.</param>
        /// 
        /// <returns>The response from the StopProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        public virtual StopProcessingJobResponse StopProcessingJob(StopProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProcessingJobResponseUnmarshaller.Instance;

            return Invoke<StopProcessingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        public virtual IAsyncResult BeginStopProcessingJob(StopProcessingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProcessingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopProcessingJob.</param>
        /// 
        /// <returns>Returns a  StopProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        public virtual StopProcessingJobResponse EndStopProcessingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopProcessingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTrainingJob

        /// <summary>
        /// Stops a training job. To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// When it receives a <code>StopTrainingJob</code> request, Amazon SageMaker changes
        /// the status of the job to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// it sets the status to <code>Stopped</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob service method.</param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return Invoke<StopTrainingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual IAsyncResult BeginStopTrainingJob(StopTrainingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingJob.</param>
        /// 
        /// <returns>Returns a  StopTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual StopTrainingJobResponse EndStopTrainingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTrainingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTransformJob

        /// <summary>
        /// Stops a transform job.
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives a <code>StopTransformJob</code> request, the status
        /// of the job changes to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// the status is set to <code>Stopped</code>. When you stop a transform job before it
        /// is completed, Amazon SageMaker doesn't store the job's output in Amazon S3.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob service method.</param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        public virtual StopTransformJobResponse StopTransformJob(StopTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return Invoke<StopTransformJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        public virtual IAsyncResult BeginStopTransformJob(StopTransformJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTransformJob.</param>
        /// 
        /// <returns>Returns a  StopTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        public virtual StopTransformJobResponse EndStopTransformJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTransformJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCodeRepository

        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        public virtual UpdateCodeRepositoryResponse UpdateCodeRepository(UpdateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        public virtual IAsyncResult BeginUpdateCodeRepository(UpdateCodeRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeRepository.</param>
        /// 
        /// <returns>Returns a  UpdateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        public virtual UpdateCodeRepositoryResponse EndUpdateCodeRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCodeRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomain

        /// <summary>
        /// Updates a domain. Changes will impact all of the people in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomain(UpdateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse EndUpdateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpoint

        /// <summary>
        /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
        /// using newly created endpoint, and then deletes resources provisioned for the endpoint
        /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
        /// After updating the endpoint, it sets the status to <code>InService</code>. To check
        /// the status of an endpoint, use the <a>DescribeEndpoint</a> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must not delete an <code>EndpointConfig</code> in use by an endpoint that is live
        /// or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code> operations
        /// are being performed on the endpoint. To update an endpoint, you must create a new
        /// <code>EndpointConfig</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities

        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, Amazon SageMaker sets the endpoint status to <code>Updating</code>. After
        /// updating the endpoint, it sets the status to <code>InService</code>. To check the
        /// status of an endpoint, use the <a>DescribeEndpoint</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        public virtual UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointWeightsAndCapacitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointWeightsAndCapacities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointWeightsAndCapacities.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointWeightsAndCapacitiesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        public virtual UpdateEndpointWeightsAndCapacitiesResponse EndUpdateEndpointWeightsAndCapacities(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointWeightsAndCapacitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateExperiment

        /// <summary>
        /// Adds, updates, or removes the description of an experiment. Updates the display name
        /// of an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify an experiment, trial, or trial component.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        public virtual UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        public virtual IAsyncResult BeginUpdateExperiment(UpdateExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperiment.</param>
        /// 
        /// <returns>Returns a  UpdateExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        public virtual UpdateExperimentResponse EndUpdateExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateExperimentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMonitoringSchedule

        /// <summary>
        /// Updates a previously created schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        public virtual UpdateMonitoringScheduleResponse UpdateMonitoringSchedule(UpdateMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitoringScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateMonitoringSchedule(UpdateMonitoringScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        public virtual UpdateMonitoringScheduleResponse EndUpdateMonitoringSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMonitoringScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotebookInstance

        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        public virtual UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotebookInstance(UpdateNotebookInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        public virtual UpdateNotebookInstanceResponse EndUpdateNotebookInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotebookInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig

        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceLifecycleConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual UpdateNotebookInstanceLifecycleConfigResponse EndUpdateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotebookInstanceLifecycleConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrial

        /// <summary>
        /// Updates the display name of a trial.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial service method.</param>
        /// 
        /// <returns>The response from the UpdateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify an experiment, trial, or trial component.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        public virtual UpdateTrialResponse UpdateTrial(UpdateTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialResponseUnmarshaller.Instance;

            return Invoke<UpdateTrialResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrial(UpdateTrialRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrial.</param>
        /// 
        /// <returns>Returns a  UpdateTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        public virtual UpdateTrialResponse EndUpdateTrial(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrialResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrialComponent

        /// <summary>
        /// Updates one or more properties of a trial component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify an experiment, trial, or trial component.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        public virtual UpdateTrialComponentResponse UpdateTrialComponent(UpdateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrialComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrialComponent(UpdateTrialComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrialComponent.</param>
        /// 
        /// <returns>Returns a  UpdateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        public virtual UpdateTrialComponentResponse EndUpdateTrialComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrialComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserProfile

        /// <summary>
        /// Updates a user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkforce

        /// <summary>
        /// Restricts access to tasks assigned to workers in the specified workforce to those
        /// within specific ranges of IP addresses. You specify allowed IP addresses by creating
        /// a list of up to four <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>.
        /// 
        ///  
        /// <para>
        /// By default, a workforce isn't restricted to specific IP addresses. If you specify
        /// a range of IP addresses, workers who attempt to access tasks using any IP address
        /// outside the specified range are denied access and get a <code>Not Found</code> error
        /// message on the worker portal. After restricting access with this operation, you can
        /// see the allowed IP values for a private workforce with the operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation applies only to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        public virtual UpdateWorkforceResponse UpdateWorkforce(UpdateWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkforceResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkforceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkforce(UpdateWorkforceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkforceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkforce.</param>
        /// 
        /// <returns>Returns a  UpdateWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        public virtual UpdateWorkforceResponse EndUpdateWorkforce(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkforceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkteam

        /// <summary>
        /// Updates an existing work team with new member definitions or description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        public virtual UpdateWorkteamResponse UpdateWorkteam(UpdateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkteamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkteam(UpdateWorkteamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkteam.</param>
        /// 
        /// <returns>Returns a  UpdateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        public virtual UpdateWorkteamResponse EndUpdateWorkteam(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkteamResponse>(asyncResult);
        }

        #endregion
        
    }
}