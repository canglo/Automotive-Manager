namespace BusinessTier
{
    /// <summary>
    /// Specifies the Accessories to choose from
    /// </summary>
    public enum Accessories
    {
        None,
        StereoSystem,
        LeatherInterior,
        StereoAndLeather,
        ComputerNavigation,
        StereoAndNavigation,
        LeatherAndNavigation,
        All
    }

    /// <summary>
    /// A static class defining the constant value of Accessory cost
    /// </summary>
    public static class Accessory
    {
        public const decimal NONE = 0M;
        public const decimal STEREO_SYSTEM = 505.05M;
        public const decimal LEATHER_INTERIOR = 1010.10M;
        public const decimal COMPUTER_NAVIGATION = 1515.15M;
    }

    
}
