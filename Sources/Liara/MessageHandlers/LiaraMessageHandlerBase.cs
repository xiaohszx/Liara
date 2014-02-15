﻿// Author: Prasanna V. Loganathar
// Project: Liara
// Copyright (c) Launchark Technologies. All rights reserved.
// See License.txt in the project root for license information.
// 
// Created: 5:33 AM 13-02-2014

using System;
using System.Threading.Tasks;

namespace Liara.MessageHandlers
{
    public abstract class LiaraMessageHandlerBase : Attribute, IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public abstract Task ProcessAsync(ILiaraContext request);

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}