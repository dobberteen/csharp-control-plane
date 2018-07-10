// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v2/core/protocol.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V2.Core {

  /// <summary>Holder for reflection information generated from envoy/api/v2/core/protocol.proto</summary>
  public static partial class ProtocolReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/api/v2/core/protocol.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBlbnZveS9hcGkvdjIvY29yZS9wcm90b2NvbC5wcm90bxIRZW52b3kuYXBp",
            "LnYyLmNvcmUaHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90bxoeZ29v",
            "Z2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0",
            "ZS5wcm90bxoUZ29nb3Byb3RvL2dvZ28ucHJvdG8iFAoSVGNwUHJvdG9jb2xP",
            "cHRpb25zIkwKE0h0dHBQcm90b2NvbE9wdGlvbnMSNQoMaWRsZV90aW1lb3V0",
            "GAEgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uQgSY3x8BIogBChRI",
            "dHRwMVByb3RvY29sT3B0aW9ucxI2ChJhbGxvd19hYnNvbHV0ZV91cmwYASAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuQm9vbFZhbHVlEhYKDmFjY2VwdF9odHRw",
            "XzEwGAIgASgIEiAKGGRlZmF1bHRfaG9zdF9mb3JfaHR0cF8xMBgDIAEoCSLL",
            "AgoUSHR0cDJQcm90b2NvbE9wdGlvbnMSNgoQaHBhY2tfdGFibGVfc2l6ZRgB",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5VSW50MzJWYWx1ZRJNChZtYXhfY29u",
            "Y3VycmVudF9zdHJlYW1zGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlVJbnQz",
            "MlZhbHVlQg+66cADCioIGP////8HKAESUwoaaW5pdGlhbF9zdHJlYW1fd2lu",
            "ZG93X3NpemUYAyABKAsyHC5nb29nbGUucHJvdG9idWYuVUludDMyVmFsdWVC",
            "EbrpwAMMKgoY/////wco//8DElcKHmluaXRpYWxfY29ubmVjdGlvbl93aW5k",
            "b3dfc2l6ZRgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5VSW50MzJWYWx1ZUIR",
            "uunAAwwqChj/////Byj//wMiXgoTR3JwY1Byb3RvY29sT3B0aW9ucxJHChZo",
            "dHRwMl9wcm90b2NvbF9vcHRpb25zGAEgASgLMicuZW52b3kuYXBpLnYyLmNv",
            "cmUuSHR0cDJQcm90b2NvbE9wdGlvbnNCBKjiHgFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Core.TcpProtocolOptions), global::Envoy.Api.V2.Core.TcpProtocolOptions.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Core.HttpProtocolOptions), global::Envoy.Api.V2.Core.HttpProtocolOptions.Parser, new[]{ "IdleTimeout" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Core.Http1ProtocolOptions), global::Envoy.Api.V2.Core.Http1ProtocolOptions.Parser, new[]{ "AllowAbsoluteUrl", "AcceptHttp10", "DefaultHostForHttp10" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Core.Http2ProtocolOptions), global::Envoy.Api.V2.Core.Http2ProtocolOptions.Parser, new[]{ "HpackTableSize", "MaxConcurrentStreams", "InitialStreamWindowSize", "InitialConnectionWindowSize" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Core.GrpcProtocolOptions), global::Envoy.Api.V2.Core.GrpcProtocolOptions.Parser, new[]{ "Http2ProtocolOptions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#not-implemented-hide:]
  /// </summary>
  public sealed partial class TcpProtocolOptions : pb::IMessage<TcpProtocolOptions> {
    private static readonly pb::MessageParser<TcpProtocolOptions> _parser = new pb::MessageParser<TcpProtocolOptions>(() => new TcpProtocolOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TcpProtocolOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Core.ProtocolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpProtocolOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpProtocolOptions(TcpProtocolOptions other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpProtocolOptions Clone() {
      return new TcpProtocolOptions(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TcpProtocolOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TcpProtocolOptions other) {
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
    public void MergeFrom(TcpProtocolOptions other) {
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

  }

  public sealed partial class HttpProtocolOptions : pb::IMessage<HttpProtocolOptions> {
    private static readonly pb::MessageParser<HttpProtocolOptions> _parser = new pb::MessageParser<HttpProtocolOptions>(() => new HttpProtocolOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HttpProtocolOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Core.ProtocolReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpProtocolOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpProtocolOptions(HttpProtocolOptions other) : this() {
      IdleTimeout = other.idleTimeout_ != null ? other.IdleTimeout.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpProtocolOptions Clone() {
      return new HttpProtocolOptions(this);
    }

    /// <summary>Field number for the "idle_timeout" field.</summary>
    public const int IdleTimeoutFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration idleTimeout_;
    /// <summary>
    /// The idle timeout for upstream connection pool connections. The idle timeout is defined as the
    /// period in which there are no active requests. If not set, there is no idle timeout. When the
    /// idle timeout is reached the connection will be closed. Note that request based timeouts mean
    /// that HTTP/2 PINGs will not keep the connection alive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration IdleTimeout {
      get { return idleTimeout_; }
      set {
        idleTimeout_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HttpProtocolOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HttpProtocolOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IdleTimeout, other.IdleTimeout)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (idleTimeout_ != null) hash ^= IdleTimeout.GetHashCode();
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
      if (idleTimeout_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(IdleTimeout);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (idleTimeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IdleTimeout);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HttpProtocolOptions other) {
      if (other == null) {
        return;
      }
      if (other.idleTimeout_ != null) {
        if (idleTimeout_ == null) {
          idleTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        IdleTimeout.MergeFrom(other.IdleTimeout);
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
          case 10: {
            if (idleTimeout_ == null) {
              idleTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(idleTimeout_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Http1ProtocolOptions : pb::IMessage<Http1ProtocolOptions> {
    private static readonly pb::MessageParser<Http1ProtocolOptions> _parser = new pb::MessageParser<Http1ProtocolOptions>(() => new Http1ProtocolOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Http1ProtocolOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Core.ProtocolReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http1ProtocolOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http1ProtocolOptions(Http1ProtocolOptions other) : this() {
      AllowAbsoluteUrl = other.AllowAbsoluteUrl;
      acceptHttp10_ = other.acceptHttp10_;
      defaultHostForHttp10_ = other.defaultHostForHttp10_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http1ProtocolOptions Clone() {
      return new Http1ProtocolOptions(this);
    }

    /// <summary>Field number for the "allow_absolute_url" field.</summary>
    public const int AllowAbsoluteUrlFieldNumber = 1;
    private static readonly pb::FieldCodec<bool?> _single_allowAbsoluteUrl_codec = pb::FieldCodec.ForStructWrapper<bool>(10);
    private bool? allowAbsoluteUrl_;
    /// <summary>
    /// Handle HTTP requests with absolute URLs in the requests. These requests
    /// are generally sent by clients to forward/explicit proxies. This allows clients to configure
    /// envoy as their HTTP proxy. In Unix, for example, this is typically done by setting the
    /// *http_proxy* environment variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? AllowAbsoluteUrl {
      get { return allowAbsoluteUrl_; }
      set {
        allowAbsoluteUrl_ = value;
      }
    }

    /// <summary>Field number for the "accept_http_10" field.</summary>
    public const int AcceptHttp10FieldNumber = 2;
    private bool acceptHttp10_;
    /// <summary>
    /// Handle incoming HTTP/1.0 and HTTP 0.9 requests.
    /// This is off by default, and not fully standards compliant. There is support for pre-HTTP/1.1
    /// style connect logic, dechunking, and handling lack of client host iff
    /// *default_host_for_http_10* is configured.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AcceptHttp10 {
      get { return acceptHttp10_; }
      set {
        acceptHttp10_ = value;
      }
    }

    /// <summary>Field number for the "default_host_for_http_10" field.</summary>
    public const int DefaultHostForHttp10FieldNumber = 3;
    private string defaultHostForHttp10_ = "";
    /// <summary>
    /// A default host for HTTP/1.0 requests. This is highly suggested if *accept_http_10* is true as
    /// Envoy does not otherwise support HTTP/1.0 without a Host header.
    /// This is a no-op if *accept_http_10* is not true.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DefaultHostForHttp10 {
      get { return defaultHostForHttp10_; }
      set {
        defaultHostForHttp10_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Http1ProtocolOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Http1ProtocolOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AllowAbsoluteUrl != other.AllowAbsoluteUrl) return false;
      if (AcceptHttp10 != other.AcceptHttp10) return false;
      if (DefaultHostForHttp10 != other.DefaultHostForHttp10) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (allowAbsoluteUrl_ != null) hash ^= AllowAbsoluteUrl.GetHashCode();
      if (AcceptHttp10 != false) hash ^= AcceptHttp10.GetHashCode();
      if (DefaultHostForHttp10.Length != 0) hash ^= DefaultHostForHttp10.GetHashCode();
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
      if (allowAbsoluteUrl_ != null) {
        _single_allowAbsoluteUrl_codec.WriteTagAndValue(output, AllowAbsoluteUrl);
      }
      if (AcceptHttp10 != false) {
        output.WriteRawTag(16);
        output.WriteBool(AcceptHttp10);
      }
      if (DefaultHostForHttp10.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DefaultHostForHttp10);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (allowAbsoluteUrl_ != null) {
        size += _single_allowAbsoluteUrl_codec.CalculateSizeWithTag(AllowAbsoluteUrl);
      }
      if (AcceptHttp10 != false) {
        size += 1 + 1;
      }
      if (DefaultHostForHttp10.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultHostForHttp10);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Http1ProtocolOptions other) {
      if (other == null) {
        return;
      }
      if (other.allowAbsoluteUrl_ != null) {
        if (allowAbsoluteUrl_ == null || other.AllowAbsoluteUrl != false) {
          AllowAbsoluteUrl = other.AllowAbsoluteUrl;
        }
      }
      if (other.AcceptHttp10 != false) {
        AcceptHttp10 = other.AcceptHttp10;
      }
      if (other.DefaultHostForHttp10.Length != 0) {
        DefaultHostForHttp10 = other.DefaultHostForHttp10;
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
          case 10: {
            bool? value = _single_allowAbsoluteUrl_codec.Read(input);
            if (allowAbsoluteUrl_ == null || value != false) {
              AllowAbsoluteUrl = value;
            }
            break;
          }
          case 16: {
            AcceptHttp10 = input.ReadBool();
            break;
          }
          case 26: {
            DefaultHostForHttp10 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Http2ProtocolOptions : pb::IMessage<Http2ProtocolOptions> {
    private static readonly pb::MessageParser<Http2ProtocolOptions> _parser = new pb::MessageParser<Http2ProtocolOptions>(() => new Http2ProtocolOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Http2ProtocolOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Core.ProtocolReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http2ProtocolOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http2ProtocolOptions(Http2ProtocolOptions other) : this() {
      HpackTableSize = other.HpackTableSize;
      MaxConcurrentStreams = other.MaxConcurrentStreams;
      InitialStreamWindowSize = other.InitialStreamWindowSize;
      InitialConnectionWindowSize = other.InitialConnectionWindowSize;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Http2ProtocolOptions Clone() {
      return new Http2ProtocolOptions(this);
    }

    /// <summary>Field number for the "hpack_table_size" field.</summary>
    public const int HpackTableSizeFieldNumber = 1;
    private static readonly pb::FieldCodec<uint?> _single_hpackTableSize_codec = pb::FieldCodec.ForStructWrapper<uint>(10);
    private uint? hpackTableSize_;
    /// <summary>
    /// `Maximum table size &lt;http://httpwg.org/specs/rfc7541.html#rfc.section.4.2>`_
    /// (in octets) that the encoder is permitted to use for the dynamic HPACK table. Valid values
    /// range from 0 to 4294967295 (2^32 - 1) and defaults to 4096. 0 effectively disables header
    /// compression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? HpackTableSize {
      get { return hpackTableSize_; }
      set {
        hpackTableSize_ = value;
      }
    }

    /// <summary>Field number for the "max_concurrent_streams" field.</summary>
    public const int MaxConcurrentStreamsFieldNumber = 2;
    private static readonly pb::FieldCodec<uint?> _single_maxConcurrentStreams_codec = pb::FieldCodec.ForStructWrapper<uint>(18);
    private uint? maxConcurrentStreams_;
    /// <summary>
    /// `Maximum concurrent streams &lt;http://httpwg.org/specs/rfc7540.html#rfc.section.5.1.2>`_
    /// allowed for peer on one HTTP/2 connection. Valid values range from 1 to 2147483647 (2^31 - 1)
    /// and defaults to 2147483647.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? MaxConcurrentStreams {
      get { return maxConcurrentStreams_; }
      set {
        maxConcurrentStreams_ = value;
      }
    }

    /// <summary>Field number for the "initial_stream_window_size" field.</summary>
    public const int InitialStreamWindowSizeFieldNumber = 3;
    private static readonly pb::FieldCodec<uint?> _single_initialStreamWindowSize_codec = pb::FieldCodec.ForStructWrapper<uint>(26);
    private uint? initialStreamWindowSize_;
    /// <summary>
    /// This field also acts as a soft limit on the number of bytes Envoy will buffer per-stream in the
    /// HTTP/2 codec buffers. Once the buffer reaches this pointer, watermark callbacks will fire to
    /// stop the flow of data to the codec buffers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? InitialStreamWindowSize {
      get { return initialStreamWindowSize_; }
      set {
        initialStreamWindowSize_ = value;
      }
    }

    /// <summary>Field number for the "initial_connection_window_size" field.</summary>
    public const int InitialConnectionWindowSizeFieldNumber = 4;
    private static readonly pb::FieldCodec<uint?> _single_initialConnectionWindowSize_codec = pb::FieldCodec.ForStructWrapper<uint>(34);
    private uint? initialConnectionWindowSize_;
    /// <summary>
    /// Similar to *initial_stream_window_size*, but for connection-level flow-control
    /// window. Currently, this has the same minimum/maximum/default as *initial_stream_window_size*.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? InitialConnectionWindowSize {
      get { return initialConnectionWindowSize_; }
      set {
        initialConnectionWindowSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Http2ProtocolOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Http2ProtocolOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HpackTableSize != other.HpackTableSize) return false;
      if (MaxConcurrentStreams != other.MaxConcurrentStreams) return false;
      if (InitialStreamWindowSize != other.InitialStreamWindowSize) return false;
      if (InitialConnectionWindowSize != other.InitialConnectionWindowSize) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (hpackTableSize_ != null) hash ^= HpackTableSize.GetHashCode();
      if (maxConcurrentStreams_ != null) hash ^= MaxConcurrentStreams.GetHashCode();
      if (initialStreamWindowSize_ != null) hash ^= InitialStreamWindowSize.GetHashCode();
      if (initialConnectionWindowSize_ != null) hash ^= InitialConnectionWindowSize.GetHashCode();
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
      if (hpackTableSize_ != null) {
        _single_hpackTableSize_codec.WriteTagAndValue(output, HpackTableSize);
      }
      if (maxConcurrentStreams_ != null) {
        _single_maxConcurrentStreams_codec.WriteTagAndValue(output, MaxConcurrentStreams);
      }
      if (initialStreamWindowSize_ != null) {
        _single_initialStreamWindowSize_codec.WriteTagAndValue(output, InitialStreamWindowSize);
      }
      if (initialConnectionWindowSize_ != null) {
        _single_initialConnectionWindowSize_codec.WriteTagAndValue(output, InitialConnectionWindowSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (hpackTableSize_ != null) {
        size += _single_hpackTableSize_codec.CalculateSizeWithTag(HpackTableSize);
      }
      if (maxConcurrentStreams_ != null) {
        size += _single_maxConcurrentStreams_codec.CalculateSizeWithTag(MaxConcurrentStreams);
      }
      if (initialStreamWindowSize_ != null) {
        size += _single_initialStreamWindowSize_codec.CalculateSizeWithTag(InitialStreamWindowSize);
      }
      if (initialConnectionWindowSize_ != null) {
        size += _single_initialConnectionWindowSize_codec.CalculateSizeWithTag(InitialConnectionWindowSize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Http2ProtocolOptions other) {
      if (other == null) {
        return;
      }
      if (other.hpackTableSize_ != null) {
        if (hpackTableSize_ == null || other.HpackTableSize != 0) {
          HpackTableSize = other.HpackTableSize;
        }
      }
      if (other.maxConcurrentStreams_ != null) {
        if (maxConcurrentStreams_ == null || other.MaxConcurrentStreams != 0) {
          MaxConcurrentStreams = other.MaxConcurrentStreams;
        }
      }
      if (other.initialStreamWindowSize_ != null) {
        if (initialStreamWindowSize_ == null || other.InitialStreamWindowSize != 0) {
          InitialStreamWindowSize = other.InitialStreamWindowSize;
        }
      }
      if (other.initialConnectionWindowSize_ != null) {
        if (initialConnectionWindowSize_ == null || other.InitialConnectionWindowSize != 0) {
          InitialConnectionWindowSize = other.InitialConnectionWindowSize;
        }
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
          case 10: {
            uint? value = _single_hpackTableSize_codec.Read(input);
            if (hpackTableSize_ == null || value != 0) {
              HpackTableSize = value;
            }
            break;
          }
          case 18: {
            uint? value = _single_maxConcurrentStreams_codec.Read(input);
            if (maxConcurrentStreams_ == null || value != 0) {
              MaxConcurrentStreams = value;
            }
            break;
          }
          case 26: {
            uint? value = _single_initialStreamWindowSize_codec.Read(input);
            if (initialStreamWindowSize_ == null || value != 0) {
              InitialStreamWindowSize = value;
            }
            break;
          }
          case 34: {
            uint? value = _single_initialConnectionWindowSize_codec.Read(input);
            if (initialConnectionWindowSize_ == null || value != 0) {
              InitialConnectionWindowSize = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// [#not-implemented-hide:]
  /// </summary>
  public sealed partial class GrpcProtocolOptions : pb::IMessage<GrpcProtocolOptions> {
    private static readonly pb::MessageParser<GrpcProtocolOptions> _parser = new pb::MessageParser<GrpcProtocolOptions>(() => new GrpcProtocolOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GrpcProtocolOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Core.ProtocolReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcProtocolOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcProtocolOptions(GrpcProtocolOptions other) : this() {
      Http2ProtocolOptions = other.http2ProtocolOptions_ != null ? other.Http2ProtocolOptions.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcProtocolOptions Clone() {
      return new GrpcProtocolOptions(this);
    }

    /// <summary>Field number for the "http2_protocol_options" field.</summary>
    public const int Http2ProtocolOptionsFieldNumber = 1;
    private global::Envoy.Api.V2.Core.Http2ProtocolOptions http2ProtocolOptions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V2.Core.Http2ProtocolOptions Http2ProtocolOptions {
      get { return http2ProtocolOptions_; }
      set {
        http2ProtocolOptions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GrpcProtocolOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GrpcProtocolOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Http2ProtocolOptions, other.Http2ProtocolOptions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (http2ProtocolOptions_ != null) hash ^= Http2ProtocolOptions.GetHashCode();
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
      if (http2ProtocolOptions_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Http2ProtocolOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (http2ProtocolOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Http2ProtocolOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GrpcProtocolOptions other) {
      if (other == null) {
        return;
      }
      if (other.http2ProtocolOptions_ != null) {
        if (http2ProtocolOptions_ == null) {
          http2ProtocolOptions_ = new global::Envoy.Api.V2.Core.Http2ProtocolOptions();
        }
        Http2ProtocolOptions.MergeFrom(other.Http2ProtocolOptions);
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
          case 10: {
            if (http2ProtocolOptions_ == null) {
              http2ProtocolOptions_ = new global::Envoy.Api.V2.Core.Http2ProtocolOptions();
            }
            input.ReadMessage(http2ProtocolOptions_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code