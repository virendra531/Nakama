﻿/**
 * Copyright 2019 The Knights Of Unity, created by Pawel Stolarczyk
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace DemoGame.Scripts.DataStorage
{

    /// <summary>
    /// Write permissions given to <see cref="Nakama.WriteStorageObject"/>.
    /// </summary>
    public enum StorageWritePermission
    {
        /// <summary>
        /// Only server and owner (user who created entry in database) can write the data.
        /// </summary>
        OwnerWrite = 1,

        /// <summary>
        /// Data writable only by server.
        /// </summary>
        NoWrite = 0
    }

}