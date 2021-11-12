// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/authentication_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/authentication_error.proto</summary>
  public static partial class AuthenticationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/authentication_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthenticationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvYXV0aGVudGljYXRp",
            "b25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVycm9y",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLoBAoXQXV0aGVudGlj",
            "YXRpb25FcnJvckVudW0izAQKE0F1dGhlbnRpY2F0aW9uRXJyb3ISDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESGAoUQVVUSEVOVElDQVRJT05fRVJS",
            "T1IQAhIeChpDTElFTlRfQ1VTVE9NRVJfSURfSU5WQUxJRBAFEhYKEkNVU1RP",
            "TUVSX05PVF9GT1VORBAIEhoKFkdPT0dMRV9BQ0NPVU5UX0RFTEVURUQQCRIh",
            "Ch1HT09HTEVfQUNDT1VOVF9DT09LSUVfSU5WQUxJRBAKEigKJEdPT0dMRV9B",
            "Q0NPVU5UX0FVVEhFTlRJQ0FUSU9OX0ZBSUxFRBAZEi0KKUdPT0dMRV9BQ0NP",
            "VU5UX1VTRVJfQU5EX0FEU19VU0VSX01JU01BVENIEAwSGQoVTE9HSU5fQ09P",
            "S0lFX1JFUVVJUkVEEA0SEAoMTk9UX0FEU19VU0VSEA4SFwoTT0FVVEhfVE9L",
            "RU5fSU5WQUxJRBAPEhcKE09BVVRIX1RPS0VOX0VYUElSRUQQEBIYChRPQVVU",
            "SF9UT0tFTl9ESVNBQkxFRBAREhcKE09BVVRIX1RPS0VOX1JFVk9LRUQQEhIe",
            "ChpPQVVUSF9UT0tFTl9IRUFERVJfSU5WQUxJRBATEhgKFExPR0lOX0NPT0tJ",
            "RV9JTlZBTElEEBQSEwoPVVNFUl9JRF9JTlZBTElEEBYSJgoiVFdPX1NURVBf",
            "VkVSSUZJQ0FUSU9OX05PVF9FTlJPTExFRBAXEiQKIEFEVkFOQ0VEX1BST1RF",
            "Q1RJT05fTk9UX0VOUk9MTEVEEBhC8wEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Ny5lcnJvcnNCGEF1dGhlbnRpY2F0aW9uRXJyb3JQcm90b1ABWkRn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjcvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY3LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY3XEVy",
            "cm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY3OjpFcnJvcnNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.AuthenticationErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.AuthenticationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.AuthenticationErrorEnum.Types.AuthenticationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible authentication errors.
  /// </summary>
  public sealed partial class AuthenticationErrorEnum : pb::IMessage<AuthenticationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthenticationErrorEnum> _parser = new pb::MessageParser<AuthenticationErrorEnum>(() => new AuthenticationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AuthenticationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.AuthenticationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum(AuthenticationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum Clone() {
      return new AuthenticationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AuthenticationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AuthenticationErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AuthenticationErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AuthenticationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible authentication errors.
      /// </summary>
      public enum AuthenticationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Authentication of the request failed.
        /// </summary>
        [pbr::OriginalName("AUTHENTICATION_ERROR")] AuthenticationError = 2,
        /// <summary>
        /// Client Customer ID is not a number.
        /// </summary>
        [pbr::OriginalName("CLIENT_CUSTOMER_ID_INVALID")] ClientCustomerIdInvalid = 5,
        /// <summary>
        /// No customer found for the provided customer ID.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_FOUND")] CustomerNotFound = 8,
        /// <summary>
        /// Client's Google Account is deleted.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_DELETED")] GoogleAccountDeleted = 9,
        /// <summary>
        /// Google account login token in the cookie is invalid.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_COOKIE_INVALID")] GoogleAccountCookieInvalid = 10,
        /// <summary>
        /// A problem occurred during Google account authentication.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_AUTHENTICATION_FAILED")] GoogleAccountAuthenticationFailed = 25,
        /// <summary>
        /// The user in the Google account login token does not match the user ID in
        /// the cookie.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH")] GoogleAccountUserAndAdsUserMismatch = 12,
        /// <summary>
        /// Login cookie is required for authentication.
        /// </summary>
        [pbr::OriginalName("LOGIN_COOKIE_REQUIRED")] LoginCookieRequired = 13,
        /// <summary>
        /// User in the cookie is not a valid Ads user.
        /// </summary>
        [pbr::OriginalName("NOT_ADS_USER")] NotAdsUser = 14,
        /// <summary>
        /// Oauth token in the header is not valid.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_INVALID")] OauthTokenInvalid = 15,
        /// <summary>
        /// Oauth token in the header has expired.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_EXPIRED")] OauthTokenExpired = 16,
        /// <summary>
        /// Oauth token in the header has been disabled.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_DISABLED")] OauthTokenDisabled = 17,
        /// <summary>
        /// Oauth token in the header has been revoked.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_REVOKED")] OauthTokenRevoked = 18,
        /// <summary>
        /// Oauth token HTTP header is malformed.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_HEADER_INVALID")] OauthTokenHeaderInvalid = 19,
        /// <summary>
        /// Login cookie is not valid.
        /// </summary>
        [pbr::OriginalName("LOGIN_COOKIE_INVALID")] LoginCookieInvalid = 20,
        /// <summary>
        /// User Id in the header is not a valid id.
        /// </summary>
        [pbr::OriginalName("USER_ID_INVALID")] UserIdInvalid = 22,
        /// <summary>
        /// An account administrator changed this account's authentication settings.
        /// To access this Google Ads account, enable 2-Step Verification in your
        /// Google account at https://www.google.com/landing/2step.
        /// </summary>
        [pbr::OriginalName("TWO_STEP_VERIFICATION_NOT_ENROLLED")] TwoStepVerificationNotEnrolled = 23,
        /// <summary>
        /// An account administrator changed this account's authentication settings.
        /// To access this Google Ads account, enable Advanced Protection in your
        /// Google account at https://landing.google.com/advancedprotection.
        /// </summary>
        [pbr::OriginalName("ADVANCED_PROTECTION_NOT_ENROLLED")] AdvancedProtectionNotEnrolled = 24,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
