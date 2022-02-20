﻿//#define DEBUG

using System;

namespace OnDemandFuelCells
{
    public class ResourceLabel
    { //resource la? originally rla
        public int resourceID;
        private string resourceAbbreviation;

        private ResourceLabel(int resourceID, string resourceAbbreviation)
        {
            this.resourceID = resourceID;
            this.resourceAbbreviation = resourceAbbreviation;
        }
    }

    /// <summary></summary>
    public struct Fuel
    {
        public int resourceID;
        public float rate;
        public ResourceFlowMode resourceFlowMode;

        public Fuel(ConfigNode.Value nodeValue, bool bp = false)
        {
            resourceID = PartResourceLibrary.Instance.GetDefinition(nodeValue.name).id;
            rate = bp ? -float.Parse(nodeValue.value) : float.Parse(s: nodeValue.value);
            resourceFlowMode = PartResourceLibrary.GetDefaultFlowMode(resourceID);
        }
    }

    /// <summary></summary>
    public struct mode
    {
        public Fuel[] fuels, byproducts;
        public double maxEC;

        public mode(ConfigNode node, Part part)
        {
            maxEC = 10;

            foreach (ConfigNode.Value nodeValue in node.values ?? new ConfigNode.ValueList())
            {
                switch (nodeValue.name)
                {
                    case "MaxEC":
                        {
                            maxEC = double.Parse(nodeValue.value);
                            break;
                        }
                }
            }

            ConfigNode.ValueList nodeValues = node.GetNode("FUELS").values; // No null coalescing intentional here
            fuels = new Fuel[nodeValues.Count];

            for (byte n = 0; n < nodeValues.Count; n++)
                fuels[n] = new Fuel(nodeValues[n]);

            nodeValues = (node.GetNode("BYPRODUCTS") ?? new ConfigNode()).values;
            byproducts = new Fuel[nodeValues.Count];

            for (byte n = 0; n < nodeValues.Count; n++)
                byproducts[n] = new Fuel(nodeValues[n], true);
        }
    }

    public struct Config
    {
        public mode[] modes;
        //  public bool autoSwitch { get; private set; }
        //public double scaleHack;

        public Config(ConfigNode node, Part part)
        {
            /*if (node.HasValues("MODE"))*/
            {
                //        ConfigNode[] nodes = node.GetNodes("ODFC"); // shouldn't need null coalescing as we should always have at least one ODFC module

                // Shouldn't need null coalescing as we should always have at least one MODE
                ConfigNode[] nodes = node.GetNodes("MODE");
                modes = new mode[nodes.Length];

                for (byte i = 0; i < nodes.Length; i++)
                    modes[i] = new mode(nodes[i], part);
            }
            /*            else
                        {
                            modes = null;
                            Log.dbg("Malformed config node: MODE");
                        }*/
        }
    }
}