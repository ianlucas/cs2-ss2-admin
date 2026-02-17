/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.Commands;

namespace Admin;

public partial class Admin
{
    [Command("rcon")]
    public void OnRconCommand(ICommandContext context)
    {
        var player = context.Sender;
        if (
            player == null
            || Swiftly.Core.Permission.PlayerHasPermissions(
                player.SteamID,
                PermissionHelpers.Split(ConVars.RconRole.Value)
            )
        )
        {
            var command = string.Join(" ", context.Args);
            Core.Engine.ExecuteCommand(command);
        }
    }
}
