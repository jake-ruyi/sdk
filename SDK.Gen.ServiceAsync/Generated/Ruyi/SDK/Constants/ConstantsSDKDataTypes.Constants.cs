/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;


namespace Ruyi.SDK.Constants
{
  public static class ConstantsSDKDataTypesConstants
  {
    public const int low_latency_socket_port = 11290;
    public const int high_latency_socket_port = 11390;
    public const string layer0_broker_address = "tcp://{addr}:5555";
    public const string layer0_publisher_in_uri = "tcp://{addr}:5567";
    public const string layer0_publisher_out_uri = "tcp://{addr}:5568";
    public const string setting_config_folder = "resources/configs/";
    public const string setting_system_config = "resources/configs/systemsetting";
    public const string setting_system_user_config = "resources/configs/usersetting";
    public const string system_setting_version = "1.0.0.1";
    public const string layer0_debugger_channel = "layer0_debugger_channel";
    public const string trc_test_channel = "trc_test_channel";
    public const string broker_playback_message = "mmi.developer.playback";
  }
}
