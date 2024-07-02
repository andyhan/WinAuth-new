﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAuth {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinAuth.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 账号没有绑定邮箱 的本地化字符串。
        /// </summary>
        internal static string AccountNotBindEmail {
            get {
                return ResourceManager.GetString("AccountNotBindEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请在输入验证码后再次登录。 的本地化字符串。
        /// </summary>
        internal static string CaptchaNeeded {
            get {
                return ResourceManager.GetString("CaptchaNeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请确认邮件内的链接 的本地化字符串。
        /// </summary>
        internal static string ConfirmLinkInEmail {
            get {
                return ResourceManager.GetString("ConfirmLinkInEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请查看账号绑定邮箱，输入邮件验证码后继续。 的本地化字符串。
        /// </summary>
        internal static string EmailAuthNeeded {
            get {
                return ResourceManager.GetString("EmailAuthNeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 账号没有绑定的手机号，请根据指示添加手机号 的本地化字符串。
        /// </summary>
        internal static string Error_AccountNotBindTel {
            get {
                return ResourceManager.GetString("Error_AccountNotBindTel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 获取交易报价图片失败 的本地化字符串。
        /// </summary>
        internal static string Error_GetQuoteTradingImage {
            get {
                return ResourceManager.GetString("Error_GetQuoteTradingImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您的帐户似乎已添加了身份验证器，需要移除现有的身份验证器才可以通过账号导入，注意这可能导致 7-15 天的交易冷却期。 的本地化字符串。
        /// </summary>
        internal static string Error_HasAuthenticator {
            get {
                return ResourceManager.GetString("Error_HasAuthenticator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无效的验证码 的本地化字符串。
        /// </summary>
        internal static string Error_InvalidActivationCode {
            get {
                return ResourceManager.GetString("Error_InvalidActivationCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 登陆信息已失效 的本地化字符串。
        /// </summary>
        internal static string Error_InvalidLoginInfo {
            get {
                return ResourceManager.GetString("Error_InvalidLoginInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 来自 Steam 的无效响应：{0} 的本地化字符串。
        /// </summary>
        internal static string Error_InvalidResponseFromSteam {
            get {
                return ResourceManager.GetString("Error_InvalidResponseFromSteam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无法发送短信，检查您的手机号已在您的 Steam 帐户中注册。 的本地化字符串。
        /// </summary>
        internal static string Error_ITwoFactorService_AddAuthenticator_v0001 {
            get {
                return ResourceManager.GetString("Error_ITwoFactorService_AddAuthenticator_v0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 来自Steam的无效响应（没有OAuth令牌）。 的本地化字符串。
        /// </summary>
        internal static string Error_NoOAuth {
            get {
                return ResourceManager.GetString("Error_NoOAuth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 激活令牌时出现了问题。Steam 服务器可能存在问题。请稍后再试。 的本地化字符串。
        /// </summary>
        internal static string Error_OnActivating {
            get {
                return ResourceManager.GetString("Error_OnActivating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您所输入的账户名或密码不正确。 的本地化字符串。
        /// </summary>
        internal static string Error_Password {
            get {
                return ResourceManager.GetString("Error_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您的 Steam 帐户必须附有支持短信的手机号码, {0}请到 Steam 客户端或 Steam 网站的帐户详细信息添加电话号码。 的本地化字符串。
        /// </summary>
        internal static string Error_SteamguardPhoneAjax {
            get {
                return ResourceManager.GetString("Error_SteamguardPhoneAjax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 IP登录请求过于频繁，请稍后重试。 的本地化字符串。
        /// </summary>
        internal static string Error_TooManyRequests {
            get {
                return ResourceManager.GetString("Error_TooManyRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请查看账号绑定手机号信息，输入验证码后继续。 的本地化字符串。
        /// </summary>
        internal static string RequiresActivation {
            get {
                return ResourceManager.GetString("RequiresActivation", resourceCulture);
            }
        }
    }
}
