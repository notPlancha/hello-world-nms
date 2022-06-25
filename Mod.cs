using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using NoMansSky.Api;
using IReloadedHooks = Reloaded.Hooks.Definitions.IReloadedHooks;
//used NoMansSky.Api v1.0.1
#pragma warning disable CA1416

namespace hello_world_nms; 

public class Mod : NMSMod {

    public Mod(IModConfig config, IReloadedHooks hooks, IModLogger logger) : base(config, hooks, logger) {
        Start();
    }

    private void Start() {
        Logger.WriteLine("Hello World!");


    }

    public override void Update() {
        if (Keyboard.IsPressed(Key.Shift)) Logger.WriteLine("Started Running");
        if (Keyboard.IsReleased(Key.Shift)) Logger.WriteLine("Stopped Running");
    }
}