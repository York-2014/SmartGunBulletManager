﻿using System;

namespace SmartGunBulletManager.IDAL
{
    public interface ILogger
    {
        void Debug(object message);
        void Debug(object message, Exception exception);
        void Info(object message);
        void Info(object message, Exception exception);
        void Error(object message);
        void Error(object message, Exception exception);
    }
}