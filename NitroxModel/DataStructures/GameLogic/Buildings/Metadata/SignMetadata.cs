﻿using System;
using ProtoBuf;

namespace NitroxModel.DataStructures.GameLogic.Buildings.Metadata
{
    [Serializable]
    [ProtoContract]
    public class SignMetadata : BasePieceMetadata
    {
        [ProtoMember(1)]
        public string Guid { get; }

        [ProtoMember(2)]
        public string Text { get; set; }

        [ProtoMember(3)]
        public int ColorIndex { get; set; }

        [ProtoMember(4)]
        public int ScaleIndex { get; set; }

        [ProtoMember(5)]
        public bool[] Elements { get; set; }

        [ProtoMember(6)]
        public bool Background { get; set; }

        public SignMetadata()
        {
            //Constructor Serializacion
        }

        public SignMetadata(string guid, string text, int colorIndex, int scaleIndex, bool[] elements, bool backgroundToggle)
        {
            Guid = guid;
            Text = text;
            ColorIndex = colorIndex;
            ScaleIndex = scaleIndex;
            Elements = elements;
            Background = backgroundToggle;
        }

        public override string ToString()
        {
            return "[SignMetadata - Guid: " + Guid + " Text: " + Text + " ColorIndex: " + ColorIndex + "ScaleIndex: " + ScaleIndex + " Elements: " + Elements + " Background: " + Background + "]";
        }
    }
}
