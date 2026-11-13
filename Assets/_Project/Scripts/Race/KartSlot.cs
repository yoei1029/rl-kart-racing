namespace RLKart.Race
{
    public enum ControllerType
    {
        Player,
        WaypointAI,
        RLAgent
    }

    [System.Serializable]
    public struct KartSlot
    {
        public int gridPosition;
        public ControllerType controllerType;
    }
}
