﻿/*
 * Copyright (c) 2013-present, The Eye Tribe. 
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the LICENSE file in the root directory of this source tree. 
 *
 */

using Newtonsoft.Json;
using System;

namespace TETCSharpClient.Data
{
    public class StandardDeviation
    {
        /// <summary>
        /// Average standard deviation, in pixels
        /// </summary>
        [JsonProperty(PropertyName = Protocol.CALIBRESULT_STANDARD_DEVIATION_AVERAGE_PIXELS)]
        public double Average { get; set; }

        /// <summary>
        /// Left eye standard deviation, in pixels
        /// </summary>
        [JsonProperty(PropertyName = Protocol.CALIBRESULT_STANDARD_DEVIATION_LEFT_PIXELS)]
        public double Left { get; set; }

        /// <summary>
        /// Right eye standard deviation, in pixels
        /// </summary>
        [JsonProperty(PropertyName = Protocol.CALIBRESULT_STANDARD_DEVIATION_RIGHT_PIXELS)]
        public double Right { get; set; }

        public override bool Equals(Object o)
        {
            if (ReferenceEquals(this, o))
                return true;

            if (!(o is StandardDeviation))
                return false;

            var other = o as StandardDeviation;

            return Double.Equals(Average, other.Average) &&
                Double.Equals(Left, other.Left) &&
                Double.Equals(Right, other.Right);
        }
    }
}