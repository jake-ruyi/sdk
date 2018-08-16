﻿using NetMQ;
using Ruyi.Layer0;
using Ruyi.Logging;
using Ruyi.SDK.Constants;
using Ruyi.SDK.LocalizationService;
using Ruyi.SDK.MediaService;
using Ruyi.SDK.Online;
using Ruyi.SDK.SDKValidator;
using Ruyi.SDK.Speech;
using Ruyi.SDK.StorageLayer;
using Ruyi.SDK.UserServiceExternal;
using Ruyi.SDK.InputManager;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Thrift.Protocol;
using Thrift.Transport;
using Ruyi.SDK.OverlayManagerExternal;

namespace Ruyi
{
    /// <summary>
    /// The root namespace of the Ruyi platform.  Most functionality is available via a <see cref="Ruyi.RuyiSDK"/> instance.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    { }

    /// <summary>
    /// The main class used to communicate with the Ruyi platform.
    /// </summary>
    /// <remarks>
    /// <see cref="RuyiSDK.Update"/> must be called periodically (e.g. each frame) for all service clients to function correctly.
    /// </remarks>
    /// <example>
    /// <code source="layer0/sdktest/doctests.cs" region="RuyiSDK"></code>
    /// </example>
    public class RuyiSDK : IDisposable
    {
        /// <summary>
        /// Flags specifying which SDK features to initialize
        /// </summary>
        [Flags]
        public enum SDKFeatures
        {
            /// <summary>
            /// No SDK features
            /// </summary>
            None = 0,
            /// <summary>
            /// <see cref="RuyiSDK.Storage">Storage layer</see>
            /// </summary>
            Storage = 1 << 0,
            /// <summary>
            /// <see cref="RuyiSDK.L10NService">Localization service</see>
            /// </summary>
            L10N = 1 << 1,
            /// <summary>
            /// <see cref="RuyiSDK.RuyiNetService">Online functionality</see>
            /// </summary>
            RuyiNet = 1 << 2,
            /// <summary>
            /// Alias for <see cref="SDKFeatures.RuyiNet"/>
            /// </summary>
            Online = RuyiNet,
            /// <summary>
            /// <see cref="RuyiSDK.SettingSys">Settings system</see>
            /// </summary>
            Settings = 1 << 3,
            /// <summary>
            /// <see cref="RuyiSDK.UserService">User service</see>
            /// </summary>
            Users = 1 << 4,
            /// <summary>
            /// <see cref="RuyiSDK.InputMgr">Input Manager</see>
            /// </summary>
            Input = 1 << 5,
            /// <summary>
            /// <see cref="RuyiSDK.SpeechService">Speech recognition</see>
            /// </summary>
            Speech = 1 << 6,
            /// <summary>
            /// <see cref="RuyiSDK.Media">Media player service</see>
            /// </summary>
            Media = 1 << 7,
            /// <summary>
            /// Overlay service
            /// </summary>
            Overlay = 1 << 8,
            /// <summary>
            /// <see cref="RuyiSDK.Subscriber">Subscriber</see> for publisher/subscriber messaging
            /// </summary>
            Subscriber = 1 << 16,

            /// <summary>
            /// Most important SDK features (key layer0 services)
            /// </summary>
            Basic = Online | Settings | Users | Input | Subscriber,

            /// <summary>
            /// All SDK features
            /// </summary>
            All = Basic | Storage | L10N | Speech | Media | Overlay,
        }

        /// <summary>
        /// To subscribe to published topics.
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Subscriber"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public SubscribeClient Subscriber { get; private set; }

        /// <summary>
        /// Storage service
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Storage"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public StorageLayerService.Client Storage { get; private set; }

        /// <summary>
        /// Localization service
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.L10N"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public LocalizationService.Client L10NService { get; private set; }

        /// <summary>
        /// Online functionality
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Online"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public RuyiNetClient RuyiNetService { get; private set; }

        /// <summary>
        /// Setting system
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Settings"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public SDK.SettingSystem.Api.SettingSystemService.Client SettingSys { get; private set; }

        /// <summary>
        /// User-related services
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Users"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public UserServExternal.Client UserService { get; private set; }

        /// <summary>
        /// Input-related services
        /// </summary>
        /// <remarks>
        /// To get gamepad/controller input events use <see cref="SubscribeClient"/> instance via <see cref="Subscriber"/> property.
        /// 
        /// Must set <see cref="SDKFeatures.Input"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public InputManagerService.Client InputMgr { get; private set; }

