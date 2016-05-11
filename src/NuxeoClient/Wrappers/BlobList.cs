﻿/*
 * (C) Copyright 2016 Nuxeo SA (http://nuxeo.com/) and others.
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

using System.Collections.Generic;

namespace NuxeoClient.Wrappers
{
    /// <summary>
    /// Represents a list of Blobs.
    /// </summary>
    public class BlobList : EntityList<Blob>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BlobList"/>.
        /// </summary>
        public BlobList() : base() { }

        /// <summary>
        /// Initializes a new instance of <see cref="BlobList"/>.
        /// </summary>
        /// <param name="blobs">A list of <see cref="Blob"/> to be included.</param>
        public BlobList(List<Blob> blobs) : base(blobs)
        {
        }
    }
}