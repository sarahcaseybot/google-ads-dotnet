// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/search_engine_results_page_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/search_engine_results_page_type.proto</summary>
  public static partial class SearchEngineResultsPageTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/search_engine_results_page_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchEngineResultsPageTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9zZWFyY2hfZW5naW5l",
            "X3Jlc3VsdHNfcGFnZV90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Mi5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKTAQof",
            "U2VhcmNoRW5naW5lUmVzdWx0c1BhZ2VUeXBlRW51bSJwChtTZWFyY2hFbmdp",
            "bmVSZXN1bHRzUGFnZVR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESDAoIQURTX09OTFkQAhIQCgxPUkdBTklDX09OTFkQAxITCg9BRFNfQU5E",
            "X09SR0FOSUMQBEL1AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zQiBTZWFyY2hFbmdpbmVSZXN1bHRzUGFnZVR5cGVQcm90b1ABWkJnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVudW1z6gIh",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.SearchEngineResultsPageTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.SearchEngineResultsPageTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.SearchEngineResultsPageTypeEnum.Types.SearchEngineResultsPageType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The type of the search engine results page.
  /// </summary>
  public sealed partial class SearchEngineResultsPageTypeEnum : pb::IMessage<SearchEngineResultsPageTypeEnum> {
    private static readonly pb::MessageParser<SearchEngineResultsPageTypeEnum> _parser = new pb::MessageParser<SearchEngineResultsPageTypeEnum>(() => new SearchEngineResultsPageTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchEngineResultsPageTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.SearchEngineResultsPageTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchEngineResultsPageTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchEngineResultsPageTypeEnum(SearchEngineResultsPageTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchEngineResultsPageTypeEnum Clone() {
      return new SearchEngineResultsPageTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchEngineResultsPageTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchEngineResultsPageTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SearchEngineResultsPageTypeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SearchEngineResultsPageTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of the search engine results page.
      /// </summary>
      public enum SearchEngineResultsPageType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Only ads were contained in the search engine results page.
        /// </summary>
        [pbr::OriginalName("ADS_ONLY")] AdsOnly = 2,
        /// <summary>
        /// Only organic results were contained in the search engine results page.
        /// </summary>
        [pbr::OriginalName("ORGANIC_ONLY")] OrganicOnly = 3,
        /// <summary>
        /// Both ads and organic results were contained in the search engine results
        /// page.
        /// </summary>
        [pbr::OriginalName("ADS_AND_ORGANIC")] AdsAndOrganic = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
