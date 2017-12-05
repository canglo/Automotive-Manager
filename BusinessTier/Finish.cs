namespace BusinessTier
{
    /// <summary>
    /// Specifies the ExteriorFinish to choose from
    /// </summary>
    public enum ExteriorFinish
    {
        None,
        Standard,
        Pearlized,
        Custom
    }

    /// <summary>
    /// A static class defining the constant value of Finish cost
    /// </summary>
    public static class Finish
    {
        public const decimal NONE = 0M;
        public const decimal STANDARD = 0M;
        public const decimal PEARLIZED = 404.04M;
        public const decimal CUSTOM = 606.06M;
    }
}