        /// <summary>
        /// Speech service
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Speech"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public SpeechService.Client SpeechService { get; private set; }

        /// <summary>
        /// the overlay service
        /// </summary>
        public ExternalOverlayManagerService.Client OverlayService { get; private set; }

        /// <summary>
        /// Multimedia-related services
        /// </summary>
        /// <remarks>
        /// Must set <see cref="SDKFeatures.Media"/> in <see cref="RuyiSDKContext.EnabledFeatures"/>.
        /// </remarks>
        public MediaService.Client Media { get; private set; }

        private RuyiSDKContext context = null;

        private TTransport lowLatencyTransport = null;
        /// <summary>
        /// Underlying transport and protocol for low-latency messages
        /// </summary>
        /// <exclude/>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public TBinaryProtocolTS LowLatencyProtocol { get; private set; }

        private TTransport highLatencyTransport = null;
        /// <summary>
        /// Underlying transport and protocol for high-latency messages
        /// </summary>
        /// <exclude/>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public TBinaryProtocolTS HighLatencyProtocol { get; private set; }

        private ValidatorService.Client validator = null;

        static private int InstanceCount = 0;

        private RuyiSDK() { }

        /// <summary>
        /// Create a new SDK instance with the given context.
        /// </summary>
        /// <param name="cont">context used to create the sdk instance</param>
        /// <returns>the created instance, null if context is not valid</returns>
        public static RuyiSDK CreateInstance(RuyiSDKContext cont)
        {
            if (cont == null || !cont.IsValid())
            {
                throw new Exception("Invalid SDKContext, you need to set all the context values.");
            }

            RuyiSDK ret = new RuyiSDK
            {
                context = cont
            };

            InstanceCount++;
            if (!ret.Init())
            {
                ret.Dispose();
                return null;
            }

            return ret;
        }

