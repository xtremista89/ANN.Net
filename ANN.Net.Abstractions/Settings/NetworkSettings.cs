﻿using System.ComponentModel;
using ANN.Net.Abstractions.Enums;

namespace ANN.Net.Abstractions.Settings
{
    public class NetworkSettings
    {
        public float MinNetworkValue { get; set; }
        public float MaxNetworkValue { get; set; }
        public bool ShouldNormalize { get; set; } = true;
        public bool HasBiasNeuron { get; set; }

        public ushort InputNeuronsCount { get; set; }
        [DefaultValue(ActivationTypes.Sigmoid)]
        public ActivationTypes InputLayerFunction { get; set; }


        public ushort OutputNeuronsCount { get; set; }

        [DefaultValue(ActivationTypes.Sigmoid)]
        public ActivationTypes OutputLayerFunction { get; set; }
    }
}
