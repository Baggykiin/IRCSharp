﻿
namespace IRCSharp.IRC
{
	public struct IrcMessage
	{
		public IrcUser Sender;
		public string Channel;
		public string Message;
		public bool Action;

		public IrcMessage(IrcUser sender, string channel, string message, bool action = false)
		{
			Sender = sender;
			Channel = channel;
			Message = message;
			Action = action;
		}
	}
}