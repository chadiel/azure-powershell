﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSResourceStatistics
    {
        
        internal Microsoft.Azure.Batch.ResourceStatistics omObject;
        
        internal PSResourceStatistics(Microsoft.Azure.Batch.ResourceStatistics omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public System.DateTime? StartTime
        {
            get
            {
                return this.omObject.StartTime;
            }
        }
        
        public System.DateTime? EndTime
        {
            get
            {
                return this.omObject.EndTime;
            }
        }
        
        public double AvgCPU
        {
            get
            {
                return this.omObject.AvgCPU;
            }
        }
        
        public double AvgMemory
        {
            get
            {
                return this.omObject.AvgMemory;
            }
        }
        
        public double PeakMemory
        {
            get
            {
                return this.omObject.PeakMemory;
            }
        }
        
        public long AvgDisk
        {
            get
            {
                return this.omObject.AvgDisk;
            }
        }
        
        public long PeakDisk
        {
            get
            {
                return this.omObject.PeakDisk;
            }
        }
        
        public long DiskReadIOps
        {
            get
            {
                return this.omObject.DiskReadIOps;
            }
        }
        
        public long DiskWriteIOps
        {
            get
            {
                return this.omObject.DiskWriteIOps;
            }
            set
            {
                this.omObject.DiskWriteIOps = value;
            }
        }
        
        public long DiskReadBytes
        {
            get
            {
                return this.omObject.DiskReadBytes;
            }
        }
        
        public long DiskWriteBytes
        {
            get
            {
                return this.omObject.DiskWriteBytes;
            }
        }
        
        public long NetworkReadBytes
        {
            get
            {
                return this.omObject.NetworkReadBytes;
            }
        }
        
        public long NetworkWriteBytes
        {
            get
            {
                return this.omObject.NetworkWriteBytes;
            }
        }
    }
}