        bool Init()
        {
            if (context.Transport == null)
            {
                // init and open high/low latency transport, create protocols
                var lowLatencyPort = context.LowLatencyPort == 0 ? ConstantsSDKDataTypesConstants.low_latency_socket_port : context.LowLatencyPort;
                lowLatencyTransport = new TSocketTransportTS(context.RemoteAddress, lowLatencyPort, context.Timeout <= 0 ? SDKUtility.Instance.LowLatencyTimeout : context.Timeout);

                var highLatencyPort = context.HighLatencyPort == 0 ? ConstantsSDKDataTypesConstants.high_latency_socket_port : context.HighLatencyPort;
                highLatencyTransport = new TSocketTransportTS(context.RemoteAddress, highLatencyPort, context.Timeout <= 0 ? SDKUtility.Instance.HighLatencyTimeout : context.Timeout);
            }
            else
            {
                lowLatencyTransport = context.Transport;
                highLatencyTransport = context.Transport;
            }

            LowLatencyProtocol = new TBinaryProtocolTS(lowLatencyTransport);
            HighLatencyProtocol = new TBinaryProtocolTS(highLatencyTransport);

            lowLatencyTransport.Open();
            highLatencyTransport.Open();

            if (!ValidateVersion())
                return false;

            if (IsFeatureEnabled(SDKFeatures.Subscriber))
            {
                var pubout = ConstantsSDKDataTypesConstants.layer0_publisher_out_uri.SetAddress(context.RemoteAddress);
                Subscriber = SubscribeClient.CreateInstance(pubout);
            }

            if (IsFeatureEnabled(SDKFeatures.Storage))
            {
                var stoProtocol = new TMultiplexedProtocol(HighLatencyProtocol, ServiceIDs.STORAGELAYER.ServiceID());
                Storage = new StorageLayerService.Client(stoProtocol);
            }

            if (IsFeatureEnabled(SDKFeatures.Online))
            {
                var bcProtocol = new TMultiplexedProtocol(HighLatencyProtocol, ServiceIDs.BCSERVICE.ServiceID());
                RuyiNetService = new RuyiNetClient(bcProtocol, Storage);
                //BCService = new BrainCloudService.Client(bcProtocal);
            }

            if (IsFeatureEnabled(SDKFeatures.Settings))
            {
                var proto = new TMultiplexedProtocol(LowLatencyProtocol, ServiceIDs.SETTINGSYSTEM_EXTERNAL.ServiceID());
                SettingSys = new SDK.SettingSystem.Api.SettingSystemService.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.L10N))
            {
                var proto = new TMultiplexedProtocol(LowLatencyProtocol, ServiceIDs.L10NSERVICE.ServiceID());
                L10NService = new LocalizationService.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.Users))
            {
                var proto = new TMultiplexedProtocol(HighLatencyProtocol, ServiceIDs.USER_SERVICE_EXTERNAL.ServiceID());
                UserService = new UserServExternal.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.Input))
            {
                var proto = new TMultiplexedProtocol(LowLatencyProtocol, ServiceIDs.INPUTMANAGER_EXTERNAL.ServiceID());
                InputMgr = new InputManagerService.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.Speech))
            {
                var proto = new TMultiplexedProtocol(HighLatencyProtocol, ServiceIDs.SPEECH.ServiceID());
                SpeechService = new SpeechService.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.Media))
            {
                var proto = new TMultiplexedProtocol(HighLatencyProtocol, ServiceIDs.MEDIA.ServiceID());
                Media = new MediaService.Client(proto);
            }

            if (IsFeatureEnabled(SDKFeatures.Overlay))
            {
                var proto = new TMultiplexedProtocol(LowLatencyProtocol, ServiceIDs.OVERLAYMANAGER_EXTERNAL.ServiceID());
                OverlayService = new ExternalOverlayManagerService.Client(proto);
            }

            return true;
        }

        bool IsFeatureEnabled(SDKFeatures fea)
        {
#if DOTNET_20
            return ((int)context.EnabledFeatures & (int)fea) != 0;
#else
            return context.EnabledFeatures.HasFlag(fea);
#endif
        }

        bool ValidateVersion()
        {
            // Do version check with layer0
            Version ver = Assembly.GetAssembly(GetType()).GetName().Version;
            var validationProtocol = new TMultiplexedProtocol(LowLatencyProtocol, ServiceIDs.VALIDATOR.ServiceID());
            validator = new ValidatorService.Client(validationProtocol);
            string valid = validator.ValidateSDK(ver.ToString());
            if (valid.StartsWith("err:"))
            {
                Logger.Log(new LoggerMessage()
                {
                    Level = LogLevel.Fatal,
                    MsgSource = "SDK",
                    Message = $"SDK version {ver} != ruyi version: {valid}"
                });
                return false;
            }
            else if (valid.StartsWith("warn:"))
            {
                Logger.Log(new LoggerMessage()
                {
                    Level = LogLevel.Warn,
                    MsgSource = "SDK",
                    Message = $"SDK version {ver} != ruyi version: {valid}",
                });
            }
            else
            {
                Logger.Log(new LoggerMessage()
                {
                    Level = LogLevel.Info,
                    MsgSource = "SDK",
                    Message = "SDK version validated.",
                });
            }

            return true;
        }

        /// <summary>
        /// Update loop for all service clients that need it.
        /// </summary>
        /// <remarks>
        /// This must be called periodically (e.g. each frame) for all service clients to function correctly.
        /// </remarks>
        public void Update()
        {
            RuyiNetService.Update();
        }

        /// <summary>
        /// Dispose the SDK instance, don't miss this after SDK usage.
        /// </summary>
        public void Dispose()
        {
            Subscriber?.Dispose();
            Subscriber = null;

            Storage?.Dispose();
            Storage = null;

            RuyiNetService?.Dispose();
            RuyiNetService = null;

            SettingSys?.Dispose();
            SettingSys = null;

            L10NService?.Dispose();
            L10NService = null;

            UserService?.Dispose();
            UserService = null;

            InputMgr?.Dispose();
            InputMgr = null;

            SpeechService?.Dispose();
            SpeechService = null;

            Media?.Dispose();
            Media = null;

            OverlayService?.Dispose();
            OverlayService = null;

            lowLatencyTransport?.Close();
            LowLatencyProtocol?.Dispose();
            lowLatencyTransport = null;
            LowLatencyProtocol = null;

            highLatencyTransport?.Close();
            HighLatencyProtocol?.Dispose();
            HighLatencyProtocol = null;
            highLatencyTransport = null;


            // don't clean up netmq in layer0.
            InstanceCount--;
            if (InstanceCount <= 0)
            {
                var entry = Assembly.GetEntryAssembly();
                if (entry == null)  // in a unit test
                {
                    NetMQConfig.Cleanup(false);
                    return;
                }

                // not Layer0 & not Layer1
                if(!entry.FullName.StartsWith("Layer0,", StringComparison.OrdinalIgnoreCase) 
                    && !entry.FullName.StartsWith("Layer1,", StringComparison.OrdinalIgnoreCase))
                {
                    NetMQConfig.Cleanup(false);
                    return;
                }
            }
        }
    }
}
