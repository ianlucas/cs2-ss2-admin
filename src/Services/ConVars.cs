/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Runtime.CompilerServices;
using SwiftlyS2.Shared.Convars;

namespace Admin;

public static class ConVars
{
    public static readonly IConVar<string> RconRole = Runtime.Core.ConVar.Create(
        "admin_rcon_role",
        "Role required to run the rcon command.",
        "@css/root"
    );

    public static void Initialize() =>
        RuntimeHelpers.RunClassConstructor(typeof(ConVars).TypeHandle);
}
