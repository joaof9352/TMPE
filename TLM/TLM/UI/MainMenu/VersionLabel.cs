namespace TrafficManager.UI.MainMenu {
    using ColossalFramework.UI;
    using UnityEngine;

    public class VersionLabel : UILabel {
        public override void Start() {
            size = new Vector2(MainMenuPanel.SIZE_PROFILES[0].MENU_WIDTH, MainMenuPanel.SIZE_PROFILES[0].TOP_BORDER); // TODO use current size profile
            text = TrafficManagerMod.ModName;
            relativePosition = new Vector3(5f, 5f);
            textAlignment = UIHorizontalAlignment.Left;
        }
    }
}
