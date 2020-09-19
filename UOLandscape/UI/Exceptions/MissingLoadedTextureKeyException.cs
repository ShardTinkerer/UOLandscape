﻿using System;

namespace UOLandscape.UI.Exceptions
{
    public class MissingLoadedTextureKeyException : InvalidOperationException
    {
        public MissingLoadedTextureKeyException(IntPtr textureId)
        {
            _textureId = textureId;
        }

        public override string Message => $"Could not find a texture with id {_textureId}, please check your bindings";

        private readonly IntPtr _textureId;
    }
}
