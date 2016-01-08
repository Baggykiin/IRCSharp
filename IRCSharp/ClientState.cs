﻿using System;
using System.Collections.Generic;
using IRCSharp.IRC;

namespace IRCSharp
{
	[Serializable]
	public struct ClientState
	{
		public string RemoteHost;
		public int RemotePort;
		public string LocalHost;
		public string Nick;
		public string Ident;
		public string RealName;
		public Dictionary<string, IrcChannel> Channels;
	}

}