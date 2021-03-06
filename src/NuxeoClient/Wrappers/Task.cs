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
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NuxeoClient.Wrappers
{
    /// <summary>
    /// Represents a Task entity, created via the <see cref="Workflow"/> service.
    /// </summary>
    /// <remarks>For more information about tasks, check
    /// <a href="https://doc.nuxeo.com/display/NXDOC60/About+Tasks">Nuxeo Documentation Center</a>.
    /// </remarks>
    public class Task : Entity
    {
        /// <summary>
        /// Gets or sets the lists of actors in the task.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "actors")]
        public List<Properties> Actors { get; set; } = null;

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "comments")]
        public List<Properties> Comments { get; set; } = null;

        /// <summary>
        /// Gets or sets the date in which the task was created.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "created")]
        public DateTime? Created { get; set; } = null;

        /// <summary>
        /// Gets or sets the task directive.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "directive")]
        public string Directive { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the task's due date.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "dueDate")]
        public DateTime? DueDate { get; set; } = null;

        /// <summary>
        /// Gets or sets the task id.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the task name.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the task's node name.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "nodeName")]
        public string nodeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the task's state.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the id of the workflow via which this tasks was created.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "workflowInstanceId")]
        public string WorkflowInstanceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of this task's workflow model.
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "workflowModelName")]
        public string WorkflowModelName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ids of the documents invoved in this task.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "targetDocumentIds")]
        public List<Properties> TargetDocumentIds { get; set; } = null;

        /// <summary>
        /// Gets or sets the task info for this task.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "taskInfo")]
        public Properties TaskInfo { get; set; } = null;

        /// <summary>
        /// Gets or sets this task's variables.
        /// </summary>
        [DefaultValue(null)]
        [JsonProperty(PropertyName = "variables")]
        public Properties Variables { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of <see cref="Tasks"/>.
        /// </summary>
        public Task()
        {
            EntityType = "task";
        }
    }
}