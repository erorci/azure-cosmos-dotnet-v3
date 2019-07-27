﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.ChangeFeed.Utils
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Azure.Documents;

    internal static class TaskExtensions
    {
        public static void LogException(this Task task)
        {
#pragma warning disable VSTHRD110 // Observe result of async calls
            task.ContinueWith(_ => DefaultTraceEx.TraceException(task.Exception), TaskContinuationOptions.OnlyOnFaulted);
#pragma warning restore VSTHRD110 // Observe result of async calls
        }
    }
}