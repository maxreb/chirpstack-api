// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/error_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/error_reason.proto</summary>
  public static partial class ErrorReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/error_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1nb29nbGUvYXBpL2Vycm9yX3JlYXNvbi5wcm90bxIKZ29vZ2xlLmFwaSrE",
            "BAoLRXJyb3JSZWFzb24SHAoYRVJST1JfUkVBU09OX1VOU1BFQ0lGSUVEEAAS",
            "FAoQU0VSVklDRV9ESVNBQkxFRBABEhQKEEJJTExJTkdfRElTQUJMRUQQAhIT",
            "Cg9BUElfS0VZX0lOVkFMSUQQAxIbChdBUElfS0VZX1NFUlZJQ0VfQkxPQ0tF",
            "RBAEEiEKHUFQSV9LRVlfSFRUUF9SRUZFUlJFUl9CTE9DS0VEEAcSHgoaQVBJ",
            "X0tFWV9JUF9BRERSRVNTX0JMT0NLRUQQCBIfChtBUElfS0VZX0FORFJPSURf",
            "QVBQX0JMT0NLRUQQCRIbChdBUElfS0VZX0lPU19BUFBfQkxPQ0tFRBANEhcK",
            "E1JBVEVfTElNSVRfRVhDRUVERUQQBRIbChdSRVNPVVJDRV9RVU9UQV9FWENF",
            "RURFRBAGEiAKHExPQ0FUSU9OX1RBWF9QT0xJQ1lfVklPTEFURUQQChIXChNV",
            "U0VSX1BST0pFQ1RfREVOSUVEEAsSFgoSQ09OU1VNRVJfU1VTUEVOREVEEAwS",
            "FAoQQ09OU1VNRVJfSU5WQUxJRBAOEhwKGFNFQ1VSSVRZX1BPTElDWV9WSU9M",
            "QVRFRBAPEhgKFEFDQ0VTU19UT0tFTl9FWFBJUkVEEBASIwofQUNDRVNTX1RP",
            "S0VOX1NDT1BFX0lOU1VGRklDSUVOVBAREhkKFUFDQ09VTlRfU1RBVEVfSU5W",
            "QUxJRBASEiEKHUFDQ0VTU19UT0tFTl9UWVBFX1VOU1VQUE9SVEVEEBNCcAoO",
            "Y29tLmdvb2dsZS5hcGlCEEVycm9yUmVhc29uUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcGkvZXJyb3JfcmVhc29u",
            "O2Vycm9yX3JlYXNvbqICBEdBUEliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Api.ErrorReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Defines the supported values for `google.rpc.ErrorInfo.reason` for the
  /// `googleapis.com` error domain. This error domain is reserved for [Service
  /// Infrastructure](https://cloud.google.com/service-infrastructure/docs/overview).
  /// For each error info of this domain, the metadata key "service" refers to the
  /// logical identifier of an API service, such as "pubsub.googleapis.com". The
  /// "consumer" refers to the entity that consumes an API Service. It typically is
  /// a Google project that owns the client application or the server resource,
  /// such as "projects/123". Other metadata keys are specific to each error
  /// reason. For more information, see the definition of the specific error
  /// reason.
  /// </summary>
  public enum ErrorReason {
    /// <summary>
    /// Do not use this default value.
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The request is calling a disabled service for a consumer.
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" contacting
    /// "pubsub.googleapis.com" service which is disabled:
    ///
    ///     { "reason": "SERVICE_DISABLED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "pubsub.googleapis.com"
    ///       }
    ///     }
    ///
    /// This response indicates the "pubsub.googleapis.com" has been disabled in
    /// "projects/123".
    /// </summary>
    [pbr::OriginalName("SERVICE_DISABLED")] ServiceDisabled = 1,
    /// <summary>
    /// The request whose associated billing account is disabled.
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to contact
    /// "pubsub.googleapis.com" service because the associated billing account is
    /// disabled:
    ///
    ///     { "reason": "BILLING_DISABLED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "pubsub.googleapis.com"
    ///       }
    ///     }
    ///
    /// This response indicates the billing account associated has been disabled.
    /// </summary>
    [pbr::OriginalName("BILLING_DISABLED")] BillingDisabled = 2,
    /// <summary>
    /// The request is denied because the provided [API
    /// key](https://cloud.google.com/docs/authentication/api-keys) is invalid. It
    /// may be in a bad format, cannot be found, or has been expired).
    ///
    /// Example of an ErrorInfo when the request is contacting
    /// "storage.googleapis.com" service with an invalid API key:
    ///
    ///     { "reason": "API_KEY_INVALID",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "service": "storage.googleapis.com",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_INVALID")] ApiKeyInvalid = 3,
    /// <summary>
    /// The request is denied because it violates [API key API
    /// restrictions](https://cloud.google.com/docs/authentication/api-keys#adding_api_restrictions).
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call the
    /// "storage.googleapis.com" service because this service is restricted in the
    /// API key:
    ///
    ///     { "reason": "API_KEY_SERVICE_BLOCKED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_SERVICE_BLOCKED")] ApiKeyServiceBlocked = 4,
    /// <summary>
    /// The request is denied because it violates [API key HTTP
    /// restrictions](https://cloud.google.com/docs/authentication/api-keys#adding_http_restrictions).
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call
    /// "storage.googleapis.com" service because the http referrer of the request
    /// violates API key HTTP restrictions:
    ///
    ///     { "reason": "API_KEY_HTTP_REFERRER_BLOCKED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_HTTP_REFERRER_BLOCKED")] ApiKeyHttpReferrerBlocked = 7,
    /// <summary>
    /// The request is denied because it violates [API key IP address
    /// restrictions](https://cloud.google.com/docs/authentication/api-keys#adding_application_restrictions).
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call
    /// "storage.googleapis.com" service because the caller IP of the request
    /// violates API key IP address restrictions:
    ///
    ///     { "reason": "API_KEY_IP_ADDRESS_BLOCKED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_IP_ADDRESS_BLOCKED")] ApiKeyIpAddressBlocked = 8,
    /// <summary>
    /// The request is denied because it violates [API key Android application
    /// restrictions](https://cloud.google.com/docs/authentication/api-keys#adding_application_restrictions).
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call
    /// "storage.googleapis.com" service because the request from the Android apps
    /// violates the API key Android application restrictions:
    ///
    ///     { "reason": "API_KEY_ANDROID_APP_BLOCKED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_ANDROID_APP_BLOCKED")] ApiKeyAndroidAppBlocked = 9,
    /// <summary>
    /// The request is denied because it violates [API key iOS application
    /// restrictions](https://cloud.google.com/docs/authentication/api-keys#adding_application_restrictions).
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call
    /// "storage.googleapis.com" service because the request from the iOS apps
    /// violates the API key iOS application restrictions:
    ///
    ///     { "reason": "API_KEY_IOS_APP_BLOCKED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("API_KEY_IOS_APP_BLOCKED")] ApiKeyIosAppBlocked = 13,
    /// <summary>
    /// The request is denied because there is not enough rate quota for the
    /// consumer.
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to contact
    /// "pubsub.googleapis.com" service because consumer's rate quota usage has
    /// reached the maximum value set for the quota limit
    /// "ReadsPerMinutePerProject" on the quota metric
    /// "pubsub.googleapis.com/read_requests":
    ///
    ///     { "reason": "RATE_LIMIT_EXCEEDED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "pubsub.googleapis.com",
    ///         "quota_metric": "pubsub.googleapis.com/read_requests",
    ///         "quota_limit": "ReadsPerMinutePerProject"
    ///       }
    ///     }
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" checks quota on
    /// the service "dataflow.googleapis.com" and hits the organization quota
    /// limit "DefaultRequestsPerMinutePerOrganization" on the metric
    /// "dataflow.googleapis.com/default_requests".
    ///
    ///     { "reason": "RATE_LIMIT_EXCEEDED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "dataflow.googleapis.com",
    ///         "quota_metric": "dataflow.googleapis.com/default_requests",
    ///         "quota_limit": "DefaultRequestsPerMinutePerOrganization"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("RATE_LIMIT_EXCEEDED")] RateLimitExceeded = 5,
    /// <summary>
    /// The request is denied because there is not enough resource quota for the
    /// consumer.
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to contact
    /// "compute.googleapis.com" service because consumer's resource quota usage
    /// has reached the maximum value set for the quota limit "VMsPerProject"
    /// on the quota metric "compute.googleapis.com/vms":
    ///
    ///     { "reason": "RESOURCE_QUOTA_EXCEEDED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "compute.googleapis.com",
    ///         "quota_metric": "compute.googleapis.com/vms",
    ///         "quota_limit": "VMsPerProject"
    ///       }
    ///     }
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" checks resource
    /// quota on the service "dataflow.googleapis.com" and hits the organization
    /// quota limit "jobs-per-organization" on the metric
    /// "dataflow.googleapis.com/job_count".
    ///
    ///     { "reason": "RESOURCE_QUOTA_EXCEEDED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "dataflow.googleapis.com",
    ///         "quota_metric": "dataflow.googleapis.com/job_count",
    ///         "quota_limit": "jobs-per-organization"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("RESOURCE_QUOTA_EXCEEDED")] ResourceQuotaExceeded = 6,
    /// <summary>
    /// The request whose associated billing account address is in a tax restricted
    /// location, violates the local tax restrictions when creating resources in
    /// the restricted region.
    ///
    /// Example of an ErrorInfo when creating the Cloud Storage Bucket in the
    /// container "projects/123" under a tax restricted region
    /// "locations/asia-northeast3":
    ///
    ///     { "reason": "LOCATION_TAX_POLICY_VIOLATED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com",
    ///         "location": "locations/asia-northeast3"
    ///       }
    ///     }
    ///
    /// This response indicates creating the Cloud Storage Bucket in
    /// "locations/asia-northeast3" violates the location tax restriction.
    /// </summary>
    [pbr::OriginalName("LOCATION_TAX_POLICY_VIOLATED")] LocationTaxPolicyViolated = 10,
    /// <summary>
    /// The request is denied because the caller does not have required permission
    /// on the user project "projects/123" or the user project is invalid. For more
    /// information, check the [userProject System
    /// Parameters](https://cloud.google.com/apis/docs/system-parameters).
    ///
    /// Example of an ErrorInfo when the caller is calling Cloud Storage service
    /// with insufficient permissions on the user project:
    ///
    ///     { "reason": "USER_PROJECT_DENIED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("USER_PROJECT_DENIED")] UserProjectDenied = 11,
    /// <summary>
    /// The request is denied because the consumer "projects/123" is suspended due
    /// to Terms of Service(Tos) violations. Check [Project suspension
    /// guidelines](https://cloud.google.com/resource-manager/docs/project-suspension-guidelines)
    /// for more information.
    ///
    /// Example of an ErrorInfo when calling Cloud Storage service with the
    /// suspended consumer "projects/123":
    ///
    ///     { "reason": "CONSUMER_SUSPENDED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("CONSUMER_SUSPENDED")] ConsumerSuspended = 12,
    /// <summary>
    /// The request is denied because the associated consumer is invalid. It may be
    /// in a bad format, cannot be found, or have been deleted.
    ///
    /// Example of an ErrorInfo when calling Cloud Storage service with the
    /// invalid consumer "projects/123":
    ///
    ///     { "reason": "CONSUMER_INVALID",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("CONSUMER_INVALID")] ConsumerInvalid = 14,
    /// <summary>
    /// The request is denied because it violates [VPC Service
    /// Controls](https://cloud.google.com/vpc-service-controls/docs/overview).
    /// The 'uid' field is a random generated identifier that customer can use it
    /// to search the audit log for a request rejected by VPC Service Controls. For
    /// more information, please refer [VPC Service Controls
    /// Troubleshooting](https://cloud.google.com/vpc-service-controls/docs/troubleshooting#unique-id)
    ///
    /// Example of an ErrorInfo when the consumer "projects/123" fails to call
    /// Cloud Storage service because the request is prohibited by the VPC Service
    /// Controls.
    ///
    ///     { "reason": "SECURITY_POLICY_VIOLATED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "uid": "123456789abcde",
    ///         "consumer": "projects/123",
    ///         "service": "storage.googleapis.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("SECURITY_POLICY_VIOLATED")] SecurityPolicyViolated = 15,
    /// <summary>
    /// The request is denied because the provided access token has expired.
    ///
    /// Example of an ErrorInfo when the request is calling Cloud Storage service
    /// with an expired access token:
    ///
    ///     { "reason": "ACCESS_TOKEN_EXPIRED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "service": "storage.googleapis.com",
    ///         "method": "google.storage.v1.Storage.GetObject"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ACCESS_TOKEN_EXPIRED")] AccessTokenExpired = 16,
    /// <summary>
    /// The request is denied because the provided access token doesn't have at
    /// least one of the acceptable scopes required for the API. Please check
    /// [OAuth 2.0 Scopes for Google
    /// APIs](https://developers.google.com/identity/protocols/oauth2/scopes) for
    /// the list of the OAuth 2.0 scopes that you might need to request to access
    /// the API.
    ///
    /// Example of an ErrorInfo when the request is calling Cloud Storage service
    /// with an access token that is missing required scopes:
    ///
    ///     { "reason": "ACCESS_TOKEN_SCOPE_INSUFFICIENT",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "service": "storage.googleapis.com",
    ///         "method": "google.storage.v1.Storage.GetObject"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ACCESS_TOKEN_SCOPE_INSUFFICIENT")] AccessTokenScopeInsufficient = 17,
    /// <summary>
    /// The request is denied because the account associated with the provided
    /// access token is in an invalid state, such as disabled or deleted.
    /// For more information, see https://cloud.google.com/docs/authentication.
    ///
    /// Warning: For privacy reasons, the server may not be able to disclose the
    /// email address for some accounts. The client MUST NOT depend on the
    /// availability of the `email` attribute.
    ///
    /// Example of an ErrorInfo when the request is to the Cloud Storage API with
    /// an access token that is associated with a disabled or deleted [service
    /// account](http://cloud/iam/docs/service-accounts):
    ///
    ///     { "reason": "ACCOUNT_STATE_INVALID",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "service": "storage.googleapis.com",
    ///         "method": "google.storage.v1.Storage.GetObject",
    ///         "email": "user@123.iam.gserviceaccount.com"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ACCOUNT_STATE_INVALID")] AccountStateInvalid = 18,
    /// <summary>
    /// The request is denied because the type of the provided access token is not
    /// supported by the API being called.
    ///
    /// Example of an ErrorInfo when the request is to the Cloud Storage API with
    /// an unsupported token type.
    ///
    ///     { "reason": "ACCESS_TOKEN_TYPE_UNSUPPORTED",
    ///       "domain": "googleapis.com",
    ///       "metadata": {
    ///         "service": "storage.googleapis.com",
    ///         "method": "google.storage.v1.Storage.GetObject"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ACCESS_TOKEN_TYPE_UNSUPPORTED")] AccessTokenTypeUnsupported = 19,
  }

  #endregion

}

#endregion Designer generated code
