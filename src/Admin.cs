/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Plugins;

namespace Admin;

[PluginMetadata(
    Id = "Admin",
    Version = "1.0.0",
    Name = "Admin",
    Author = "Ian Lucas",
    Description = "Commands for administrators."
)]
public partial class Admin(ISwiftlyCore core) : BasePlugin(core)
{
    public override void Load(bool hotReload)
    {
        Swiftly.Initialize();
        ConVars.Initialize();
    }

    public override void Unload() { }
}
