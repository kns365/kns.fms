using kns.fms.Debugging;

namespace kns.fms
{
    public class fmsConsts
    {
        public const string LocalizationSourceName = "fms";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fa20b5cb63e7404d9b356589050e99bf";
    }
}
