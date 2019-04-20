﻿using Datory;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 插件运行环境接口。
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// 系统使用的数据库类型。
        /// </summary>
        DatabaseType DatabaseType { get; }

        /// <summary>
        /// 系统使用的数据库连接字符串。
        /// </summary>
        DatabaseType ConnectionString { get; }

        /// <summary>
        /// 用户中心文件夹名称。
        /// </summary>
        string HomeDirectory { get; }

        /// <summary>
        /// 管理后台文件夹名称。
        /// </summary>
        string AdminDirectory { get; }

        /// <summary>
        /// 网站根目录文件夹地址。
        /// </summary>
        string PhysicalApplicationPath { get; }

        /// <summary>
        /// API访问地址。
        /// </summary>
        string ApiUrl { get; }
    }
}
