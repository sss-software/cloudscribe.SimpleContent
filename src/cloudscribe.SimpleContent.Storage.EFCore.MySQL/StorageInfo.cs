﻿using cloudscribe.SimpleContent.Models;

namespace cloudscribe.SimpleContent.Storage.EFCore.MySQL
{
    public class StorageInfo : IStorageInfo
    {
        public string StoragePlatform { get { return "Entity Framework with MySql"; } }
    }
}
