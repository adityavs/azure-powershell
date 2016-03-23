﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Globalization;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.HydraAdapter
{
    public class CommonHelpers
    {
        public static string GetDateTimeStringForService(DateTime date)
        {
            // our service expects date time to be serialized in the following format
            // we have to use english culture because our user might be running 
            // PS in another culture and our service can't understand it.
            DateTimeFormatInfo dateFormat = new CultureInfo("en-US").DateTimeFormat;
            return date.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss tt", dateFormat);
        }
    }
}
