using System;

namespace MonoGame.ImGui.Exceptions
{
	public class MissingLoadedTextureKeyException
		: InvalidOperationException
	{
		public override string Message
		{
			get { return string.Format("Could not find a texture with id {0}, please check your bindings", _texture_id); }
		}

		public MissingLoadedTextureKeyException(IntPtr texture_id)
		{
			_texture_id = texture_id;
		}

		public MissingLoadedTextureKeyException() : base()
		{
		}

		public MissingLoadedTextureKeyException(string? message) : base(message)
		{
		}

		public MissingLoadedTextureKeyException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		private readonly IntPtr _texture_id;
	}
}
