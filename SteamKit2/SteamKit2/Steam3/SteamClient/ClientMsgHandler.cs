﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamKit2
{
    /// <summary>
    /// This class implements the base requirements every message handler should inherit from.
    /// </summary>
    public abstract class ClientMsgHandler
    {
        public string Name { get; private set; }
        protected SteamClient Client { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMsgHandler"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ClientMsgHandler( string name )
        {
            this.Name = name;
        }


        internal void Setup( SteamClient client )
        {
            this.Client = client;
        }


        /// <summary>
        /// Handles a client message. This should not be called directly.
        /// </summary>
        /// <param name="e">The <see cref="SteamKit2.ClientMsgEventArgs"/> instance containing the event data.</param>
        public abstract void HandleMsg( ClientMsgEventArgs e );
    }
}
