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

namespace NuxeoClient.Adapters
{
    /// <summary>
    /// Represents a Convert Adapter, which converts target document blobs int other formats.
    /// </summary>
    /// <remarks>For more details about Adapters, check
    /// <a href="https://doc.nuxeo.com/display/NXDOC/Web+Adapters+for+the+REST+API">Nuxeo Documentation Page</a>.</remarks>
    public class ConvertAdapter : Adapter
    {
        /// <summary>
        /// Gets the target conversion format.
        /// </summary>
        public string Format { get; protected set; } = string.Empty;

        /// <summary>
        /// Gets the parameters of the <see cref="ConvertAdapter"/>.
        /// </summary>
        protected QueryParams QParams { get; set; } = new QueryParams();

        /// <summary>
        /// Initializes a new instance of <see cref="ConvertAdapter"/>.
        /// </summary>
        public ConvertAdapter() :
            base("convert")
        { }

        /// <summary>
        /// Sets the target conversion format.
        /// </summary>
        /// <param name="format">The target conversion format.</param>
        /// <returns>The current <see cref="ConvertAdapter"/> instance.</returns>
        public ConvertAdapter SetFormat(string format)
        {
            Format = format;
            QParams["format"] = format;
            Parameters = QParams.ToString();
            return this;
        }
    }
}