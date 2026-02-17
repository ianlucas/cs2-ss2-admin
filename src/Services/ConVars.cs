/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.Convars;

namespace Admin;

public static class ConVars
{
    public static readonly IConVar<string> RconRole = Swiftly.Core.ConVar.Create(
        "admin_rcon_role",
        "Role required to run the rcon command.",
        "@css/root"
    );

    public static void Initialize()
    {
        _ = RconRole;
    }
}
