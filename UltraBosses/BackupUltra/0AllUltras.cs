//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Army/SkuaUltras-main\CoreArmyLiteReborn.cs
//cs_include Scripts/Farm/BuyScrolls.cs
//cs_include Scripts/Army/UltraBosses/BackupUltra/CoreUltra.cs
//cs_include Scripts/Army/SkuaUltras-main\UltraBosses\BackupUltra\CoreUltra.cs
using Skua.Core.Interfaces;

public class AllUltra
{
    private IScriptInterface Bot => IScriptInterface.Instance;
    private CoreBots Core => CoreBots.Instance;
    private CoreAdvanced Adv = new();
    private static CoreArmyLiteReborn sArmy = new();
    private static CoreUltra cUltra = new();

    public string OptionsStorage = cUltra.OptionsStorage;
    public List<IOption> Options = cUltra.StartOptions;

    public void ScriptMain(IScriptInterface Bot)
    {
        // Core.BankingBlackList.Add("Engineer Insignia");
        Core.SetOptions(disableClassSwap: true);

        cUltra.InitUltra();

        cUltra.UltraTyndarius();
        cUltra.UltraEngineer();
        cUltra.UltraWarden();
        cUltra.UltraEzrajal();
        cUltra.ChampionDrakath();
        cUltra.UltraDage();
        cUltra.UltraNulgath();
        cUltra.UltraDrago();
        cUltra.UltraSpeaker();
        cUltra.UltraDarkon();

        // Core.SetOptions(false);
    }
}