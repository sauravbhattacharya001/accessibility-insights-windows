// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace AccessibilityInsights.SharedUx.Telemetry
{
    /// <summary>
    /// Enums for Telemetry Properties
    /// </summary>
    public enum TelemetryProperty
    {
        Version,
        ModeName,
        ModeSessionId,
        View,
        UIFramework,
        MSIVersion,
        By,
        Comment,
        IsAlreadyLoggedIn,
        FileMode,
        ProtocolMode,
        Error,
        Scope, // to indicate the scope of selection
        TabStopLooped,
        TabStopCount,
        Seconds,
        RuleId,
        SessionType,
        AppSessionID,
        PatternMethod,
        InstallationID,
        UpdateTimedOut,
        UpdateInitializationTime,
        UpdateOptionWaitTime,
        UpdateOption,
        UpdateInstallerUpdateTime,
        UpdateResult,
        ReleaseChannel,
        ReleaseChannelConsidered,
        IssueReporter,
    }
}
