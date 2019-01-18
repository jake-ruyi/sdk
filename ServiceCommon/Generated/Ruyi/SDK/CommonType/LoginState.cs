/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Ruyi.SDK.CommonType
{
  /// <summary>
  /// @LoginState_desc
  /// </summary>
  public enum LoginState
  {
    /// <summary>
    /// This state means that the user needs to go through authentication if he wants to use the console. His save date is still in the console and safe. He can access it after authentication (log in process). The portrait is black and white.
    /// </summary>
    Logout = 0,
    /// <summary>
    /// @LoginState_Login
    /// </summary>
    Login = 1,
  }
}
