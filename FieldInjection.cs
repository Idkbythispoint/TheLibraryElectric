using FieldInjector;
using TheLibraryElectric.Environment;
using TheLibraryElectric.TLEFusion;
using TheLibraryElectric.Markers;
using TheLibraryElectric.Misc;
using TheLibraryElectric.PlayerUtil;
using TheLibraryElectric.Rigidbodies;
using TheLibraryElectric.Signals;
using TheLibraryElectric.Water;
using TheLibraryElectric.Marrow;
using TheLibraryElectric.Groups;
using TheLibraryElectric.Melon;
using TheLibraryElectric.Vehicles;

namespace TheLibraryElectric
{
    internal static class FieldInjection
    {
        public static void Inject()
        {
            ModConsole.Msg("Injecting the fields with the fieldinjector which injects fields, crazy isnt it", 1);
            SerialisationHandler.Inject<DoNotFreeze>();
            ModConsole.Msg("Hopefully injected DoNotFreeze", 1);
            SerialisationHandler.Inject<DoNotDestroy>();
            ModConsole.Msg("Hopefully injected DoNotDestroy", 1);
            SerialisationHandler.Inject<RecieveSignal>();
            ModConsole.Msg("Hopefully injected RecieveSignal", 1);
            SerialisationHandler.Inject<SendSignal>();
            ModConsole.Msg("Hopefully injected SendSignal", 1);
            SerialisationHandler.Inject<RigManagerControl>();
            ModConsole.Msg("Hopefully injected RigManagerControl", 1);
            SerialisationHandler.Inject<FreezeRigidbodies>();
            ModConsole.Msg("Hopefully injected FreezeRigidbodies", 1);
            SerialisationHandler.Inject<DestroyOnCollision>();
            ModConsole.Msg("Hopefully injected DestroyOnCollision", 1);
            SerialisationHandler.Inject<TimescaleController>();
            ModConsole.Msg("Hopefully injected TimescaleController", 1);
            SerialisationHandler.Inject<UpdateTMP>();
            ModConsole.Msg("Hopefully injected UpdateTMP", 1);
            SerialisationHandler.Inject<VoidCounterObject>();
            ModConsole.Msg("Hopefully injected VoidCounterObject", 1);
            SerialisationHandler.Inject<RBGravityManager>();
            ModConsole.Msg("Hopefully injected RBGravityManager", 1);
            SerialisationHandler.Inject<GravityChamber>();
            ModConsole.Msg("Hopefully injected GravityChamber", 1);
            SerialisationHandler.Inject<RagdollZone>();
            ModConsole.Msg("Hopefully injected RagdollZone", 1);
            SerialisationHandler.Inject<ForceZone>();
            ModConsole.Msg("Hopefully injected ForceZone", 1);
            SerialisationHandler.Inject<SpawnOnTriggerEnter>();
            ModConsole.Msg("Hopefully injected SpawnOnTriggerEnter", 1);
            SerialisationHandler.Inject<DespawnPooledObject>();
            ModConsole.Msg("Hopefully injected DespawnPooledObject", 1);
            SerialisationHandler.Inject<RandomAudioPlayer>();
            ModConsole.Msg("Hopefully injected RandomAudioPlayer", 1);
            SerialisationHandler.Inject<IgnoreRigidbody>();
            ModConsole.Msg("Hopefully injected IgnoreRigidbody", 1);
            SerialisationHandler.Inject<RbBuoyancyManager>();
            ModConsole.Msg("Hopefully injected RbBuoyancyManager", 1);
            SerialisationHandler.Inject<WaterZone>();
            ModConsole.Msg("Hopefully injected WaterZone", 1);
            SerialisationHandler.Inject<SignalTrigger>();
            ModConsole.Msg("Hopefully injected SignalTrigger", 1);
            SerialisationHandler.Inject<SignalTriggerer>();
            ModConsole.Msg("Hopefully injected SignalTriggerer", 1);
            SerialisationHandler.Inject<HandMonitor>();
            ModConsole.Msg("Hopefully injected HandMonitor", 1);
            SerialisationHandler.Inject<SwimmingController>();
            ModConsole.Msg("Hopefully injected SwimmingController", 1);
            SerialisationHandler.Inject<InvokeIfLibInstalled>();
            ModConsole.Msg("Hopefully injected InvokeIfLibInstalled", 1);
            SerialisationHandler.Inject<DrowningManager>();
            ModConsole.Msg("Hopefully injected DrowningManager", 1);
            SerialisationHandler.Inject<BitShop>();
            ModConsole.Msg("Hopefully injected BitShop", 1);
            SerialisationHandler.Inject<RagdollOnCollide>();
            ModConsole.Msg("Hopefully injected RagdollOnCollide", 1);
            SerialisationHandler.Inject<InvokeWhenCounter>();
            ModConsole.Msg("Hopefully injected InvokeWhenCounter", 1);
            SerialisationHandler.Inject<PhotonThruster>();
            ModConsole.Msg("Hopefully injected PhotonThruster", 1);
            SerialisationHandler.Inject<GroupProxy>();
            ModConsole.Msg("Hopefully injected GroupProxy", 1);
            SerialisationHandler.Inject<GroupIdentifier>();
            ModConsole.Msg("Hopefully injected GroupIdenifier", 1);
            SerialisationHandler.Inject<TLE_SimpleRaycast>();
            ModConsole.Msg("Hopefully injected TLE_SimpleRaycast", 1);
            SerialisationHandler.Inject<RbSpeedMeter>();
            ModConsole.Msg("Hopefully injected RbSpeedMeter", 1);
            SerialisationHandler.Inject<ScoreKeeper>();
            ModConsole.Msg("Hopefully injected ScoreKeeper", 1);
            SerialisationHandler.Inject<RealtimeAnalogClock>();
            ModConsole.Msg("Hopefully injected RealtimeAnalogClock", 1);
            SerialisationHandler.Inject<CoolerSpawnablePlacer>();
            ModConsole.Msg("Hopefully injected CoolerSpawnablePlacer", 1);
            // arm forgot to inject this and then wondered why it didnt work
            SerialisationHandler.Inject<Boat>();
            ModConsole.Msg("Hopefully injected Boat", 1);
            SerialisationHandler.Inject<TimeCycleHandler>();
            ModConsole.Msg("Hopefully injected TimeCycleHandler", 1);
            SerialisationHandler.Inject<BootlegPlayerRig>();
            ModConsole.Msg("Hopefully injected TimeCycleHandler", 1);
            ModConsole.Msg("All fields are probably injected. I can't tell since this isn't async so I can't slap a bool on it.", 1);
        }
    }
}