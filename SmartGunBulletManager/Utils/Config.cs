using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGunBulletManager.Utils
{
    public class Config
    {
        public static readonly string RsaPublicKey = "PFJTQUtleVZhbHVlPjxNb2R1bHVzPnJOMEpIS0ZZZmdiOWk4R25JTC9Wb0RWT2xSLzZGb01PRUw5K2FtMjQzYmxJL1QyT0xyZk9keWF1bU13Q1Y4ZXM2L05LUndyWWZmL1NSeW1FY2RJcXpkOTBzRXkrT0dHM2NMSHlCZFZBV3ZoZzNVVmwrZVhHYkVxcjhEZ1VjbjRjMjdyZ1ArRmZMR05xQ0I3UHh4YytKMk9pMzN5TS9JbkR4Rnd6bWVXcWFrOD08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";
        public static readonly string RsaPrivateKey = "PFJTQUtleVZhbHVlPjxNb2R1bHVzPnJOMEpIS0ZZZmdiOWk4R25JTC9Wb0RWT2xSLzZGb01PRUw5K2FtMjQzYmxJL1QyT0xyZk9keWF1bU13Q1Y4ZXM2L05LUndyWWZmL1NSeW1FY2RJcXpkOTBzRXkrT0dHM2NMSHlCZFZBV3ZoZzNVVmwrZVhHYkVxcjhEZ1VjbjRjMjdyZ1ArRmZMR05xQ0I3UHh4YytKMk9pMzN5TS9JbkR4Rnd6bWVXcWFrOD08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjxQPjRHS1drWSt2bmt6TWRhaU1PK29vT2IzaEJnc1dtVFBXRnlLOTJwU0ZQdGI5UVk4SHVCYy91ZXh6MHBMNmp2WWNHNWltTnBVM1NQZCtnaFROWk5MTjRRPT08L1A+PFE+eFRnWXU1cnZrQzhRSnYvQS9oemZMYkxxd0xwL0NZU1NGekErcFdaanJFamlpQkRReVdSVllFSks2bzhJVHlSUzhidTh3RWc4a3JJTGNYZTRPeDVlTHc9PTwvUT48RFA+bWk0a0Y5RUxjMUtDQ3piTlpUMzRkZlNxOG1RY0d4a3JPcXA4bWYwRHNiSTRReHZzeWVudnQrbHBqSC9CK3duUk5vVWxjTXdIT1BRVzBYdEp4c1d6QVE9PTwvRFA+PERRPkE4TzlYUjlwQVVTVXQxbmNjajFVMlVkNENiUEZwd1hiMEF1QXRxR010NFl3cE01RlhnTEhTbTRaaGY2eTl1ZkhtWXV1MzdEQlR6K016bDZ0cXBzNnl3PT08L0RRPjxJbnZlcnNlUT5DdFNRT0luMi8yNEZJTVhOQlZJZzUwSy9RcThiVjM2NEU3MFVUTUdGVTY2eHZ3TEVkLytNUk4zMS9wVHJ5R0tlQS9oWWpWVjNFcXhqZWwyRk4rQzhYZz09PC9JbnZlcnNlUT48RD5ScWhDcFRVK0dxVjQxYnRlT1FDd3JUK2MwMCt5eGFqa0F1eURHN1dscnR1aGZnRy9NRkZwVDBLOGN6QlFkTmpsVWJ5c1M4V2ZJRUdGRGhsbVRhLytWbVAvUEJFN240OVZkdjRNbUN5NmpmSGNid28zUFVRN1ltckQ0VHNMRlRURHU2ZXRENVFlVHlSYjIyN1Z2RE11NnBZOGxxRitVbnYzdEpBNld3cjA0UUU9PC9EPjwvUlNBS2V5VmFsdWU+";
        public static string SettingsXmlPath = string.Empty;
        public static string LogPath = string.Empty;
        public static string DatabaseFile = string.Empty;
        public static string DatabasePwd = string.Empty;
        public static string DataSource
        {
            get
            {
                if (string.IsNullOrEmpty(DatabasePwd))
                {
                    return string.Format("data source={0};", DatabaseFile);
                }
                else
                {
                    return string.Format("data source={0};password={1}", DatabaseFile, DatabasePwd);
                }
            }
        }

        public static readonly string soundFile_Welcome = @".\Sound\welcome.mp3";
        public static readonly string soundFile_Waiting = @".\Sound\waiting.mp3";
        public static readonly string soundFile_InputAgain = @".\Sound\please input again.mp3";
        public static readonly string soundFile_InputPwd = @".\Sound\please input your password.mp3";
        public static readonly string soundFile_SelectOptions = @".\Sound\please select options.mp3";
        public static readonly string soundFile_UserNameLogin = @".\Sound\username login please click the button below.mp3";
        public static readonly string soundFile_PresonalizeSettings = @".\Sound\you have access to a personal set interface, in here, you can personalize settings.mp3";

        public static int CheckTemperatureInterval { get; set; }
        public static int CheckHumidityInterval { get; set; }
        public static int CheckAlcoholConcentrationInterval { get; set; }
        public static int CheckPowerStateInterval { get; set; }
        public static int CheckNetworkStateInterval { get; set; }
        public static int CheckServerStateInterval { get; set; }

        public static string LockControllerComm { get; set; }
        public static int LockControllerBaudRate { get; set; }
    }
}