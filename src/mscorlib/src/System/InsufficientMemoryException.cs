// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: The exception class for running out of memory
** but most likely in a non-fatal way that shouldn't 
** be affected by escalation policy.  Use this for cases
** like MemoryFailPoint or a TryAllocate method, where you 
** expect OOM's with no shared state corruption and you
** want to recover from these errors.
**
**
=============================================================================*/


using System;
using System.Runtime.Serialization;

namespace System
{
    public sealed class InsufficientMemoryException : OutOfMemoryException
    {
        public InsufficientMemoryException()
            : base(GetMessageFromNativeResources(ExceptionMessageKind.OutOfMemory))
        {
            HResult = HResults.COR_E_INSUFFICIENTMEMORY;
        }

        public InsufficientMemoryException(String message)
            : base(message)
        {
            HResult = HResults.COR_E_INSUFFICIENTMEMORY;
        }

        public InsufficientMemoryException(String message, Exception innerException)
            : base(message, innerException)
        {
            HResult = HResults.COR_E_INSUFFICIENTMEMORY;
        }
    }
}
