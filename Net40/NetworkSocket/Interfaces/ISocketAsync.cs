﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkSocket.Interfaces
{
    /// <summary>
    /// 异步Socket接口
    /// </summary>
    /// <typeparam name="T">协议类型</typeparam>
    public interface ISocketAsync<T> : IDisposable where T : PacketBase
    {
        /// <summary>
        /// 获取动态数据字典
        /// </summary>
        dynamic TagBag { get; }

        /// <summary>
        /// 获取远程终结点
        /// </summary>
        IPEndPoint RemoteEndPoint { get; }

        /// <summary>
        /// 获取是否已连接到远程端
        /// </summary>
        bool IsConnected { get; }       

        /// <summary>
        /// 异步发送数据
        /// </summary>
        /// <param name="packet">数据包</param>
        void Send(T packet);
    }
}
