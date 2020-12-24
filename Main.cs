using SRML;

namespace FarmableGuildedGingersMod {
    
    public class Main : ModEntryPoint {
        public override void PreLoad() {
            HarmonyInstance.PatchAll();
        }
        
        public override void Load() {
        }
        
        public override void PostLoad() {
            
            // plantableDict is private need to find a way of either making it public or another way of making new farmable
            GardenCatcher.plantableDict.Add(Identifiable.Id.GINGER_VEGGIE,
                GameContext.Instance.LookupDirector.GetPrefab(Identifiable.Id.GINGER_VEGGIE).gameObject);
        }
    }
}