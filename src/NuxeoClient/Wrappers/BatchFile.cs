﻿/*
 * (C) Copyright 2015-2016 Nuxeo SA (http://nuxeo.com/) and others.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Contributors:
 *     Gabriel Barata <gbarata@nuxeo.com>
 */

using Newtonsoft.Json;
using System.ComponentModel;

namespace NuxeoClient.Wrappers
{
    /// <summary>
    /// Encloses information about a file that was uploaded into a batch.
    /// </summary>
    public class BatchFile : Entity
    {
        /// <summary>
        /// Gets the file name.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets the file size.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; } = string.Empty;

        /// <summary>
        /// Gets the type of upload.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "uploadType")]
        public string UploadType { get; set; } = string.Empty;

        /// <summary>
        /// Gets the IDs of the uploaded chunks.
        /// </summary>
        [DefaultValue(new int[0])]
        [JsonProperty(PropertyName = "uploadedChunkIds")]
        public int[] UploadedChunkIds { get; set; } = new int[0];

        /// <summary>
        /// Gets the number of uploaded chunks.
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "chunkCount")]
        public int ChunkCount { get; set; } = 1;

        /// <summary>
        /// Initializes a new instance of <see cref="BatchFile"/>.
        /// </summary>
        internal BatchFile()
        { }
    }
}